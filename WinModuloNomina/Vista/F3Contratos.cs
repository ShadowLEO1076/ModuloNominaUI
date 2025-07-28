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
    public partial class F3Contratos : Form
    {
        private readonly APIModuloNomina _apimodulonomina;
        private string ApiUrl;
        private BindingSource bindingSource1 = new BindingSource();
        private List<ContratosDTO> _contratosOriginales = new List<ContratosDTO>();

        public F3Contratos()
        {
            InitializeComponent();
<<<<<<< HEAD
            string baseUrl = ConfigurationManager.AppSettings["APIBaseUrl"];
            _apimodulonomina = new APIModuloNomina(baseUrl);
            CargarDatosIniciales();
            CargarJornadatipo();
           
            cbJornadaTipo.SelectedIndexChanged += cbJornadaTipo_SelectedIndexChanged;





            txtIdTipoContrato.Enabled = false;
            txtIdContrato.Enabled = false;
            txtHorasJornada.Enabled = false;
            // Configurar ADGV
            dgvHistorialContratos.FilterAndSortEnabled = true;
=======
>>>>>>> e3824a7c25003619496ee093ec36cbd74e6e22eb

            try
            {
                string baseUrl = ConfigurationManager.AppSettings["APIBaseUrl"];
                _apimodulonomina = new APIModuloNomina(baseUrl);


                this.Load += F3Contratos_Load;

                //dgvHistorialContratos.CellClick += dgvHistorialContratos_CellClick;
                dgvTipoContrato.CellClick += dgvTipoContrato_CellClick;

                txtIdContrato.Enabled = false;
                txtIdTipoContrato.Enabled = false;
                txtAuxE.Enabled = false;

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar: " + ex.Message);
            }

            ConfigurarEventos();
            CargarDatosIniciales();
        }

        private void F3Contratos_Load(object sender, EventArgs e)
        {

        }


        private async void CargarDatosIniciales()
        {
            await CargarJornadaTipo();
            await CargarTiposContrato();
            await CargarEmpleados();
            await CargarContratos();
            await ConfigurarGestionFechas();  // a borrar para demostracion de finalizados por defecto funciona aqui 
            await CargarComboBoxEstado();
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
                dtpFechaFin.Format = DateTimePickerFormat.Custom;
                dtpFechaFin.CustomFormat = "dd-MM-yyyy";

                dtpFechaInicio.MinDate = DateTime.Today;
                dtpFechaFin.MinDate = DateTime.Today;

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
                var contratos = await _apimodulonomina.ObtenerResumenSolicitudesVacaciones<List<ContratosDTO>>("ContratosControlador/ObtenerContratosCompletos");

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

                // Cargar las otras grids (sin cambios)
                var contratoTipo = await _apimodulonomina.GetAsync<List<ContratosTipo>>("ContratoTipoControlador/ListarTiposContratos");


                //dgvAprovados.DataSource = aprovados;
                dgvTipoContrato.DataSource = contratoTipo;

                dgvHistorialContratos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //dgvAprovados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvTipoContrato.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los contratos", ex.Message);
            }
        }
        private void ConfigurarEventos()
        {
            cbJornadaTipo.SelectedIndexChanged += cbJornadaTipo_SelectedIndexChanged;

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
<<<<<<< HEAD
        private void CargarJornadatipo()
        {
            cbJornadaTipo.Items.Add("Tiempo Completo");
            cbJornadaTipo.Items.Add("Medio Tiempo");
            cbJornadaTipo.Items.Add("Tiempo Parcial");
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

      

        private void DgvHistorialContratos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
=======
        private void dgvHistorialContratos_CellClick(object sender, DataGridViewCellEventArgs e)
>>>>>>> e3824a7c25003619496ee093ec36cbd74e6e22eb
        {

            if (e.RowIndex < 0 || e.RowIndex >= dgvHistorialContratos.Rows.Count) return;

            try
            {
<<<<<<< HEAD
                var contratos = await _apimodulonomina.GetAsync<List<Contratos>>("ContratosControlador/ListarContratos");
                // Convertir a DataTable
                DataTable dtSolicitudes = ToDataTable(contratos);
                bindingSource1.DataSource = dtSolicitudes;
                dgvHistorialContratos.DataSource = bindingSource1;

                // Configurar modo de orden para cada columna
                foreach (DataGridViewColumn col in dgvHistorialContratos.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.Programmatic;
                }

                dgvHistorialContratos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvHistorialContratos.DataSource = contratos;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los contratos");
            }
        }
        private async void CargarDatosIniciales()
        {
                _contratosOriginales = await _apimodulonomina.GetAsync<List<Contratos>>("ContratosControlador/ListarContratos");
                bindingSource1.DataSource = _contratosOriginales;
                dgvHistorialContratos.DataSource = bindingSource1;
            }
=======
                var row = dgvHistorialContratos.Rows[e.RowIndex];
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
                MessageBox.Show("Error al seleccionar contrato");
            }

        }
        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtpFechaFin.Value < dtpFechaInicio.Value)
                {
                    dtpFechaFin.Value = dtpFechaInicio.Value.AddDays(30);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar fecha inicio");
            }
        }
        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtpFechaInicio.Value > dtpFechaFin.Value)
                {
                    dtpFechaInicio.Value = dtpFechaFin.Value.AddDays(-1);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar fecha fin");
            }
        }

        private void UnsubscribeDateEvents()
        {
            dtpFechaInicio.ValueChanged -= dtpFechaInicio_ValueChanged;
            dtpFechaFin.ValueChanged -= dtpFechaFin_ValueChanged;
        }
        private void LoadBasicData(DataRow dataRow)
        {
            txtIdContrato.Text = dataRow["IdContrato"]?.ToString();
            cbTipoContrato.Text = dataRow["TipoContrato"]?.ToString();
            cbEmpleado.Text = dataRow["EmpleadoId"]?.ToString();
            //txtAuxE.Text = dataRow["EmpleadoId"]?.ToString();
            txtSalario.Text = dataRow["Salario"]?.ToString();
            cbEstadoContrato.Text = dataRow["Estado"]?.ToString();
            txtHorasJornada.Text = dataRow["HorasJornada"]?.ToString();

        }
        private void LoadBasicData2(DataRow dataRowi)
        {
            txtIdTipoContrato.Text = dataRowi["IdTipo"]?.ToString();
            cbJornadaTipo.Text = dataRowi["Jornada"]?.ToString();
            txtNombreTipo.Text = dataRowi["Nombre"]?.ToString();
        }
        private void LoadAndValidateDates(DataRow dataRow)
        {
            LoadAndValidateDate(dataRow, "FechaInicio", dtpFechaInicio, "inicio");
            LoadAndValidateDate(dataRow, "FechaFin", dtpFechaFin, "fin");
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
>>>>>>> e3824a7c25003619496ee093ec36cbd74e6e22eb


        private void SubscribeDateEvents()
        {
            dtpFechaInicio.ValueChanged += dtpFechaInicio_ValueChanged;
            dtpFechaFin.ValueChanged += dtpFechaFin_ValueChanged;
        }
        private void HighlightSelectedRow(DataGridViewRow selectedRow)
        {
            foreach (DataGridViewRow row in dgvHistorialContratos.SelectedRows)
            {
                row.DefaultCellStyle.BackColor = Color.LightBlue;
            }
        }
        private async Task CargarJornadaTipo()
        {
            cbJornadaTipo.Items.Clear();
            cbJornadaTipo.Items.Add("Tiempo Completo");
            cbJornadaTipo.Items.Add("Medio Tiempo");
            cbJornadaTipo.Items.Add("Tiempo Parcial");
            await Task.CompletedTask;
        }
        private async Task CargarComboBoxEstado()
        {
            cbEstadoContrato.Items.Clear();
            cbEstadoContrato.Items.Add("Vigente");
            cbEstadoContrato.Items.Add("Finalizado");
            cbEstadoContrato.SelectedIndex = 0;
            await Task.CompletedTask;
        }
        private void cbJornadaTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cbJornadaTipo.SelectedItem?.ToString();

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
                txtHorasJornada.Enabled = true; // permitir que el usuario escriba manual
            }
            
        }


        private void LoadBasicData(DataRow dataRow)
        {
            txtIdTipoContrato.Text = dataRow["IdSolicitud"]?.ToString();
            cbEmpleado.Text = dataRow["NombreCompleto"]?.ToString();
            txtIdContrato.Text = dataRow["DiasSolicitados"]?.ToString();
            cbJornadaTipo.Text = dataRow["Estado"]?.ToString();
            cbTipoContrato.Text = dataRow["Estado"]?.ToString();
            cbEstadoContrato.Text = dataRow["Estado"]?.ToString();
            txtHorasJornada.Text = dataRow["Estado"]?.ToString();
        }
        private void HighlightSelectedRow(DataGridViewRow selectedRow)
        {
            foreach (DataGridViewRow row in dgvHistorialContratos.SelectedRows)
            {
                row.DefaultCellStyle.BackColor = Color.LightBlue;
            }
        }
        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaInicio.Value.Date < DateTime.Today)
            {
                MessageBox.Show("La fecha de inicio no puede ser anterior a hoy.");
                dtpFechaInicio.Value = DateTime.Today;
            }
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaFin.Value < dtpFechaInicio.Value)
            {
                MessageBox.Show("La fecha fin no puede ser menor a la de inicio.");
                dtpFechaFin.Value = dtpFechaInicio.Value;
                txtHorasJornada.Enabled = true;
            }
            else if (seleccion == "Otro")
            {
                txtHorasJornada.Value = 0;
                txtHorasJornada.Enabled = true;
            }
        }
        private async Task CargarTiposContrato()
        {
            try
            {
                var tiposContrato = await _apimodulonomina.GetAsync<List<ContratosTipo>>("ContratoTipoControlador/ListarTiposContratos");
                var listacontratos = tiposContrato
                    .Select(t => new
                    {
                        Nombre = $"{t.Jornada} {t.Nombre}",
                        Valor = t.IdTipo
                    }).ToList();

                cbTipoContrato.DataSource = tiposContrato;
                cbTipoContrato.DisplayMember = "Jornada" + "Nombre";
                cbTipoContrato.ValueMember = "IdTipo";
                dgvTipoContrato.DataSource = tiposContrato;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }
        private async Task CargarEmpleados()
        {
            try
            {
                var empleados = await _apimodulonomina.GetAsync<List<Empleados>>("EmpleadoControlador/ListarEmpleados");

                var listaParaCombo = empleados
                    .Select(e => new
                    {
                        Id = e.IdEmpleado,
                        NombreCompleto = $"{e.Nombres} {e.Apellidos}"
                    })
                    .ToList();

                cbEmpleado.DataSource = listaParaCombo;
                cbEmpleado.DisplayMember = "NombreCompleto";
                cbEmpleado.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los empleados, ojito 😵‍💫");
                MessageBox.Show(ex.Message);
                MessageBox.Show("No se pudieron cargar los empleados: " + ex.Message);
            }
        }
<<<<<<< HEAD



        private async Task CargarHistorialContratos()
        {
            var contratos = await _apimodulonomina.GetAsync<List<Contratos>>("ContratosControlador/ListarContratos");
            dgvHistorialContratos.DataSource = contratos;
        }
=======
>>>>>>> e3824a7c25003619496ee093ec36cbd74e6e22eb
        private async Task CrearContrato()
        {
            try
            {
                if (cbEmpleado.SelectedItem == null || cbTipoContrato.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un empleado y un tipo de contrato.");
                    return;
                }
                var nuevoContrato = new Contratos
                {
                    IdContrato = 0,
                    EmpleadoId = int.Parse(cbEmpleado.SelectedValue.ToString()),
                    TipoId = int.Parse(cbTipoContrato.SelectedValue.ToString()),
                    FechaInicio = DateOnly.FromDateTime(dtpFechaInicio.Value),
                    FechaFin = DateOnly.FromDateTime(dtpFechaFin.Value),
                    Salario = decimal.Parse(txtSalario.Text.ToString()),
                    Estado = cbEstadoContrato.Text,
                    FechaCreacion = DateTime.Now.Date,
                    FechaModificacion = DateTime.Now.Date,
                    HorasJornada = int.Parse(txtHorasJornada.Text.Trim())


                };

                await _apimodulonomina.PostAsync<Contratos>("ContratosControlador/InsertarContratos", nuevoContrato);
                await CargarContratos();
                LimpiarControlesContrato();
                MessageBox.Show("Contrato creado exitosamente.");







            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el contrato: " + ex.Message);
            }
        }
        private async Task CrearTipoContrato()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreTipo.Text) || string.IsNullOrWhiteSpace(cbJornadaTipo.Text))
                {
                    MessageBox.Show("Completa los campos de Tipo de Contrato.");
                    return;
                }

                var nuevoTipo = new ContratosTipo
                {
                    Nombre = txtNombreTipo.Text,
                    Jornada = cbJornadaTipo.Text
                };

                await _apimodulonomina.PostAsync<ContratosTipo>("ContratoTipoControlador/InsertarTipoContrato", nuevoTipo);
                LimpiarControlesTipoContrato();
                await CargarContratos();
                await CargarTiposContrato();

                MessageBox.Show("Tipo de contrato creado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el tipo de contrato: " + ex.Message);
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
                    FechaFin = DateOnly.FromDateTime(dtpFechaFin.Value),
                    Salario = decimal.Parse(txtSalario.Text.Trim()),
                    Estado = nuevoEstado,
                    FechaCreacion = contratoActual.FechaCreacion,
                    FechaModificacion = DateTime.Now,
                    HorasJornada = int.Parse(txtHorasJornada.Value.ToString())
                };




                // Enviar la actualización al API
                await _apimodulonomina.PutAsync<ContratosDTO>("ContratosControlador/ActualizarContratos", contratoActualizado);
                MessageBox.Show("Contrato actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await CargarContratos(); // Recargar la lista de contratos

                //LimpiarControlesContrato(); // Limpiar los controles




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
        private async Task EditarTipoContrato()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdTipoContrato.Text))
                {
                    MessageBox.Show("Por favor, seleccione un puesto para editar.");
                    return;
                }

                string jornadact = cbJornadaTipo.Text.Trim(); //nombrePuesto
                string nombrect = txtNombreTipo.Text.Trim(); //salarioBaseText

                if (string.IsNullOrWhiteSpace(jornadact) || string.IsNullOrWhiteSpace(nombrect))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                var ctipoEditado = new ContratosTipo
                {
                    IdTipo = int.Parse(txtIdTipoContrato.Text),
                    Jornada = jornadact,
                    Nombre = nombrect
                };

                try
                {
                    var resultado = await _apimodulonomina.PutAsync<Puestos>($"ContratoTipoControlador/ActualizarTipoContrato/{ctipoEditado.IdTipo}", ctipoEditado);
                    MessageBox.Show("Puesto editado exitosamente.");
                    await CargarContratos(); // ahora sí espera a que termine de recargar
                    await CargarTiposContrato();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al editar el puesto: {ex.Message}");
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void LimpiarControlesContrato()
        {
            txtIdContrato.Clear();
            cbTipoContrato.SelectedIndex = -1;
            cbEmpleado.SelectedIndex = -1;
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now.AddYears(1);
            txtSalario.Clear();
            cbEstadoContrato.SelectedIndex = 0;
            txtHorasJornada.Value = 0;
        }
        private void LimpiarControlesTipoContrato()
        {
            txtIdTipoContrato.Clear();
            txtNombreTipo.Clear();
            cbJornadaTipo.SelectedIndex = -1;
            txtHorasJornada.Value = 0;
        }
        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {



        }
<<<<<<< HEAD

        private void F3Contratos_Load(object sender, EventArgs e)
        {

        }



        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private async void btnCrearContrato_Click(object sender, EventArgs e)
        {
            if (cbEmpleado.SelectedItem == null || cbTipoContrato.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un empleado y un tipo de contrato.");
                return;
            }

            var nuevoContrato = new Contratos
            {
                EmpleadoId = (int)cbEmpleado.SelectedValue,
                TipoId = (int)cbTipoContrato.SelectedValue,
                FechaInicio = DateOnly.FromDateTime(dtpFechaInicio.Value.Date),
                FechaFin = DateOnly.FromDateTime(dtpFechaFin.Value.Date),
                Salario = decimal.Parse(txtSalario.Text),
                Estado = cbEstadoContrato.Text,
                HorasJornada = int.TryParse(txtHorasJornada.Text, out var horas) ? horas : null,
                FechaCreacion = DateTime.Now
            };

            await _apimodulonomina.PostAsync<Contratos>("ContratosControlador/InsertarContratos", nuevoContrato);

            await CargarHistorialContratos();

        }

        private async void btnEditarContrato_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdContrato.Text)) return;

            var contratoActualizado = new Contratos
            {
                IdContrato = int.Parse(txtIdContrato.Text),
                EmpleadoId = (int)cbEmpleado.SelectedValue,
                TipoId = (int)cbTipoContrato.SelectedValue,
                FechaInicio = DateOnly.FromDateTime(dtpFechaInicio.Value),
                FechaFin = DateOnly.FromDateTime(dtpFechaFin.Value),
                Salario = decimal.Parse(txtSalario.Text),
                Estado = cbEstadoContrato.Text,
                HorasJornada = int.TryParse(txtHorasJornada.Text, out var horas) ? horas : null,
                FechaModificacion = DateTime.Now
            };

            var actualizado = await _apimodulonomina.PutAsync<ContratosTipo>("ContratosControlador/ActualizarContratos", contratoActualizado);
            MessageBox.Show("Contrato actualizado.");
            await CargarHistorialContratos();





        }

        private async void btnBorrarTipoContrato_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdTipoContrato.Text)) return;

            int id = int.Parse(txtIdTipoContrato.Text);
            await _apimodulonomina.DeleteAsync($"ContratoTipoControlador/EliminarTipoContrato/{id}");
            MessageBox.Show("Tipo de contrato eliminado.");
            await CargarTiposContrato();





        }

        private void dgvTipoContrato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHistorialContratos_CellContentClick(object sender, DataGridViewCellEventArgs e)
