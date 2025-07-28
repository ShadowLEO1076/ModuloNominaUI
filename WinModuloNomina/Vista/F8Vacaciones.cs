
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http.Json;
using System.Windows.Forms;
using Infraestructura.AccesoDatos;
using Newtonsoft.Json;
using WinModuloNomina.Controlador;
using WinModuloNomina.Modelo;
using WinModuloNomina.Modelo.DTOS;
using Zuby.ADGV;

namespace WinModuloNomina.Vista
{
    public partial class F8Vacaciones : Form
    {
        private readonly APIModuloNomina _apimodulonomina;
        private string ApiUrl;
        private BindingSource bindingSource1 = new BindingSource();

        public F8Vacaciones()
        {
            InitializeComponent();

            try
            {
                ApiUrl = ConfigurationManager.AppSettings["APIBaseUrl"];
                _apimodulonomina = new APIModuloNomina(ApiUrl);


                this.Load += F8Vacaciones_Load;
                txtBuscar2.TextChanged += txtBuscar2_TextChanged;
                dgvSolicitudes.CellClick += dgvSolicitudes_CellClick;

                txtIdSVacacion.Enabled = false;
                txtidAprovacion.Enabled = false;

                // Configurar ADGV
                dgvSolicitudes.FilterAndSortEnabled = true;
                dgvSolicitudes.FilterStringChanged += (s, e) =>
                {
                    if (bindingSource1.DataSource != null)
                        bindingSource1.Filter = dgvSolicitudes.FilterString;
                };

                dgvSolicitudes.SortStringChanged += (s, e) =>
                {
                    if (bindingSource1.DataSource != null)
                        bindingSource1.Sort = dgvSolicitudes.SortString;
                };
            }
            catch (Exception ex)
            {
                MostrarError("Error al inicializar el formulario", ex);
            }
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

        private async void F8Vacaciones_Load(object sender, EventArgs e)
        {
            try
            {
                await CargarVacaciones();
                await CargarEmpleadosEnComboBox();
                await CargarComboBoxEstado();
                await ConfigurarGestionFechas();
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar los datos iniciales", ex);
            }
        }

        private async Task ConfigurarGestionFechas()
        {
            try
            {
                dateInicio.Format = DateTimePickerFormat.Custom;
                dateInicio.CustomFormat = "dd-MM-yyyy";
                dateFin.Format = DateTimePickerFormat.Custom;
                dateFin.CustomFormat = "dd-MM-yyyy";

                dateInicio.MinDate = DateTime.Today;
                dateFin.MinDate = DateTime.Today;

                dateInicio.ValueChanged += (s, ev) =>
                {
                    if (dateFin.Value < dateInicio.Value)
                    {
                        dateFin.Value = dateInicio.Value.AddDays(1);
                    }
                    CalcularDiasSolicitados();




                };

                dateFin.ValueChanged += (s, ev) =>
                {
                    if (dateInicio.Value > dateFin.Value)
                    {
                        dateInicio.Value = dateFin.Value.AddDays(-1);
                    }
                    CalcularDiasSolicitados();

                };

                txtDiasSolicitados.Enabled = false;
            }
            catch (Exception ex)
            {
                MostrarError("Error al configurar las fechas", ex);
            }
        }
        private void CalcularDiasSolicitados()
        {
            try
            {
                if (dateInicio.Value <= dateFin.Value)
                {
                    var diasSolicitados = (dateFin.Value - dateInicio.Value).Days + 1;
                    txtDiasSolicitados.Text = diasSolicitados.ToString();
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error al calcular días solicitados", ex, false);
            }
        }
        public async Task CargarVacaciones()
        {
            try
            {
                var solicitudes = await _apimodulonomina.ObtenerResumenSolicitudesVacaciones<List<SolicitudVacacionDTO>>("SolicitudVacacionesControlador/ObtenerResumenSolicitudes");

                // Convertir a DataTable
                DataTable dtSolicitudes = ToDataTable(solicitudes);
                bindingSource1.DataSource = dtSolicitudes;
                dgvSolicitudes.DataSource = bindingSource1;

                // Configurar modo de orden para cada columna
                foreach (DataGridViewColumn col in dgvSolicitudes.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.Programmatic;
                }

                // Cargar las otras grids (sin cambios)
                var aprovados = await _apimodulonomina.GetAsync<List<EmpleadosVacacionesTotales>>("EmpleadoVacacionesTotalesControlador/resumen-vacaciones");
                var revisiones = await _apimodulonomina.GetAsync<List<AprobacionVacaciones>>("AprovacionVacacionesControlador/ListarAprobacionesVacaciones");

                //dgvAprovados.DataSource = aprovados;
                dataRevisionV.DataSource = revisiones;

                dgvSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //dgvAprovados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataRevisionV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar las vacaciones", ex);
            }
        }
        private async Task CargarComboBoxEstado()
        {
            try
            {
                cbxEstado.Items.Clear();
                cbxEstado.Items.Add("Pendiente");
                cbxEstado.Items.Add("Aprobado");
                cbxEstado.Items.Add("Rechazado");
                cbxEstado.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar estados", ex);
            }
        }
        public async Task CargarEmpleadosEnComboBox()
        {
            try
            {
                var empleados = await _apimodulonomina.GetAsync<List<Empleados>>("EmpleadoControlador/ListarEmpleados");

                var listaNombres = empleados
                    .Select(e => new
                    {
                        NombreCompleto = $"{e.Nombres} {e.Apellidos}",
                        Valor = e.IdEmpleado
                    })
                    .ToList();

                cbxEmpleado.DataSource = listaNombres;
                cbxEmpleado.DisplayMember = "NombreCompleto";
                cbxEmpleado.ValueMember = "Valor";
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar empleados", ex);
            }
        }
        private void txtBuscar2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtBuscar2.Text.Trim();

                if (string.IsNullOrWhiteSpace(searchText))
                {
                    bindingSource1.Filter = string.Empty;
                    return;
                }

                // Construir filtro para las columnas relevantes
                var filterParts = new List<string>();
                filterParts.Add($"(NombreCompleto LIKE '%{searchText}%')");
                filterParts.Add($"(Cedula LIKE '%{searchText}%')");

                bindingSource1.Filter = string.Join(" OR ", filterParts);
            }
            catch (Exception ex)
            {
                MostrarError("Error al buscar", ex, false);
            }
        }
        private void dataRevisionV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que el click no fue en encabezado o fuera de rango
            if (e.RowIndex < 0 || e.RowIndex >= dataRevisionV.Rows.Count)
            {
                txtidAprovacion.Text = string.Empty;
                return;
            }
            try
            {
                // Obtener la fila seleccionada de forma segura
                DataGridViewRow selectedRow = dataRevisionV.Rows[e.RowIndex];

                // Verificar que la fila y la celda existen
                if (selectedRow == null || selectedRow.Cells.Count == 0)
                {
                    txtidAprovacion.Text = string.Empty;
                    return;
                }

                // Intentar obtener el ID de aprobación de la primera columna
                object cellValue = selectedRow.Cells[0].Value;
                string valorId = cellValue?.ToString()?.Trim() ?? string.Empty;

                // Validar que el valor no esté vacío
                if (string.IsNullOrEmpty(valorId))
                {
                    txtidAprovacion.Text = string.Empty;
                    MessageBox.Show("La fila seleccionada no contiene un ID válido.",
                                  "Advertencia",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }

                // Asignar el valor al TextBox
                txtidAprovacion.Text = valorId;

                // Opcional: Seleccionar automáticamente la fila completa
                selectedRow.Selected = true;

                // Opcional: Deseleccionar otras filas
                foreach (DataGridViewRow row in dataRevisionV.Rows)
                {
                    if (row.Index != e.RowIndex) row.Selected = false;
                }
            }
            catch (ArgumentOutOfRangeException argEx)
            {
                txtidAprovacion.Text = string.Empty;
                MostrarError("Error de rango al seleccionar revisión", argEx, false);
            }
            catch (NullReferenceException nullEx)
            {
                txtidAprovacion.Text = string.Empty;
                MostrarError("Referencia nula al seleccionar revisión", nullEx, false);
            }
            catch (Exception ex)
            {
                txtidAprovacion.Text = string.Empty;
                MostrarError("Error inesperado al seleccionar revisión", ex, false);
            }
        }
        private void dgvSolicitudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvSolicitudes.Rows.Count) return;

