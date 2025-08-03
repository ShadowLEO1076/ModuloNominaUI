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
using Newtonsoft.Json;
using WinModuloNomina.Controlador;
using WinModuloNomina.Modelo;
using WinModuloNomina.Modelo.DTOS;

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

                // Especifica explícitamente el tipo esperado en PostAsync
                var descuentos = await _api.PostAsync<List<BusquedaDTO>>("InasistenciasControlador/ObtenerInasistenciasPorMesAnio", aux);

                /*if (descuentos == null || !descuentos.Any())
                {
                    MessageBox.Show("No se encontraron inasistencias para el período seleccionado");
                    return;
                }*/

                // Convertir a DataTable especificando el tipo
                //DataTable dtInasistencias = ToDataTable3<Inasistencias>(descuentos);

                //bindingSource5.DataSource = dtInasistencias;
                dgvDescuentosF.DataSource = bindingSource5;

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

        private void F15FaltasD_Load(object sender, EventArgs e)
        {

        }

        private async void iconButton2_Click(object sender, EventArgs e)
        {
            await CargarInasistenciasDescontables();
        }
    }
}
/* private async Task CrearDescuento()
        {
            try
            {
                // Validaciones

                var nuevoDescuento = new Descuentos
                {
                    IdDescuento = 0,
                    EmpleadoId = // va a rrecorres la tabla inasistencias y va seleccionar todos los empleados
                                 // que tengan insasistencias con estado Remunerable false
                                 // y que correspondan al rango de fecha seleccionadao en el datetimepicker,
                    Tipo = "Inasistencia",
                    Descripcion = "Faltas y ausencias",
                    Monto = // la sumatoria por cada empleado es decir si un empleado falto 5 veces me va sumar solo para el pero despues para los demas no se si usar un ciclo ,
                    Fecha = DateOnly.FromDateTime(DateTime.Now),
                    Estado = true
                };

                var response = await _api.PostAsync<Descuentos>("DescuentosControlador/AgregarAsync", nuevoDescuento);

                if (response != null)
                {
                    await CargarDescuentos();
                    MessageBox.Show("Descuento creado exitosamente.");

                else
                {
                    MessageBox.Show("No se recibió respuesta del servidor.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el descuento: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       */
/*
private async Task GenerarDescuentosPorInasistencias()
{
    try
    {
        int mes = dateTimePicker1.Value.Month;
        int anio = dateTimePicker1.Value.Year;

        var filtro = new BusquedaDTO { mes = mes, anio = anio };

        var listaInasistencias = await _api.PostAsync<List<InasistenciasEmpleadoDTO>>("InasistenciasControlador/ObtenerInasistenciasPorMesAnio", filtro);

        foreach (var empleado in listaInasistencias)
        {
            var inasistenciasNoRemu = empleado.inasistencias
                .Where(i => i.Remunerable == false)
                .ToList();

            if (!inasistenciasNoRemu.Any())
                continue;

            // Obtener contrato del empleado
            var contrato = await _api.GetAsync<Contratos>($"ContratosControlador/ObtenerPorCedula/{empleado.CedulaEmpleado}");

            if (contrato == null)
                continue;

            var tipoContrato = await _api.GetAsync<ContratosTipo>($"ContratoTipoControlador/ObtenerPorId/{contrato.IdTipoContrato}");

            if (tipoContrato == null)
                continue;

            // Datos base
            decimal sueldo = contrato.Sueldo;
            int horasMensuales = tipoContrato.HorasJornada * 30;

            // Sumamos las horas faltadas
            decimal horasFaltadas = inasistenciasNoRemu.Sum(i => i.DiasContados * tipoContrato.HorasJornada);

            // Cálculo
            decimal monto = (sueldo / horasMensuales) * horasFaltadas;

            var nuevoDescuento = new Descuentos
            {
                IdDescuento = 0,
                EmpleadoId = contrato.IdEmpleado,
                Tipo = "Inasistencia",
                Descripcion = $"Descuento por inasistencias de {mes}/{anio}",
                Monto = Math.Round(monto, 2),
                Fecha = DateOnly.FromDateTime(DateTime.Now),
                Estado = true
            };

            await _api.PostAsync<Descuentos>("DescuentosControlador/AgregarAsync", nuevoDescuento);
        }

        await CargarDescuentos();
        MessageBox.Show("Descuentos generados correctamente 💸", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Error al generar descuentos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}*/
