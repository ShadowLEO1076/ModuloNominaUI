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
        private BindingSource bindingSource1 = new BindingSource();
        private List<Contratos> _contratosOriginales = new List<Contratos>();

        public F3Contratos()
        {
            InitializeComponent();
            string baseUrl = ConfigurationManager.AppSettings["APIBaseUrl"];
            _apimodulonomina = new APIModuloNomina(baseUrl);

        
            ConfigurarEventos();
            CargarDatosIniciales();
        }


        private async void CargarDatosIniciales()
        {
            await CargarJornadaTipo();
            await CargarTiposContrato();
            await CargarEmpleados();
            await CargarContratosHistorico();
            await CargarComboBoxEstado();
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




       

        public async Task CargarContratosHistorico()
        {
            try
            {
                _contratosOriginales = await _apimodulonomina.GetAsync<List<Contratos>>("ContratosControlador/ListarContratos");
                bindingSource1.DataSource = _contratosOriginales;
                dgvHistorialContratos.DataSource = bindingSource1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los contratos: " + ex.Message);
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
                txtHorasJornada.Enabled = true;
            }
        }
        private async Task CargarTiposContrato()
        {
            try
            {
                var tiposContrato = await _apimodulonomina.GetAsync<List<ContratosTipo>>("ContratoTipoControlador/ListarTiposContratos");
                cbTipoContrato.DataSource = tiposContrato;
                cbTipoContrato.DisplayMember = "Nombre";
                cbTipoContrato.ValueMember = "IdTipo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tipos de contrato: " + ex.Message);
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
                MessageBox.Show("No se pudieron cargar los empleados: " + ex.Message);
            }
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

        

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void F3Contratos_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrarTipoContrato_Click(object sender, EventArgs e)
        {

        }

        private void cbTipoContrato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}