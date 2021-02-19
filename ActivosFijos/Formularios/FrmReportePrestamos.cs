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
    public partial class FrmReportePrestamos : Form
    {
        public FrmReportePrestamos()
        {
            InitializeComponent();
        }

        public object Datos { get; internal set; }

        private void FrmReportePrestamos_Load(object sender, EventArgs e)
        {

            this.RpvPrestamos.RefreshReport();
        }
    }
}
