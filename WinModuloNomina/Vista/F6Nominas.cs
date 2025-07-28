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
            //elementos que no quiero esté disponibles al inicio. Sino solo elegir un dato del datagridview
            actualizarBtn.Enabled = false;
            eliminarBtn.Enabled = false;
            salManTxt.Enabled = false;
            boniManTxt.Enabled = false;
            fecEmiDtp.Enabled = false;
            descManTxt.Enabled = false;
            //el numerico muestra el año actual, sin embargo si puede modififcarse.
            anioNud.Minimum = DateTime.Now.Year;
            anioNud.Value = DateTime.Now.Year;
            anioNud.Maximum = DateTime.Now.Year; 
        }

        private void nominasActivasDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < nominasActivasDgv.Rows.Count)
            {
                var nominaSeleccionada = nominasActivasDgv.Rows[e.RowIndex].DataBoundItem as NominasDTO;

                if (nominaSeleccionada != null)
                {
                    idNomTxt.Text = nominaSeleccionada.IdNomina.ToString();
                    empleAutoCb.SelectedValue = nominaSeleccionada.IdEmpleado;
                    anioNud.Value = nominaSeleccionada.Anio;
                    mesAutoCb.SelectedIndex = nominaSeleccionada.Mes - 1; // necesitamos el -1 para conseguir el dato correcto en el ComboBox
                    salManTxt.Text = nominaSeleccionada.Salario.ToString();
                    fecEmiDtp.Value = nominaSeleccionada.FechaEmision.ToDateTime(TimeOnly.MinValue);
                    boniManTxt.Text = nominaSeleccionada.Bonificaciones.ToString();
                }

                insertarBtn.Enabled = false;
                actualizarBtn.Enabled = true;
                eliminarBtn.Enabled = true;
            }
        }

        private void nominasActivasDgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var col = nominasActivasDgv.Columns["SalarioNeto"];
            if (col != null)
            {
                col.DefaultCellStyle.Format = "N2"; // mostrar solo 2 decimales
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private async void ingAutoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var empleadoSeleccionado = empleAutoCb.SelectedItem as Empleados;

                if (empleadoSeleccionado == null)
                {
                    MessageBox.Show("Debe seleccionar un empleado.");
                    return;
                }

                if(anioNud.Value != DateTime.Now.Year)
                {
                    MessageBox.Show("El año de la nómina debe ser el actual.");
                    return;
                }

                if (mesAutoCb.SelectedIndex != DateTime.Now.Month)
                {
                    MessageBox.Show("El mes de la nómina debe ser el actual.");
                    return;
                }

                BusquedaDTO nuevoDato = new BusquedaDTO
                {
                    CedulaEmpleado = empleadoSeleccionado.Cedula,
                    anio = int.Parse(anioNud.Value.ToString()),
                    mes = mesAutoCb.SelectedIndex + 1

                };

                var verificacion = await _api.PostAsync<NominasDTO>("NominasControlador/ObtenerNominaPorEmpleadoMesAnioAsync", nuevoDato);

                if (verificacion != null)
                {
                    MessageBox.Show("Ya existe una nómina a nombre del empleado en la fecha establecida, en caso de necesitar hacer algo, editarla manualmente.");
                    return;
                }

                await _api.PostAsync<BusquedaDTO>("NominasControlador/InsertarNominaAuto", nuevoDato);
                await CargarNominasActivosAsync();
            }
            catch
            {
                MessageBox.Show("Error al ingresar nómina automáticamente.");
            }
        }

        //codigo que no tiene que ver con la forma

     

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
