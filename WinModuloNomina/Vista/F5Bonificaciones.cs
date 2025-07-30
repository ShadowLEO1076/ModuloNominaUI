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
using System.Windows.Media.Animation;
using WinModuloNomina.Controlador;

namespace WinModuloNomina.Vista
{
    public partial class F5Bonificaciones : Form
    {
        private readonly APIModuloNomina _api;
        private string _apiUrl;

        public F5Bonificaciones()
        {
            _apiUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
            //instancia de api. Con ello somos capaces de hacer las transacciones
            _api = new APIModuloNomina(_apiUrl);
            InitializeComponent();
            this.Load += F5Bonificaciones_Load;
        }

        private async void F5Bonificaciones_Load(object sender, EventArgs e)
        {
            await CargarBonificaciones();
            await CargarEmpleados();
            CargarBonosTipos();
            this.montoTxt.KeyPress += SoloNumerosDecimal_KeyPress;

            actualizarBtn.Enabled = false;
            eliminarBtn.Enabled = false;

        }


        private async void insertarBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(tipoCb.Text) || string.IsNullOrWhiteSpace(montoTxt.Text) || string.IsNullOrWhiteSpace(descripcionTxt.Text))
                {
                    MessageBox.Show("Ingresar el tipo de bono, el motivo del bono y la cantidad.");
                    return;
                }

                var confirm = MessageBox.Show("¿Está seguro que desea crear este registro?", "Confirmar edición", MessageBoxButtons.YesNo);
                if (confirm != DialogResult.Yes) return;

                var dato = new Bonificaciones
                {
                    EmpleadoId = int.Parse(empleCb.SelectedValue.ToString()),
                    Tipo = tipoCb.SelectedItem.ToString(),
                    Monto = decimal.Parse(montoTxt.Text),
                    Descripcion = descripcionTxt.Text,
                    Fecha = DateOnly.FromDateTime(fechaIngresoDtp.Value),
                    Estado = true
                };

                await _api.PostAsync<Bonificaciones>("BonificacionesControlador/AgregarAsync", dato);

                await CargarBonificaciones();

            }
            catch
            {
                MessageBox.Show($"No se pueden ingresar los datos.");
            }
        }

        private async void descuentosDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < bonificacionesDgv.Rows.Count)
                {
                    var descuentosSelec = bonificacionesDgv.Rows[e.RowIndex].DataBoundItem as BonificacionesFormDTO;

                    if (descuentosSelec != null)
                    {
                        empleCb.SelectedValue = descuentosSelec.EmpleadoId;
                        idBoniTxt.Text = descuentosSelec.IdBonificaciones.ToString();
                        tipoCb.SelectedItem = descuentosSelec.Tipo;
                        descripcionTxt.Text = descuentosSelec.Descripcion;
                        montoTxt.Text = descuentosSelec.Monto.ToString();
                        fechaIngresoDtp.Value = descuentosSelec.Fecha.ToDateTime(TimeOnly.MinValue);
                    }
                    eliminarBtn.Enabled = true;
                    actualizarBtn.Enabled = true;
                    insertarBtn.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar el empleado: favor editar los datos.");
            }
        }

        private async void actualizarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tipoCb.Text) || string.IsNullOrWhiteSpace(montoTxt.Text) || string.IsNullOrWhiteSpace(descripcionTxt.Text))
                {
                    MessageBox.Show("Ingresar el tipo de bono, el motivo del bono y la cantidad.");
                    return;
                }

                var confirm = MessageBox.Show("¿Está seguro que desea actualizar este registro?", "Confirmar edición", MessageBoxButtons.YesNo);
                if (confirm != DialogResult.Yes) return;

                var dato = new Bonificaciones
                {
                    IdBonificacion = int.Parse(idBoniTxt.Text),
                    EmpleadoId = int.Parse(empleCb.SelectedValue.ToString()),
                    Tipo = tipoCb.SelectedValue.ToString(),
                    Monto = decimal.Parse(montoTxt.Text),
                    Descripcion = descripcionTxt.Text,
                    Fecha = DateOnly.FromDateTime(fechaIngresoDtp.Value),
                    Estado = true
                };

                await _api.PutAsync<Bonificaciones>("BonificacionesControlador/ActualizarAsync", dato);

                await CargarBonificaciones();

            }
            catch
            {
                MessageBox.Show($"No se pueden ingresar los datos.");
            }
        }

        private async void eliminarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tipoCb.Text) || string.IsNullOrWhiteSpace(montoTxt.Text) || string.IsNullOrWhiteSpace(descripcionTxt.Text))
                {
                    MessageBox.Show("Ingresar el tipo de bono, el motivo del bono y la cantidad.");
                    return;
                }

                var confirm = MessageBox.Show("¿Está seguro que desea eliminar este registro?", "Confirmar edición", MessageBoxButtons.YesNo);
                if (confirm != DialogResult.Yes) return;

                var dato = new Bonificaciones
                {
                    IdBonificacion = int.Parse(idBoniTxt.Text),
                    EmpleadoId = int.Parse(empleCb.SelectedValue.ToString()),
                    Tipo = tipoCb.SelectedValue.ToString(),
                    Monto = decimal.Parse(montoTxt.Text),
                    Descripcion = descripcionTxt.Text,
                    Fecha = DateOnly.FromDateTime(fechaIngresoDtp.Value),
                    Estado = false
                };

                await _api.PutAsync<Bonificaciones>("BonificacionesControlador/ActualizarAsync", dato);

                await CargarBonificaciones();

            }
            catch
            {
                MessageBox.Show($"No se pueden eliminar los datos.");
            }
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //campos a limpiar
                idBoniTxt.Clear();
                descripcionTxt.Clear();
                montoTxt.Clear();
                tipoCb.SelectedIndex = -1;
                empleCb.SelectedIndex = -1;
                fechaIngresoDtp.Value = DateTime.Today;

                //se reactivan ciertos botones
                insertarBtn.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Error al limpiar datos.");
            }
        }

        public void empleCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empleCb.SelectedIndex == -1) return;

            if (empleCb.SelectedItem is Empleados emple)
            {
                empleLb.Text = $"{emple.Nombres} {emple.Apellidos}";
            }
        }

        //código necesario pero que no es del formulario

        private List<string> bonosTipo = new List<String>
        {
            "Horas Extras",
            "Por Objetivos",
            "Por Productividad",
        };

        public void CargarBonosTipos()
        {
            try
            {
              tipoCb.DataSource = bonosTipo;

              tipoCb.SelectedIndex = -1; // No seleccionado al cargar
            }
            catch
            {
                MessageBox.Show($"No se pueden cargar los tipos bonificaciones.");
            }

        }

        public async Task CargarBonificaciones()
        {
            try
            {
                var datos = await _api.GetAsync<List<BonificacionesFormDTO>>("BonificacionesControlador/ObtenerTodasActivasBonificacionesFormDTO");

                bonificacionesDgv.DataSource = datos;
                bonificacionesDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show($"No se pueden cargar las bonificaciones.");
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

        public void SoloNumerosDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox; //referente que se usa en textbox

            // Permitir teclas de control como borrado y retroceso
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return;
            }

            // Permitir solo uso de comas, pues lños puntos no crean decimales.
            if (e.KeyChar == ',')
            {
                // si ya existe una coma, no poder crear otras
                if (textBox.Text.Contains(","))
                {
                    e.Handled = true;
                    return;
                }
                else
                {
                    e.Handled = false;
                    return;
                }
            }

            // Permitir solo números (0-9)
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Todo OK
            e.Handled = false;
        }
    }
}
