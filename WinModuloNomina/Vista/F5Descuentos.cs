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

        public async Task CargarEmpleados()
        {
            try
            {

                var empleado = await _api.GetAsync<List<Empleados>>("EmpleadoControlador/ListarEmpleados");
                var listaNombre = empleado
                    .Select(e => new
                    {
                        NombreCompleto = $"{e.Nombres} {e.Apellidos}",
                        Valor = e.IdEmpleado
                    })
                    .ToList();
                idEmpleadoCb.DataSource = listaNombre;
                idEmpleadoCb.DisplayMember = "NombreCompleto";
                idEmpleadoCb.ValueMember = "IdEmpleado";

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al cargar los empleados: {ex.Message}");

            }
        }
        private async Task CargarDescuentosTipo()
        {
            tipoTxt.Items.Clear();
            tipoTxt.Items.Add("Anticipo");
            tipoTxt.Items.Add("Inasistencias");
            tipoTxt.Items.Add("Falla Operativa");
            await Task.CompletedTask;

        }
       
       
        private async void tipoTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = tipoTxt.SelectedItem?.ToString();

            if (seleccion == "Anticipo")
            {
                montoTxt.Value = 0;
                montoTxt.Enabled = true;
            }
            else if (seleccion == "Inasistencias")
            {
            
                montoTxt.Value = 0 ;
                montoTxt.Enabled = false;
            }
            else if (seleccion == "Falla Operativa")
            {
                montoTxt.Value = 0;
                montoTxt.Enabled = true;
            }

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
        public async Task CargarInasistencias()
        {
            try
            {
                var inacistencia = await _api.GetAsync<List<Inasistencias>>("InasistenciasControlador/ObtenerTodosAsync");
                dgvInasistencias.DataSource = inacistencia;
                dgvInasistencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los descuentos: {ex.Message}");
            }
        }

        private async void F5Descuentos_Load(object sender, EventArgs e)
        {
            await CargarDescuentos();
            await CargarEmpleados();
            await CargarDescuentosTipo();
            await CargarInasistencias();
        }

        private void dgvDescuentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                var entidad = new Descuentos
                {//EmpleadoId = int.Parse(idEmpleadoCb.SelectedValue.ToString()),
                    Descripcion = descripcionTxt.Text,
                    Monto = decimal.Parse(montoTxt.Text),
                    Fecha = DateOnly.FromDateTime(fechaDTP.Value),
                    Tipo = tipoTxt.Text,
                };
                await _api.PostAsync<Descuentos>("DescuentosControlador/AgregarAsync", entidad);
                await CargarDescuentos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDescuentos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
