using Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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


        private async void F2Empleados_Load(object sender, EventArgs e)
        {
            await CargarEmpleados();
            await CargarPuesto();
            CargarGenero();
            //limitacíon de caracteres, los métodos están al final del todo
            this.cedulaTxt.KeyPress += SoloNumeros_KeyPress;
            this.telfTxt.KeyPress += SoloNumeros_KeyPress;
            this.nombresTxt.KeyPress += SoloLetras_KeyPress;
            this.apellidosTxt.KeyPress += SoloLetras_KeyPress;
            //limitación de fechas
            fecIngresoDtp.MaxDate = DateTime.Today;
            fechaNacDtp.MaxDate = DateTime.Today.AddYears(-15);
            //limitaciones en largo de campos a escribir
            nombresTxt.MaxLength = 50;
            apellidosTxt.MaxLength = 50;
            cedulaTxt.MaxLength = 10; // formato Ecuador
            telfTxt.MaxLength = 10; // formato Ecuador
            correoTxt.MaxLength = 100;

        }

        private async void crearBtn_Click(object sender, EventArgs e)
        {
            var empleado = new Empleados();
            
            
            //validación de campos lleno
            if
            (string.IsNullOrWhiteSpace(nombresTxt.Text) || string.IsNullOrWhiteSpace(apellidosTxt.Text) || string.IsNullOrEmpty(cedulaTxt.Text)
            || string.IsNullOrWhiteSpace(correoTxt.Text) || string.IsNullOrWhiteSpace(generoCb.Text) || string.IsNullOrWhiteSpace(telfTxt.Text))
            {
                MessageBox.Show("Llenar todos los campos: nombres, apellidos, cédula, correo, teléfono");
                return;
            }
            //validación de largo de digitos en cedula y telf
            if (cedulaTxt.Text.Length != 10)
            {
                MessageBox.Show("La cédula debe tener exactamente 10 dígitos.");
                return;
            }

            if (telfTxt.Text.Length != 10)
            {
                MessageBox.Show("El teléfono debe tener exactamente 10 dígitos.");
                return;
            }

            // validación de formato de correo
            if (!Regex.IsMatch(correoTxt.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El correo ingresado no tiene un formato válido.");
                return;
            }
            //validación para que la fecha de ingreso no sea menor a la de nacimiento
            if (fecIngresoDtp.Value < fechaNacDtp.Value)
            {
                MessageBox.Show("La fecha de ingreso no puede ser anterior a la fecha de nacimiento.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //validaciones a género y puesto
            if (puestosCb.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un puesto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (generoCb.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un género.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existente = await _api.GetAsync<Empleados>($"EmpleadosControlador/ObtenerEmpleadoPorCedula/{cedulaTxt.Text}");

            if (existente != null)
            {
                MessageBox.Show("Ya existe un empleado con esta cédula.");
                return;
            }

            var confirm = MessageBox.Show("¿Está seguro que desea crear este registro?", "Confirmar edición", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            empleado = new Empleados
            {
                Nombres = nombresTxt.Text,
                Apellidos = apellidosTxt.Text,
                Cedula = cedulaTxt.Text,
                Correo = correoTxt.Text,
                FechaIngreso = DateOnly.FromDateTime(fecIngresoDtp.Value),
                Genero = generoCb.SelectedValue.ToString(),
                Telefono = telfTxt.Text,
                FechaNacimiento = DateOnly.FromDateTime(fechaNacDtp.Value),
                FechaCreacion = DateTime.Now.Date,
                PuestoId = int.Parse(puestosCb.SelectedValue.ToString()),
                Estado = estadoCheckbox.Checked,
            };

            await _api.PostAsync<Empleados>("EmpleadoControlador/InsertarEmpleado", empleado);
            await CargarEmpleados();
        }

        private void empleadosDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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

                        if (_generos.ContainsValue(empleadoSeleccionado.Genero))
                          {
                            generoCb.SelectedValue = empleadoSeleccionado.Genero;
                          }
                        else
                          {
                            generoCb.SelectedIndex = -1;
                          }

                        telfTxt.Text = empleadoSeleccionado.Telefono;
                        fechaNacDtp.Value = empleadoSeleccionado.FechaNacimiento.ToDateTime(TimeOnly.MinValue);
                        puestosCb.SelectedValue = empleadoSeleccionado.PuestoId;
                        estadoCheckbox.Checked = empleadoSeleccionado.Estado;
                    }

                    editarBtn.Enabled = true;
                    crearBtn.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar el empleado: favor editar los datos.");
            }
        }

        private async void editarBtn_Click(object sender, EventArgs e)
        {

            var empleado = new Empleados();

            //validación de campos llenos
            if (string.IsNullOrWhiteSpace(idEmplTxt.Text))
            {
                MessageBox.Show($"Presione una de las entidades en la lista de abajo para poder modificar el dato. O en su defecto, búsquelo por cédula");
            }
            //validación de largo de digitos en cedula y telf
            if (cedulaTxt.Text.Length != 10)
            {
                MessageBox.Show("La cédula debe tener exactamente 10 dígitos.");
                return;
            }

            if (telfTxt.Text.Length != 10)
            {
                MessageBox.Show("El teléfono debe tener exactamente 10 dígitos.");
                return;
            }
            // validación de formato de correo
            if (!Regex.IsMatch(correoTxt.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El correo ingresado no tiene un formato válido.");
                return;
            }
            //validación de que el ingreso no sea menor a la fecha de nacimiento
            if (fecIngresoDtp.Value < fechaNacDtp.Value)
            {
                MessageBox.Show("La fecha de ingreso no puede ser anterior a la fecha de nacimiento.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //validaciones a género y puesto
            if (puestosCb.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un puesto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //validaciones a género y puesto
            if (generoCb.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un género.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //última verificacion
            var confirm = MessageBox.Show("¿Está seguro que desea modificar este registro?", "Confirmar edición", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            empleado = new Empleados
            {
                IdEmpleado = int.Parse(idEmplTxt.Text),
                Nombres = nombresTxt.Text,
                Apellidos = apellidosTxt.Text,
                Cedula = cedulaTxt.Text,
                Correo = correoTxt.Text,
                FechaIngreso = DateOnly.FromDateTime(fecIngresoDtp.Value),
                Genero = generoCb.SelectedValue.ToString(),
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
            else
            {
                var queryCedula = txtBuscar.Text;
                var empleadoSeleccionado = await _api.GetAsync<Empleados>($"EmpleadosControlador/ObtenerEmpleadoPorCedula/{queryCedula}");


                if (empleadoSeleccionado == null)
                {
                    MessageBox.Show("No se encontró un empleado con esa cédula.");
                    return;
                }

                idEmplTxt.Text = empleadoSeleccionado.IdEmpleado.ToString();
                nombresTxt.Text = empleadoSeleccionado.Nombres;
                apellidosTxt.Text = empleadoSeleccionado.Apellidos;
                cedulaTxt.Text = empleadoSeleccionado.Cedula;
                correoTxt.Text = empleadoSeleccionado.Correo;
                fecIngresoDtp.Value = empleadoSeleccionado.FechaIngreso.ToDateTime(TimeOnly.MinValue);
                generoCb.SelectedValue = empleadoSeleccionado.Genero;
                telfTxt.Text = empleadoSeleccionado.Telefono;
                fechaNacDtp.Value = empleadoSeleccionado.FechaNacimiento.ToDateTime(TimeOnly.MinValue);
                puestosCb.SelectedValue = empleadoSeleccionado.PuestoId;
                estadoCheckbox.Checked = empleadoSeleccionado.Estado;
            }
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            LimpiarInfo();
            crearBtn.Enabled = true;
            editarBtn.Enabled = false;
        }

        //CODIGO REUTILIZABLE
        public void LimpiarInfo()
        {
            idEmplTxt.Clear();
            nombresTxt.Clear();
            apellidosTxt.Clear();
            cedulaTxt.Clear();
            correoTxt.Clear();
            telfTxt.Clear();
            generoCb.SelectedIndex = -1; // Si es ComboBox, o .Clear() si es TextBox
            puestosCb.SelectedIndex = -1;
            estadoCheckbox.Checked = false;

            // Restaurar fechas a valores por defecto
            fecIngresoDtp.Value = DateTime.Today;
            fechaNacDtp.Value = DateTime.Today.AddYears(-15); // o cualquier valor por defecto apropiado

            txtBuscar.Clear();
        }

        public DateTime ValidarFecha(DateTime fecha, DateTimePicker control)
        {
            if (fecha < control.MinDate)
                return control.MinDate;
            if (fecha > control.MaxDate)
                return control.MaxDate;
            return fecha;
        }

        private Dictionary<string, string> _generos = new Dictionary<string, string>
        {
          { "Masculino", "M" },
          { "Femenino", "F" },
          { "Otro", "O" }
        };

        public void CargarGenero()
        {


            generoCb.DataSource = new BindingSource(_generos, null);

            generoCb.DisplayMember = "Key";
            generoCb.ValueMember = "Value";
            generoCb.SelectedIndex = -1;
        }
        public async Task CargarEmpleados()
        {
            try
            {
                var empleados = await _api.GetAsync<List<Empleados>>("EmpleadosControlador/ObtenerTodosActivosAsync");
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

        public void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}


