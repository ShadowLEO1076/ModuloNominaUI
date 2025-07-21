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
using FontAwesome.Sharp;
using Infraestructura.AccesoDatos;
using WinModuloNomina.Controlador;


namespace WinModuloNomina.Vista
{
    public partial class F1Puestos : Form
    {
        private readonly APIModuloNomina _apimodulonomina;
        private string ApiUrl;
        public F1Puestos()
        {
            InitializeComponent();
            ApiUrl = ConfigurationManager.AppSettings["APIBaseUrl"]; // Obtiene la URL de la API desde el archivo de configuración
            _apimodulonomina = new APIModuloNomina(ApiUrl); // Inicializa la instancia de APINomina con la URL de la API
            this.Load += F1Puestos_Load; // Asocia el even

        }
        public async Task CargarPuestos()
        {
            try
            {
                // Aquí puedes llamar al método de la API para obtener los empleados
                var puestos = await _apimodulonomina.GetAsync<List<Puestos>>("PuestoControlador/ListarPuestos");
                dgvPuestos.DataSource = puestos;
                dgvPuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los puestos: {ex.Message}");
            }
        }

        private void F1Puestos_Load(object sender, EventArgs e)
        {

            CargarPuestos();
        }

        private void dgvPuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarPuestos();
        }
    }
}
