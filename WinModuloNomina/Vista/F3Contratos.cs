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
            await CargarTiposContrato();
            await CargarEmpleados();
            await CargarContratosHistorico();
            await CargarComboBoxEstado();
            

        }
        private async Task CargarComboBoxEstado()
        {
            try
            {
             
                cbEstadoContrato.Items.Add("Vigente");
                cbEstadoContrato.Items.Add("Finalizado");
                cbEstadoContrato.SelectedIndex = 0;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los estados");
            }
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
            }
        }



        private async Task CargarHistorialContratos()
        {
            var contratos = await _apimodulonomina.GetAsync<List<Contratos>>("ContratosControlador/ListarContratos");
            dgvHistorialContratos.DataSource = contratos;
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
