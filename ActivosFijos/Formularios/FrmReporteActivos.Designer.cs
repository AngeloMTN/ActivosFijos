namespace ActivosFijos
{
    partial class FrmReporteActivos
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
            this.ClsDatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clsEstructuraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RpvActivos = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ClsDatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEstructuraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RpvActivos
            // 
            this.RpvActivos.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsReporteActivos";
            reportDataSource1.Value = this.ClsDatosBindingSource;
            this.RpvActivos.LocalReport.DataSources.Add(reportDataSource1);
            this.RpvActivos.LocalReport.ReportEmbeddedResource = "ActivosFijos.Reportes.RptActivos.rdlc";
            this.RpvActivos.Location = new System.Drawing.Point(0, 0);
            this.RpvActivos.Name = "RpvActivos";
            this.RpvActivos.ServerReport.BearerToken = null;
            this.RpvActivos.Size = new System.Drawing.Size(1282, 763);
            this.RpvActivos.TabIndex = 0;
            // 
            // FrmReporteActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 763);
            this.Controls.Add(this.RpvActivos);
            this.Name = "FrmReporteActivos";
            this.Text = "FrmReporteActivos";
            this.Load += new System.EventHandler(this.FrmReporteActivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClsDatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEstructuraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource clsEstructuraBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer RpvActivos;
        private System.Windows.Forms.BindingSource ClsDatosBindingSource;
    }
}