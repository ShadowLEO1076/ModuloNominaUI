
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
                MessageBox.Show("ERROR AL INICIAR EL FORMULARIO", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                await CargarEmpleadosEnComboBox();
                await CargarComboBoxEstado();
                await ConfigurarGestionFechas();
                await CargarVacaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CARGAR LOS DATOS ADICIONALES");
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
                MessageBox.Show("ERROR AL CONFIGURAR FECHAS"); ;
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
                MessageBox.Show("ERROR AL CALCULAR LOS DIAS SOLICITADOS");
            }
        }
        public async Task CargarVacaciones()
        {
            try
            {
                var solicitudes = await _apimodulonomina.GetAsync<List<SolicitudVacacionDTO>>("SolicitudVacacionesControlador/ObtenerResumenSolicitudes");

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
                //var aprovados = await _apimodulonomina.GetAsync<List<EmpleadosVacacionesTotales>>("EmpleadoVacacionesTotalesControlador/resumen-vacaciones");
                var revisiones = await _apimodulonomina.GetAsync<List<AprobacionVacaciones>>("AprovacionVacacionesControlador/ListarAprobacionesVacaciones");

                //dgvAprovados.DataSource = aprovados;
                dataRevisionV.DataSource = revisiones;

                dgvSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //dgvAprovados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataRevisionV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CARGAR LAS VACACIONES");
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
                MessageBox.Show("ERROR AL CARGAR LOS ESTADOS");
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
                MessageBox.Show("ERROR AL CARGAR LOS EMPLEADOS");
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
                MessageBox.Show("ERROR AL BUSCAR");
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
                MessageBox.Show("ERROR DEL RRANGO AL SELECCIONAR REVISION");
            }
            catch (NullReferenceException nullEx)
            {
                txtidAprovacion.Text = string.Empty;
                MessageBox.Show("REFERENCIA NULA AL SELECCIONAR REVISION");
            }
            catch (Exception ex)
            {
                txtidAprovacion.Text = string.Empty;
                MessageBox.Show("ERROR INESPERADO AL SELECCIONAR REVISION");
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
                MessageBox.Show("ERROR AL SELECCIONAR LA SOLICITUD");
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
            /*MessageBox.Show($"La fecha de {tipoFecha} ({fecha:dd/MM/yyyy}) es {comparacion} a la permitida. Se ajustó automáticamente.",
                          "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
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
                MessageBox.Show("ERROR AL CAMBIAR FECHA DE INICIO");
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
                MessageBox.Show("ERROR AL CAMBIAR FECHA DE FIN");
            }
        }


        private async void btnCrear_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario(true))
                return;

            // Validar que los campos de días no estén vacíos
            if (string.IsNullOrWhiteSpace(txtDiasAcumulados.Text) ||
                string.IsNullOrWhiteSpace(txtDiasSolicitados.Text))
            {
                MessageBox.Show("Debe ingresar tanto los días acumulados como los días solicitados.",
                                "Validación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Validar y convertir los días a enteros
            bool acumuladosOk = int.TryParse(txtDiasAcumulados.Text.Trim(), out int diasAcumulados);
            bool solicitadosOk = int.TryParse(txtDiasSolicitados.Text.Trim(), out int diasSolicitados);

            if (!acumuladosOk)
            {
                MessageBox.Show("Ingrese un número válido para los días acumulados.",
                                "Validación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (!solicitadosOk)
            {
                MessageBox.Show("Ingrese un número válido para los días solicitados.",
                                "Validación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Validar que haya suficientes días acumulados
            if (diasSolicitados > diasAcumulados)
            {
                MessageBox.Show("No tiene suficientes días acumulados para esta solicitud.",
                                "Días insuficientes",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Crear solicitud
            var solicitud = new SolicitudVacaciones
            {
                EmpleadoId = int.Parse(cbxEmpleado.SelectedValue.ToString()),
                FechaInicio = DateOnly.FromDateTime(dateInicio.Value),
                FechaFin = DateOnly.FromDateTime(dateFin.Value),
                DiasSolicitados = diasSolicitados,
                Estado = UsuarioSesion.EsAdministrador ? cbxEstado.Text : "Pendiente",
                FechaCreacion = DateTime.Now.Date
            };

            try
            {
                // Enviar solicitud
                var solicitudCreada = await _apimodulonomina.PostAsync<SolicitudVacaciones>(
                    "SolicitudVacacionesControlador/InsertarSolicitudVacaciones",
                    solicitud);

                // Si el administrador aprobó directamente, registrar la aprobación automática
                if (UsuarioSesion.EsAdministrador && solicitud.Estado == "Aprobado")
                {
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

                // Actualizar interfaz
                LimpiarFormulario();
                await CargarVacaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la solicitud:\n" + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }





        //CRUD BASICO


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
                MessageBox.Show("ERROR AL LIMPIAR EL FORMULARIO");
            }
        }

       

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!UsuarioSesion.EsAdministrador)
                {
                    MessageBox.Show("Solo el administrador puede aprobar solicitudes",
                                  "Permiso denegado",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }




                int idsolicitud = int.Parse(txtIdSVacacion.Text);
                string nuevoEstado = cbxEstado.Text;
                string estadoAnterior = "";
                var solicitudActual = await _apimodulonomina.GetAsync<SolicitudVacaciones>($"SolicitudVacacionesControlador/BuscarPorId/{idsolicitud}");
                estadoAnterior = solicitudActual?.Estado ?? "";
                var solicitud4 = new SolicitudVacaciones
                {
                    IdSolicitud = idsolicitud,
                    EmpleadoId = int.Parse(cbxEmpleado.SelectedValue.ToString()),
                    FechaInicio = DateOnly.FromDateTime(dateInicio.Value),
                    FechaFin = DateOnly.FromDateTime(dateFin.Value),
                    DiasSolicitados = int.Parse(txtDiasSolicitados.Text.Trim()),
                    Estado = "Rechazado",
                    FechaCreacion = solicitudActual?.FechaCreacion ?? DateTime.Now.Date
                };
                await _apimodulonomina.PutAsync<SolicitudVacaciones>("SolicitudVacacionesControlador/ActualizarSolicitudVacaciones", solicitud4);
                if (!int.TryParse(txtidAprovacion.Text.Trim(), out int idaprovacion))
                {
                    MessageBox.Show("El ID de aprobación no es válido",
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                    return;
                }
                await _apimodulonomina.DeleteAsync($"AprovacionVacacionesControlador/EliminarAprobacionVacaciones/{idaprovacion}");
                MessageBox.Show("solicitud eliminado exitosamente.");
                await CargarVacaciones();


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ELIMINAR LA SOLICITUD");
            }


        }
        private async void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validar selección en grid
                if (dgvSolicitudes.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una solicitud para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Validar campos numéricos básicos
                if (!int.TryParse(txtIdSVacacion.Text.Trim(), out int idSolicitud) ||
                    !int.TryParse(txtDiasSolicitados.Text.Trim(), out int diasSolicitados))
                {
                    MessageBox.Show("Verifique los valores numéricos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3. Validar días acumulados (manejo seguro de decimales)
                decimal diasAcumulados;
                if (!decimal.TryParse(txtDiasAcumulados.Text.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out diasAcumulados))
                {
                    MessageBox.Show("Formato inválido en días acumulados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 4. Obtener estado seleccionado
                string nuevoEstado = cbxEstado.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(nuevoEstado))
                {
                    MessageBox.Show("Seleccione un estado válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 5. Validar formulario
                if (!ValidarFormulario(true)) return;

                // 6. Obtener datos actuales
                var solicitudActual = await _apimodulonomina.GetAsync<SolicitudVacaciones>(
                    $"SolicitudVacacionesControlador/BuscarPorId/{idSolicitud}");

                // 7. Preparar objeto solicitud (manteniendo tu estructura original)
                var solicitud = new SolicitudVacaciones
                {
                    IdSolicitud = idSolicitud,
                    EmpleadoId = int.Parse(cbxEmpleado.SelectedValue.ToString()),
                    FechaInicio = DateOnly.FromDateTime(dateInicio.Value),
                    FechaFin = DateOnly.FromDateTime(dateFin.Value),
                    DiasSolicitados = diasSolicitados, // Usamos el valor ya validado
                    Estado = nuevoEstado,
                    FechaCreacion = solicitudActual?.FechaCreacion ?? DateTime.Now.Date
                };

                // 8. Validación especial para aprobación
                if (nuevoEstado == "Aprobado")
                {
                    // 8.1 Validar permisos
                    if (!UsuarioSesion.EsAdministrador)
                    {
                        MessageBox.Show("Solo el administrador puede aprobar solicitudes",
                                      "Permiso denegado",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                        return;
                    }

                    // 8.2 Validar días acumulados vs solicitados (comparación segura)
                    if ((int)Math.Floor(diasAcumulados) < diasSolicitados)
                    {
                        MessageBox.Show($"No puede aprobar. Días acumulados: {diasAcumulados}, Días solicitados: {diasSolicitados}",
                                      "Validación",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                        return;
                    }

                    // 8.3 Proceso de aprobación (manteniendo tu lógica original)
                    var aprobacion = new AprobacionVacaciones
                    {
                        IdAprobacion = 0,
                        SolicitudId = idSolicitud,
                        FechaAprobacion = DateTime.Now.Date,
                        UsuarioAprobador = UsuarioSesion.Cedula
                    };
                    // Validación básica
                    if (cbxEmpleado.SelectedValue == null)
                    {
                        txtDiasAcumulados.Text = "0";
                        return;
                    }
                    
                    // Conversión segura del ID
                    if (!int.TryParse(cbxEmpleado.SelectedValue.ToString(), out int idEmpleado))
                    {
                        txtDiasAcumulados.Text = "0";
                        return;
                    }
                    /*
                    // Obtener saldo actual
                    var saldo = await _apimodulonomina.GetAsync<SaldoVacaciones>(
                        $"SaldoVacacionesControlador/BuscarSaldoPorIdEmpleado/{idEmpleado}");

                    if (saldo == null)
                    {
                        MessageBox.Show("No se encontró el saldo de vacaciones del empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }*/
/*
                    // Calcular nuevos valores
                    decimal nuevosDiasAcumulados = saldo.DiasAcumulados - diasSolicitados;
                    decimal nuevosDiasUsados = saldo.DiasUsadosAnioActual + diasSolicitados;*/

                    // Crear objeto de actualización
                    // Modifica el objeto actualizacion para asegurar el formato correcto
                    /*var actualizacion = new
                    {
                        Id = saldo.Id,
                        IdEmpleado = int.Parse(cbxEmpleado.SelectedValue.ToString()),
                        DiasAcumulados = nuevosDiasAcumulados.ToString("0.00", CultureInfo.InvariantCulture),
                        FechaUltimaAsignacion = dateInicio.Value.ToString("yyyy-MM-dd"),
                        DiasUsadosAnioActual = nuevosDiasUsados.ToString("0.00", CultureInfo.InvariantCulture),
                        AnioActual = 2025
                    };*/

                    // Asignar ID al campo de texto (si es necesario)
                    //txtSaldoid.Text = saldo.Id.ToString();

                    // Ejecutar operaciones
                    await _apimodulonomina.PostAsync<AprobacionVacaciones>(
                        "AprovacionVacacionesControlador/InsertarAprobacionVacaciones",
                        aprobacion);

                    await _apimodulonomina.PutAsync<SolicitudVacaciones>(
                        "SolicitudVacacionesControlador/ActualizarSolicitudVacaciones",
                        solicitud);

                    /*await _apimodulonomina.PutAsync<SaldoVacaciones>(
                        "SaldoVacacionesControlador/ActualizarSaldoVacaciones",
                        actualizacion);*/



                }
                else if (nuevoEstado == "Rechazado" || nuevoEstado == "Pendiente")
                {
                    // 9. Validación para Rechazado/Pendiente
                    if (!int.TryParse(txtidAprovacion.Text.Trim(), out int idaprovacion))
                    {
                        MessageBox.Show("ID de aprobación no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 10. Confirmación de acción
                    var confirmacion = MessageBox.Show(
                        $"¿Está seguro de cambiar a estado {nuevoEstado}?",
                        "Confirmar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (confirmacion != DialogResult.Yes) return;

                    // 11. Ejecutar acciones (manteniendo tu lógica original)
                    await _apimodulonomina.DeleteAsync(
                        $"AprovacionVacacionesControlador/EliminarAprobacionVacaciones/{idaprovacion}");

                    await _apimodulonomina.PutAsync<SolicitudVacaciones>(
                        "SolicitudVacacionesControlador/ActualizarSolicitudVacaciones",
                        solicitud);
                }
                else
                {
                    // 12. Actualización normal para otros estados
                    await _apimodulonomina.PutAsync<SolicitudVacaciones>(
                        "SolicitudVacacionesControlador/ActualizarSolicitudVacaciones",
                        solicitud);
                }

                // 13. Actualizar vista
                await CargarVacaciones();
                MessageBox.Show("Solicitud actualizada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar la solicitud: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void dgvSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private async void cbxEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Validación básica
                if (cbxEmpleado.SelectedValue == null)
                {
                    txtDiasAcumulados.Text = "0";
                    return;
                }

                // Conversión segura del ID
                int idEmpleado;
                if (!int.TryParse(cbxEmpleado.SelectedValue.ToString(), out idEmpleado))
                {
                    txtDiasAcumulados.Text = "0";
                    return;
                }

                // Obtener saldo (versión simplificada)
                var saldo = await _apimodulonomina.GetAsync<SaldoVacaciones>(
                    $"SaldoVacacionesControlador/BuscarSaldoPorIdEmpleado/{idEmpleado}");

                // Manejo seguro del valor decimal/int
                int diasAcumulados = 0;
                if (saldo != null)
                {
                    // Conversión directa a entero (truncando decimales)
                    diasAcumulados = (int)saldo.DiasAcumulados;
                }

                // Asignación segura
                txtDiasAcumulados.Text = diasAcumulados.ToString();

                // Feedback opcional
                if (diasAcumulados == 0)
                {
                    MessageBox.Show("El empleado no tiene días acumulados");
                }
            }
            catch (Exception ex)
            {
                txtDiasAcumulados.Text = "0";
                MessageBox.Show("Error al cargar días acumulados: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }



    }
}




/*private void MostrarError(string mensaje, Exception ex, bool esCritico = true)
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
       }*/


/*private async void btnEliminarA_Click(object sender, EventArgs e)
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
                                  "Error Seleccione en la tabla",
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
                if (!UsuarioSesion.EsAdministrador)
                {
                    MessageBox.Show("Solo el administrador puede aprobar solicitudes",
                                  "Permiso denegado",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }
       

                int idsolicitud = int.Parse(txtIdSVacacion.Text);
                string nuevoEstado = cbxEstado.Text;
                string estadoAnterior = "";
                var solicitudActual = await _apimodulonomina.GetAsync<SolicitudVacaciones>($"SolicitudVacacionesControlador/BuscarPorId/{idsolicitud}");
                estadoAnterior = solicitudActual?.Estado ?? "";
                var solicitud5 = new SolicitudVacaciones
                {
                    IdSolicitud = idsolicitud,
                    EmpleadoId = int.Parse(cbxEmpleado.SelectedValue.ToString()),
                    FechaInicio = DateOnly.FromDateTime(dateInicio.Value),
                    FechaFin = DateOnly.FromDateTime(dateFin.Value),
                    DiasSolicitados = int.Parse(txtDiasSolicitados.Text.Trim()),
                    Estado = "Pendiente",
                    FechaCreacion = solicitudActual?.FechaCreacion ?? DateTime.Now.Date
                };

                await _apimodulonomina.PutAsync<SolicitudVacaciones>("SolicitudVacacionesControlador/ActualizarSolicitudVacaciones", solicitud5);
                MessageBox.Show("solicitud eliminado exitosamente.");


                await CargarVacaciones();


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ELIMINAR APROVACION");
            }
            finally
            {
                await CargarVacaciones(); // Actualizar la vista siempre
            }
        }*/