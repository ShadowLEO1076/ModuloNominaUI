using Aplicacion.DTO.DTOs;
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
    public partial class F4Asistencias : Form
    {
        private readonly APIModuloNomina _api;
        private string _apiUrl;
        public F4Asistencias()
        {
            //esto permite conseguir el url en app.settigns
            _apiUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
            //instancia de api. Con ello somos capaces de hacer las transacciones
            _api = new APIModuloNomina(_apiUrl);
            this.Load += F4Asistencias_Load;
            InitializeComponent();
        }

        private async void F4Asistencias_Load(object sender, EventArgs e)
        {
            await CargarAsistencias();
            await CargarEmpleados();
            //inicia así para que no se pueda actualizar nada
            actualizarBtn.Enabled = false;
        }

        public async Task CargarAsistencias()
        {
            try
            {
                var busq = await _api.GetAsync<List<AsistenciasFormDTO>>("AsistenciasControlador/ObtenerTodasActivasAsistenciasFormDTO");

                asistenciasDgv.DataSource = busq;
                asistenciasDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Error al cargar las asistencias");
            }
        }

        public async Task CargarEmpleados()
        {
            try
            {
                var datos = await _api.GetAsync<List<Empleados>>("EmpleadosControlador/ObtenerTodosActivosAsync");
                empleCb.DataSource = datos;
                empleCb.ValueMember = "IdEmpleado";
                empleCb.DisplayMember = "Cedula";
            }
            catch
            {
                MessageBox.Show($"Error al cargar empleados.");
            }
        }

        private async void ingresarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //añadir verificación de asistencia e inasistencia: solopuede haaber una por empleado en un día dado
                //y en una tabla.
                var asistencia = new Asistencias
                {
                    EmpleadoId = int.Parse(empleCb.SelectedValue.ToString()),
                    Fecha = DateOnly.FromDateTime(fecAsisDtp.Value),
                    HoraEntrada = TimeOnly.FromDateTime(horaEntraDtp.Value),
                    HoraSalida = TimeOnly.FromDateTime(horaSaliDtp.Value)
                };

                

                await _api.PostAsync<Asistencias>("AsistenciasControlador/AgregarAsync", asistencia);
                await CargarAsistencias();
            }
            catch
            {
                MessageBox.Show("Error al insertar asistencia, verifique que los datos sean correctos");
            }

        }
    }
}
