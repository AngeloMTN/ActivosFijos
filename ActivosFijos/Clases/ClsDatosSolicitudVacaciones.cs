using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivosFijos.Clases
{
    class ClsDatosSolicitudVacaciones
    {
        public Int32 VacId { get; set; }
        public string VacCedula { get; set; }
        public string EmpNombre { get; set; }
        public string EmpFechaEntrada { get; set; }
        public string VacAntiguedad { get; set; }
        public string VacDiasPorAnio { get; set; }
        public string VacDiasPendiente { get; set; }
        public string VacFechaSalida { get; set; }
        public string VacFechaRetorno { get; set; }
        public string VacDiasTomados { get; set; }
        public string VacObservaciones { get; set; }
        public string VacFechaCreacion { get; set; }
    }
}
