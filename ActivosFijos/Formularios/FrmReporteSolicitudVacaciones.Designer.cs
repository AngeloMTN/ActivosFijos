
namespace ActivosFijos.Formularios
{
    partial class FrmReporteSolicitudVacaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RpvSolicitudVacaciones = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RpvSolicitudVacaciones
            // 
            this.RpvSolicitudVacaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RpvSolicitudVacaciones.Location = new System.Drawing.Point(0, 0);
            this.RpvSolicitudVacaciones.Name = "RpvSolicitudVacaciones";
            this.RpvSolicitudVacaciones.ServerReport.BearerToken = null;
            this.RpvSolicitudVacaciones.Size = new System.Drawing.Size(1282, 763);
            this.RpvSolicitudVacaciones.TabIndex = 0;
            // 
            // FrmReporteSolicitudVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 763);
            this.Controls.Add(this.RpvSolicitudVacaciones);
            this.Name = "FrmReporteSolicitudVacaciones";
            this.Text = "Reporte Solicitud de Vacaciones";
            this.Load += new System.EventHandler(this.FrmReporteSolicitudVacaciones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RpvSolicitudVacaciones;
    }
}