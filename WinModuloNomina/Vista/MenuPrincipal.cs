using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Microsoft.Windows.Themes;

namespace WinModuloNomina.Vista
{
    public partial class MenuPrincipal : Form
    {
        // Variables de estado
        private bool sliderExpand;
        private IconButton currentButton;
        private Random random;
        private Form activeForm;

        // Colores para el diseño
        private Color menuColor = Color.FromArgb(51, 51, 76);
        private Color buttonDefaultColor = Color.Gainsboro;
        private Color buttonSelectedColor = Color.White;
        private Color buttonHoverColor = Color.FromArgb(224, 224, 224);
        private Color iconDefaultColor = Color.FromArgb(0, 122, 204); // Azul similar al de tu diseño
        private Color iconSelectedColor = Color.White;

        public MenuPrincipal()
        {
            InitializeComponent();
            random = new Random();
            panelMenu.Width = 10;

            // Configuración inicial
            labelTitulo.Text = "HOME S.NOMINA";
            //labelTitulo.ForeColor = iconDefaultColor;

            // Establecer eventos para todos los botones del menú
            foreach (Control control in panelMenu.Controls)
            {
                if (control is IconButton)
                {
                    var btn = (IconButton)control;
                    //btn.MouseEnter += Button_MouseEnter;
                    // btn.MouseLeave += Button_MouseLeave;
                }
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            // Puedes inicializar algún formulario por defecto aquí si lo deseas
        }

        #region Métodos para manejar el menú

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                // Restablecer el botón anterior
                if (currentButton != null)
                {
                    // currentButton.BackColor = menuColor;
                    currentButton.ForeColor = buttonDefaultColor;
                    currentButton.IconColor = buttonDefaultColor;
                    //currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                    //currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                }

                // Establecer el nuevo botón activo
                currentButton = (IconButton)senderBtn;
                //currentButton.BackColor = Color.FromArgb(0, 122, 204); // Azul similar al de tu diseño
                currentButton.ForeColor = buttonSelectedColor;
                currentButton.IconColor = iconSelectedColor;
                //currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                //currentButton.ImageAlign = ContentAlignment.MiddleRight;
            }
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
                panelEscritorio.Controls.Clear();

                panelEscritorio.Controls.Add(childForm);
                panelEscritorio.Tag = childForm;

                // Actualizar el título
                labelTitulo.Text = title;

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

        #endregion

        #region Eventos de los botones

       /* private void btnMenu_Click(object sender, EventArgs e)
        {
            if (sliderExpand)
            {
                panelMenu.Width = 77;
                btnMenu.IconChar = IconChar.Bars;
                sliderExpand = false;
            }
            else
            {
                panelMenu.Width = 220;
                btnMenu.IconChar = IconChar.Times;
                sliderExpand = true;
            }
        }*/


        private void btnPuestos_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new F1Puestos(), "GESTIÓN DE PUESTOS");
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new F2Empleados(), "GESTIÓN DE EMPLEADOS");
        }

        private void btnContratos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new F3Contratos(), "GESTIÓN DE CONTRATOS");
        }

        private void btnAsistencias_Click(object sender, EventArgs e) //cambiar cuando tenga el menú
        {
            ActivateButton(sender);
            OpenChildForm(new F4AsistenciasMenu(), "GESTIÓN DE ASISTENCIAS");
        }

        private void btnBonos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new F5Bonificaciones(), "GESTIÓN DE BONOS");
        }

        private void btnDescuentos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new F5Descuentos(), "GESTIÓN DE DESCUENTOS");
        }

        private void btnNomina_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new F6Nominas(), "GESTIÓN DE NÓMINA");
        }

      

        private void btnVacaciones_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new F8Vacaciones(), "GESTIÓN DE VACACIONES");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {

                activeForm.Close();
                // quiero que al presionar el btncerrar abra el formulario de inicio de secion y cierre el formulario de menuprincipal
                this.Hide();
                new LoginForm().Show();
                // Restablecer el título
                labelTitulo.Text = "HOME S.NOMINA";
                labelTitulo.ForeColor = iconDefaultColor;

                // Restablecer el botón activo
                if (currentButton != null)
                {
                    currentButton.BackColor = menuColor;
                    currentButton.ForeColor = buttonDefaultColor;
                    currentButton.IconColor = buttonDefaultColor;
                    currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                    currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                    currentButton = null;
                }
            }
        }

        #endregion

        #region Efectos visuales para los botones

        /*private void Button_MouseEnter(object sender, EventArgs e)
        {
            var btn = (IconButton)sender;
            if (btn != currentButton)
            {
                btn.BackColor = Color.FromArgb(70, 70, 90);
                btn.ForeColor = buttonHoverColor;
                btn.IconColor = buttonHoverColor;
            }
        }*/

        /*private void Button_MouseLeave(object sender, EventArgs e)
        {
            var btn = (IconButton)sender;
            if (btn != currentButton)
            {
                btn.BackColor = menuColor;
                btn.ForeColor = buttonDefaultColor;
                btn.IconColor = buttonDefaultColor;
            }
        }
        */
        #endregion

        /*private void label2_Click(object sender, EventArgs e)
        {
            if (sliderExpand)
            {
                panelMenu.Width = 77;
                btnMenu.IconChar = IconChar.Bars;
                sliderExpand = false;
            }
            else
            {
                panelMenu.Width = 220;
                btnMenu.IconChar = IconChar.Times;
                sliderExpand = true;
            }
        }*/
    }
}

