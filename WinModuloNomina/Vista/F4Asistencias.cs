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
            //inicia así para que no se pueda actualizar nada
            empleCb.SelectedIndex = -1;
            registroCb.SelectedIndex = 0;
            horaEntraDtp.Enabled = false;
            horaSaliDtp.Enabled = false;
            actualizarBtn.Enabled = false;
            EliminarBtn.Enabled = false;
            horaEntraDtp.Format = DateTimePickerFormat.Time;
            horaSaliDtp.Format = DateTimePickerFormat.Time;
            fecAsisDtp.Value = DateTime.Now;
            horaEntraDtp.Value = DateTime.Now;
            horaSaliDtp.Value = DateTime.Now;
        }
        private async void ingresarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (registroCb.SelectedItem.ToString() == "Asistencia")
                {
                    //verificar que el día ingresado no sea mayor al actual
                    if (DateOnly.FromDateTime(fecAsisDtp.Value) > DateOnly.FromDateTime(DateTime.Now))
                    {
                        MessageBox.Show("La fecha del registro debe ser la de hoy.");
                        return;
                    }
                    //verificar horas
                    if (TimeOnly.FromDateTime(horaSaliDtp.Value) <= TimeOnly.FromDateTime(horaEntraDtp.Value))
                    {
                        MessageBox.Show("La hora de salida de la asistencia no puede ser menor o igual a la hora de entrada.");
                        return;
                    }

                    var veri = new VerificarAsisInasisDTO
                    {
                        idEmpleado = int.Parse(empleCb.SelectedValue.ToString()),
                        fechaVerificacion = DateOnly.FromDateTime(fecAsisDtp.Value),
                    };

                    //se verifica si la entidad que se quiere ingresar no existe con anterioridad
                    var verificacionAsis = await _api.PostAsync<VerificarAsisInasisDTO>("AsistenciasControlador/BuscarPorIdYFechaAsync", veri);

                    if (verificacionAsis != null)
                    {
                        MessageBox.Show("El usuario ingresado ya posee una asistencia este día. No se puede volver a añadir otra.");
                        return;
                    }
                    //verificar si no existe el mismo ingreso en inasistencias
                    var verificacionInasis = await _api.PostAsync<VerificarAsisInasisDTO>("InasistenciasControlador/BuscarPorIdYFechaAsync", veri);
                    if (verificacionInasis != null)
                    {
                        MessageBox.Show("El usuario ingresado ya posee una inasistencia este día. No se puede volver a añadir otra.");
                        return;
                    }

                    var asistencia = new Asistencias
                    {
                        EmpleadoId = int.Parse(empleCb.SelectedValue.ToString()),
                        Fecha = DateOnly.FromDateTime(fecAsisDtp.Value),
                        HoraEntrada = TimeOnly.FromDateTime(horaEntraDtp.Value),
                        HoraSalida = TimeOnly.FromDateTime(horaSaliDtp.Value),
                        Estado = true
                    };

                    await _api.PostAsync<Asistencias>("AsistenciasControlador/AgregarAsync", asistencia);
                }
                else if (registroCb.SelectedItem.ToString() == "Inasistencia")
                {
                    //verificar día
                    if (DateOnly.FromDateTime(fecAsisDtp.Value) > DateOnly.FromDateTime(DateTime.Now))
                    {
                        MessageBox.Show("La fecha del registro debe ser la de hoy.");
                        return;
                    }
                    var veri = new VerificarAsisInasisDTO
                    {
                        idEmpleado = int.Parse(empleCb.SelectedValue.ToString()),
                        fechaVerificacion = DateOnly.FromDateTime(fecAsisDtp.Value),
                    };

                    //se verifica si la entidad que se quiere ingresar no existe con anterioridad
                    var verificacionAsis = await _api.PostAsync<VerificarAsisInasisDTO>("AsistenciasControlador/BuscarPorIdYFechaAsync", veri);

                    if (verificacionAsis != null)
                    {
                        MessageBox.Show("El usuario ingresado ya posee una asistencia este día. No se puede volver a añadir otra.");
                        return;
                    }
                    //verificar si no existe el mismo ingreso en inasistencias
                    var verificacionInasis = await _api.PostAsync<VerificarAsisInasisDTO>("InasistenciasControlador/BuscarPorIdYFechaAsync", veri);
                    if (verificacionInasis != null)
                    {
                        MessageBox.Show("El usuario ingresado ya posee una inasistencia este día. No se puede volver a añadir otra.");
                        return;
                    }

                    var inasistencia = new Inasistencias
                    {
                        EmpleadoId = int.Parse(empleCb.SelectedValue.ToString()),
                        Fecha = DateOnly.FromDateTime(fecAsisDtp.Value),
                        LicenciaId = int.Parse(licenciaCb.SelectedValue.ToString()),
                        DiasContados = 1,
                        Estado = true
                    };

                    await _api.PostAsync<InasistenciasFormDTO>("InasistenciasControlador/AgregarAsync", inasistencia);
                }
            }
            catch
            {
                MessageBox.Show("Error al insertar el registro, verifique que los datos sean correctos");
            }

        }

        private async void asistenciasDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < empleadosDgv.Rows.Count)
                {
                    var asistenciasSeleccionado = empleadosDgv.Rows[e.RowIndex].DataBoundItem as AsistenciasFormDTO;

                    if (asistenciasSeleccionado != null)
                    {
                        idAsisTxt.Text = asistenciasSeleccionado.IdAsistencia.ToString();
                        empleCb.SelectedValue = asistenciasSeleccionado.EmpleadoId;
                        fecAsisDtp.Value = asistenciasSeleccionado.Fecha.ToDateTime(TimeOnly.MinValue);
                        horaEntraDtp.Value = DateTime.Today.Add(asistenciasSeleccionado.HoraEntrada.Value.ToTimeSpan());
                        horaSaliDtp.Value = DateTime.Today.Add(asistenciasSeleccionado.HoraSalida.Value.ToTimeSpan());
                    }

                }

                actualizarBtn.Enabled = true;
                EliminarBtn.Enabled = true;
                ingresarBtn.Enabled = false;
                empleCb.Enabled = false;
                fecAsisDtp.Enabled = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar la asistencia : favor editar los datos.");
            }
        }



        private async void actualizarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //gracias al método de ClickCell solo podemos actualizar datos. Para recuperar otras opciones, debemos usar el
                //botón limpiar datos
                if (registroCb.SelectedItem.ToString() == "Asistencia")
                {
                    //verificar que el día ingresado no sea mayor al actual

                    //verificar horas
                    if (TimeOnly.FromDateTime(horaSaliDtp.Value) <= TimeOnly.FromDateTime(horaEntraDtp.Value))
                    {
                        MessageBox.Show("La hora de salida de la asistencia no puede ser menor o igual a la hora de entrada.");
                        return;
                    }

                    var asistencia = new Asistencias
                    {
                        IdAsistencia = int.Parse(idAsisTxt.Text),
                        EmpleadoId = int.Parse(empleCb.SelectedValue.ToString()),
                        Fecha = DateOnly.FromDateTime(fecAsisDtp.Value),
                        HoraEntrada = TimeOnly.FromDateTime(horaEntraDtp.Value),
                        HoraSalida = TimeOnly.FromDateTime(horaSaliDtp.Value),
                        Estado = true
                    };

                    await _api.PutAsync<Asistencias>("AsistenciasControlador/ActualizarAsync", asistencia);
                }
                else if (registroCb.SelectedItem.ToString() == "Inasistencia")
                {


                    var inasistencia = new Inasistencias
                    {
                        IdInasistencia = int.Parse(idAsisTxt.Text),
                        EmpleadoId = int.Parse(empleCb.SelectedValue.ToString()),
                        Fecha = DateOnly.FromDateTime(fecAsisDtp.Value),
                        LicenciaId = int.Parse(licenciaCb.SelectedValue.ToString()),
                        DiasContados = 1,
                        Estado = true
                    };

                    await _api.PutAsync<Inasistencias>("InasistenciasControlador/ActualizarAsync", inasistencia);

                }
            }
            catch
            {
                MessageBox.Show("Error al actualizar registro, verifique que los datos sean correctos");
            }

        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            LimpiarInfo();
            ingresarBtn.Enabled = true;
            EliminarBtn.Enabled = false;
            actualizarBtn.Enabled = false;
            empleCb.Enabled = true;
            fecAsisDtp.Enabled = true;
        }

        private async void EliminarBtn_Click(object sender, EventArgs e)
        {
            // no se elimina, solo se cambia su estado a false.
            try
            {
                if (registroCb.SelectedItem.ToString() == "Asistencia")
                {
                    //verificar que el día ingresado no sea mayor al actual

                    //verificar horas
                    if (TimeOnly.FromDateTime(horaSaliDtp.Value) <= TimeOnly.FromDateTime(horaEntraDtp.Value))
                    {
                        MessageBox.Show("La hora de salida de la asistencia no puede ser menor o igual a la hora de entrada.");
                        return;
                    }

                    var asistencia = new Asistencias
                    {
                        IdAsistencia = int.Parse(idAsisTxt.Text),
                        EmpleadoId = int.Parse(empleCb.SelectedValue.ToString()),
                        Fecha = DateOnly.FromDateTime(fecAsisDtp.Value),
                        HoraEntrada = TimeOnly.FromDateTime(horaEntraDtp.Value),
                        HoraSalida = TimeOnly.FromDateTime(horaSaliDtp.Value),
                        Estado = false
                    };

                    await _api.PutAsync<Asistencias>("AsistenciasControlador/ActualizarAsync", asistencia);
                }
                else if (registroCb.SelectedItem.ToString() == "Inasistencia")
                {


                    var inasistencia = new Inasistencias
                    {
                        IdInasistencia = int.Parse(idAsisTxt.Text),
                        EmpleadoId = int.Parse(empleCb.SelectedValue.ToString()),
                        Fecha = DateOnly.FromDateTime(fecAsisDtp.Value),
                        LicenciaId = int.Parse(licenciaCb.SelectedValue.ToString()),
                        DiasContados = 1,
                        Estado = false
                    };

                    await _api.PutAsync<Inasistencias>("InasistenciasControlador/ActualizarAsync", inasistencia);
                    await _api.PutAsync<InasistenciasFormDTO>("InasistenciasControlador/ActualizarAsync", inasistencia);
                }
            }
            catch
            {
                MessageBox.Show("Error al eliminar registro, verifique que los datos sean correctos");
            }
        }

        /*private async void EmpleCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (empleCb.SelectedIndex == -1)
                    return;

                if (empleCb.SelectedItem is Empleados emp)
                {
                    string empleCedula = emp.Cedula;

                    var contrato = await _api.GetAsync<Contratos>($"ContratosControlador/ObtenerContratoActivoPorCedulaAsync/{empleCedula}");

                    if (contrato == null)
                    {
                        MessageBox.Show("El empleado no tiene contrato activo.");
                        return;
                    }

                    //double HoraJorDecimales = (double)contrato.HorasJornada;

                    DateTime horaEntrada = DateTime.Now;
                    DateTime horaSalida = horaEntrada.AddHours(HoraJorDecimales);

                    horaEntraDtp.Value = horaEntrada;
                    horaSaliDtp.Value = horaSalida;

                    nombreEmpleadoLbl.Text = $"{emp.Nombres} {emp.Apellidos}";
                }

            }
            catch
            {
                MessageBox.Show("Error al cargar de empleados.");
            }
        }*/


        private async void EmpleCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (empleCb.SelectedIndex == -1)
                    return;

                if (empleCb.SelectedItem is Empleados emp)
                {
                    string empleCedula = emp.Cedula;

                    var contrato = await _api.GetAsync<Contratos>($"ContratosControlador/ObtenerContratoActivoPorCedulaAsync/{empleCedula}");

                    if (contrato == null)
                    {
                        MessageBox.Show("El empleado no tiene contrato activo.");
                        return;
                    }


                    DateTime horaEntrada = DateTime.Now;

                    horaEntraDtp.Value = horaEntrada;

                    empleLb.Text = $"{emp.Nombres} {emp.Apellidos}";
                }

            }
            catch
            {
                MessageBox.Show("Error al cargar de empleados.");
            }
        }

        //código reutilizable --------------------------

     

        public void LimpiarInfo()
        {
            idAsisTxt.Clear();
            empleCb.SelectedIndex = -1;
            licenciaCb.SelectedIndex = -1;
            registroCb.SelectedIndex = -1;

            horaEntraDtp.Value = DateTime.Today;
            horaSaliDtp.Value = DateTime.Today;
            fecAsisDtp.Value = DateTime.Today;
        }

        

        public async Task CargarEmpleados()
        {
            try
            {
                var datos = await _api.GetAsync<List<Empleados>>("EmpleadosControlador/ObtenerTodosActivosAsync");
                empleCb.DataSource = datos;
                empleCb.ValueMember = "IdEmpleado";
                empleCb.DisplayMember = "Cedula";

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

        private void registroCb_SelectedIndexChanged(object sender, EventArgs e)
        {

            var tipo = registroCb.SelectedItem as string;

            if (string.IsNullOrWhiteSpace(tipo)) return;

            if (tipo == "Asistencia")
            {
                horaEntraDtp.Enabled = true;
                horaSaliDtp.Enabled = true;
                licenciaCb.Enabled = false;
            }
            else if (tipo == "Inasistencia")
            {
                horaEntraDtp.Enabled = false;
                horaSaliDtp.Enabled = false;
                licenciaCb.Enabled = true;
            }
        }
    }
}