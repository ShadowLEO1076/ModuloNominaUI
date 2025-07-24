using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicacion.DTO.DTOs;
using WinModuloNomina.Modelo;
using WinModuloNomina.Modelo.DTOS;

namespace WinModuloNomina.Vista
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Ingrese cédula y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Mostrar indicador de carga
                btnIngresar.Enabled = false;
                Cursor.Current = Cursors.WaitCursor;

                var loginDto = new LoginDTO
                {
                    Cedula = txtCedula.Text.Trim(),
                    Contraseña = txtContraseña.Text.Trim()
                };

                // Configuración del HttpClient (simplificada)
                using HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7164/");
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.PostAsJsonAsync("api/UsuariosControlador/login", loginDto);

                if (response.IsSuccessStatusCode)
                {
                    var usuario = await response.Content.ReadFromJsonAsync<UsuarioDTO>();

                    // GUARDAR DATOS EN SESIÓN (lo que necesitas)
                    UsuarioSesion.Cedula = usuario.Cedula;
                    UsuarioSesion.Rol = usuario.Rol;
                    

                    // Mostrar menú principal
                    new MenuPrincipal().Show();
                    this.Hide();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error en autenticación: {response.ReasonPhrase}\n{errorContent}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error de conexión: {ex.Message}", "Error de red",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Restaurar controles
                btnIngresar.Enabled = true;
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación
            Application.Exit();

        }
    }
}