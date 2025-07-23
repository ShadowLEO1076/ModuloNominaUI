using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicacion.DTO.DTOs;
using Infraestructura.AccesoDatos;
using WinModuloNomina.Controlador;
using WinModuloNomina.Modelo;

namespace WinModuloNomina.Vista
{
    public partial class F8Vacaciones : Form
    {
        private bool isPlaceholderActive = true;
        private bool isEditing = false;
        private readonly APIModuloNomina _apimodulonomina;
        private string ApiUrl;
        public F8Vacaciones()
        {
            InitializeComponent();


            ApiUrl = ConfigurationManager.AppSettings["APIBaseUrl"]; // Obtiene la URL de la API desde el archivo de configuración
            _apimodulonomina = new APIModuloNomina(ApiUrl); // Inicializa la instancia de APINomina con la URL de la API
            this.Load += F8Vacaciones_Load; // Asocia el even
            txtBuscar2.TextChanged += txtBuscar2_TextChanged;
            dgvSolicitudes.CellClick += dgvSolicitudes_CellContentClick;
            txtFInincio.Enter += txtFInincio_Enter;
            txtFInincio.Leave += txtFInincio_Leave;
            txtFInincio.TextChanged += txtFInincio_TextChanged;
        }


        public async Task CargarVacaciones() // quiero usar mi funcion de obtener resumen vacaciones y tambien mi dtosolicitud vacaciones
        {
            try
            {
                // Aquí puedes llamar al método de la API para obtener las solicitudes de vacaciones
                var solicitudes = await _apimodulonomina.GetAsync<List<SolicitudVacaciones>>("SolicitudVacacionesControlador/ListarSolicitudVacaciones");
                var aprovados = await _apimodulonomina.GetAsync<List<EmpleadosVacacionesTotales>>("EmpleadoVacacionesTotalesControlador/resumen-vacaciones");
                var revisiones = await _apimodulonomina.GetAsync<List<AprobacionVacaciones>>("AprovacionVacacionesControlador/ListarAprobacionesVacaciones");
                dgvSolicitudes.DataSource = solicitudes;
                dgvAprovados.DataSource = aprovados;
                dataRevisionV.DataSource = revisiones;
                dgvSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvAprovados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataRevisionV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las solicitudes de vacaciones: {ex.Message}");
            }


        }
        private void CargarComboBoxEstado()
        {
            cbxEstado.Items.Clear();
            cbxEstado.Items.Add("Pendiente");
            cbxEstado.Items.Add("Aprobado");
            cbxEstado.Items.Add("Rechazado");
            cbxEstado.SelectedIndex = 0;
        }

        /*private async Task CargarEmpleadosComboBox()
        {
            try
            {
                var empleados = await _apimodulonomina.GetAsync<List<Empleados>>("EmpleadosControlador/ObtenerTodosAsync");
                cbxEmpleado.DataSource = empleados;
                cbxEmpleado.DisplayMember = "Nombre"; // Lo que se muestra
                cbxEmpleado.ValueMember = "Id";       // Lo que se usa internamente
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message);
            }
        }*/
        public async Task CargarEmpleadosEnComboBox()
        {
            try
            {
                var empleados = await _apimodulonomina.GetAsync<List<Empleados>>("EmpleadoControlador/ListarEmpleados");

                // Creamos una lista con solo los nombres y apellidos
                var listaNombres = empleados
                    .Select(e => new
                    {
                        NombreCompleto = $"{e.Nombres} {e.Apellidos}",
                        Valor = e.IdEmpleado // Puedes cambiarlo por otro valor único si lo prefieres
                    })
                    .ToList();

                cbxEmpleado.DataSource = listaNombres;
                cbxEmpleado.DisplayMember = "NombreCompleto"; // Lo que se muestra
                cbxEmpleado.ValueMember = "Valor";            // Lo que se guarda internamente

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los empleados en el combo: {ex.Message}");
            }
        }
        private int CalcularDiasSolicitados(DateTime inicio, DateTime fin)
        {
            return (fin - inicio).Days + 1;
        }





        private void txtBuscar2_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtBuscar2.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                _ = CargarVacaciones(); // recarga todo si no hay texto
                return;
            }

            // Filtrado independiente para cada DataGridView
            if (dgvSolicitudes.DataSource is List<SolicitudVacaciones> listaSolicitudes)
            {
                var solicitudesFiltrados = listaSolicitudes
                    .Where(s => s.Estado.ToString().ToLower().Contains(searchText) ||
                                s.EmpleadoId.ToString().Contains(searchText) ||
                                s.FechaInicio.ToString().Contains(searchText) ||
                                s.FechaFin.ToString().Contains(searchText))
                    .ToList();
                dgvSolicitudes.DataSource = solicitudesFiltrados;
            }

            if (dgvAprovados.DataSource is List<AprobacionVacaciones> listaAprovados)
            {
                var aprovadosFiltrados = listaAprovados
                    .Where(a => a.UsuarioAprobador.ToString().ToLower().Contains(searchText) ||
                                a.SolicitudId.ToString().Contains(searchText) ||
                                a.FechaAprobacion.ToString().Contains(searchText))
                    .ToList();
                dgvAprovados.DataSource = aprovadosFiltrados;
            }

