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
        private Form activeForm;
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

                montoTxt.Value = 0;
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

       

        private async void F5Descuentos_Load(object sender, EventArgs e)
        {
            await CargarDescuentos();
            await CargarEmpleados();
            await CargarDescuentosTipo();
            await CargarDescuentos();
            
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



        private  async void OpenChildForm(Form ChildForm)
        {
            try
            {
                // Verificar si el nuevo formulario ya está abierto
                if (activeForm != null && activeForm.GetType() == ChildForm.GetType() && !activeForm.IsDisposed)
                {
                    activeForm.BringToFront();
                    return;
                }

                // Cerrar el formulario activo si existe y no es el formulario principal
                if (activeForm != null && activeForm != this && !activeForm.IsDisposed)
                {
                    activeForm.Close();
                    // Esperar un poco para que se cierre correctamente
                    await Task.Delay(100);
                }

                // Configurar el nuevo formulario
                activeForm = ChildForm;
                ChildForm.TopLevel = false;
                ChildForm.FormBorderStyle = FormBorderStyle.None;
                ChildForm.Dock = DockStyle.Fill;

                // Limpiar controles existentes
                panelAuxiliar.Controls.Clear();

                panelAuxiliar.Controls.Add(ChildForm);
                panelAuxiliar.Tag = ChildForm;



                // Mostrar el formulario
                ChildForm.BringToFront();

                // Pequeña animación opcional
                ChildForm.Opacity = 0;
                ChildForm.Show();

                for (int i = 0; i < 10; i++)
                {
                    await Task.Delay(20);
                    ChildForm.Opacity += 0.1;
                }
                ChildForm.Opacity = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnInacistencias_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F9Inasistencias());
        }






    }
}
