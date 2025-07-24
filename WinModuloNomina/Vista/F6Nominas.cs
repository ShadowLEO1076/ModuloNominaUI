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
using WinModuloNomina.Modelo;

namespace WinModuloNomina.Vista
{
    public partial class F6Nominas : Form
    {
        private readonly APIModuloNomina _api;
        private string _apiUrl;
        public F6Nominas()
        {
            _apiUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
            _api = new APIModuloNomina(_apiUrl);
            this.Load += F6Nominas_Load;
            InitializeComponent();
        }

        private async void F6Nominas_Load(object sender, EventArgs e)
        {
            await CargarNominasActivosAsync();
            await CargarEmpleadosIngresoAuto();

            //carga de datos solo para la comboBox del comboBox de año en IngresoAuto y el NumericUpDown

            CargarMesesIngresoAuto();
            LimitarNumUpDownIngresoAuto();
        }

        private void nominasActivasDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void ingAutoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                BusquedaDTO nuevoDato = new BusquedaDTO
                {

                    CedulaEmpleado = empleAutoCb.Text,
                    mes = mesAutoCb.SelectedIndex + 1,
                    anio = int.Parse(anioAutoNumUpDown.Value.ToString())
                };

                await _api.PostAsync<BusquedaDTO>("NominasControlador/InsertarNominaAuto", nuevoDato);
                await CargarNominasActivosAsync();
            }
            catch
            {
                MessageBox.Show("Error al ingresar nómina automáticamente.");
            }
        }

        //codigo que no tiene que ver con la forma

        public void LimitarNumUpDownIngresoAuto()
        {
            anioAutoNumUpDown.Minimum = 2000;
            anioAutoNumUpDown.Maximum = DateTime.Now.Year;
            anioAutoNumUpDown.Value = DateTime.Now.Year;
        }

        public void CargarMesesIngresoAuto()
        {
            mesAutoCb.DataSource = System.Globalization.CultureInfo.CurrentCulture
                  .DateTimeFormat.MonthNames.Where(m => !string.IsNullOrEmpty(m)).ToList();
        }
        public async Task CargarNominasActivosAsync()
        {
            try
            {
                var datos = await _api.GetAsync<List<NominasDTO>>("NominasControlador/ObtenerTodosActivosAsync");
                nominasActivasDgv.DataSource = datos;
                nominasActivasDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show($"Error al cargar nóminas.");
            }
        }

        public async Task CargarEmpleadosIngresoAuto()
        {
            try
            {
                var datos = await _api.GetAsync<List<Empleados>>("EmpleadosControlador/ObtenerTodosActivosAsync");
                empleAutoCb.DataSource = datos;
                empleAutoCb.ValueMember = "Cedula";
                empleAutoCb.DisplayMember = "Cedula";
            }
            catch
            {
                MessageBox.Show($"Error al cargar empleados.");
            }
        }

        // a cambiar cuando toque el ingreso automático
        public async Task CargarEmpleadosIngresoManual()
        {
            try 
            {
                var datos = await _api.GetAsync<List<Empleados>>("EmpleadosControlador/ObtenerTodosActivosAsync");
                empleAutoCb.DataSource = datos;
                empleAutoCb.ValueMember = "IdEmpleado";
                empleAutoCb.DisplayMember = "Cedula";
            }
            catch 
            {
                MessageBox.Show($"Error al cargar empleados.");
            }
        } 
       
    }
}
