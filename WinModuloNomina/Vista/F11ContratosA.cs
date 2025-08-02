using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicacion.DTO.DTOs;
using Infraestructura.AccesoDatos;
using Newtonsoft.Json;
using WinModuloNomina.Controlador;
using WinModuloNomina.Modelo.DTOS;

namespace WinModuloNomina.Vista
{

    public partial class F11ContratosA : Form
    {
        private readonly APIModuloNomina _apimodulonomina;
        private BindingSource bindingSource1 = new BindingSource();
        private List<ContratosDTO> _contratosOriginales = new List<ContratosDTO>();

        public F11ContratosA()
        {
            InitializeComponent();
            try
            {
                string baseUrl = ConfigurationManager.AppSettings["APIBaseUrl"];
                _apimodulonomina = new APIModuloNomina(baseUrl);


                this.Load += F11ContratosA_Load;

                dgvHistorialContratos.CellClick += dgvHistorialContratos_CellClick;
                cbEmpleado.SelectedIndexChanged += cbEmpleado_SelectedIndexChanged;


                txtIdContrato.Enabled = false;


                // Configurar ADGV
                dgvHistorialContratos.FilterAndSortEnabled = true;
                dgvHistorialContratos.FilterStringChanged += (s, e) =>
                {
                    if (bindingSource1.DataSource != null)
                        bindingSource1.Filter = dgvHistorialContratos.FilterString;
                };

                dgvHistorialContratos.SortStringChanged += (s, e) =>
                {
                    if (bindingSource1.DataSource != null)
                        bindingSource1.Sort = dgvHistorialContratos.SortString;
                };
                CargarDatosIniciales();

            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar: " + ex.Message);
            }
        }
        private async void CargarDatosIniciales()
        {
            await CargarEmpleados();
            await CargarContratos();
            await ConfigurarGestionFechas();  // a borrar para demostracion de finalizados por defecto funciona aqui 
            await CargarComboBoxEstado();
            await cargarTipoCombo();
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
        private async Task ConfigurarGestionFechas()
        {
            try
            {
                dtpFechaInicio.Format = DateTimePickerFormat.Custom;
                dtpFechaInicio.CustomFormat = "dd-MM-yyyy";
                dtpFechaInicio.MinDate = DateTime.Today;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al configurar las fechas", ex.Message);
            }
        }
        public async Task CargarContratos()
        {
            try
            {
                var contratos = await _apimodulonomina.GetAsync<List<ContratosDTO>>("ContratosControlador/ObtenerContratosCompletos");

                // Convertir a DataTable
                DataTable dtContratos = ToDataTable(contratos);
                bindingSource1.DataSource = dtContratos;
                bindingSource1.Filter = "Estado = 'Vigente'";
                dgvHistorialContratos.DataSource = bindingSource1;

                // Configurar modo de orden para cada columna
                foreach (DataGridViewColumn col in dgvHistorialContratos.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.Programmatic;
                }
                dgvHistorialContratos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los contratos", ex.Message);
            }
        }

        private void dgvHistorialContratos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvHistorialContratos.Rows.Count) return;

            try
            {
                var row = dgvHistorialContratos.Rows[e.RowIndex];
                var dataRow = ((DataRowView)row.DataBoundItem)?.Row;

                if (dataRow == null) return;                
                // Cargar datos básicos
                LoadBasicData(dataRow);
                // Cargar y validar fechas
                LoadAndValidateDates(dataRow);           
                // Colorear fila seleccionada
                HighlightSelectedRow(row);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar contrato");
            }
        }
       
        private void ConfigurarEventos()
        {
            //cbJornadaTipo.SelectedIndexChanged += cbJornadaTipo_SelectedIndexChanged;

            dgvHistorialContratos.FilterStringChanged += (s, e) =>
            {
                if (bindingSource1.DataSource != null)
                    bindingSource1.Filter = dgvHistorialContratos.FilterString;
            };

            dgvHistorialContratos.SortStringChanged += (s, e) =>
            {
                if (bindingSource1.DataSource != null)
                    bindingSource1.Sort = dgvHistorialContratos.SortString;
            };
        }
       
