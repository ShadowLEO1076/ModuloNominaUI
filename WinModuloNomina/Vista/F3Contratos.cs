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
using WinModuloNomina.Controlador;
using WinModuloNomina.Modelo.DTOS;

namespace WinModuloNomina.Vista
{
    public partial class F3Contratos : Form
    {
        private readonly APIModuloNomina _apimodulonomina;
        private string ApiUrl;
        private BindingSource bindingSource1 = new BindingSource();
        private List<Contratos> _contratosOriginales = new List<Contratos>();

        public F3Contratos()
        {
            InitializeComponent();
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

            ConfigurarDataGridView();
            ConfigurarEventos();
            CargarDatosIniciales();
        }

        private void ConfigurarDataGridView()
        {
            dgvHistorialContratos.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvHistorialContratos.AllowUserToAddRows = false;
            dgvHistorialContratos.AllowUserToDeleteRows = false;
            dgvHistorialContratos.ReadOnly = false;
            dgvHistorialContratos.FilterAndSortEnabled = true;
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
        {
            ConfigurarColumnasDataGridView();
        }

        private void ConfigurarColumnasDataGridView()
        {
            if (dgvHistorialContratos.Columns.Count == 0) return;

            // Configurar columnas de solo lectura
            SetColumnReadOnly("IdContrato");
            SetColumnReadOnly("FechaCreacion");
            SetColumnReadOnly("FechaModificacion");

            // Configurar formatos
            SetColumnFormat("FechaInicio", "d");
            SetColumnFormat("FechaFin", "d");
            SetColumnFormat("FechaCreacion", "g");
            SetColumnFormat("FechaModificacion", "g");
            SetColumnFormat("Salario", "C2");

            // Configurar columna de estado como ComboBox
            if (dgvHistorialContratos.Columns.Contains("Estado"))
            {
                var colEstado = new DataGridViewComboBoxColumn
                {
                    HeaderText = "Estado",
                    Name = "Estado",
                    DataPropertyName = "Estado",
                    DataSource = new List<string> { "Vigente", "Finalizado" }
                };

                int index = dgvHistorialContratos.Columns["Estado"].Index;
                dgvHistorialContratos.Columns.Remove("Estado");
                dgvHistorialContratos.Columns.Insert(index, colEstado);
            }

            dgvHistorialContratos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SetColumnReadOnly(string columnName)
        {
            if (dgvHistorialContratos.Columns.Contains(columnName))
            {
                dgvHistorialContratos.Columns[columnName].ReadOnly = true;
            }
        }

        private void SetColumnFormat(string columnName, string format)
        {
            if (dgvHistorialContratos.Columns.Contains(columnName))
            {
                dgvHistorialContratos.Columns[columnName].DefaultCellStyle.Format = format;
            }
        }

        public async Task CargarContratosHistorico()
        {
            try
            {
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
                cbTipoContrato.DisplayMember = "Nombre";
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



        private async Task CargarHistorialContratos()
        {
            var contratos = await _apimodulonomina.GetAsync<List<Contratos>>("ContratosControlador/ListarContratos");
            dgvHistorialContratos.DataSource = contratos;
        }
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
                    EmpleadoId = (int)cbEmpleado.SelectedValue,
                    TipoId = (int)cbTipoContrato.SelectedValue,
                    FechaInicio = DateOnly.FromDateTime(dtpFechaInicio.Value.Date),
                    FechaFin = DateOnly.FromDateTime(dtpFechaFin.Value.Date),
                    Salario = decimal.Parse(txtSalario.Text),
                    Estado = cbEstadoContrato.Text,
                    HorasJornada = (int)txtHorasJornada.Value,
                    FechaCreacion = DateTime.Now
                };

                await _apimodulonomina.PostAsync<Contratos>("ContratosControlador/InsertarContratos", nuevoContrato);
                await CargarContratosHistorico();
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
                await CargarTiposContrato();
                LimpiarControlesTipoContrato();
                MessageBox.Show("Tipo de contrato creado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el tipo de contrato: " + ex.Message);
            }
        }


        private async Task EditarContrato()
        {
            if (dgvHistorialContratos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un contrato para editar.");
                return;
            }

            try
            {
                var contratoModificado = (Contratos)dgvHistorialContratos.CurrentRow.DataBoundItem;
                contratoModificado.FechaModificacion = DateTime.Now;

                await _apimodulonomina.PutAsync<Contratos>(
                    "ContratosControlador/ActualizarContratos",
                    contratoModificado);

                MessageBox.Show("Contrato actualizado correctamente.");
                await CargarContratosHistorico();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el contrato: " + ex.Message);
                await CargarContratosHistorico();
            }
        }

        private async Task EditarTipoContrato()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdTipoContrato.Text))
                {
                    MessageBox.Show("No hay un tipo de contrato seleccionado para editar.");
                    return;
                }

                var tipoContratoActualizado = new ContratosTipo
                {
                    IdTipo = int.Parse(txtIdTipoContrato.Text),
                    Nombre = txtNombreTipo.Text,
                    Jornada = cbJornadaTipo.Text
                };

                await _apimodulonomina.PutAsync<ContratosTipo>("ContratoTipoControlador/ActualizarTipoContrato", tipoContratoActualizado);
                await CargarTiposContrato();
                MessageBox.Show("Tipo de contrato actualizado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el tipo de contrato: " + ex.Message);
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

        private void dgvHistorialContratos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText = dgvHistorialContratos.Columns[e.ColumnIndex].HeaderText;

            if (headerText.Equals("FechaFin"))
            {
                DateTime fechaInicio = (DateTime)dgvHistorialContratos.Rows[e.RowIndex].Cells["FechaInicio"].Value;
                DateTime fechaFin = (DateTime)e.FormattedValue;

                if (fechaFin < fechaInicio)
                {
                    MessageBox.Show("La fecha fin debe ser posterior a la fecha inicio");
                    e.Cancel = true;
                }
            }

            if (headerText.Equals("Salario"))
            {
                if (!decimal.TryParse(e.FormattedValue.ToString(), out decimal salario) || salario <= 0)
                {
                    MessageBox.Show("El salario debe ser un número positivo");
                    e.Cancel = true;
                }
            }
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {



        }

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
        {

        }
    }
}