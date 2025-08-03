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
          
        }
        private async void CargarDatosIniciales()
        {
            await CargarDescuentos();
            await CargarEmpleados();

            await CargarDescuentosTipo();

        }



        private async void btnCrear_Click(object sender, EventArgs e)
        {
            await CrearDescuento();
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



   

        private void iconButton1_Click(object sender, EventArgs e)
        {
 
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