=======
        private void btnBorrarTipoContrato_Click(object sender, EventArgs e)
>>>>>>> e3824a7c25003619496ee093ec36cbd74e6e22eb
        {

        }
        private void cbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private async void btnCrearContrato_Click(object sender, EventArgs e)
        {
            await CrearContrato();
        }

        private async void btnCrearTipoC_Click(object sender, EventArgs e)
        {
            await CrearTipoContrato();

        }

        private async void btnEditarContrato_Click(object sender, EventArgs e)
        {
            await EditarContrato();
        }

        private void btnEditarTipoC_Click(object sender, EventArgs e)
        {
            EditarTipoContrato();
        }

        private void dgvTipoContrato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Validaciones
                if (e.RowIndex < 0 || e.RowIndex >= dgvTipoContrato.Rows.Count) return;
                if (dgvTipoContrato.Columns.Count < 3)
                    throw new Exception("El DataGridView no tiene las columnas esperadas");

                var row = dgvTipoContrato.Rows[e.RowIndex];

                // Validar valores nulos
                txtIdTipoContrato.Text = row.Cells[0]?.Value?.ToString()?.Trim() ?? "";
                txtNombreTipo.Text = row.Cells[2]?.Value?.ToString()?.Trim() ?? "";

                // Configurar ComboBox de Jornada
                string jornada = row.Cells[1]?.Value?.ToString()?.Trim() ?? "";
                if (!string.IsNullOrEmpty(jornada))
                {
                    cbJornadaTipo.SelectedItem = jornada;
                }

                // Resaltar fila
                dgvTipoContrato.ClearSelection();
                row.Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminarCT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdTipoContrato.Text))
            {
                MessageBox.Show("Por favor, seleccione un puesto para borrar.");
                return;
            }


            try
            {
                int idCT = int.Parse(txtIdTipoContrato.Text);
                await _apimodulonomina.DeleteAsync($"ContratoTipoControlador/EliminarTipoContrato/{idCT}");
                MessageBox.Show("Puesto eliminado exitosamente.");
                await CargarContratos();
                await CargarTiposContrato();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error El tipo contrato esta asociado a un empleado: {ex.Message}");
            }
        }

        private async void btnBorrarContrato_Click(object sender, EventArgs e)
        {
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
                FechaFin = DateOnly.FromDateTime(dtpFechaFin.Value),
                Salario = decimal.Parse(txtSalario.Text.Trim()),
                Estado = "Finalizado",
                FechaCreacion = contratoActual.FechaCreacion,
                FechaModificacion = DateTime.Now,
                HorasJornada = int.Parse(txtHorasJornada.Value.ToString())
            };




            // Enviar la actualización al API
            await _apimodulonomina.PutAsync<ContratosDTO>("ContratosControlador/ActualizarContratos", contratoActualizado2);
            MessageBox.Show("Contrato Eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await CargarContratos(); // Recargar la lista de contratos
            //LimpiarControlesContrato(); // Limpiar los controles

        }

        private void txtBuscarContrato_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtBuscarContrato.Text.Trim();

                if (string.IsNullOrWhiteSpace(searchText))
                {
                    bindingSource1.Filter = string.Empty;
                    return;
                }

                // Construir filtro para las columnas relevantes
                var filterParts = new List<string>();
                filterParts.Add($"(CedulaEmpleado LIKE '%{searchText}%')");
                bindingSource1.Filter = string.Join(" OR ", filterParts);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Contrato no  encontrado.");
            }
        }
    }
}


