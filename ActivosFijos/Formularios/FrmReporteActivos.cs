using ActivosFijos.Clases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ActivosFijos
{
    public partial class FrmReporteActivos : Form
    {
        public List<ClsDatos> Datos = new List<ClsDatos>();

        public FrmReporteActivos()
        {
            InitializeComponent();
        }

        private void FrmReporteActivos_Load(object sender, EventArgs e)
        {
            RpvActivos.LocalReport.DataSources.Clear();
            ReportDataSource fuente = new ReportDataSource("DsReporteActivos", Datos);
            RpvActivos.LocalReport.DataSources.Add(fuente);
            RpvActivos.LocalReport.ReportEmbeddedResource = "ActivosFijos.Reportes.RptActivos.rdlc";
            this.RpvActivos.RefreshReport();
        }
    }
}
