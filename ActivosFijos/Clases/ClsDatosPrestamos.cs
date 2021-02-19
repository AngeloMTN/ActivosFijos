using System;

namespace ActivosFijos.Clases
{
    class ClsDatosPrestamos
    {
        public Int32 PreId { get; set; }
        public string PreCedula { get; set; }
        public string EmpNombre { get; set; }
        public string PreFechaPrestamo { get; set; }
        public decimal PreValorPrestamo { get; set; }
        public Int32 PreNumeroCuotas { get; set; }
        public decimal PreValorCuota { get; set; }
        public string PreFechaAbono { get; set; }
        public decimal PreValorAbono { get; set; }
        public decimal PreSaldoParcial { get; set; }
        public string PreObservaciones { get; set; }

    }
}
