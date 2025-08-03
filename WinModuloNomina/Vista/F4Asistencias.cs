using Aplicacion.DTO.DTOs;
using Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.Contracts;
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
            await CargarEmpleados();
            await CargarLicencias();
            CargarRegistros();
            relojTimer.Start();
            //inicia así para que no se pueda actualizar nada
            empleNomApeCb.SelectedIndex = -1;
            empleCedCb.SelectedIndex = -1;
            registroCb.SelectedIndex = -1;
            //cargar los botones desactivados para obligar a la gente a seleccionar un tipo de asistencia
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            LimpiarInfo();
        }
        private void registroCb_SelectedIndexChanged(object sender, EventArgs e)
        {

            var tipo = registroCb.SelectedItem as string;

            if (string.IsNullOrWhiteSpace(tipo)) return;

            if (tipo == "Asistencia")
            {
                licenciaCb.Enabled = false;
                ingresoAsisBtn.Enabled = true;
                entradaAlmBtn.Enabled = true;
                salidaAlmBtn.Enabled = true;
                inasistenciaBtn.Enabled = false;
            }
            else if (tipo == "Inasistencia")
            {
                licenciaCb.Enabled = true;
                //los botones de inasistencia se desactivan
                ingresoAsisBtn.Enabled = false;
                entradaAlmBtn.Enabled = false;
                salidaAlmBtn.Enabled = false;
                inasistenciaBtn.Enabled = true;
            }
        }

        private void relojTimer_Tick(object sender, EventArgs e)
        {
            relojLb.Text = DateTime.Now.ToString("HH:mm:ss");
            fechaLb.Text = DateTime.Now.ToShortDateString();
        }

        private async void ingresoAsisBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //asegurarse que el tipo de registro en Asistencia
                if (registroCb.SelectedItem?.ToString() == "Asistencia")
                {
                    if (empleCedCb.SelectedIndex == -1)
                    {
                        MessageBox.Show("Seleccione un empleado desde las listas disponibles");
                        return;
                    }

                    //inicio de verificación de datos, vemos si no existe un registro ya ese dia
                    var verificacion = new VerificarAsisInasisDTO
                    {
                        idEmpleado = (int)empleCedCb.SelectedValue,
                        fechaVerificacion = DateOnly.Parse(fechaLb.Text)
                    };

                    var busquedaAsis = await _api.PostAsync<Asistencias>("AsistenciasControlador/BuscarPorIdYFechaAsync", verificacion);
                    var busquedaInasis = await _api.PostAsync<Inasistencias>("InasistenciasControlador/BuscarPorIdYFechaAsync", verificacion);

                    if (busquedaAsis != null || busquedaInasis != null)
                    {
                        MessageBox.Show("Ya existe un registro de este empleado en esta fecha. Registre el resto de datos.");
                        return;
                    }
                    //fin de la verificación, si pasamos, se ingresa el dato.
                    var asistencia = new Asistencias
                    {
                        EmpleadoId = (int)empleCedCb.SelectedValue,
                        Fecha = DateOnly.Parse(fechaLb.Text),
                        HoraEntrada = TimeOnly.Parse(relojLb.Text),
                        HoraSalida = null,
                        Estado = true
                    };


                    var resultado = await _api.PostAsync<Asistencias>("AsistenciasControlador/AgregarAsync", asistencia);
                    if (resultado != null)
                    {
                        MessageBox.Show("Asistencia registrada con éxito.");
                        LimpiarInfo();
                    }
                }
                else
                {
                    MessageBox.Show("Elegir la opción de registro \"Asistencia\"");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Error al ingresar la entrada de asistencia.");
            }
        }
        private async void inasistenciaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //asegurarse que el tipo de registro en Asistencia
                if (registroCb.SelectedItem?.ToString() == "Inasistencia")
                {
                    if (empleCedCb.SelectedIndex == -1)
                    {
                        MessageBox.Show("Seleccione un empleado desde las listas disponibles");
                        return;
                    }

                    //inicio de verificación de datos, vemos si no existe un registro ya ese dia
                    var verificacion = new VerificarAsisInasisDTO
                    {
                        idEmpleado = (int)empleCedCb.SelectedValue,
                        fechaVerificacion = DateOnly.Parse(fechaLb.Text)
                    };

                    var busquedaAsis = await _api.PostAsync<VerificarAsisInasisDTO>("AsistenciasControlador/BuscarPorIdYFechaAsync", verificacion);
                    var busquedaInasis = await _api.PostAsync<VerificarAsisInasisDTO>("InasistenciasControlador/BuscarPorIdYFechaAsync", verificacion);

                    if (busquedaAsis != null || busquedaInasis != null)
                    {
                        MessageBox.Show("Ya existe un registro de este empleado en esta fecha. Registre el resto de datos.");
                        return;
                    }
                    //fin de la verificación, si pasamos, se ingresa el dato.
                    var asistencia = new Inasistencias
                    {
                        EmpleadoId = (int)empleCedCb.SelectedValue,
                        Fecha = DateOnly.Parse(fechaLb.Text),
                        LicenciaId = (int)licenciaCb.SelectedValue,
                        Estado = true
                    };


                    var resultado = await _api.PostAsync<Inasistencias>("InasistenciasControlador/AgregarAsync", asistencia);
                    if (resultado != null)
                    {
                        MessageBox.Show("Inasistencia registrada con éxito.");
                        LimpiarInfo();
                    }
                }
                else
                {
                    MessageBox.Show("Elegir la opción de registro \"Asistencia\"");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Error al ingresar la entrada de asistencia.");
            }
        }

        private async void salidaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //asegurarse que el tipo de registro en Asistencia
                if (registroCb.SelectedItem?.ToString() == "Asistencia")
                {
                    if (empleCedCb.SelectedIndex == -1)
                    {
                        MessageBox.Show("Seleccione un empleado desde las listas disponibles");
                        return;
                    }

                    //inicio de verificación de datos, vemos si no existe un registro ya ese dia
                    var verificacion = new VerificarAsisInasisDTO
                    {
                        idEmpleado = (int)empleCedCb.SelectedValue,
                        fechaVerificacion = DateOnly.Parse(fechaLb.Text)
                    };

                    var busquedaAsis = await _api.PostAsync<Asistencias>("AsistenciasControlador/BuscarPorIdYFechaAsync", verificacion);

                    if (busquedaAsis == null)
                    {
                        MessageBox.Show("No se halló un registro en de entrada, por tanto no se puede registrar la salida.");
                        return;
                    }

                    busquedaAsis.HoraSalida = TimeOnly.Parse(relojLb.Text);
                    //fin de la verificación, si pasamos, se ingresa el dato.


                    var resultado = await _api.PutAsync<Asistencias>("AsistenciasControlador/ActualizarAsync", busquedaAsis);
                    if (resultado != null)
                    {
                        MessageBox.Show("Se registro su salida con éxito.");
                        LimpiarInfo();
                    }
                }
                else
                {
                    MessageBox.Show("Elegir la opción de registro \"Asistencia\"");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Error al ingresar la entrada de asistencia.");
            }
        }

        private async void entradaAlmBtn_Click(object sender, EventArgs e)
        {

            try
            {
                //asegurarse que el tipo de registro en Asistencia
                if (registroCb.SelectedItem?.ToString() == "Asistencia")
                {
                    if (empleCedCb.SelectedIndex == -1)
                    {
                        MessageBox.Show("Seleccione un empleado desde las listas disponibles");
                        return;
                    }

                    //inicio de verificación de datos, vemos si no existe un registro ya ese dia
                    var verificacion = new VerificarAsisInasisDTO
                    {
                        idEmpleado = (int)empleCedCb.SelectedValue,
                        fechaVerificacion = DateOnly.Parse(fechaLb.Text)
                    };

                    var busquedaAsis = await _api.PostAsync<Asistencias>("AsistenciasControlador/BuscarPorIdYFechaAsync", verificacion);

                    if (busquedaAsis == null)
                    {
                        MessageBox.Show("No se halló un registro en de entrada, por tanto no se puede registrar la entrada de la hora de almuerzo.");
                        return;
                    }

                    busquedaAsis.HoraInicioAlmuerzo = TimeOnly.Parse(relojLb.Text);
                    //fin de la verificación, si pasamos, se ingresa el dato.


                    var resultado = await _api.PutAsync<Asistencias>("AsistenciasControlador/ActualizarAsync", busquedaAsis);
                    if (resultado != null)
                    {
                        MessageBox.Show("Se registro su entrada al almuerzo con éxito.");
                        LimpiarInfo();
                    }
                }
                else
                {
                    MessageBox.Show("Elegir la opción de registro \"Asistencia\"");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Error al ingresar la entrada de asistencia.");
            }
        }

        private async void salidaAlmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //asegurarse que el tipo de registro en Asistencia
                if (registroCb.SelectedItem?.ToString() == "Asistencia")
                {
                    if (empleCedCb.SelectedIndex == -1)
                    {
                        MessageBox.Show("Seleccione un empleado desde las listas disponibles");
                        return;
                    }

                    //inicio de verificación de datos, vemos si no existe un registro ya ese dia
                    var verificacion = new VerificarAsisInasisDTO
                    {
                        idEmpleado = (int)empleCedCb.SelectedValue,
                        fechaVerificacion = DateOnly.Parse(fechaLb.Text)
                    };

                    var busquedaAsis = await _api.PostAsync<Asistencias>("AsistenciasControlador/BuscarPorIdYFechaAsync", verificacion);

                    if (busquedaAsis == null)
                    {
                        MessageBox.Show("No se halló un registro en de entrada, por tanto no se puede registrar la entrada de la hora de almuerzo.");
                        return;
                    }

                    busquedaAsis.HoaFinAlmuerzo = TimeOnly.Parse(relojLb.Text);
                    //fin de la verificación, si pasamos, se ingresa el dato.


                    var resultado = await _api.PutAsync<Asistencias>("AsistenciasControlador/ActualizarAsync", busquedaAsis);
                    if (resultado != null)
                    {
                        MessageBox.Show("Se registro su salida del almuerzo con éxito.");
                        LimpiarInfo();
                    }
                }
                else
                {
                    MessageBox.Show("Elegir la opción de registro \"Asistencia\"");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Error al ingresar la entrada de asistencia.");
            }
        }

        //código reutilizable --------------------------

        private void empleCedCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empleCedCb.SelectedIndex != -1 && empleCedCb.SelectedValue is int id)
            {
                idEmplLb.Text = id.ToString();
            }
            else
            {
                idEmplLb.Text = string.Empty;
            }
        }

        public void LimpiarInfo()
        {
            idAsisTxt.Clear();
            empleCedCb.SelectedIndex = -1;
            licenciaCb.SelectedIndex = -1;
            registroCb.SelectedIndex = -1;
            empleNomApeCb.SelectedIndex = -1;
        }



        public async Task CargarEmpleados()
        {
            try
            {
                var datos = await _api.GetAsync<List<Empleados>>("EmpleadosControlador/ObtenerTodosActivosAsync");
                empleCedCb.DataSource = datos;
                empleCedCb.ValueMember = "IdEmpleado";
                empleCedCb.DisplayMember = "Cedula";


                empleNomApeCb.DataSource = datos;
                empleNomApeCb.ValueMember = "IdEmpleado";
                empleNomApeCb.DisplayMember = "NombreCompleto";

                empleadosDgv.DataSource = datos;
                empleadosDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show($"Error al cargar empleados.");
            }
        }


        public async Task CargarLicencias()
        {
            try
            {
                var datos = await _api.GetAsync<List<LicenciasDTO>>("LicenciaControlador/ObtenerTodosAsync");
                licenciaCb.DataSource = datos;
                licenciaCb.ValueMember = "IdLicencia";
                licenciaCb.DisplayMember = "Nombre";
            }
            catch
            {
                MessageBox.Show($"Error al cargar Licencias");
            }
        }

        private List<String> TiposRegistros = new List<string>
        { "Asistencia",
          "Inasistencia"
        };

        public void CargarRegistros()
        {
            registroCb.DataSource = TiposRegistros;
        }
    }  
}