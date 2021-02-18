
namespace ActivosFijos.Formularios
{
    partial class FrmMantenimientoVacaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantenimientoVacaciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TpgEmpleados = new System.Windows.Forms.TabPage();
            this.BtnEmpleadoReportes = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnFiltroEmpleadoBuscar = new System.Windows.Forms.Button();
            this.TxtFiltroEmpleadoBuscar = new System.Windows.Forms.TextBox();
            this.LblFiltroNombre = new System.Windows.Forms.Label();
            this.DgvEmpleados = new System.Windows.Forms.DataGridView();
            this.TpgRegistro = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BtnImprimirSolicitud = new System.Windows.Forms.Button();
            this.DtpRegistroFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.LblRegistroFechaEntrada = new System.Windows.Forms.Label();
            this.LblRegistroNombre = new System.Windows.Forms.Label();
            this.LblDiasPendiente = new System.Windows.Forms.Label();
            this.LblDiasPorAnio = new System.Windows.Forms.Label();
            this.LblAntiguedad = new System.Windows.Forms.Label();
            this.TxtSaldo = new System.Windows.Forms.TextBox();
            this.TxtDiasPorAnio = new System.Windows.Forms.TextBox();
            this.TxtAntiguedad = new System.Windows.Forms.TextBox();
            this.LblObservaciones = new System.Windows.Forms.Label();
            this.TxtObservaciones = new System.Windows.Forms.TextBox();
            this.DtpFechaRetorno = new System.Windows.Forms.DateTimePicker();
            this.LblFechaRetorno = new System.Windows.Forms.Label();
            this.TxtIdRegistro = new System.Windows.Forms.TextBox();
            this.LblIdRegistro = new System.Windows.Forms.Label();
            this.BtnRegistroCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnRegistroGrabar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnRegistroEliminar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnRegistroNuevo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TxtDiasTomados = new System.Windows.Forms.TextBox();
            this.LblDiasTomados = new System.Windows.Forms.Label();
            this.DtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.LblFechaSalida = new System.Windows.Forms.Label();
            this.CmbRegistroNombre = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CmbFiltroRegistroBuscar = new System.Windows.Forms.ComboBox();
            this.BtnFiltroRegistroBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvRegistroVacaciones = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.TpgEmpleados.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleados)).BeginInit();
            this.TpgRegistro.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegistroVacaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.TpgEmpleados);
            this.tabControl1.Controls.Add(this.TpgRegistro);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(56, 30);
            this.tabControl1.Location = new System.Drawing.Point(12, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1265, 747);
            this.tabControl1.TabIndex = 23;
            // 
            // TpgEmpleados
            // 
            this.TpgEmpleados.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TpgEmpleados.Controls.Add(this.BtnEmpleadoReportes);
            this.TpgEmpleados.Controls.Add(this.groupBox2);
            this.TpgEmpleados.Controls.Add(this.DgvEmpleados);
            this.TpgEmpleados.Location = new System.Drawing.Point(4, 34);
            this.TpgEmpleados.Name = "TpgEmpleados";
            this.TpgEmpleados.Padding = new System.Windows.Forms.Padding(3);
            this.TpgEmpleados.Size = new System.Drawing.Size(1257, 709);
            this.TpgEmpleados.TabIndex = 0;
            this.TpgEmpleados.Text = "Empleados";
            // 
            // BtnEmpleadoReportes
            // 
            this.BtnEmpleadoReportes.ActiveBorderThickness = 1;
            this.BtnEmpleadoReportes.ActiveCornerRadius = 20;
            this.BtnEmpleadoReportes.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnEmpleadoReportes.ActiveForecolor = System.Drawing.Color.White;
            this.BtnEmpleadoReportes.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnEmpleadoReportes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEmpleadoReportes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEmpleadoReportes.BackgroundImage")));
            this.BtnEmpleadoReportes.ButtonText = "REPORTES";
            this.BtnEmpleadoReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEmpleadoReportes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpleadoReportes.ForeColor = System.Drawing.Color.DarkGray;
            this.BtnEmpleadoReportes.IdleBorderThickness = 1;
            this.BtnEmpleadoReportes.IdleCornerRadius = 20;
            this.BtnEmpleadoReportes.IdleFillColor = System.Drawing.Color.Black;
            this.BtnEmpleadoReportes.IdleForecolor = System.Drawing.Color.DarkKhaki;
            this.BtnEmpleadoReportes.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnEmpleadoReportes.Location = new System.Drawing.Point(1087, 5);
            this.BtnEmpleadoReportes.Margin = new System.Windows.Forms.Padding(5);
            this.BtnEmpleadoReportes.Name = "BtnEmpleadoReportes";
            this.BtnEmpleadoReportes.Size = new System.Drawing.Size(159, 60);
            this.BtnEmpleadoReportes.TabIndex = 44;
            this.BtnEmpleadoReportes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnFiltroEmpleadoBuscar);
            this.groupBox2.Controls.Add(this.TxtFiltroEmpleadoBuscar);
            this.groupBox2.Controls.Add(this.LblFiltroNombre);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(769, 68);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros:";
            // 
            // BtnFiltroEmpleadoBuscar
            // 
            this.BtnFiltroEmpleadoBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnFiltroEmpleadoBuscar.Location = new System.Drawing.Point(651, 13);
            this.BtnFiltroEmpleadoBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnFiltroEmpleadoBuscar.Name = "BtnFiltroEmpleadoBuscar";
            this.BtnFiltroEmpleadoBuscar.Size = new System.Drawing.Size(102, 50);
            this.BtnFiltroEmpleadoBuscar.TabIndex = 3;
            this.BtnFiltroEmpleadoBuscar.Text = "Buscar...";
            this.BtnFiltroEmpleadoBuscar.UseVisualStyleBackColor = false;
            this.BtnFiltroEmpleadoBuscar.Click += new System.EventHandler(this.BtnFiltroEmpleadoBuscar_Click);
            // 
            // TxtFiltroEmpleadoBuscar
            // 
            this.TxtFiltroEmpleadoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFiltroEmpleadoBuscar.Location = new System.Drawing.Point(83, 23);
            this.TxtFiltroEmpleadoBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtFiltroEmpleadoBuscar.Name = "TxtFiltroEmpleadoBuscar";
            this.TxtFiltroEmpleadoBuscar.Size = new System.Drawing.Size(542, 27);
            this.TxtFiltroEmpleadoBuscar.TabIndex = 1;
            // 
            // LblFiltroNombre
            // 
            this.LblFiltroNombre.AutoSize = true;
            this.LblFiltroNombre.Location = new System.Drawing.Point(6, 27);
            this.LblFiltroNombre.Name = "LblFiltroNombre";
            this.LblFiltroNombre.Size = new System.Drawing.Size(72, 20);
            this.LblFiltroNombre.TabIndex = 0;
            this.LblFiltroNombre.Text = "Nombre:";
            // 
            // DgvEmpleados
            // 
            this.DgvEmpleados.AllowUserToDeleteRows = false;
            this.DgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.DgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvEmpleados.ColumnHeadersHeight = 30;
            this.DgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvEmpleados.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvEmpleados.EnableHeadersVisualStyles = false;
            this.DgvEmpleados.GridColor = System.Drawing.Color.SteelBlue;
            this.DgvEmpleados.Location = new System.Drawing.Point(9, 77);
            this.DgvEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvEmpleados.Name = "DgvEmpleados";
            this.DgvEmpleados.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvEmpleados.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DgvEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvEmpleados.RowTemplate.Height = 24;
            this.DgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEmpleados.Size = new System.Drawing.Size(1237, 623);
            this.DgvEmpleados.TabIndex = 22;
            // 
            // TpgRegistro
            // 
            this.TpgRegistro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TpgRegistro.Controls.Add(this.groupBox5);
            this.TpgRegistro.Controls.Add(this.groupBox4);
            this.TpgRegistro.Controls.Add(this.DgvRegistroVacaciones);
            this.TpgRegistro.Location = new System.Drawing.Point(4, 34);
            this.TpgRegistro.Name = "TpgRegistro";
            this.TpgRegistro.Size = new System.Drawing.Size(1257, 709);
            this.TpgRegistro.TabIndex = 2;
            this.TpgRegistro.Text = "Registro";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BtnImprimirSolicitud);
            this.groupBox5.Controls.Add(this.DtpRegistroFechaEntrada);
            this.groupBox5.Controls.Add(this.LblRegistroFechaEntrada);
            this.groupBox5.Controls.Add(this.LblRegistroNombre);
            this.groupBox5.Controls.Add(this.LblDiasPendiente);
            this.groupBox5.Controls.Add(this.LblDiasPorAnio);
            this.groupBox5.Controls.Add(this.LblAntiguedad);
            this.groupBox5.Controls.Add(this.TxtSaldo);
            this.groupBox5.Controls.Add(this.TxtDiasPorAnio);
            this.groupBox5.Controls.Add(this.TxtAntiguedad);
            this.groupBox5.Controls.Add(this.LblObservaciones);
            this.groupBox5.Controls.Add(this.TxtObservaciones);
            this.groupBox5.Controls.Add(this.DtpFechaRetorno);
            this.groupBox5.Controls.Add(this.LblFechaRetorno);
            this.groupBox5.Controls.Add(this.TxtIdRegistro);
            this.groupBox5.Controls.Add(this.LblIdRegistro);
            this.groupBox5.Controls.Add(this.BtnRegistroCancelar);
            this.groupBox5.Controls.Add(this.BtnRegistroGrabar);
            this.groupBox5.Controls.Add(this.BtnRegistroEliminar);
            this.groupBox5.Controls.Add(this.BtnRegistroNuevo);
            this.groupBox5.Controls.Add(this.TxtDiasTomados);
            this.groupBox5.Controls.Add(this.LblDiasTomados);
            this.groupBox5.Controls.Add(this.DtpFechaSalida);
            this.groupBox5.Controls.Add(this.LblFechaSalida);
            this.groupBox5.Controls.Add(this.CmbRegistroNombre);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(9, 2);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(1237, 202);
            this.groupBox5.TabIndex = 47;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Solicitud de Vacaciones";
            // 
            // BtnImprimirSolicitud
            // 
            this.BtnImprimirSolicitud.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnImprimirSolicitud.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimirSolicitud.ForeColor = System.Drawing.Color.Khaki;
            this.BtnImprimirSolicitud.Location = new System.Drawing.Point(928, 138);
            this.BtnImprimirSolicitud.Name = "BtnImprimirSolicitud";
            this.BtnImprimirSolicitud.Size = new System.Drawing.Size(290, 50);
            this.BtnImprimirSolicitud.TabIndex = 74;
            this.BtnImprimirSolicitud.Text = "IMPRIMIR SOLICITUD";
            this.BtnImprimirSolicitud.UseVisualStyleBackColor = false;
            this.BtnImprimirSolicitud.Click += new System.EventHandler(this.BtnImprimirSolicitud_Click);
            // 
            // DtpRegistroFechaEntrada
            // 
            this.DtpRegistroFechaEntrada.CustomFormat = "yyyy/MM/dd";
            this.DtpRegistroFechaEntrada.Enabled = false;
            this.DtpRegistroFechaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpRegistroFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpRegistroFechaEntrada.Location = new System.Drawing.Point(158, 59);
            this.DtpRegistroFechaEntrada.Name = "DtpRegistroFechaEntrada";
            this.DtpRegistroFechaEntrada.Size = new System.Drawing.Size(138, 27);
            this.DtpRegistroFechaEntrada.TabIndex = 73;
            this.DtpRegistroFechaEntrada.Value = new System.DateTime(2021, 1, 25, 0, 0, 0, 0);
            // 
            // LblRegistroFechaEntrada
            // 
            this.LblRegistroFechaEntrada.AutoSize = true;
            this.LblRegistroFechaEntrada.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistroFechaEntrada.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblRegistroFechaEntrada.Location = new System.Drawing.Point(25, 63);
            this.LblRegistroFechaEntrada.Name = "LblRegistroFechaEntrada";
            this.LblRegistroFechaEntrada.Size = new System.Drawing.Size(120, 20);
            this.LblRegistroFechaEntrada.TabIndex = 72;
            this.LblRegistroFechaEntrada.Text = "Fecha Entrada:";
            // 
            // LblRegistroNombre
            // 
            this.LblRegistroNombre.AutoSize = true;
            this.LblRegistroNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistroNombre.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblRegistroNombre.Location = new System.Drawing.Point(147, 26);
            this.LblRegistroNombre.Name = "LblRegistroNombre";
            this.LblRegistroNombre.Size = new System.Drawing.Size(133, 20);
            this.LblRegistroNombre.TabIndex = 71;
            this.LblRegistroNombre.Text = "Cedula/Nombre:";
            // 
            // LblDiasPendiente
            // 
            this.LblDiasPendiente.AutoSize = true;
            this.LblDiasPendiente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDiasPendiente.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblDiasPendiente.Location = new System.Drawing.Point(700, 63);
            this.LblDiasPendiente.Name = "LblDiasPendiente";
            this.LblDiasPendiente.Size = new System.Drawing.Size(110, 20);
            this.LblDiasPendiente.TabIndex = 70;
            this.LblDiasPendiente.Text = "DiasPorTomar:";
            // 
            // LblDiasPorAnio
            // 
            this.LblDiasPorAnio.AutoSize = true;
            this.LblDiasPorAnio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDiasPorAnio.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblDiasPorAnio.Location = new System.Drawing.Point(503, 63);
            this.LblDiasPorAnio.Name = "LblDiasPorAnio";
            this.LblDiasPorAnio.Size = new System.Drawing.Size(97, 20);
            this.LblDiasPorAnio.TabIndex = 69;
            this.LblDiasPorAnio.Text = "DiasPorAño:";
            // 
            // LblAntiguedad
            // 
            this.LblAntiguedad.AutoSize = true;
            this.LblAntiguedad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAntiguedad.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblAntiguedad.Location = new System.Drawing.Point(308, 63);
            this.LblAntiguedad.Name = "LblAntiguedad";
            this.LblAntiguedad.Size = new System.Drawing.Size(100, 20);
            this.LblAntiguedad.TabIndex = 68;
            this.LblAntiguedad.Text = "Antiguedad:";
            // 
            // TxtSaldo
            // 
            this.TxtSaldo.Enabled = false;
            this.TxtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSaldo.Location = new System.Drawing.Point(826, 58);
            this.TxtSaldo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtSaldo.MaxLength = 15;
            this.TxtSaldo.Name = "TxtSaldo";
            this.TxtSaldo.Size = new System.Drawing.Size(64, 28);
            this.TxtSaldo.TabIndex = 67;
            this.TxtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtDiasPorAnio
            // 
            this.TxtDiasPorAnio.Enabled = false;
            this.TxtDiasPorAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDiasPorAnio.Location = new System.Drawing.Point(615, 58);
            this.TxtDiasPorAnio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDiasPorAnio.MaxLength = 15;
            this.TxtDiasPorAnio.Name = "TxtDiasPorAnio";
            this.TxtDiasPorAnio.Size = new System.Drawing.Size(64, 28);
            this.TxtDiasPorAnio.TabIndex = 66;
            this.TxtDiasPorAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtAntiguedad
            // 
            this.TxtAntiguedad.Enabled = false;
            this.TxtAntiguedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAntiguedad.Location = new System.Drawing.Point(425, 58);
            this.TxtAntiguedad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtAntiguedad.MaxLength = 15;
            this.TxtAntiguedad.Name = "TxtAntiguedad";
            this.TxtAntiguedad.Size = new System.Drawing.Size(64, 28);
            this.TxtAntiguedad.TabIndex = 65;
            this.TxtAntiguedad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblObservaciones
            // 
            this.LblObservaciones.AutoSize = true;
            this.LblObservaciones.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObservaciones.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblObservaciones.Location = new System.Drawing.Point(20, 133);
            this.LblObservaciones.Name = "LblObservaciones";
            this.LblObservaciones.Size = new System.Drawing.Size(125, 20);
            this.LblObservaciones.TabIndex = 64;
            this.LblObservaciones.Text = "Observaciones:";
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.Enabled = false;
            this.TxtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObservaciones.Location = new System.Drawing.Point(158, 133);
            this.TxtObservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtObservaciones.MaxLength = 0;
            this.TxtObservaciones.Multiline = true;
            this.TxtObservaciones.Name = "TxtObservaciones";
            this.TxtObservaciones.Size = new System.Drawing.Size(732, 58);
            this.TxtObservaciones.TabIndex = 63;
            // 
            // DtpFechaRetorno
            // 
            this.DtpFechaRetorno.CustomFormat = "yyyy/MM/dd";
            this.DtpFechaRetorno.Enabled = false;
            this.DtpFechaRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaRetorno.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaRetorno.Location = new System.Drawing.Point(485, 96);
            this.DtpFechaRetorno.Name = "DtpFechaRetorno";
            this.DtpFechaRetorno.Size = new System.Drawing.Size(138, 27);
            this.DtpFechaRetorno.TabIndex = 62;
            this.DtpFechaRetorno.Value = new System.DateTime(2021, 1, 25, 0, 0, 0, 0);
            this.DtpFechaRetorno.Validated += new System.EventHandler(this.DtpFechaRetorno_Validated);
            // 
            // LblFechaRetorno
            // 
            this.LblFechaRetorno.AutoSize = true;
            this.LblFechaRetorno.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaRetorno.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblFechaRetorno.Location = new System.Drawing.Point(352, 100);
            this.LblFechaRetorno.Name = "LblFechaRetorno";
            this.LblFechaRetorno.Size = new System.Drawing.Size(121, 20);
            this.LblFechaRetorno.TabIndex = 61;
            this.LblFechaRetorno.Text = "Fecha Retorno:";
            // 
            // TxtIdRegistro
            // 
            this.TxtIdRegistro.Enabled = false;
            this.TxtIdRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdRegistro.Location = new System.Drawing.Point(76, 23);
            this.TxtIdRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtIdRegistro.MaxLength = 15;
            this.TxtIdRegistro.Name = "TxtIdRegistro";
            this.TxtIdRegistro.Size = new System.Drawing.Size(64, 28);
            this.TxtIdRegistro.TabIndex = 60;
            // 
            // LblIdRegistro
            // 
            this.LblIdRegistro.AutoSize = true;
            this.LblIdRegistro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdRegistro.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblIdRegistro.Location = new System.Drawing.Point(39, 26);
            this.LblIdRegistro.Name = "LblIdRegistro";
            this.LblIdRegistro.Size = new System.Drawing.Size(28, 20);
            this.LblIdRegistro.TabIndex = 59;
            this.LblIdRegistro.Text = "Id:";
            // 
            // BtnRegistroCancelar
            // 
            this.BtnRegistroCancelar.ActiveBorderThickness = 1;
            this.BtnRegistroCancelar.ActiveCornerRadius = 20;
            this.BtnRegistroCancelar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnRegistroCancelar.ActiveForecolor = System.Drawing.Color.White;
            this.BtnRegistroCancelar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnRegistroCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnRegistroCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegistroCancelar.BackgroundImage")));
            this.BtnRegistroCancelar.ButtonText = "CANCELAR";
            this.BtnRegistroCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistroCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistroCancelar.ForeColor = System.Drawing.Color.DarkGray;
            this.BtnRegistroCancelar.IdleBorderThickness = 1;
            this.BtnRegistroCancelar.IdleCornerRadius = 20;
            this.BtnRegistroCancelar.IdleFillColor = System.Drawing.Color.Black;
            this.BtnRegistroCancelar.IdleForecolor = System.Drawing.Color.DarkKhaki;
            this.BtnRegistroCancelar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnRegistroCancelar.Location = new System.Drawing.Point(1078, 75);
            this.BtnRegistroCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnRegistroCancelar.Name = "BtnRegistroCancelar";
            this.BtnRegistroCancelar.Size = new System.Drawing.Size(140, 60);
            this.BtnRegistroCancelar.TabIndex = 53;
            this.BtnRegistroCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnRegistroCancelar.Click += new System.EventHandler(this.BtnRegistroCancelar_Click);
            // 
            // BtnRegistroGrabar
            // 
            this.BtnRegistroGrabar.ActiveBorderThickness = 1;
            this.BtnRegistroGrabar.ActiveCornerRadius = 20;
            this.BtnRegistroGrabar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnRegistroGrabar.ActiveForecolor = System.Drawing.Color.White;
            this.BtnRegistroGrabar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnRegistroGrabar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnRegistroGrabar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegistroGrabar.BackgroundImage")));
            this.BtnRegistroGrabar.ButtonText = "GRABAR";
            this.BtnRegistroGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistroGrabar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistroGrabar.ForeColor = System.Drawing.Color.DarkGray;
            this.BtnRegistroGrabar.IdleBorderThickness = 1;
            this.BtnRegistroGrabar.IdleCornerRadius = 20;
            this.BtnRegistroGrabar.IdleFillColor = System.Drawing.Color.Black;
            this.BtnRegistroGrabar.IdleForecolor = System.Drawing.Color.DarkKhaki;
            this.BtnRegistroGrabar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnRegistroGrabar.Location = new System.Drawing.Point(928, 75);
            this.BtnRegistroGrabar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnRegistroGrabar.Name = "BtnRegistroGrabar";
            this.BtnRegistroGrabar.Size = new System.Drawing.Size(140, 60);
            this.BtnRegistroGrabar.TabIndex = 52;
            this.BtnRegistroGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnRegistroGrabar.Click += new System.EventHandler(this.BtnRegistroGrabar_Click);
            // 
            // BtnRegistroEliminar
            // 
            this.BtnRegistroEliminar.ActiveBorderThickness = 1;
            this.BtnRegistroEliminar.ActiveCornerRadius = 20;
            this.BtnRegistroEliminar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnRegistroEliminar.ActiveForecolor = System.Drawing.Color.White;
            this.BtnRegistroEliminar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnRegistroEliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnRegistroEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegistroEliminar.BackgroundImage")));
            this.BtnRegistroEliminar.ButtonText = "ELIMINAR";
            this.BtnRegistroEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistroEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistroEliminar.ForeColor = System.Drawing.Color.DarkGray;
            this.BtnRegistroEliminar.IdleBorderThickness = 1;
            this.BtnRegistroEliminar.IdleCornerRadius = 20;
            this.BtnRegistroEliminar.IdleFillColor = System.Drawing.Color.Black;
            this.BtnRegistroEliminar.IdleForecolor = System.Drawing.Color.DarkKhaki;
            this.BtnRegistroEliminar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnRegistroEliminar.Location = new System.Drawing.Point(1078, 17);
            this.BtnRegistroEliminar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnRegistroEliminar.Name = "BtnRegistroEliminar";
            this.BtnRegistroEliminar.Size = new System.Drawing.Size(140, 60);
            this.BtnRegistroEliminar.TabIndex = 51;
            this.BtnRegistroEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnRegistroEliminar.Click += new System.EventHandler(this.BtnRegistroEliminar_Click);
            // 
            // BtnRegistroNuevo
            // 
            this.BtnRegistroNuevo.ActiveBorderThickness = 1;
            this.BtnRegistroNuevo.ActiveCornerRadius = 20;
            this.BtnRegistroNuevo.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnRegistroNuevo.ActiveForecolor = System.Drawing.Color.White;
            this.BtnRegistroNuevo.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnRegistroNuevo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnRegistroNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegistroNuevo.BackgroundImage")));
            this.BtnRegistroNuevo.ButtonText = "NUEVO";
            this.BtnRegistroNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistroNuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistroNuevo.ForeColor = System.Drawing.Color.DarkGray;
            this.BtnRegistroNuevo.IdleBorderThickness = 1;
            this.BtnRegistroNuevo.IdleCornerRadius = 20;
            this.BtnRegistroNuevo.IdleFillColor = System.Drawing.Color.Black;
            this.BtnRegistroNuevo.IdleForecolor = System.Drawing.Color.DarkKhaki;
            this.BtnRegistroNuevo.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnRegistroNuevo.Location = new System.Drawing.Point(928, 17);
            this.BtnRegistroNuevo.Margin = new System.Windows.Forms.Padding(5);
            this.BtnRegistroNuevo.Name = "BtnRegistroNuevo";
            this.BtnRegistroNuevo.Size = new System.Drawing.Size(140, 60);
            this.BtnRegistroNuevo.TabIndex = 49;
            this.BtnRegistroNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnRegistroNuevo.Click += new System.EventHandler(this.BtnRegistroNuevo_Click);
            // 
            // TxtDiasTomados
            // 
            this.TxtDiasTomados.Enabled = false;
            this.TxtDiasTomados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDiasTomados.Location = new System.Drawing.Point(826, 95);
            this.TxtDiasTomados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDiasTomados.MaxLength = 10;
            this.TxtDiasTomados.Name = "TxtDiasTomados";
            this.TxtDiasTomados.Size = new System.Drawing.Size(64, 28);
            this.TxtDiasTomados.TabIndex = 47;
            this.TxtDiasTomados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblDiasTomados
            // 
            this.LblDiasTomados.AutoSize = true;
            this.LblDiasTomados.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDiasTomados.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblDiasTomados.Location = new System.Drawing.Point(699, 99);
            this.LblDiasTomados.Name = "LblDiasTomados";
            this.LblDiasTomados.Size = new System.Drawing.Size(111, 20);
            this.LblDiasTomados.TabIndex = 48;
            this.LblDiasTomados.Text = "Dias Tomados:";
            // 
            // DtpFechaSalida
            // 
            this.DtpFechaSalida.CustomFormat = "yyyy/MM/dd";
            this.DtpFechaSalida.Enabled = false;
            this.DtpFechaSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaSalida.Location = new System.Drawing.Point(158, 96);
            this.DtpFechaSalida.Name = "DtpFechaSalida";
            this.DtpFechaSalida.Size = new System.Drawing.Size(138, 27);
            this.DtpFechaSalida.TabIndex = 46;
            this.DtpFechaSalida.Value = new System.DateTime(2021, 1, 25, 0, 0, 0, 0);
            this.DtpFechaSalida.Validated += new System.EventHandler(this.DtpFechaSalida_Validated);
            // 
            // LblFechaSalida
            // 
            this.LblFechaSalida.AutoSize = true;
            this.LblFechaSalida.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaSalida.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblFechaSalida.Location = new System.Drawing.Point(39, 100);
            this.LblFechaSalida.Name = "LblFechaSalida";
            this.LblFechaSalida.Size = new System.Drawing.Size(106, 20);
            this.LblFechaSalida.TabIndex = 45;
            this.LblFechaSalida.Text = "Fecha Salida:";
            // 
            // CmbRegistroNombre
            // 
            this.CmbRegistroNombre.Enabled = false;
            this.CmbRegistroNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbRegistroNombre.FormattingEnabled = true;
            this.CmbRegistroNombre.Location = new System.Drawing.Point(295, 23);
            this.CmbRegistroNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbRegistroNombre.Name = "CmbRegistroNombre";
            this.CmbRegistroNombre.Size = new System.Drawing.Size(595, 28);
            this.CmbRegistroNombre.TabIndex = 43;
            this.CmbRegistroNombre.SelectedIndexChanged += new System.EventHandler(this.CmbRegistroNombre_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CmbFiltroRegistroBuscar);
            this.groupBox4.Controls.Add(this.BtnFiltroRegistroBuscar);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(10, 208);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(1236, 62);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filtros:";
            // 
            // CmbFiltroRegistroBuscar
            // 
            this.CmbFiltroRegistroBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFiltroRegistroBuscar.FormattingEnabled = true;
            this.CmbFiltroRegistroBuscar.Location = new System.Drawing.Point(91, 20);
            this.CmbFiltroRegistroBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbFiltroRegistroBuscar.Name = "CmbFiltroRegistroBuscar";
            this.CmbFiltroRegistroBuscar.Size = new System.Drawing.Size(535, 28);
            this.CmbFiltroRegistroBuscar.TabIndex = 38;
            // 
            // BtnFiltroRegistroBuscar
            // 
            this.BtnFiltroRegistroBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnFiltroRegistroBuscar.Location = new System.Drawing.Point(642, 15);
            this.BtnFiltroRegistroBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnFiltroRegistroBuscar.Name = "BtnFiltroRegistroBuscar";
            this.BtnFiltroRegistroBuscar.Size = new System.Drawing.Size(102, 38);
            this.BtnFiltroRegistroBuscar.TabIndex = 3;
            this.BtnFiltroRegistroBuscar.Text = "Buscar...";
            this.BtnFiltroRegistroBuscar.UseVisualStyleBackColor = false;
            this.BtnFiltroRegistroBuscar.Click += new System.EventHandler(this.BtnFiltroRegistroBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // DgvRegistroVacaciones
            // 
            this.DgvRegistroVacaciones.AllowUserToDeleteRows = false;
            this.DgvRegistroVacaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvRegistroVacaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvRegistroVacaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.DgvRegistroVacaciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvRegistroVacaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRegistroVacaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvRegistroVacaciones.ColumnHeadersHeight = 30;
            this.DgvRegistroVacaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRegistroVacaciones.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgvRegistroVacaciones.EnableHeadersVisualStyles = false;
            this.DgvRegistroVacaciones.GridColor = System.Drawing.Color.SteelBlue;
            this.DgvRegistroVacaciones.Location = new System.Drawing.Point(9, 274);
            this.DgvRegistroVacaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvRegistroVacaciones.Name = "DgvRegistroVacaciones";
            this.DgvRegistroVacaciones.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRegistroVacaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvRegistroVacaciones.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.DgvRegistroVacaciones.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvRegistroVacaciones.RowTemplate.Height = 24;
            this.DgvRegistroVacaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvRegistroVacaciones.Size = new System.Drawing.Size(1237, 425);
            this.DgvRegistroVacaciones.TabIndex = 45;
            this.DgvRegistroVacaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRegistroVacaciones_CellClick);
            // 
            // FrmMantenimientoVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1282, 763);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmMantenimientoVacaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Vacaciones";
            this.Load += new System.EventHandler(this.FrmMantenimientoVacaciones_Load);
            this.tabControl1.ResumeLayout(false);
            this.TpgEmpleados.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleados)).EndInit();
            this.TpgRegistro.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegistroVacaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TpgEmpleados;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnEmpleadoReportes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnFiltroEmpleadoBuscar;
        private System.Windows.Forms.TextBox TxtFiltroEmpleadoBuscar;
        private System.Windows.Forms.Label LblFiltroNombre;
        private System.Windows.Forms.DataGridView DgvEmpleados;
        private System.Windows.Forms.TabPage TpgRegistro;
        private System.Windows.Forms.GroupBox groupBox5;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnRegistroCancelar;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnRegistroGrabar;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnRegistroEliminar;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnRegistroNuevo;
        private System.Windows.Forms.TextBox TxtDiasTomados;
        private System.Windows.Forms.Label LblDiasTomados;
        private System.Windows.Forms.DateTimePicker DtpFechaSalida;
        private System.Windows.Forms.Label LblFechaSalida;
        private System.Windows.Forms.ComboBox CmbRegistroNombre;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox CmbFiltroRegistroBuscar;
        private System.Windows.Forms.Button BtnFiltroRegistroBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvRegistroVacaciones;
        private System.Windows.Forms.TextBox TxtIdRegistro;
        private System.Windows.Forms.Label LblIdRegistro;
        private System.Windows.Forms.Label LblObservaciones;
        private System.Windows.Forms.TextBox TxtObservaciones;
        private System.Windows.Forms.DateTimePicker DtpFechaRetorno;
        private System.Windows.Forms.Label LblFechaRetorno;
        private System.Windows.Forms.TextBox TxtSaldo;
        private System.Windows.Forms.TextBox TxtDiasPorAnio;
        private System.Windows.Forms.TextBox TxtAntiguedad;
        private System.Windows.Forms.Label LblDiasPendiente;
        private System.Windows.Forms.Label LblDiasPorAnio;
        private System.Windows.Forms.Label LblAntiguedad;
        private System.Windows.Forms.Label LblRegistroNombre;
        private System.Windows.Forms.DateTimePicker DtpRegistroFechaEntrada;
        private System.Windows.Forms.Label LblRegistroFechaEntrada;
        private System.Windows.Forms.Button BtnImprimirSolicitud;
    }
}