            try
            {
                var row = dgvSolicitudes.Rows[e.RowIndex];
                var dataRow = ((DataRowView)row.DataBoundItem)?.Row;

                if (dataRow == null) return;

                // Desactivar eventos temporalmente
                UnsubscribeDateEvents();

                // Cargar datos básicos
                LoadBasicData(dataRow);

                // Cargar y validar fechas
                LoadAndValidateDates(dataRow);

                // Reactivar eventos
                SubscribeDateEvents();

                // Colorear fila seleccionada
                HighlightSelectedRow(row);
            }
            catch (Exception ex)
            {
                MostrarError("Error al seleccionar solicitud", ex, false);
            }
        }
        // Métodos auxiliares para dividir la funcionalidad
        private void UnsubscribeDateEvents()
        {
            dateInicio.ValueChanged -= dateInicio_ValueChanged;
            dateFin.ValueChanged -= dateFin_ValueChanged;
        }
        private void SubscribeDateEvents()
        {
            dateInicio.ValueChanged += dateInicio_ValueChanged;
            dateFin.ValueChanged += dateFin_ValueChanged;
        }
        private void LoadBasicData(DataRow dataRow)
        {
            txtIdSVacacion.Text = dataRow["IdSolicitud"]?.ToString();
            cbxEmpleado.Text = dataRow["NombreCompleto"]?.ToString();
            txtDiasSolicitados.Text = dataRow["DiasSolicitados"]?.ToString();
            cbxEstado.Text = dataRow["Estado"]?.ToString();
        }
        private void LoadAndValidateDates(DataRow dataRow)
        {
            LoadAndValidateDate(dataRow, "FechaInicio", dateInicio, "inicio");
            LoadAndValidateDate(dataRow, "FechaFin", dateFin, "fin");
        }
        private void LoadAndValidateDate(DataRow dataRow, string columnName, DateTimePicker picker, string tipoFecha)
        {
            if (DateTime.TryParse(dataRow[columnName]?.ToString(), out DateTime fecha))
            {
                if (fecha < picker.MinDate)
                {
                    picker.Value = picker.MinDate;
                    ShowDateAdjustmentMessage(fecha, tipoFecha, "anterior");
                }
                else if (fecha > picker.MaxDate)
                {
                    picker.Value = picker.MaxDate;
                    ShowDateAdjustmentMessage(fecha, tipoFecha, "posterior");
                }
                else
                {
                    picker.Value = fecha;
                }
            }
        }
        private void ShowDateAdjustmentMessage(DateTime fecha, string tipoFecha, string comparacion)
        {
            MessageBox.Show($"La fecha de {tipoFecha} ({fecha:dd/MM/yyyy}) es {comparacion} a la permitida. Se ajustó automáticamente.",
                          "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void HighlightSelectedRow(DataGridViewRow selectedRow)
        {
            foreach (DataGridViewRow row in dgvSolicitudes.SelectedRows)
            {
                row.DefaultCellStyle.BackColor = Color.LightBlue;
            }
        }
        private void dateInicio_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dateFin.Value < dateInicio.Value)
                {
                    dateFin.Value = dateInicio.Value.AddDays(1);
                }
                CalcularDiasSolicitados();
            }
            catch (Exception ex)
            {
                MostrarError("Error al cambiar fecha de inicio", ex, false);
            }
        }
        private void dateFin_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dateInicio.Value > dateFin.Value)
                {
                    dateInicio.Value = dateFin.Value.AddDays(-1);
                }
                CalcularDiasSolicitados();
            }
            catch (Exception ex)
            {
                MostrarError("Error al cambiar fecha de fin", ex, false);
            }
        }

        //CRUD BASICO
        private async void btnCrear_Click(object sender, EventArgs e)
        {

            if (!ValidarFormulario(true)) return;


            // Crear solicitud de vacaciones
            var nuevaSolicitud = new SolicitudVacaciones
            {
                EmpleadoId = int.Parse(cbxEmpleado.SelectedValue.ToString()),
                FechaInicio = DateOnly.FromDateTime(dateInicio.Value),
                FechaFin = DateOnly.FromDateTime(dateFin.Value),
                DiasSolicitados = int.Parse(txtDiasSolicitados.Text.Trim()),
                Estado = cbxEstado.Text,
                FechaCreacion = DateTime.Now.Date
            };


            var nuevaSolicitud2 = new SolicitudVacaciones
            {
                EmpleadoId = int.Parse(cbxEmpleado.SelectedValue.ToString()),
                FechaInicio = DateOnly.FromDateTime(dateInicio.Value),
                FechaFin = DateOnly.FromDateTime(dateFin.Value),
                DiasSolicitados = int.Parse(txtDiasSolicitados.Text.Trim()),
                Estado = "Pendiente",
                FechaCreacion = DateTime.Now.Date

            };


            if (UsuarioSesion.EsAdministrador == true)
            {
                var solicitudCreada = await _apimodulonomina.PostAsync<SolicitudVacaciones>(
                "SolicitudVacacionesControlador/InsertarSolicitudVacaciones",
                nuevaSolicitud);
                await Task.Delay(500);
                // Si es aprobada, crear aprobación automática
                if (nuevaSolicitud.Estado == "Aprobado" && UsuarioSesion.EsAdministrador == true)
                {
                    // metodo para esperar 5 segundos antes de continuar 


                    var aprobacion = new AprobacionVacaciones
                    {
                        SolicitudId = solicitudCreada.IdSolicitud,
                        FechaAprobacion = DateTime.Now.Date,
                        UsuarioAprobador = UsuarioSesion.Cedula
                    };

                    await _apimodulonomina.PostAsync<AprobacionVacaciones>(
                        "AprovacionVacacionesControlador/InsertarAprobacionVacaciones",
                        aprobacion);
                }
            }
            else if (UsuarioSesion.EsAdministrador == false)
            {
                await _apimodulonomina.PostAsync<SolicitudVacaciones>(
                "SolicitudVacacionesControlador/InsertarSolicitudVacaciones",
                nuevaSolicitud2);
            }


            // Actualizar interfaz
            LimpiarFormulario();
            await CargarVacaciones();
        }

        private bool ValidarFormulario(bool validarFechas = true)
        {
            if (cbxEmpleado.SelectedValue == null || cbxEstado.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un empleado y un estado.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (validarFechas)
            {
                // Validación de fecha de inicio
                if (dateInicio.Value < DateTime.Today)
                {
                    var resultado = MessageBox.Show("La fecha de inicio seleccionada es anterior a hoy. ¿Desea continuar de todas formas?",
                                                    "Advertencia de fecha",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
                    if (resultado == DialogResult.No)
                    {
                        dateInicio.Value = DateTime.Today;
                        return false;
                    }
                }

                // Validación de fecha fin menor a inicio
                if (dateFin.Value < dateInicio.Value)
                {
                    MessageBox.Show("La fecha de fin no puede ser menor que la fecha de inicio. Se ajustará automáticamente.",
                                    "Validación de fecha",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    dateFin.Value = dateInicio.Value.AddDays(1);
                    return false;
                }
            }

            // Validación de días solicitados
            if (!int.TryParse(txtDiasSolicitados.Text.Trim(), out int dias) || dias <= 0)
            {
                MessageBox.Show("Ingrese un número válido de días solicitados.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LimpiarFormulario()
        {
            try
            {
                cbxEmpleado.SelectedIndex = -1;
                txtDiasSolicitados.Text = string.Empty;
                cbxEstado.SelectedIndex = 0;
                dateInicio.Value = DateTime.Today;
                dateFin.Value = DateTime.Today.AddDays(1);
            }
            catch (Exception ex)
            {
                MostrarError("Error al limpiar formulario", ex, false);
            }
        }

        private void MostrarError(string mensaje, Exception ex, bool esCritico = true)
        {
            string mensajeCompleto = $"{mensaje}: {ex.Message}";

            if (esCritico)
            {
                MessageBox.Show(mensajeCompleto, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(mensajeCompleto, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Loggear el error (podrías implementar un sistema de logging aquí)
            Console.WriteLine($"{DateTime.Now}: {mensajeCompleto}\n{ex.StackTrace}");
        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    int idsolicitud = int.Parse(txtIdSVacacion.Text);
                    await _apimodulonomina.DeleteAsync($"SolicitudVacacionesControlador/EliminarSolicitudVacaciones/{idsolicitud}");
                    MessageBox.Show("solicitud eliminado exitosamente.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el solicitud: {ex.Message}");
                }
                await CargarVacaciones();


            }
            catch (Exception ex)
            {
                MostrarError("Error al eliminar solicitud", ex);
            }


        }
        private async void btnEditar_Click(object sender, EventArgs e)
        {

            try
            {
                int idSolicitud = int.Parse(txtIdSVacacion.Text);
                string nuevoEstado = cbxEstado.Text;
                string estadoAnterior = "";
                var solicitudActual = await _apimodulonomina.GetAsync<SolicitudVacaciones>(
                        $"SolicitudVacacionesControlador/BuscarPorId/{idSolicitud}");
                estadoAnterior = solicitudActual?.Estado ?? "";
                var solicitud = new SolicitudVacaciones
                {
                    IdSolicitud = idSolicitud,
                    EmpleadoId = int.Parse(cbxEmpleado.SelectedValue.ToString()),
                    FechaInicio = DateOnly.FromDateTime(dateInicio.Value),
                    FechaFin = DateOnly.FromDateTime(dateFin.Value),
                    DiasSolicitados = int.Parse(txtDiasSolicitados.Text.Trim()),
                    Estado = nuevoEstado,
                    FechaCreacion = solicitudActual?.FechaCreacion ?? DateTime.Now.Date
                };
                var solicitud2 = new SolicitudVacaciones
                {
                    IdSolicitud = idSolicitud,
                    EmpleadoId = int.Parse(cbxEmpleado.SelectedValue.ToString()),
                    FechaInicio = DateOnly.FromDateTime(dateInicio.Value),
                    FechaFin = DateOnly.FromDateTime(dateFin.Value),
                    DiasSolicitados = int.Parse(txtDiasSolicitados.Text.Trim()),
                    Estado = "Pendiente",
                    FechaCreacion = solicitudActual?.FechaCreacion ?? DateTime.Now.Date

                };
                var solicitud3 = new SolicitudVacaciones
                {
                    IdSolicitud = idSolicitud,
                    EmpleadoId = int.Parse(cbxEmpleado.SelectedValue.ToString()),
                    FechaInicio = DateOnly.FromDateTime(dateInicio.Value),
                    FechaFin = DateOnly.FromDateTime(dateFin.Value),
                    DiasSolicitados = int.Parse(txtDiasSolicitados.Text.Trim()),
                    Estado = "Rechazado",
                    FechaCreacion = solicitudActual?.FechaCreacion ?? DateTime.Now.Date

                };
                if (!ValidarFormulario(true)) return;

                /*int idSolicitud = int.Parse(txtIdSVacacion.Text);
                string nuevoEstado = cbxEstado.Text;
                string estadoAnterior = "";*/

                // Obtener estado actual


                // Validar cambio de estado a "Aprobado"
                if (nuevoEstado == "Aprobado" && !UsuarioSesion.EsAdministrador)
                {
                    MessageBox.Show("Solo el administrador puede aprobar solicitudes",
                                  "Permiso denegado",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }

                // Actualizar la solicitud



                // 1. Obtener la fila seleccionada
                if (dgvSolicitudes.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una solicitud para editar.", "Advertencia");
                    return;
                }

                // 2. Obtener el ID y estado DE la solicitud
                idSolicitud = Convert.ToInt32(txtIdSVacacion.Text);
                nuevoEstado = cbxEstado.SelectedItem.ToString();



                if (nuevoEstado == "Aprobado")
                {

                    // 4. Crear el objeto de aprobación
                    var aprobacion = new AprobacionVacaciones
                    {
                        IdAprobacion = 0, // mi dto espera int jason espera string
                        SolicitudId = idSolicitud,  // mi dto espera int jason espera string
                        FechaAprobacion = DateTime.Now.Date, // mi dto espera DateTime jason espera string
                        UsuarioAprobador = UsuarioSesion.Cedula  // mi dto espera string jason espera string

                    };
                    string json = JsonConvert.SerializeObject(aprobacion);
                    await _apimodulonomina.PostAsync<AprobacionVacaciones>("AprovacionVacacionesControlador/InsertarAprobacionVacaciones", aprobacion);
                    await _apimodulonomina.PutAsync<SolicitudVacaciones>("SolicitudVacacionesControlador/ActualizarSolicitudVacaciones", solicitud);

                }
                else if (nuevoEstado == "Rechazado")
                {
                    if (string.IsNullOrWhiteSpace(txtidAprovacion.Text))
                    {
                        MessageBox.Show("Clik en el id a eliminar en la tabla de aprovados",
                                      "Validación",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                        return;
                    }

                    // Convertir el ID a entero de forma segura
                    if (!int.TryParse(txtidAprovacion.Text.Trim(), out int idaprovacion))
                    {
                        MessageBox.Show("El ID de aprobación no es válido",
                                      "Error",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                        return;
                    }

                    // Confirmar eliminación
                    var confirmacion = MessageBox.Show($"¿Está seguro de eliminar la aprobación con ID {idaprovacion}?",
                                                     "Confirmar eliminación",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                    if (confirmacion != DialogResult.Yes) return;

                    // Eliminar usando el ID directamente en la URL
                    await _apimodulonomina.DeleteAsync($"AprovacionVacacionesControlador/EliminarAprobacionVacaciones/{idaprovacion}");
                    await _apimodulonomina.PutAsync<SolicitudVacaciones>("SolicitudVacacionesControlador/ActualizarSolicitudVacaciones", solicitud3);
                }
                else if (nuevoEstado == "Pendiente")
                {
                    if (string.IsNullOrWhiteSpace(txtidAprovacion.Text))
                    {
                        MessageBox.Show("Seleccione una aprobación para eliminar",
                                      "Validación",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                        return;
                    }

                    // Convertir el ID a entero de forma segura
                    if (!int.TryParse(txtidAprovacion.Text.Trim(), out int idaprovacion))
                    {
                        MessageBox.Show("El ID de aprobación no es válido",
                                      "Error",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                        return;
                    }

                    // Confirmar eliminación
                    var confirmacion = MessageBox.Show($"¿Está seguro de eliminar la aprobación con ID {idaprovacion}?",
                                                     "Confirmar eliminación",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                    if (confirmacion != DialogResult.Yes) return;

                    // Eliminar usando el ID directamente en la URL
                    await _apimodulonomina.DeleteAsync($"AprovacionVacacionesControlador/EliminarAprobacionVacaciones/{idaprovacion}");
                    await _apimodulonomina.PutAsync<SolicitudVacaciones>("SolicitudVacacionesControlador/ActualizarSolicitudVacaciones", solicitud2);
                }
                else
                {
                    MessageBox.Show("Error al actualizar aqui la solicitud.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                await CargarVacaciones();



            }
            catch (Exception ex)
            {
                MostrarError("Error al editar solicitud aca", ex);
            }
        }

        private async void btnEliminarA_Click(object sender, EventArgs e)
        {


            try
            {

                // Validar que el campo no esté vacío
                if (string.IsNullOrWhiteSpace(txtidAprovacion.Text))
                {
                    MessageBox.Show("Seleccione una aprobación para eliminar",
                                  "Validación",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }

                // Convertir el ID a entero de forma segura
                if (!int.TryParse(txtidAprovacion.Text.Trim(), out int idaprovacion))
                {
                    MessageBox.Show("El ID de aprobación no es válido",
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                    return;
                }

                // Confirmar eliminación
                var confirmacion = MessageBox.Show($"¿Está seguro de eliminar la aprobación con ID {idaprovacion}?",
                                                 "Confirmar eliminación",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

                if (confirmacion != DialogResult.Yes) return;

                // Eliminar usando el ID directamente en la URL
                await _apimodulonomina.DeleteAsync($"AprovacionVacacionesControlador/EliminarAprobacionVacaciones/{idaprovacion}");

            }
            catch (Exception ex)
            {
                MostrarError("Error al eliminar aprobación", ex);
            }
            finally
            {
                await CargarVacaciones(); // Actualizar la vista siempre
            }
        }

        private void dgvSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}