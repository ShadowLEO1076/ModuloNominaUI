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
using WinModuloNomina.Controlador;

namespace WinModuloNomina.Vista
{
    public partial class F9Inasistencias : Form
    {
        
        private readonly APIModuloNomina _apimodulonomina;
        private string ApiUrl;
        private BindingSource bindingSource2 = new BindingSource();

        public F9Inasistencias()
        {
            InitializeComponent();

            try
            {
                string baseUrl = ConfigurationManager.AppSettings["APIBaseUrl"];
                _apimodulonomina = new APIModuloNomina(baseUrl);
                this.Load += F9Inasistencias_Load;

                //dgvHistorialContratos.CellClick += dgvHistorialContratos_CellClick;



                // Configurar ADGV
                dgvInasistenciasL.FilterAndSortEnabled = true;
                dgvInasistenciasL.FilterStringChanged += (s, e) =>
                {
                    if (bindingSource2.DataSource != null)
                        bindingSource2.Filter = dgvInasistenciasL.FilterString;
                };

                dgvInasistenciasL.SortStringChanged += (s, e) =>
                {
                    if (bindingSource2.DataSource != null)
                        bindingSource2.Sort = dgvInasistenciasL.SortString;
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar: " + ex.Message);
            }



        }
        private DataTable ToDataTable<T>(IEnumerable<T> data)
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

        public async Task CargarInasistencias()
        {

            try
            {
                var inacistencia = await _apimodulonomina.GetAsync<List<InasistenciasFormDTO>>("InasistenciasControlador/ObtenerTodasActivasInasistenciasFormDTO");

                // Convertir a DataTable
                DataTable dtInacistencias = ToDataTable(inacistencia);
                bindingSource2.DataSource = dtInacistencias;
                bindingSource2.Filter = "Remunerable = 'False'";
                dgvInasistenciasL.DataSource = bindingSource2;

                // Configurar modo de orden para cada columna
                foreach (DataGridViewColumn col in dgvInasistenciasL.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.Programmatic;
                }

                dgvInasistenciasL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los contratos", ex.Message);
            }
        }

       
        private async void F9Inasistencias_Load(object sender, EventArgs e)
        {
            await CargarInasistencias();
        }
    }
}
