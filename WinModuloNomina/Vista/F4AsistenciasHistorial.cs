using Aplicacion.DTO.DTOs;
using Infraestructura.AccesoDatos;
using Microsoft.VisualBasic;
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
using WinModuloNomina.Controlador;

namespace WinModuloNomina.Vista
{
    public partial class F4AsistenciasHistorial : Form
    {
        private readonly APIModuloNomina _api;
        private string _apiUrl;
        private List<AsistenciasFormDTO> _listaAsistencias;
        public F4AsistenciasHistorial()
        {
            _apiUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
            _api = new APIModuloNomina(_apiUrl);
            this.Load += F4AsistenciasHistorial_Load;
            InitializeComponent();
        }

        private async void F4AsistenciasHistorial_Load(object sender, EventArgs e)
        {
            await CargarAsistencias();
        }

        private async Task CargarAsistencias()
        {
            try
            {
                _listaAsistencias = await _api.GetAsync<List<AsistenciasFormDTO>>("AsistenciasControlador/ObtenerTodasActivasAsistenciasFormDTO");

                AsistenciasDgv.DataSource = _listaAsistencias;
                AsistenciasDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Error al cargar asistencias.");
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarAsistencias(filtroTxt.Text);
        }


        private void FiltrarAsistencias(string filtro)
        {
            if (_listaAsistencias == null) return;

            string filtroLower = filtro.ToLower().Trim();

            var filtrado = _listaAsistencias.Where(a =>
                (a.IdAsistencia.ToString().Contains(filtroLower)) ||
                (a.EmpleadoId.ToString().Contains(filtroLower)) ||
                (!string.IsNullOrEmpty(a.NombresApellidos) && a.NombresApellidos.ToLower().Contains(filtroLower)) ||
                (!string.IsNullOrEmpty(a.Cedula) && a.Cedula.ToLower().Contains(filtroLower)) ||
                (a.Fecha.ToString("yyyy-MM-dd").Contains(filtroLower)) ||
                (a.HoraEntrada.HasValue && a.HoraEntrada.Value.ToString().Contains(filtroLower)) ||
                (a.HoraInicioAlmuerzo.HasValue && a.HoraInicioAlmuerzo.Value.ToString().Contains(filtroLower)) ||
                (a.HoaFinAlmuerzo.HasValue && a.HoaFinAlmuerzo.Value.ToString().Contains(filtroLower)) ||
                (a.HoraSalida.HasValue && a.HoraSalida.Value.ToString().Contains(filtroLower))
            ).ToList();

            AsistenciasDgv.DataSource = filtrado;
        }

        private void AsistenciasDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex <= AsistenciasDgv.ColumnCount)
                {
                    var AsistenciaSelec = AsistenciasDgv.Rows[e.RowIndex].DataBoundItem as AsistenciasFormDTO;

                    if (AsistenciaSelec != null)
                    {
                        idAsisTxt.Text = AsistenciaSelec.IdAsistencia.ToString();
                        empleNomApeTxt.Text = AsistenciaSelec.NombresApellidos.ToString();
                        cedulaTxt.Text = AsistenciaSelec.Cedula.ToString();
                        fechaTxt.Text = AsistenciaSelec.Fecha.ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error al asignar los datos.");
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            idAsisTxt.Clear();
            empleNomApeTxt.Clear();
            cedulaTxt.Clear();
            fechaTxt.Clear();
        }

        private async void eliminarBtn_Click(object sender, EventArgs e)
        {
            try 
            {
                if (string.IsNullOrWhiteSpace(idAsisTxt.Text))
                {
                    MessageBox.Show("Favor, buscar y presionar el registro que necesite en a lista de abajo, tras eso, presione el botó eliminar.");
                    return;
                }

                var confirm = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Confirmar edición", MessageBoxButtons.YesNo);
                if (confirm != DialogResult.Yes) return;

                var busq = await _api.GetAsync<Asistencias>($"AsistenciasControlador/ObtenerPorIdAsync/{int.Parse(idAsisTxt.Text)}");

                busq.Estado = false;

                await _api.PutAsync<Asistencias>($"AsistenciasControlador/ActualizarAsync", busq);

                await CargarAsistencias();

                MessageBox.Show("Éxito al borrar el dato seleccionado.")
            }
            catch
            {
                MessageBox.Show("Error al eliminar datos.");
            }
        }
    }
}
