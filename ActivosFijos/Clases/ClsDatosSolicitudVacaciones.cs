using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivosFijos.Clases
{
    class ClsDatosSolicitudVacaciones
    {
        public Int32 RegId { get; set; }
        public string RegCedula { get; set; }
        public string EmpNombre { get; set; }
        public string EmpAntiguedad { get; set; }
        public string EmpDiasPorAnio { get; set; }
        public string EmpSaldo { get; set; }
        public string EmpFechaEntrada { get; set; }
        public string RegFechaSalida { get; set; }
        public string RegFechaRetorno { get; set; }
        public string RegDiasTomados { get; set; }
        public string RegObservaciones { get; set; }
        public string RegFechaCreacion { get; set; }
    }
}