        private void LoadBasicData(DataRow dataRow)
        {
            txtIdContrato.Text = dataRow["IdContrato"]?.ToString();
            cbTipoContrato.Text = dataRow["TipoContrato"]?.ToString();
            cbEmpleado.Text = dataRow["EmpleadoId"]?.ToString();
            //txtAuxE.Text = dataRow["EmpleadoId"]?.ToString();
            txtSalario.Text = dataRow["Salario"]?.ToString();
            cbEstadoContrato.Text = dataRow["Estado"]?.ToString();
          

        }
        private void LoadAndValidateDates(DataRow dataRow)
        {
            LoadAndValidateDate(dataRow, "FechaInicio", dtpFechaInicio, "inicio");
        }
        private void LoadAndValidateDate(DataRow dataRow, string columnName, DateTimePicker picker, string tipoFecha)
        {
            if (DateTime.TryParse(dataRow[columnName]?.ToString(), out DateTime fecha))
            {
                if (fecha < picker.MinDate)
                {
                    picker.Value = picker.MinDate;

                }
                else if (fecha > picker.MaxDate)
                {
                    picker.Value = picker.MaxDate;

                }
                else
                {
                    picker.Value = fecha;
                }
            }
        }
       
        private void HighlightSelectedRow(DataGridViewRow selectedRow)
        {
            foreach (DataGridViewRow row in dgvHistorialContratos.SelectedRows)
            {
                row.DefaultCellStyle.BackColor = Color.LightBlue;
            }
        }
        private async Task CargarComboBoxEstado()
        {
            cbEstadoContrato.Items.Clear();
            cbEstadoContrato.Items.Add("Vigente");
            cbEstadoContrato.Items.Add("Finalizado");
            cbEstadoContrato.SelectedIndex = 0;
            await Task.CompletedTask;
        }
        /*private void cbJornadaTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cbTipoContrato.SelectedItem?.ToString();

            if (seleccion == "Tiempo Completo")
            {
                txtHorasJornada.Value = 8;
                txtHorasJornada.Enabled = false;
            }
            else if (seleccion == "Medio Tiempo")
            {
                txtHorasJornada.Value = 4;
                txtHorasJornada.Enabled = false;
            }
            else if (seleccion == "Tiempo Parcial")
            {
                txtHorasJornada.Value = 0;
                txtHorasJornada.Enabled = true;
            }
            else if (seleccion == "Otro")
            {
                txtHorasJornada.Value = 0;
                txtHorasJornada.Enabled = true;
            }
        }*/
        private List<EmpleadoConSalarioDTO> _empleadosCache = new List<EmpleadoConSalarioDTO>();

        private async Task CargarEmpleados()
        {
            try
            {
                _empleadosCache = await _apimodulonomina.GetAsync<List<EmpleadoConSalarioDTO>>("EmpleadosControlador/ListarEmpleadosConSalario");

                var listaParaCombo = _empleadosCache
                    .Select(e => new
                    {
                        Id = e.IdEmpleado,
                        NombreCompleto = $"{e.NombreCompleto} {e.NombrePuesto}"
                    })
                    .ToList();

                cbEmpleado.DataSource = listaParaCombo;
                cbEmpleado.DisplayMember = "NombreCompleto";
                cbEmpleado.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los empleados: " + ex.Message);
            }
        }

