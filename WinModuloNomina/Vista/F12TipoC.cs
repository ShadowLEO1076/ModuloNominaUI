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
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WinModuloNomina.Controlador;

namespace WinModuloNomina.Vista
{
    public partial class F12TipoC : Form
    {
        private readonly APIModuloNomina _apimodulonomina;
        public F12TipoC()
        {
            InitializeComponent();
            try
            {
                string baseUrl = ConfigurationManager.AppSettings["APIBaseUrl"];
                _apimodulonomina = new APIModuloNomina(baseUrl);
                dgvTipoContrato.CellClick += dgvTipoContrato_CellClick;

                this.Load += F12TipoC_Load;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar: " + ex.Message);
            }

        }
        public async Task CargarTiposContratos()
        {
            try
            {

                // Cargar las otras grids (sin cambios)
                var contratoTipo = await _apimodulonomina.GetAsync<List<ContratosTipo>>("ContratoTipoControlador/ListarTiposContratos");
                dgvTipoContrato.DataSource = contratoTipo;
                dgvTipoContrato.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los contratos tipo", ex.Message);
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
                //await CargarContratos();
                await CargarTiposContratos();

                MessageBox.Show("Tipo de contrato creado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el tipo de contrato: " + ex.Message);
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
                    //await CargarContratos(); // ahora sí espera a que termine de recargar
                    await CargarTiposContratos();

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
        private async void F12TipoC_Load(object sender, EventArgs e)
        {
            await CargarTiposContratos();
            await CargarJornadaTipo();

        }
        private void LimpiarControlesTipoContrato()
        {
            txtIdTipoContrato.Clear();
            txtNombreTipo.Clear();
            cbJornadaTipo.SelectedIndex = -1;

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
        private void LoadBasicData2(DataRow dataRowi)
        {
            txtIdTipoContrato.Text = dataRowi["IdTipo"]?.ToString();
            cbJornadaTipo.Text = dataRowi["Jornada"]?.ToString();
            txtNombreTipo.Text = dataRowi["Nombre"]?.ToString();
        }

        private async void btnCrearTipoC_Click(object sender, EventArgs e)
        {
            await CrearTipoContrato();
        }

        private async void btnEditarTipoC_Click(object sender, EventArgs e)
        {
            await EditarTipoContrato();
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
                //await CargarContratos();
                await CargarTiposContratos();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error El tipo contrato esta asociado a un empleado: {ex.Message}");
            }

        }
    }
}
