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
using Aplicacion.DTO.DTOs;
using Infraestructura.AccesoDatos;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using WinModuloNomina.Controlador;
using WinModuloNomina.Modelo;
using BindingSource = System.Windows.Forms.BindingSource;


namespace WinModuloNomina.Vista
{
    public partial class F15FaltasD : Form
    {
        private readonly APIModuloNomina _api;
        private string _apiUrl;
        private BindingSource bindingSource5 = new BindingSource();
        private Form activeForm;
        public F15FaltasD()
        {
            InitializeComponent();
            try
            {
                string baseUrl = ConfigurationManager.AppSettings["APIBaseUrl"];
                _api = new APIModuloNomina(baseUrl);
                this.Load += F15FaltasD_Load;








                // Configurar ADGV
                dgvDescuentosF.FilterAndSortEnabled = true;
                dgvDescuentosF.FilterStringChanged += (s, e) =>
                {
                    if (bindingSource5.DataSource != null)
                        bindingSource5.Filter = dgvDescuentosF.FilterString;
                };

                dgvDescuentosF.SortStringChanged += (s, e) =>
                {
                    if (bindingSource5.DataSource != null)
                        bindingSource5.Sort = dgvDescuentosF.SortString;
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar: " + ex.Message);
            }

        }
        private DataTable ToDataTable3<T>(IEnumerable<T> data)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in props)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in props)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }
            return table;
        }

        public async Task CargarInasistenciasDescontables()
        {
            try
            {
                var aux = new BusquedaDTO
                {
                    mes = dateTimePicker1.Value.Month,
                    anio = dateTimePicker1.Value.Year
                };

                // --- ¡Ajuste 1: Endpoint correcto! ---
                // --- ¡Ajuste 2: Tipo de dato esperado correcto! ---
                var descuentos = await _api.PostAsync<List<DescuentoPorInasistenciaDTO>>("InasistenciasControlador/CalcularDescuentosPorInasistencias", aux);

                // Si la lista es nula o vacía, muestra un mensaje
                if (descuentos == null || !descuentos.Any())
                {
                    MessageBox.Show("No se encontraron inasistencias no remunerables para el período seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpia el DataGridView si no hay datos
                    bindingSource5.DataSource = null;
                    return;
                }

                // Convertir la lista de DTOs a un DataTable y enlazarlo
                DataTable dtDescuentos = ToDataTable3(descuentos);
                bindingSource5.DataSource = dtDescuentos;
                dgvDescuentosF.DataSource = bindingSource5;

                // ... (El resto de tu código para configurar el DataGridView está bien) ...
                foreach (DataGridViewColumn col in dgvDescuentosF.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.Programmatic;
                }
                dgvDescuentosF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar inasistencias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public async Task descontaraTodos()
        {
            try
            {
                // 1. Confirmación del usuario
                DialogResult result = MessageBox.Show("¿Está seguro de que desea registrar los descuentos en la base de datos? Esta acción es irreversible.", "Confirmar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    return;
                }

                // Limpia el DataGridView antes de la operación
                bindingSource5.DataSource = null;
                dgvDescuentosF.DataSource = null;

                var aux = new BusquedaDTO
                {
                    mes = dateTimePicker1.Value.Month,
                    anio = dateTimePicker1.Value.Year
                };

                // --- ¡Ajuste CRÍTICO AQUÍ! ---
                // Ahora, la llamada a PostAsync espera el nuevo DTO de respuesta completo.
                var response = await _api.PostAsync<APIResponseDTO>("InasistenciasControlador/CalcularYGuardarDescuentos", aux);

                // 2. Maneja la respuesta
                if (response?.Descuentos == null || !response.Descuentos.Any())
                {
                    MessageBox.Show(response?.Mensaje ?? "No se encontraron inasistencias para registrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Muestra el mensaje de éxito que viene del servidor
                MessageBox.Show(response.Mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 3. Usa la lista que viene DENTRO de la respuesta para actualizar el DataGridView
                DataTable dtDescuentos = ToDataTable3(response.Descuentos);
                bindingSource5.DataSource = dtDescuentos;
                dgvDescuentosF.DataSource = bindingSource5;

                // ... (El resto de tu código de configuración del DataGridView) ...
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al descontar las inasistencias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void F15FaltasD_Load(object sender, EventArgs e)
        {

        }


        private async void iconButton2_Click_1(object sender, EventArgs e)
        {
            await CargarInasistenciasDescontables();
        }

        private async void btndescontar_Click(object sender, EventArgs e)
        {
            await descontaraTodos();
        }
    }
}
