using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinModuloNomina.Vista
{
    public partial class F4AsistenciasMenu : Form
    {
        //variable que hace que esta form sea activa
        private Form activeForm;
        public F4AsistenciasMenu()
        {
            InitializeComponent();

            //permite definir los elementos dentro de un panel como elementos interactuables
            foreach (Control control in panelControl.Controls)
            {
                if (control is IconButton)
                {
                    var btn = (IconButton)control;

                }
            }
        }

        private void asistenciasFormBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F4Asistencias(), "Ingresa registro de asistencias");
        }

        private void historialBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F4AsistenciasHistorial(), "Historial de registros");
        }

        private void historialInasBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F4AsistenciasInasHistorial(), "Historial de registros inasistencias");
        }

        //necesario para tener childForms
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

                panelVentanas.Controls.Clear();

                panelVentanas.Controls.Add(childForm);
                panelVentanas.Tag = childForm;

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
      }
}
