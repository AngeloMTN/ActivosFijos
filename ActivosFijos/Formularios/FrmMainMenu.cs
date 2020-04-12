using System;
using System.Windows.Forms;

namespace ActivosFijos.Formularios
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void PbxSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void PbxMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PbxMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            PbxMaximizar.Visible = false;
            PbxRestaurar.Visible = true;
        }

        private void PbxRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            PbxRestaurar.Visible = false;
            PbxMaximizar.Visible = true;
        }

        private void PbxMenuSidebar_Click(object sender, EventArgs e)
        {
            if(BnfGradientPanel.Width == 180)
            {
                BnfGradientPanel.Width = 50;
                PnlSidebarWraper.Width = 68;
                BnfLineSidebar.Width = 40;
            }
            else
            {
                BnfGradientPanel.Width = 180;
                PnlSidebarWraper.Width = 200;
                BnfLineSidebar.Width = 172;
            }
        }

        private void AbrirFormularioHijo(object formhijo)
        {
            if (this.PnlWraper.Controls.Count > 0)
                this.PnlWraper.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PnlWraper.Controls.Add(fh);
            this.PnlWraper.Tag = fh;
            fh.Show();
        }

        private void BtnActivos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmMantenimientoActivos());
            //AbrirFormularioHijo(new FrmGestionActivos());
        }

        private void BtnAreas_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmMantenimientoAreas());
        }

        private void BtnPropietarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmMantenimientoEmpresas());
        }
    }
}
