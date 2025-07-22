using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.DTO.DTOs
{
    public class SolicitudVacacionDTO
    {
        public int IdSolicitud { get; set; }
        public int EmpleadoId { get; set; }
        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFin { get; set; }
        public int DiasSolicitados { get; set; }
        public string Estado { get; set; }
    }
}
