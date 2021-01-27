using ActivosFijos.Clases;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivosFijos.Formularios
{
    public partial class FrmReporteSolicitudVacaciones : Form
    {
        private List<ClsDatosSolicitudVacaciones> datosSV = new List<ClsDatosSolicitudVacaciones>();

        public FrmReporteSolicitudVacaciones()
        {
            InitializeComponent();
        }

        internal List<ClsDatosSolicitudVacaciones> DatosSV { get => datosSV; set => datosSV = value; }

        private void FrmReporteSolicitudVacaciones_Load(object sender, EventArgs e)
        {
            RpvSolicitudVacaciones.LocalReport.DataSources.Clear();
            ReportDataSource fuente = new ReportDataSource("DsReporteSolicitudVacaciones", DatosSV);
            RpvSolicitudVacaciones.LocalReport.DataSources.Add(fuente);
            RpvSolicitudVacaciones.LocalReport.ReportEmbeddedResource = "ActivosFijos.Reportes.RptSolicitudVacaciones.rdlc";
            this.RpvSolicitudVacaciones.RefreshReport();

        }
    }
}
