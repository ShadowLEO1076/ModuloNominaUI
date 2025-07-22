using System;
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
                var loginDto = new LoginDTO
                {
                    Cedula = txtCedula.Text.Trim(),
                    Contraseña = txtContraseña.Text.Trim()
                };

                // Configuración especial para desarrollo
                var handler = new HttpClientHandler
                {
                    ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
                };

                using HttpClient client = new HttpClient(handler);
                client.BaseAddress = new Uri("https://localhost:7164/");
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                // Debug: Ver request
                var jsonContent = new StringContent(
                    System.Text.Json.JsonSerializer.Serialize(loginDto),
                    Encoding.UTF8,
                    "application/json");

                Console.WriteLine($"Request: {await jsonContent.ReadAsStringAsync()}");

                var response = await client.PostAsync("api/UsuariosControlador/login", jsonContent);

                // Debug: Ver respuesta en crudo
                string rawResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Raw response: {rawResponse}");

                if (response.IsSuccessStatusCode)
                {
                    try
                    {
                        var usuario = await response.Content.ReadFromJsonAsync<UsuarioDTO>();
                        MessageBox.Show($"Bienvenido, {usuario.NombreCompleto}", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new MenuPrincipal().Show();
                        this.Hide();
                    }
                    catch (JsonException)
                    {
                        MessageBox.Show($"La API devolvió formato inválido:\n{rawResponse}",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"Error HTTP {(int)response.StatusCode}: {response.ReasonPhrase}\n{rawResponse}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado:\n{ex.Message}\n\nStack Trace:\n{ex.StackTrace}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
