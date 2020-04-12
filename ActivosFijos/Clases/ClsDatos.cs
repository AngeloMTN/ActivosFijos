using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivosFijos.Clases
{
    public class ClsDatos
    {
        public Int32 ActId { get; set; }
        public string ActArchivo { get; set; }
        public Int32 AreId { get; set; }
        public string AreNombre { get; set; }
        public string ActNombre { get; set; }
        public string ActObservaciones { get; set; }
        public double ActValorBase0 { get; set; }
        public double ActValorBaseIva { get; set; }
        public double ActPctjeIva { get; set; }
        public double ActValorIva { get; set; }
        public double ActValorTotal { get; set; }
        public string ActFechaCompra { get; set; }
        public Int32 ProId { get; set; }
        public string ProNombre { get; set; }
        public string ActEstado { get; set; }

    }
}
