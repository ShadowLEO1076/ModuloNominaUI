using Infraestructura.AccesoDatos;
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
    public partial class F5Descuentos : Form
    {
        private readonly APIModuloNomina _api;
        private string _apiUrl;
        public F5Descuentos()
        {
            InitializeComponent();
            _apiUrl = ConfigurationManager.AppSettings["APIBaseUrl"];
            _api = new APIModuloNomina(_apiUrl);
            this.Load += F5Descuentos_Load;
        }

        public async Task CargarDescuentos()
        {
            try
            {
                var descuentos = await _api.GetAsync<List<Descuentos>>("DescuentosControlador/ObtenerTodos");
                dgvDescuentos.DataSource = descuentos;
                dgvDescuentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los descuentos: {ex.Message}");
            }
        }
        private void F5Descuentos_Load(object sender, EventArgs e)
        {
            CargarDescuentos();
        }

        private void dgvDescuentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idEmpleadoTxt.Text = e.RowIndex.ToString();

        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                var entidad = new Descuentos
                {
                    EmpleadoId = int.Parse(idEmpleadoTxt.Text),
                    Descripcion = descripcionTxt.Text,
                    Monto = decimal.Parse(montoTxt.Text),
                    Fecha = DateOnly.FromDateTime(fechaDTP.Value),
                    Tipo = tipoTxt.Text,
                };
                await _api.CrearEntidad<Descuentos>(entidad, "DescuentosControlador/AgregarAsync", "Descuentos");
                await CargarDescuentos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
