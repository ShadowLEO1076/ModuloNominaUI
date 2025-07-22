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
using FontAwesome.Sharp;
using Infraestructura.AccesoDatos;
using WinModuloNomina.Controlador;


namespace WinModuloNomina.Vista
{
    public partial class F1Puestos : Form
    {
        private readonly APIModuloNomina _apimodulonomina;
        private string ApiUrl;
        public F1Puestos()
        {
            InitializeComponent();
            
            ApiUrl = ConfigurationManager.AppSettings["APIBaseUrl"]; // Obtiene la URL de la API desde el archivo de configuración
            _apimodulonomina = new APIModuloNomina(ApiUrl); // Inicializa la instancia de APINomina con la URL de la API
            this.Load += F1Puestos_Load; // Asocia el even
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            dgvPuestos.CellClick += dgvPuestos_CellClick;




        }
        public async Task CargarPuestos()
        {
            try
            {
                // Aquí puedes llamar al método de la API para obtener los empleados
                var puestos = await _apimodulonomina.GetAsync<List<Puestos>>("PuestoControlador/ListarPuestos");
                dgvPuestos.DataSource = puestos;
                dgvPuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los puestos: {ex.Message}");
            }
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtBuscar.Text.ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                _ = CargarPuestos(); // recarga todo si no hay texto
            }
            else
            {
                if (dgvPuestos.DataSource is List<Puestos> listaPuestos)
                {
                    var puestosFiltrados = listaPuestos
                        .Where(p => p.Nombre.ToLower().Contains(searchText) ||
                                    p.SalarioBase.ToString().Contains(searchText))
                        .ToList();

                    dgvPuestos.DataSource = puestosFiltrados;
                }
            }
        }

        // la idea es con post, put y delete poder agregar, editar y eliminar puestos



        private void  F1Puestos_Load(object sender, EventArgs e)
        {
            CargarPuestos(); // usa await correctamente

        }

        


        private async void btnCrear_Click(object sender, EventArgs e)
        {
            string nombrePuesto = txtNombrePuesto.Text.Trim();
            string salarioBaseText = txtSalarioPuesto.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombrePuesto) || string.IsNullOrWhiteSpace(salarioBaseText))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!decimal.TryParse(salarioBaseText, out decimal salarioBase))
            {
                MessageBox.Show("El salario base debe ser un número válido.");
                return;
            }

            var nuevoPuesto = new Puestos
            {
                Nombre = nombrePuesto,
                SalarioBase = salarioBase
            };

            try
            {
                var resultado = await _apimodulonomina.PostAsync<Puestos>("PuestoControlador/InsertarPuesto", nuevoPuesto);
                MessageBox.Show("Puesto creado exitosamente.");
                await CargarPuestos(); // Recarga los datos usando await
                txtNombrePuesto.Clear();
                txtSalarioPuesto.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el puesto: {ex.Message}");
            }
        }


        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdPuesto.Text))
            {
                MessageBox.Show("Por favor, seleccione un puesto para editar.");
                return;
            }

            string nombrePuesto = txtNombrePuesto.Text.Trim();
            string salarioBaseText = txtSalarioPuesto.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombrePuesto) || string.IsNullOrWhiteSpace(salarioBaseText))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!decimal.TryParse(salarioBaseText, out decimal salarioBase))
            {
                MessageBox.Show("El salario base debe ser un número válido.");
                return;
            }

            var puestoEditado = new Puestos
            {
                IdPuesto = int.Parse(txtIdPuesto.Text),
                Nombre = nombrePuesto,
                SalarioBase = salarioBase
            };

            try
            {
                var resultado = await _apimodulonomina.PutAsync<Puestos>($"PuestoControlador/ActualizarPuesto/{puestoEditado.IdPuesto}", puestoEditado);
                MessageBox.Show("Puesto editado exitosamente.");
                await CargarPuestos(); // ahora sí espera a que termine de recargar
                txtNombrePuesto.Clear();
                txtSalarioPuesto.Clear();
                txtIdPuesto.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar el puesto: {ex.Message}");
            }
        }


        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdPuesto.Text))
            {
                MessageBox.Show("Por favor, selecciona un puesto para eliminar.");
                return;
            }

            int idPuesto;
            if (!int.TryParse(txtIdPuesto.Text, out idPuesto))
            {
                MessageBox.Show("ID del puesto no es válido.");
                return;
            }

            // Confirmación opcional para no eliminar por accidente
            var confirmResult = MessageBox.Show("¿Estás seguro de eliminar este puesto?", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes)
                return;

            try
            {
                bool eliminado = await _apimodulonomina.DeleteAsync($"PuestoControlador/EliminarPuesto/{idPuesto}");
                MessageBox.Show("Puesto eliminado exitosamente.");
                await CargarPuestos();  // Recarga la tabla con los datos actualizados
                txtIdPuesto.Clear();
                txtNombrePuesto.Clear();
                txtSalarioPuesto.Clear();




            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el puesto esta asosiado a un empleado: {ex.Message}");
            }
        }


        private void dgvPuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            

        }
        private void dgvPuestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvPuestos.Rows.Count)
            {
                var puestoSeleccionado = dgvPuestos.Rows[e.RowIndex].DataBoundItem as Puestos;
                if (puestoSeleccionado != null)
                {
                    txtNombrePuesto.Text = puestoSeleccionado.Nombre;
                    txtSalarioPuesto.Text = puestoSeleccionado.SalarioBase.ToString();
                    txtIdPuesto.Text = puestoSeleccionado.IdPuesto.ToString();
                }
            }
        }

    }
}