        private void cbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEmpleado.SelectedValue != null &&
                int.TryParse(cbEmpleado.SelectedValue.ToString(), out int idEmpleado))
            {
                var empleado = _empleadosCache.FirstOrDefault(e => e.IdEmpleado == idEmpleado);
                if (empleado != null)
                {
                    txtSalario.Text = empleado.SalarioBase.ToString("N2");
                }
            }
        }

        private async Task cargarTipoCombo()
        {
            try
            {
                var tipos = await _apimodulonomina.GetAsync<List<ContratosTipo>>("ContratoTipoControlador/ListarTiposContratos");

                var listaCombito = tipos
                    .OrderByDescending(t => t.IdTipo) // Ordenar por IdTipo descendente
                    .Select(t => new
                    {
                        IdTipo = t.IdTipo,
                        Nombre = $"{t.Jornada} {t.Nombre} {t.IdTipo}"
                    })
                    .ToList();

                cbTipoContrato.DataSource = listaCombito;
                cbTipoContrato.DisplayMember = "Nombre";
                cbTipoContrato.ValueMember = "IdTipo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los tipos: " + ex.Message);
            }
        }

     



        // En el evento Leave del TextBox
        private void txtSalario_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtSalario.Text, out decimal salario))
            {
                txtSalario.Text = salario.ToString("N2"); // Formato con 2 decimales
            }
        }




        private async Task CrearContrato()
        {
            try
            {
                // Validaciones iniciales
                if (cbEmpleado.SelectedItem == null || cbTipoContrato.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un empleado y un tipo de contrato.");
                    return;
                }

                if (!decimal.TryParse(txtSalario.Text.Trim(), out decimal salario))
                {
                    MessageBox.Show("Salario u horas no válidas.");
                    return;
                }
                // Crear contrato
                var nuevoContrato = new Contratos
                {
                    IdContrato = 0, // Se asignará automáticamente en el backend
                    EmpleadoId = int.Parse(cbEmpleado.SelectedValue.ToString()),
                    TipoId = int.Parse(cbTipoContrato.SelectedValue.ToString()),
                    FechaInicio = DateOnly.FromDateTime(dtpFechaInicio.Value),
                    JornadaHoraInicio = TimeOnly.FromDateTime(TimeEntrada.Value),
                    JornadaHoraFin = TimeOnly.FromDateTime(TimeSalida.Value),
                    Salario = decimal.Parse(txtSalario.Text.Trim()),
                    Estado = cbEstadoContrato.Text,
                    FechaCreacion = DateTime.Now.Date,
                    FechaModificacion = DateTime.Now.Date,
                    
                };
                // Insertar contrato usando PostAsync<T>
                var contratoInsertado = await _apimodulonomina.PostAsync<Contratos>(
                    "ContratosControlador/InsertarContratos", nuevoContrato);

                if (contratoInsertado == null || contratoInsertado.IdContrato == 0)
                {
                    MessageBox.Show("No se pudo obtener el ID del contrato creado.");
                    return;
                }
                // Actualizar vista
                await CargarContratos();
                LimpiarControlesContrato();
                MessageBox.Show("Contrato  creados exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }









        private async Task EditarContrato()
        {
            try
            {
                // Validar que hay un contrato seleccionado
                if (string.IsNullOrWhiteSpace(txtIdContrato.Text))
                {
                    MessageBox.Show("Seleccione un contrato para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar campos obligatorios
                if (cbEmpleado.SelectedItem == null || cbTipoContrato.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(txtSalario.Text) || string.IsNullOrWhiteSpace(cbEstadoContrato.Text))
                {
                    MessageBox.Show("Complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Convertir el ID a entero de forma segura
                if (!int.TryParse(txtIdContrato.Text.Trim(), out int idContrato))
                {
                    MessageBox.Show("El ID de contrato no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar cambio de estado a "Finalizado" si no es administrador
                string nuevoEstado = cbEstadoContrato.Text;
                if (nuevoEstado == "Finalizado" && !UsuarioSesion.EsAdministrador)
                {
                    MessageBox.Show("Solo el administrador puede finalizar contratos", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el contrato actual para mantener datos de creación
                var contratoActual = await _apimodulonomina.GetAsync<Contratos>($"ContratosControlador/BuscarPorId/{idContrato}");


                // Mostrar mensaje de confirmación
                var confirmacion = MessageBox.Show($"¿Está seguro de editar el contrato con ID {idContrato}?",
                                                 "Confirmar edición",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

                if (confirmacion != DialogResult.Yes) return;


                // Crear objeto con los datos actualizados
                var contratoActualizado = new Contratos
                {

                    IdContrato = idContrato,
                    EmpleadoId = int.Parse(cbEmpleado.SelectedValue.ToString()),
                    TipoId = int.Parse(cbTipoContrato.SelectedValue.ToString()),
                    FechaInicio = DateOnly.FromDateTime(dtpFechaInicio.Value),
                    JornadaHoraInicio = TimeOnly.FromDateTime(TimeEntrada.Value),
                    JornadaHoraFin = TimeOnly.FromDateTime(TimeSalida.Value),
                    Salario = decimal.Parse(txtSalario.Text.Trim()),
                    Estado = nuevoEstado,
                    FechaCreacion = contratoActual.FechaCreacion,
                    FechaModificacion = DateTime.Now
                };
                await _apimodulonomina.PutAsync<Contratos>($"ContratosControlador/ActualizarContratos",contratoActualizado);
                await CargarContratos();





            }


            catch (FormatException fex)
            {
                MessageBox.Show($"Error de formato en los datos: {fex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar contrato: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarControlesContrato()
        {
            txtIdContrato.Clear();
            cbTipoContrato.SelectedIndex = -1;
            cbEmpleado.SelectedIndex = -1;
            dtpFechaInicio.Value = DateTime.Now;
         
            //txtSalario.Clear();////////////////////////////////////////////ojito
            cbEstadoContrato.SelectedIndex = 0;
         
        }


        private void F11ContratosA_Load(object sender, EventArgs e)
        {

        }

        private async void btnCrearContrato_Click(object sender, EventArgs e)
        {
            await CrearContrato();
        }

        private async void btnEditarContrato_Click(object sender, EventArgs e)
        {
            await EditarContrato();
        }

        private async void btnBorrarContrato_Click(object sender, EventArgs e)
        {
            // Validar cambio de estado a "Finalizado" si no es administrador

            if (!UsuarioSesion.EsAdministrador)
            {
                MessageBox.Show("Solo el administrador puede finalizar contratos", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtIdContrato.Text))
            {
                MessageBox.Show("Seleccione un contrato para Finalizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar campos obligatorios
            /*if (cbEmpleado.SelectedItem == null || cbTipoContrato.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtSalario.Text) || string.IsNullOrWhiteSpace(cbEstadoContrato.Text))
            {
                MessageBox.Show("Complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }*/

            // Convertir el ID a entero de forma segura
            if (!int.TryParse(txtIdContrato.Text.Trim(), out int idContrato))
            {
                MessageBox.Show("El ID de contrato no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            // Obtener el contrato actual para mantener datos de creación
            var contratoActual = await _apimodulonomina.GetAsync<Contratos>($"ContratosControlador/BuscarPorId/{idContrato}");


            // Mostrar mensaje de confirmación
            var confirmacion = MessageBox.Show($"¿Está seguro de eliminar el contrato con ID {idContrato}?",
                                             "Confirmar edición",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes) return;

            // Crear objeto con los datos actualizados
            var contratoActualizado2 = new Contratos
            {
                IdContrato = idContrato,
                EmpleadoId = int.Parse(cbEmpleado.SelectedValue.ToString()),
                TipoId = int.Parse(cbTipoContrato.SelectedValue.ToString()),
                FechaInicio = DateOnly.FromDateTime(dtpFechaInicio.Value),
                JornadaHoraInicio = TimeOnly.FromDateTime(TimeEntrada.Value),
                JornadaHoraFin = TimeOnly.FromDateTime(TimeSalida.Value),
                Salario = decimal.Parse(txtSalario.Text.Trim()),
                Estado = "Finalizado",
                FechaCreacion = contratoActual.FechaCreacion,
                FechaModificacion = DateTime.Now,
              
            };




            // Enviar la actualización al API
            await _apimodulonomina.PutAsync<ContratosDTO>("ContratosControlador/ActualizarContratos", contratoActualizado2);
            MessageBox.Show("Contrato Eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await CargarContratos(); // Recargar la lista de contratos
            //LimpiarControlesContrato(); // Limpiar los controles

        }



        private async Task CrearHistorico()
        {
            try
            {
                // Validaciones iniciales
                if (cbEmpleado.SelectedItem == null || cbTipoContrato.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un empleado y un tipo de contrato.");
                    return;
                }
                if(!UsuarioSesion.EsAdministrador)
                {
                    MessageBox.Show("Debe ser administrador ");
                    return;
                }

                

                var nuevoHistorico = new ContratosHistoricoDTO
                {
                    IdHistorico = 0,
                    IdContratoOriginal = int.Parse(txtIdContrato.Text.Trim()),
                    EmpleadoId = int.Parse(cbEmpleado.SelectedValue.ToString()),
                    TipoId = int.Parse(cbTipoContrato.SelectedValue.ToString()),
                    FechaInicio = DateOnly.FromDateTime(dtpFechaInicio.Value),
                    FechaFin = DateOnly.FromDateTime(DateTime.Now),
                    Salario = decimal.Parse(txtSalario.Text.Trim()),
                    Estado = "Finalizado",
                    FechaCreacion = DateTime.Now.Date,
                    FechaModificacion = DateTime.Now.Date,
                    UsuarioCambio = UsuarioSesion.Cedula,
                    FechaRegistro = DateTime.Now.Date,
                    JornadaHoraInicio = TimeOnly.FromDateTime(TimeEntrada.Value),
                    JornadaHoraFin = TimeOnly.FromDateTime(TimeSalida.Value)
                };

                // Insertar contrato usando PostAsync<T>
               await _apimodulonomina.PostAsync<ContratosHistoricoDTO>(
               "ContratosHistoricosControlador/InsertarContratosHistorico", nuevoHistorico);

                // Actualizar vista
                await CargarContratos();
                LimpiarControlesContrato();
                MessageBox.Show("Contrato historico  creados exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void btnHistorico_Click(object sender, EventArgs e)
        {
            await CrearHistorico();
            

            // Insertar histórico usando PostAsync sin genérico
            
        }
    }
}
