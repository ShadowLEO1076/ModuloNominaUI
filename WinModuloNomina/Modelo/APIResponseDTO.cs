using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicacion.DTO.DTOs;

namespace WinModuloNomina.Modelo
{
    public class APIResponseDTO
    {
        // Esta propiedad coincide con la propiedad 'Mensaje' que envías desde la API
        public string Mensaje { get; set; }

        // Esta lista coincide con la propiedad 'Descuentos' que envías desde la API
        public List<DescuentoPorInasistenciaDTO> Descuentos { get; set; }
    }
}
