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
using WinModuloNomina.Controlador;

namespace WinModuloNomina.Vista
{
    public partial class F10Historicos : Form
    {
        private readonly APIModuloNomina _apimodulonomina;
        private BindingSource bindingSource1 = new BindingSource();
        private List<ContratosDTO> _contratosOriginales = new List<ContratosDTO>();
        public F10Historicos()
        {
            InitializeComponent();
            try
            {
                string baseUrl = ConfigurationManager.AppSettings["APIBaseUrl"];
                _apimodulonomina = new APIModuloNomina(baseUrl);


                this.Load += F10Historicos_Load;

                // Configurar ADGV
                dgvHistoricos.FilterAndSortEnabled = true;
                dgvHistoricos.FilterStringChanged += (s, e) =>
                {
                    if (bindingSource1.DataSource != null)
                        bindingSource1.Filter = dgvHistoricos.FilterString;
                };

                dgvHistoricos.SortStringChanged += (s, e) =>
                {
                    if (bindingSource1.DataSource != null)
                        bindingSource1.Sort = dgvHistoricos.SortString;
                };
                CargarContratos2();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar: " + ex.Message);
            }
        }
        private DataTable ToDataTable2<T>(IEnumerable<T> data)
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
        public async Task CargarContratos2()
        {
            try
            {
                var contratos = await _apimodulonomina.GetAsync<List<ContratosHistoricoDTO>>("ContratosHistoricosControlador/ListarContratoHistoricos");

                // Convertir a DataTable
                DataTable dtHistorico = ToDataTable2(contratos);
                bindingSource1.DataSource = dtHistorico;
                //bindingSource1.Filter = "Estado = 'Vigente'";
                dgvHistoricos.DataSource = bindingSource1;

                // Configurar modo de orden para cada columna
                foreach (DataGridViewColumn col in dgvHistoricos.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.Programmatic;
                }
                dgvHistoricos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los contratos", ex.Message);
            }
        }

        private void F10Historicos_Load(object sender, EventArgs e)
        {

        }
    }
}