            if (dataRevisionV.DataSource is List<EmpleadosVacacionesTotales> revisionVacaciones)
            {
                var revisionFiltrados = revisionVacaciones
                    .Where(r => r.EmpleadoId.ToString().Contains(searchText) ||
                                r.DiasOtorgados.ToString().Contains(searchText) ||
                                r.DiasUsados.ToString().Contains(searchText))
                    .ToList();
                dataRevisionV.DataSource = revisionFiltrados;
            }
        }
        private void F8Vacaciones_Load(object sender, EventArgs e)
        {
            CargarVacaciones();
            CargarEmpleadosEnComboBox();
            CargarComboBoxEstado();
            SetPlaceholder();

        }
        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(txtFInincio.Text))
            {
                isPlaceholderActive = true;
                txtFInincio.ForeColor = Color.Gray;
                txtFInincio.Text = "yyyy-MM-dd";
            }
        }

        private void RemovePlaceholder()
        {
            if (isPlaceholderActive)
            {
                isPlaceholderActive = false;
                txtFInincio.Text = "";
                txtFInincio.ForeColor = Color.Black;
            }
        }

        private void dgvSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSolicitudes.Rows.Count)
            {
                var solicitudSeleccionado = dgvSolicitudes.Rows[e.RowIndex].DataBoundItem as SolicitudVacaciones;
                if (solicitudSeleccionado != null)
                {
                    txtIdSVacacion.Text = solicitudSeleccionado.IdSolicitud.ToString();
                    cbxEmpleado.Text = solicitudSeleccionado.EmpleadoId.ToString();
                    //dateFInicio.Text = solicitudSeleccionado.FechaInicio.ToString();
                   // dateFFin.Text = solicitudSeleccionado.FechaFin.ToString();
                    txtDiasSolicitados.Text = solicitudSeleccionado.DiasSolicitados.ToString();
                    cbxEstado.Text = solicitudSeleccionado.Estado.ToString();
                }
            }
            if (dgvSolicitudes.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvSolicitudes.SelectedRows)
                {
                    row.DefaultCellStyle.BackColor = Color.LightBlue; // Cambia el color de fondo de la fila seleccionada
                }
            }

        }
        private async void btnCrear_Click(object sender, EventArgs e)
        {
            if (cbxEmpleado.SelectedValue == null || cbxEstado.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un empleado y un estado.");
                return;
            }

            // Confirmamos que el ID de empleado se esté leyendo bien
            MessageBox.Show("Empleado ID seleccionado: " + cbxEmpleado.SelectedValue.ToString());
           // MessageBox.Show("Empleado ID seleccionado: " + dateFInicio.Value.ToString());

            int idsolicitud = 0;
            int empleadoid = Convert.ToInt32(cbxEmpleado.SelectedValue); // Asegúrate de que este sea el ID correcto del empleado seleccionado
           // string fechaInicio = dateFInicio.Value.ToString();
           // string fechaFin = dateFFin.Value.ToString();
            int diasSolicitados = string.IsNullOrWhiteSpace(txtDiasSolicitados.Text)
                                  ? 0 : int.Parse(txtDiasSolicitados.Text.Trim());
            string estado = cbxEstado.Text.Trim().ToLower();

            var nuevasolicitud = new SolicitudVacaciones
            {
                IdSolicitud = idsolicitud,
                EmpleadoId = empleadoid,
                //FechaInicio = fechaInicio,
                //FechaFin = fechaFin,
                DiasSolicitados = diasSolicitados,
                Estado = estado,
                FechaCreacion = DateTime.Now // Asignamos la fecha de creación a la fecha actual
            };

            try
            {
                // Asegúrate de que este sea el mismo cliente que usas en el resto del código
                var resultado = await _apimodulonomina.PostAsync<SolicitudVacaciones>(
                    "SolicitudVacacionesControlador/InsertarSolicitudVacaciones",
                    nuevasolicitud
                );

                MessageBox.Show("Solicitud de vacaciones creada exitosamente. 🏖️");
                LimpiarFormulario();
                await CargarVacaciones(); // Recargar solicitudes
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar la solicitud: " + ex.Message);
            }
        }








        private void LimpiarFormulario()
        {
            cbxEmpleado.SelectedIndex = -1;
            //dateFInicio.Text = string.Empty;
            //dateFFin.Text = string.Empty;
            txtDiasSolicitados.Text = string.Empty;
            cbxEstado.SelectedIndex = -1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void txtFInincio_TextChanged(object sender, EventArgs e)
        {
            if (isEditing || isPlaceholderActive) return;

            isEditing = true;

            // Guardamos la posición actual del cursor
            int selectionStart = txtFInincio.SelectionStart;

            // Eliminamos todo lo que no sea número
            string onlyNumbers = new string(txtFInincio.Text.Where(char.IsDigit).ToArray());

            if (onlyNumbers.Length > 8)
                onlyNumbers = onlyNumbers.Substring(0, 8);

            // Formateamos con guiones yyyy-MM-dd
            if (onlyNumbers.Length > 4 && onlyNumbers.Length <= 6)
            {
                onlyNumbers = onlyNumbers.Insert(4, "-");
            }
            else if (onlyNumbers.Length > 6)
            {
                onlyNumbers = onlyNumbers.Insert(4, "-").Insert(7, "-");
            }

            txtFInincio.Text = onlyNumbers;

            // Ajustar posición del cursor para que no salte raro
            if (selectionStart == 5 || selectionStart == 8)
                selectionStart++;

            if (selectionStart > txtFInincio.Text.Length)
                selectionStart = txtFInincio.Text.Length;

            txtFInincio.SelectionStart = selectionStart;

            isEditing = false;

        }

        private void txtFInincio_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFInincio.Text))
            {
                SetPlaceholder();
            }
            else
            {
                if (!ValidarFecha(txtFInincio.Text))
                {
                    MessageBox.Show("Fecha inválida. Usa el formato yyyy-MM-dd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFInincio.Focus();
                }
            }

        }
        private bool ValidarFecha(string fecha)
        {
            DateTime dt;
            return DateTime.TryParseExact(fecha, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt);
        }

        private void txtFInincio_Enter(object sender, EventArgs e)
        {

        }
    }
}
