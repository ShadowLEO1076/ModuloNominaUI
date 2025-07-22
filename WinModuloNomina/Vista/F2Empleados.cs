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
    public partial class F2Empleados : Form
    {
        private readonly APIModuloNomina _api;
        private string _apiUrl;
        public F2Empleados()
        {
            _apiUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
            _api = new APIModuloNomina(_apiUrl);
            this.Load += F2Empleados_Load;
            InitializeComponent();
        }
        public async Task CargarEmpleados()
        {
            try
            {
                var empleados = await _api.GetAsync<List<Empleados>>("EmpleadosControlador/ObtenerTodosAsync");
                empleadosDgv.DataSource = empleados;
                empleadosDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos : {ex.Message}");
            }
        }

        public async Task CargarPuesto()
        {
            try
            {
                var puestos = await _api.GetAsync<List<Puestos>>("PuestoControlador/ListarPuestos");
                puestosCb.DataSource = puestos;
                puestosCb.DisplayMember = "Nombre";
                puestosCb.ValueMember = "IdPuesto";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar puestos : {ex.Message}");
            }

        }
        private async void F2Empleados_Load(object sender, EventArgs e)
        {
            await CargarEmpleados();
            await CargarPuesto();
        }

        private async void crearBtn_Click(object sender, EventArgs e)
        {

            var empleado = new Empleados();
            if
            (string.IsNullOrWhiteSpace(nombresTxt.Text) || string.IsNullOrWhiteSpace(apellidosTxt.Text) || string.IsNullOrEmpty(cedulaTxt.Text)
            || string.IsNullOrWhiteSpace(correoTxt.Text) || string.IsNullOrWhiteSpace(generoTxt.Text) || string.IsNullOrWhiteSpace(telfTxt.Text))
            {
                MessageBox.Show("Llenar todos los campos: nombres, apellidos, cédula, correo, teléfono");
                return;
            }

            empleado = new Empleados
            {
                Nombres = nombresTxt.Text,
                Apellidos = apellidosTxt.Text,
                Cedula = cedulaTxt.Text,
                Correo = correoTxt.Text,
                FechaIngreso = DateOnly.FromDateTime(fecIngresoDtp.Value),
                Genero = generoTxt.Text,
                Telefono = telfTxt.Text,
                FechaNacimiento = DateOnly.FromDateTime(fechaNacDtp.Value),
                FechaCreacion = DateTime.Now.Date,
                PuestoId = int.Parse(puestosCb.SelectedValue.ToString()),
                Estado = estadoCheckbox.Checked,
            };

            await _api.PostAsync<Empleados>("EmpleadoControlador/InsertarEmpleado", empleado);
            await CargarEmpleados();
        }

        private void empleadosDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < empleadosDgv.Rows.Count)
            {
                var empleadoSeleccionado = empleadosDgv.Rows[e.RowIndex].DataBoundItem as Empleados;
                if (empleadoSeleccionado != null)
                {
                    idEmplTxt.Text = empleadoSeleccionado.IdEmpleado.ToString();
                    nombresTxt.Text = empleadoSeleccionado.Nombres;
                    apellidosTxt.Text = empleadoSeleccionado.Apellidos;
                    cedulaTxt.Text = empleadoSeleccionado.Cedula;
                    correoTxt.Text = empleadoSeleccionado.Correo;
                    fecIngresoDtp.Value = empleadoSeleccionado.FechaIngreso.ToDateTime(TimeOnly.MinValue);
                    generoTxt.Text = empleadoSeleccionado.Genero;
                    telfTxt.Text = empleadoSeleccionado.Telefono;
                    fechaNacDtp.Value = empleadoSeleccionado.FechaNacimiento.ToDateTime(TimeOnly.MinValue);
                    puestosCb.SelectedValue = empleadoSeleccionado.PuestoId;
                    estadoCheckbox.Checked = empleadoSeleccionado.Estado;
                }
            }
        }

        private async void editarBtn_Click(object sender, EventArgs e)
        {
            var empleado = new Empleados();
            if (string.IsNullOrWhiteSpace(idEmplTxt.Text))
            {
                MessageBox.Show($"Presione una de las entidades en la lista de abajo para poder modificar el dato. O en su defecto, búsquelo por cédula");
            }

            empleado = new Empleados
            {
                IdEmpleado = int.Parse(idEmplTxt.Text),
                Nombres = nombresTxt.Text,
                Apellidos = apellidosTxt.Text,
                Cedula = cedulaTxt.Text,
                Correo = correoTxt.Text,
                FechaIngreso = DateOnly.FromDateTime(fecIngresoDtp.Value),
                Genero = generoTxt.Text,
                Telefono = telfTxt.Text,
                FechaNacimiento = DateOnly.FromDateTime(fechaNacDtp.Value),
                FechaCreacion = DateTime.Now.Date,
                PuestoId = int.Parse(puestosCb.SelectedValue.ToString()),
                Estado = estadoCheckbox.Checked,
            };

            await _api.PutAsync<Empleados>("EmpleadosControlador/ActualizarAsync", empleado);
            await CargarEmpleados();
        }

        private async void buscarBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                MessageBox.Show($"Favor, ingresar la cédula del empleado que busca en la parte de arriba");
            }


            var queryCedula = txtBuscar.Text;
            var empleadoSeleccionado = await _api.GetAsync<Empleados>($"EmpleadosControlador/ObtenerEmpleadoPorCedula/{queryCedula}");


            idEmplTxt.Text = empleadoSeleccionado.IdEmpleado.ToString();
            nombresTxt.Text = empleadoSeleccionado.Nombres;
            apellidosTxt.Text = empleadoSeleccionado.Apellidos;
            cedulaTxt.Text = empleadoSeleccionado.Cedula;
            correoTxt.Text = empleadoSeleccionado.Correo;
            fecIngresoDtp.Value = empleadoSeleccionado.FechaIngreso.ToDateTime(TimeOnly.MinValue);
            generoTxt.Text = empleadoSeleccionado.Genero;
            telfTxt.Text = empleadoSeleccionado.Telefono;
            fechaNacDtp.Value = empleadoSeleccionado.FechaNacimiento.ToDateTime(TimeOnly.MinValue);
            puestosCb.SelectedValue = empleadoSeleccionado.PuestoId;
            estadoCheckbox.Checked = empleadoSeleccionado.Estado;

        }
    }
}

