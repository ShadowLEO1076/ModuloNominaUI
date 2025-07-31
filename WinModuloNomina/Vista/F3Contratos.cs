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
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using WinModuloNomina.Controlador;
using WinModuloNomina.Modelo.DTOS;

namespace WinModuloNomina.Vista
{
    public partial class F3Contratos : Form
    {
        private bool sliderExpand;
        private IconButton currentButton;
        private Form activeForm;
        private readonly APIModuloNomina _apimodulonomina;
        private List<ContratosDTO> _contratosOriginales = new List<ContratosDTO>();

        public F3Contratos()
        {
            InitializeComponent();
            //random = new Random();
            panel38.Width = 181;

            // Configuración inicial
            //labelcambiante.Text = "Mesa de trabajo Contratos";
            //labelTitulo.ForeColor = iconDefaultColor;

            // Establecer eventos para todos los botones del menú
            foreach (Control control in panel38.Controls)
            {
                if (control is IconButton)
                {
                    var btn = (IconButton)control;
                    //btn.MouseEnter += Button_MouseEnter;
                    // btn.MouseLeave += Button_MouseLeave;
                }
            }



        }
        /*private void txtBuscarContrato_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtBuscarContrato.Text.Trim();

                if (string.IsNullOrWhiteSpace(searchText))
                {
                    bindingSource1.Filter = string.Empty;
                    return;
                }

                // Construir filtro para las columnas relevantes
                var filterParts = new List<string>();
                filterParts.Add($"(CedulaEmpleado LIKE '%{searchText}%')");
                bindingSource1.Filter = string.Join(" OR ", filterParts);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Contrato no  encontrado.");
            }
        }*/
        private void F3Contratos_Load(object sender, EventArgs e)
        {

        }
        private async void OpenChildForm(Form childForm, string title)
        {
            try
            {
                // Verificar si el nuevo formulario ya está abierto
                if (activeForm != null && activeForm.GetType() == childForm.GetType() && !activeForm.IsDisposed)
                {
                    activeForm.BringToFront();
                    return;
                }

                // Cerrar el formulario activo si existe y no es el formulario principal
                if (activeForm != null && activeForm != this && !activeForm.IsDisposed)
                {
                    activeForm.Close();
                    // Esperar un poco para que se cierre correctamente
                    await Task.Delay(100);
                }

                // Configurar el nuevo formulario
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;

                // Limpiar controles existentes
                panelMostrar.Controls.Clear();

                panelMostrar.Controls.Add(childForm);
                panelMostrar.Tag = childForm;

                // Actualizar el título
                //labelcambiante.Text = title;

                // Mostrar el formulario
                childForm.BringToFront();

                // Pequeña animación opcional
                childForm.Opacity = 0;
                childForm.Show();

                for (int i = 0; i < 10; i++)
                {
                    await Task.Delay(20);
                    childForm.Opacity += 0.1;
                }
                childForm.Opacity = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTipos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F12TipoC(), "Crea un tipo de contrato para asignarlo");
        }

        private void btnContratoG_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F11ContratosA(), "Configuracion de contrato utiliza el tipo creado");
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F10Historicos(), "Visualisacion de Historicos");
        }

        private void btnMenusto_Click(object sender, EventArgs e)
        {
            if (sliderExpand)
            {
                panel38.Width = 77;
                //btnMenusto.IconChar = IconChar.Bars;
                sliderExpand = false;
            }
            else
            {
                panel38.Width = 220;
                //btnMenusto.IconChar = IconChar.Times;
                sliderExpand = true;
            }
        }
    }
}


