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
            await CargarInasistencias();
            //inicia así para que no se pueda actualizar nada
            actualizarBtn.Enabled = false;
            EliminarBtn.Enabled = false;
            horaEntraDtp.Format = DateTimePickerFormat.Time;
            horaSaliDtp.Format = DateTimePickerFormat.Time;
            fecAsisDtp.Value = DateTime.Now;
        }
        private async void ingresarBtn_Click(object sender, EventArgs e)
        {
            try
            {
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
                var verificacion = await _api.PostAsync<VerificarAsisInasisDTO>("AsistenciasControlador/BuscarPorIdYFechaAsync", veri);

                if (verificacion != null)
                {
                    MessageBox.Show("El usuario ingresado ya posee una asistencia este día. No se puede volver a añadir otra.");
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
                await CargarAsistencias();
            }
            catch
            {
                MessageBox.Show("Error al insertar asistencia, verifique que los datos sean correctos");
            }

        }

        private async void asistenciasDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < asistenciasDgv.Rows.Count)
                {
                    var asistenciasSeleccionado = asistenciasDgv.Rows[e.RowIndex].DataBoundItem as AsistenciasFormDTO;

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

                await CargarAsistencias();

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
                await CargarAsistencias();
            }
            catch
            {
                MessageBox.Show("Error al insertar asistencia, verifique que los datos sean correctos");
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

        //código reutilizable
        public void LimpiarInfo()
        {
            idAsisTxt.Clear();
            empleCb.SelectedIndex = -1;

            // Restaurar fechas a valores por defecto
            fecAsisDtp.Value = DateTime.Today;
        }

        public async Task CargarInasistencias()
        {
            try
            {
                var busq = await _api.GetAsync<List<InasistenciasFormDTO>>("InasistenciasControlador/ObtenerTodasActivasInasistenciasFormDTO");

                inasisDgv.DataSource = busq;
                inasisDgv.Columns["Remunerable"].ReadOnly = true;
                //esto obliga a que se generen las columnas. ME SALVÓ
                asistenciasDgv.AutoGenerateColumns = true;
                asistenciasDgv.AutoResizeColumns();
                inasisDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Error al cargar las asistencias");
            }
        }

        public async Task CargarAsistencias()
        {
            try
            {
                var busq = await _api.GetAsync<List<AsistenciasFormDTO>>("AsistenciasControlador/ObtenerTodasActivasAsistenciasFormDTO");

                asistenciasDgv.DataSource = busq;
                asistenciasDgv.AutoResizeColumns();
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

        private async void EliminarBtn_Click(object sender, EventArgs e)
        {
            // no se elimina, solo se cambia su estado a false.
            try
            {
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
                await CargarAsistencias();
            }
            catch
            {
                MessageBox.Show("Error al insertar asistencia, verifique que los datos sean correctos");
            }
        }

      
    }
}
