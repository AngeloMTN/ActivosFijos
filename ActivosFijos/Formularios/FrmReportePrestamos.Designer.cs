
namespace ActivosFijos.Formularios
{
    partial class FrmReportePrestamos
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RpvPrestamos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClsDatosPrestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ClsDatosPrestamosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RpvPrestamos
            // 
            this.RpvPrestamos.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsReportePrestamos";
            reportDataSource1.Value = this.ClsDatosPrestamosBindingSource;
            this.RpvPrestamos.LocalReport.DataSources.Add(reportDataSource1);
            this.RpvPrestamos.LocalReport.ReportEmbeddedResource = "ActivosFijos.Reportes.RptPrestamos.rdlc";
            this.RpvPrestamos.Location = new System.Drawing.Point(0, 0);
            this.RpvPrestamos.Name = "RpvPrestamos";
            this.RpvPrestamos.ServerReport.BearerToken = null;
            this.RpvPrestamos.Size = new System.Drawing.Size(1282, 763);
            this.RpvPrestamos.TabIndex = 0;
            // 
            // ClsDatosPrestamosBindingSource
            // 
            this.ClsDatosPrestamosBindingSource.DataSource = typeof(ActivosFijos.Clases.ClsDatosPrestamos);
            // 
            // FrmReportePrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 763);
            this.Controls.Add(this.RpvPrestamos);
            this.Name = "FrmReportePrestamos";
            this.Text = "Reporte Prestamos de Empleados";
            this.Load += new System.EventHandler(this.FrmReportePrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClsDatosPrestamosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RpvPrestamos;
        private System.Windows.Forms.BindingSource ClsDatosPrestamosBindingSource;
    }
}