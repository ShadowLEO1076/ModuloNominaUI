using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infraestructura.AccesoDatos;
using Newtonsoft.Json;
using WinModuloNomina.Controlador;
using WinModuloNomina.Modelo.DTOS;

namespace WinModuloNomina.Vista
{
    public partial class F5Descuentos : Form
    {
        private readonly APIModuloNomina _api;
        private string _apiUrl;
        private BindingSource bindingSource4 = new BindingSource();

        private Form activeForm;
        public F5Descuentos()
        {
            InitializeComponent();
            try
            {
                string baseUrl = ConfigurationManager.AppSettings["APIBaseUrl"];
                _api = new APIModuloNomina(baseUrl);
                this.Load += F5Descuentos_Load;

                //dgvHistorialContratos.CellClick += dgvHistorialContratos_CellClick;
                dgvDescuentos.CellClick += dgvDescuentos_CellClick;
                



                // Configurar ADGV
                dgvDescuentos.FilterAndSortEnabled = true;
                dgvDescuentos.FilterStringChanged += (s, e) =>
                {
                    if (bindingSource4.DataSource != null)
                        bindingSource4.Filter = dgvDescuentos.FilterString;
                };

                dgvDescuentos.SortStringChanged += (s, e) =>
                {
                    if (bindingSource4.DataSource != null)
                        bindingSource4.Sort = dgvDescuentos.SortString;
                };
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar: " + ex.Message);
            }
            CargarDatosIniciales();
            

        }

