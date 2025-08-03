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
using Infraestructura.AccesoDatos;
using WinModuloNomina.Controlador;

namespace WinModuloNomina.Vista
{


    public partial class F14CalculadoraD : Form
    {
        private readonly APIModuloNomina _api;
        private string _apiUrl;
        public F14CalculadoraD()
        {
            InitializeComponent();
            try
            {
                string baseUrl = ConfigurationManager.AppSettings["APIBaseUrl"];
                _api = new APIModuloNomina(baseUrl);
                this.Load += F14CalculadoraD_Load;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar: " + ex.Message);
            }
        }
        public async Task salarioempleado()
        {
            try
            {
                var contrato = await _api.GetAsync<List<ContratosDTO>>("ContratosControlador/ObtenerContratosCompletos");

                if (contrato == null || contrato.Count == 0)
                {
                    MessageBox.Show("No se encontraron contratos o no se pudo cargar la información.");
                    cbSalario.DataSource = null;
                    return;
                }

                var Listasalario = contrato
                    .Where(c => c.Estado == "Vigente")
                    .Select(c => new
                    {
                        NombreCompletoEmpleado = $"{c.NombreCompletoEmpleado} - {c.Salario:C}",
                        Salario = c.Salario
                    })
                    .ToList();


                cbSalario.DataSource = Listasalario;
                cbSalario.DisplayMember = "NombreCompletoEmpleado";
                cbSalario.ValueMember = "Salario";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los salarios: " + ex.Message);
            }
        }
        public void CargarDiasFaltados()
        {
            try
            {
                cbdiasfaltados.Items.Clear();

                // Agregar días del 1 al 30 (o el rango que necesites)
                for (int i = 1; i <= 30; i++)
                {
                    cbdiasfaltados.Items.Add(i);
                }

                // Seleccionar el primer item por defecto
                if (cbdiasfaltados.Items.Count > 0)
                {
                    cbdiasfaltados.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar días faltados: {ex.Message}");
            }
        }
        private void tipoTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string seleccion = tipoTxt.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(seleccion))
                {
                    return;
                }

                switch (seleccion)
                {
                    case "Anticipo":
                        montoTxt.Text = "0";
                        montoTxt.Enabled = true;
                        cbdiasfaltados.Enabled = false;
                        cbSalario.Enabled = false;
                        break;

                    case "Inasistencias":
                        montoTxt.Text = "0";
                        montoTxt.Enabled = false;
                        cbdiasfaltados.Enabled = true;
                        cbSalario.Enabled = true;

                        break;

                    case "Falla Operativa":
                        montoTxt.Text = "0";
                        montoTxt.Enabled = true;
                        cbdiasfaltados.Enabled = false;
                        cbSalario.Enabled = false;
                        break;

                    default:
                        montoTxt.Enabled = false;

                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cambiar tipo: {ex.Message}");
            }
        }
        private void CalcularDescuentoInasistencias()
        {
            try
            {
                // Validaciones iniciales
                if (cbSalario.SelectedValue == null || cbdiasfaltados.SelectedItem == null)
                {
                    MessageBox.Show("Por favor seleccione un empleado y los días faltados.");
                    return;
                }

                if (!decimal.TryParse(cbSalario.SelectedValue.ToString(), out decimal salarioMensual) || salarioMensual <= 0)
                {
                    MessageBox.Show("No se pudo obtener el salario válido del empleado.");
                    return;
                }

                if (!int.TryParse(cbdiasfaltados.SelectedItem.ToString(), out int diasFaltados) || diasFaltados <= 0)
                {
                    MessageBox.Show("La cantidad de días faltados debe ser un número positivo.");
                    return;
                }

                // Constantes para el cálculo
                const int DIAS_MES = 30;
                const decimal PORCENTAJE_MAXIMO_DESCUENTO = 0.10m; // 10% del salario

                // Calcular valor del día completo (100%)
                decimal valorDiaCompleto = salarioMensual / DIAS_MES;

                // Calcular descuento total sin límite
                decimal descuentoTotal = valorDiaCompleto * diasFaltados;

                // Calcular el 10% del salario (límite máximo a descontar)
                decimal maximoDescuentoPermitido = salarioMensual * PORCENTAJE_MAXIMO_DESCUENTO;

                // Aplicar regla: si el descuento supera el 10% del salario, usar el límite
                decimal descuentoAplicar = (descuentoTotal > maximoDescuentoPermitido)
                                            ? maximoDescuentoPermitido
                                            : descuentoTotal;

                // Mostrar el resultado
                montoTxt.Text = descuentoAplicar.ToString("N2");
                montoTxt.Enabled = false;

                // Opcional: Mostrar advertencia si se aplicó el límite
                if (descuentoTotal > maximoDescuentoPermitido)
                {
                    MessageBox.Show($"El descuento calculado ({descuentoTotal:C}) supera el 10% del salario. " +
                                  $"Se aplicará el descuento máximo permitido: {maximoDescuentoPermitido:C}",
                                  "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular el descuento: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                montoTxt.Text = "0";
            }
        }

        private void F14CalculadoraD_Load(object sender, EventArgs e)
        {

        }
    }
}