         private DataTable ToDataTable<T>(IEnumerable<T> data)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in props)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in props)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }
            return table;
        }


        public async Task CargarEmpleados()
        {
            try
            {
                var empleadosos = await _api.GetAsync<List<Empleados>>("EmpleadoControlador/ListarEmpleados");

                var listaCombo = empleadosos
                    .Select(e => new
                    {
                        Id = e.IdEmpleado,
                        NombreCompleto = $"{e.Nombres} {e.Apellidos}"
                    })
                    .ToList();

                idEmpleadoCb.DataSource = listaCombo;
                idEmpleadoCb.DisplayMember = "NombreCompleto";
                idEmpleadoCb.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los empleados: " + ex.Message);
            }


        }
        private async Task CargarDescuentosTipo()
        {
            tipoTxt.Items.Clear();
            tipoTxt.Items.Add("Anticipo");
            tipoTxt.Items.Add("Inasistencias");
            tipoTxt.Items.Add("Falla Operativa");
            await Task.CompletedTask;

        }
        public async Task salarioempleado()
        {
            try
            {
                var contrato = await _api.GetAsync<List<ContratosDTO>>("ContratosControlador/ObtenerContratosCompletos");

                if (contrato == null || contrato.Count == 0)
                {
                    MessageBox.Show("No se encontraron contratos o no se pudo cargar la información.");
                    cbSalario.DataSource = null;
                    return;
                }

                var Listasalario = contrato
                    .Where(c => c.Estado == "Vigente")
                    .Select(c => new
                    {
                        NombreCompletoEmpleado = $"{c.NombreCompletoEmpleado} - {c.Salario:C}",
                        Salario = c.Salario
                    })
                    .ToList();


                cbSalario.DataSource = Listasalario;
                cbSalario.DisplayMember = "NombreCompletoEmpleado";
                cbSalario.ValueMember = "Salario";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los salarios: " + ex.Message);
            }
        }

        public void CargarDiasFaltados()
        {
            try
            {
                cbdiasfaltados.Items.Clear();

                // Agregar días del 1 al 30 (o el rango que necesites)
                for (int i = 1; i <= 30; i++)
                {
                    cbdiasfaltados.Items.Add(i);
                }

                // Seleccionar el primer item por defecto
                if (cbdiasfaltados.Items.Count > 0)
                {
                    cbdiasfaltados.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar días faltados: {ex.Message}");
            }
        }



        // var diasfaltados = cbdiasfaltados.selectValue


        private void tipoTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string seleccion = tipoTxt.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(seleccion))
                {
                    return;
                }

                switch (seleccion)
                {
                    case "Anticipo":
                        montoTxt.Text = "0";
                        montoTxt.Enabled = true;
                        cbdiasfaltados.Enabled = false;
                        cbSalario.Enabled = false;
                        break;

                    case "Inasistencias":
                        montoTxt.Text = "0";
                        montoTxt.Enabled = false;
                        cbdiasfaltados.Enabled = true;
                        cbSalario.Enabled = true;

                        break;

                    case "Falla Operativa":
                        montoTxt.Text = "0";
                        montoTxt.Enabled = true;
                        cbdiasfaltados.Enabled = false;
                        cbSalario.Enabled = false;
                        break;

                    default:
                        montoTxt.Enabled = false;

                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cambiar tipo: {ex.Message}");
            }
        }
        private void CalcularDescuentoInasistencias()
        {
            try
            {
                // Validaciones iniciales
                if (cbSalario.SelectedValue == null || cbdiasfaltados.SelectedItem == null)
                {
                    MessageBox.Show("Por favor seleccione un empleado y los días faltados.");
                    return;
                }

                if (!decimal.TryParse(cbSalario.SelectedValue.ToString(), out decimal salarioMensual) || salarioMensual <= 0)
                {
                    MessageBox.Show("No se pudo obtener el salario válido del empleado.");
                    return;
                }

                if (!int.TryParse(cbdiasfaltados.SelectedItem.ToString(), out int diasFaltados) || diasFaltados <= 0)
                {
                    MessageBox.Show("La cantidad de días faltados debe ser un número positivo.");
                    return;
                }

                // Constantes para el cálculo
                const int DIAS_MES = 30;
                const decimal PORCENTAJE_MAXIMO_DESCUENTO = 0.10m; // 10% del salario

                // Calcular valor del día completo (100%)
                decimal valorDiaCompleto = salarioMensual / DIAS_MES;

                // Calcular descuento total sin límite
                decimal descuentoTotal = valorDiaCompleto * diasFaltados;

                // Calcular el 10% del salario (límite máximo a descontar)
                decimal maximoDescuentoPermitido = salarioMensual * PORCENTAJE_MAXIMO_DESCUENTO;

                // Aplicar regla: si el descuento supera el 10% del salario, usar el límite
                decimal descuentoAplicar = (descuentoTotal > maximoDescuentoPermitido)
                                            ? maximoDescuentoPermitido
                                            : descuentoTotal;

                // Mostrar el resultado
                montoTxt.Text = descuentoAplicar.ToString("N2");
                montoTxt.Enabled = false;

                // Opcional: Mostrar advertencia si se aplicó el límite
                if (descuentoTotal > maximoDescuentoPermitido)
                {
                    MessageBox.Show($"El descuento calculado ({descuentoTotal:C}) supera el 10% del salario. " +
                                  $"Se aplicará el descuento máximo permitido: {maximoDescuentoPermitido:C}",
                                  "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular el descuento: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                montoTxt.Text = "0";
            }
        }

        public async Task CargarDescuentos()
        {
            /*try
            {
                var descuentos = await _api.GetAsync<List<Descuentos>>("DescuentosControlador/ObtenerTodos");
                dgvDescuentos.DataSource = descuentos;
                dgvDescuentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los descuentos: {ex.Message}");
            }*/
            try
            {
                var descuentos = await _api.GetAsync<List<Descuentos>>("DescuentosControlador/ObtenerTodos");

                // Convertir a DataTable
                DataTable dtDescuentos = ToDataTable(descuentos);
                bindingSource4.DataSource = dtDescuentos;
                bindingSource4.Filter = "Estado = 'True'";
                dgvDescuentos.DataSource = bindingSource4;

                // Configurar modo de orden para cada columna
                foreach (DataGridViewColumn col in dgvDescuentos.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.Programmatic;
                }

                dgvDescuentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private async void F5Descuentos_Load(object sender, EventArgs e)
        {
            CargarDiasFaltados();
        }
        private async void CargarDatosIniciales()
        {
            await CargarDescuentos();
            await CargarEmpleados();
            await salarioempleado();
            await CargarDescuentosTipo();

        }



        private async void btnCrear_Click(object sender, EventArgs e)
        {
            await CrearDescuento();
        }


        private async void OpenChildForm(Form ChildForm)
        {
            try
            {
                // Verificar si el nuevo formulario ya está abierto
                if (activeForm != null && activeForm.GetType() == ChildForm.GetType() && !activeForm.IsDisposed)
                {
                    activeForm.BringToFront();
                    return;
                }

                // Cerrar el formulario activo si existe y no es el formulario principal
                if (activeForm != null && activeForm != this && !activeForm.IsDisposed)
                {
                    activeForm.Close();
                    // Esperar un poco para que se cierre correctamente
                    await Task.Delay(100);
                }

                // Configurar el nuevo formulario
                activeForm = ChildForm;
                ChildForm.TopLevel = false;
                ChildForm.FormBorderStyle = FormBorderStyle.None;
                ChildForm.Dock = DockStyle.Fill;

                // Limpiar controles existentes
                panelAuxiliar.Controls.Clear();

                panelAuxiliar.Controls.Add(ChildForm);
                panelAuxiliar.Tag = ChildForm;



                // Mostrar el formulario
                ChildForm.BringToFront();

                // Pequeña animación opcional
                ChildForm.Opacity = 0;
                ChildForm.Show();

                for (int i = 0; i < 10; i++)
                {
                    await Task.Delay(20);
                    ChildForm.Opacity += 0.1;
                }
                ChildForm.Opacity = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task CrearDescuento()
        {
            try
            {
                // Validaciones
                if (idEmpleadoCb.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un empleado.");
                    return;
                }

                if (tipoTxt.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un tipo de descuento.");
                    return;
                }

                if (!decimal.TryParse(montoTxt.Text, out decimal monto) || monto <= 0)
                {
                    MessageBox.Show("El monto debe ser un valor positivo.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(descripcionTxt.Text))
                {
                    MessageBox.Show("Debe ingresar una descripción.");
                    return;
                }

                var nuevoDescuento = new Descuentos
                {
                    IdDescuento = 0,
                    EmpleadoId = Convert.ToInt32(idEmpleadoCb.SelectedValue),
                    Tipo = tipoTxt.SelectedItem.ToString(),
                    Descripcion = descripcionTxt.Text.Trim(),
                    Monto = monto,
                    Fecha = DateOnly.FromDateTime(fechaDTP.Value),
                    Estado = true
                };

                var response = await _api.PostAsync<Descuentos>("DescuentosControlador/AgregarAsync", nuevoDescuento);

                if (response != null)
                {
                    await CargarDescuentos();
                    MessageBox.Show("Descuento creado exitosamente.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se recibió respuesta del servidor.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el descuento: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task EditarDescuento()
        {
            try
            {

                // Validaciones
                if (idEmpleadoCb.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un empleado.");
                    return;
                }

                if (tipoTxt.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un tipo de descuento.");
                    return;
                }

                if (!decimal.TryParse(montoTxt.Text, out decimal monto) || monto <= 0)
                {
                    MessageBox.Show("El monto debe ser un valor positivo.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(descripcionTxt.Text))
                {
                    MessageBox.Show("Debe ingresar una descripción.");
                    return;
                }

                var nuevoDescuento = new Descuentos
                {
                    IdDescuento = int.Parse(textBox4.Text.ToString()),
                    EmpleadoId = Convert.ToInt32(idEmpleadoCb.SelectedValue),
                    Tipo = tipoTxt.SelectedItem.ToString(),
                    Descripcion = descripcionTxt.Text.Trim(),
                    Monto = monto,
                    Fecha = DateOnly.FromDateTime(fechaDTP.Value), // Correcto
                    Estado = true
                };

                var response = await _api.PutAsync<Descuentos>("DescuentosControlador/ActualizarAsyn", nuevoDescuento);

                if (response != null)
                {
                    await CargarDescuentos();
                    MessageBox.Show("Descuento editado exitosamente.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se recibió respuesta del servidor.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar el descuento: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task eliminarDescuento()
        {
            try
            {

                // Validaciones
                if (idEmpleadoCb.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un empleado.");
                    return;
                }

                if (tipoTxt.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un tipo de descuento.");
                    return;
                }

                if (!decimal.TryParse(montoTxt.Text, out decimal monto) || monto <= 0)
                {
                    MessageBox.Show("El monto debe ser un valor positivo.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(descripcionTxt.Text))
                {
                    MessageBox.Show("Debe ingresar una descripción.");
                    return;
                }

                var nuevoDescuento = new Descuentos
                {
                    IdDescuento = int.Parse(textBox4.Text.ToString()),
                    EmpleadoId = Convert.ToInt32(idEmpleadoCb.SelectedValue),
                    Tipo = tipoTxt.SelectedItem.ToString(),
                    Descripcion = descripcionTxt.Text.Trim(),
                    Monto = monto,
                    Fecha = DateOnly.FromDateTime(fechaDTP.Value), // Correcto
                    Estado = false
                };

                var response = await _api.PutAsync<Descuentos>("DescuentosControlador/ActualizarAsyn", nuevoDescuento);

                if (response != null)
                {
                    await CargarDescuentos();
                    MessageBox.Show("Descuento eliminado exitosamente.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se recibió respuesta del servidor.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el descuento: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void LimpiarCampos()
        {
            tipoTxt.SelectedIndex = -1;
            descripcionTxt.Clear();
            montoTxt.Text = "0";
            fechaDTP.Value = DateTime.Now;
        }



        private void btnInacistencias_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F9Inasistencias());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            CalcularDescuentoInasistencias();
        }

        private void btnAsistencias_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Licencias());
        }


        private async void btnEditar_Click(object sender, EventArgs e)
        {
            await EditarDescuento();
        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            await eliminarDescuento();
        }

        private void dgvDescuentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvDescuentos.Rows.Count) return;

            try
            {
                var row = dgvDescuentos.Rows[e.RowIndex];
                var dataRow = ((DataRowView)row.DataBoundItem)?.Row;

                if (dataRow == null) return;

                LoadBasicData(dataRow);

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar contrato");
            }

        }
        private void LoadBasicData(DataRow dataRow)
        {
            textBox4.Text = dataRow["IdDescuento"]?.ToString();
            idEmpleadoCb.Text = dataRow["EmpleadoId"]?.ToString();
            tipoTxt.Text = dataRow["Tipo"]?.ToString();
            //txtAuxE.Text = dataRow["EmpleadoId"]?.ToString();
            descripcionTxt.Text = dataRow["Descripcion"]?.ToString();
            fechaDTP.Text = dataRow["Fecha"]?.ToString();
            txtEstado.Text = dataRow["Estado"]?.ToString();
            montoTxt.Text = dataRow["Monto"]?.ToString();

        }
    }
}
