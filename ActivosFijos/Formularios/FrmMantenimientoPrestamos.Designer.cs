
namespace ActivosFijos.Formularios
{
    partial class FrmMantenimientoPrestamos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantenimientoPrestamos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TpgResumen = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnFiltroEmpleadoBuscar = new System.Windows.Forms.Button();
            this.TxtFiltroEmpleadoBuscar = new System.Windows.Forms.TextBox();
            this.LblFiltroNombre = new System.Windows.Forms.Label();
            this.DgvEmpleados = new System.Windows.Forms.DataGridView();
            this.TpgRegistro = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.RbtAbono = new System.Windows.Forms.RadioButton();
            this.RbtPrestamo = new System.Windows.Forms.RadioButton();
            this.GbxAbono = new System.Windows.Forms.GroupBox();
            this.TxtValorAbono = new System.Windows.Forms.TextBox();
            this.LblValorAbono = new System.Windows.Forms.Label();
            this.DtpFechaAbono = new System.Windows.Forms.DateTimePicker();
            this.LblFechaAbono = new System.Windows.Forms.Label();
            this.GbxPrestamo = new System.Windows.Forms.GroupBox();
            this.TxtValorCuota = new System.Windows.Forms.TextBox();
            this.LblValorCuota = new System.Windows.Forms.Label();
            this.TxtValorPrestamo = new System.Windows.Forms.TextBox();
            this.DtpFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.LblFechaPrestamo = new System.Windows.Forms.Label();
            this.LblNumeroCuotas = new System.Windows.Forms.Label();
            this.LblValorPrestamo = new System.Windows.Forms.Label();
            this.TxtNumeroCuotas = new System.Windows.Forms.TextBox();
            this.LblRegistroNombre = new System.Windows.Forms.Label();
            this.LblObservaciones = new System.Windows.Forms.Label();
            this.TxtObservaciones = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnGrabar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnNuevo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.CmbNombre = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnReporte = new Bunifu.Framework.UI.BunifuThinButton2();
            this.CmbFiltroBuscar = new System.Windows.Forms.ComboBox();
            this.BtnFiltroBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvPrestamos = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.TpgResumen.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleados)).BeginInit();
            this.TpgRegistro.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.GbxAbono.SuspendLayout();
            this.GbxPrestamo.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.TpgResumen);
            this.tabControl1.Controls.Add(this.TpgRegistro);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(56, 30);
            this.tabControl1.Location = new System.Drawing.Point(9, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1265, 747);
            this.tabControl1.TabIndex = 24;
            // 
            // TpgResumen
            // 
            this.TpgResumen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TpgResumen.Controls.Add(this.groupBox2);
            this.TpgResumen.Controls.Add(this.DgvEmpleados);
            this.TpgResumen.Location = new System.Drawing.Point(4, 34);
            this.TpgResumen.Name = "TpgResumen";
            this.TpgResumen.Size = new System.Drawing.Size(1257, 709);
            this.TpgResumen.TabIndex = 3;
            this.TpgResumen.Text = "Resumen";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnFiltroEmpleadoBuscar);
            this.groupBox2.Controls.Add(this.TxtFiltroEmpleadoBuscar);
            this.groupBox2.Controls.Add(this.LblFiltroNombre);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1236, 60);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros:";
            // 
            // BtnFiltroEmpleadoBuscar
            // 
            this.BtnFiltroEmpleadoBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnFiltroEmpleadoBuscar.Location = new System.Drawing.Point(651, 15);
            this.BtnFiltroEmpleadoBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnFiltroEmpleadoBuscar.Name = "BtnFiltroEmpleadoBuscar";
            this.BtnFiltroEmpleadoBuscar.Size = new System.Drawing.Size(102, 38);
            this.BtnFiltroEmpleadoBuscar.TabIndex = 3;
            this.BtnFiltroEmpleadoBuscar.Text = "Buscar...";
            this.BtnFiltroEmpleadoBuscar.UseVisualStyleBackColor = false;
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
            this.DgvEmpleados.EnableHeadersVisualStyles = false;
            this.DgvEmpleados.GridColor = System.Drawing.Color.SteelBlue;
            this.DgvEmpleados.Location = new System.Drawing.Point(10, 81);
            this.DgvEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvEmpleados.Name = "DgvEmpleados";
            this.DgvEmpleados.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvEmpleados.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DgvEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvEmpleados.RowTemplate.Height = 24;
            this.DgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEmpleados.Size = new System.Drawing.Size(1237, 611);
            this.DgvEmpleados.TabIndex = 24;
            // 
            // TpgRegistro
            // 
            this.TpgRegistro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TpgRegistro.Controls.Add(this.groupBox5);
            this.TpgRegistro.Controls.Add(this.groupBox4);
            this.TpgRegistro.Controls.Add(this.DgvPrestamos);
            this.TpgRegistro.Location = new System.Drawing.Point(4, 34);
            this.TpgRegistro.Name = "TpgRegistro";
            this.TpgRegistro.Size = new System.Drawing.Size(1257, 709);
            this.TpgRegistro.TabIndex = 2;
            this.TpgRegistro.Text = "Registro";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.RbtAbono);
            this.groupBox5.Controls.Add(this.RbtPrestamo);
            this.groupBox5.Controls.Add(this.GbxAbono);
            this.groupBox5.Controls.Add(this.GbxPrestamo);
            this.groupBox5.Controls.Add(this.LblRegistroNombre);
            this.groupBox5.Controls.Add(this.LblObservaciones);
            this.groupBox5.Controls.Add(this.TxtObservaciones);
            this.groupBox5.Controls.Add(this.BtnCancelar);
            this.groupBox5.Controls.Add(this.BtnGrabar);
            this.groupBox5.Controls.Add(this.BtnNuevo);
            this.groupBox5.Controls.Add(this.CmbNombre);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(9, 2);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(1237, 208);
            this.groupBox5.TabIndex = 47;
            this.groupBox5.TabStop = false;
            // 
            // RbtAbono
            // 
            this.RbtAbono.AutoSize = true;
            this.RbtAbono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtAbono.ForeColor = System.Drawing.Color.Gold;
            this.RbtAbono.Location = new System.Drawing.Point(161, 19);
            this.RbtAbono.Name = "RbtAbono";
            this.RbtAbono.Size = new System.Drawing.Size(107, 27);
            this.RbtAbono.TabIndex = 1;
            this.RbtAbono.Text = "ABONO";
            this.RbtAbono.UseVisualStyleBackColor = true;
            this.RbtAbono.CheckedChanged += new System.EventHandler(this.RbtAbono_CheckedChanged);
            // 
            // RbtPrestamo
            // 
            this.RbtPrestamo.AutoSize = true;
            this.RbtPrestamo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtPrestamo.ForeColor = System.Drawing.Color.Gold;
            this.RbtPrestamo.Location = new System.Drawing.Point(13, 19);
            this.RbtPrestamo.Name = "RbtPrestamo";
            this.RbtPrestamo.Size = new System.Drawing.Size(132, 27);
            this.RbtPrestamo.TabIndex = 2;
            this.RbtPrestamo.Text = "PRESTAMO";
            this.RbtPrestamo.UseVisualStyleBackColor = true;
            this.RbtPrestamo.CheckedChanged += new System.EventHandler(this.RbtPrestamo_CheckedChanged);
            // 
            // GbxAbono
            // 
            this.GbxAbono.Controls.Add(this.TxtValorAbono);
            this.GbxAbono.Controls.Add(this.LblValorAbono);
            this.GbxAbono.Controls.Add(this.DtpFechaAbono);
            this.GbxAbono.Controls.Add(this.LblFechaAbono);
            this.GbxAbono.Location = new System.Drawing.Point(581, 47);
            this.GbxAbono.Name = "GbxAbono";
            this.GbxAbono.Size = new System.Drawing.Size(294, 86);
            this.GbxAbono.TabIndex = 81;
            this.GbxAbono.TabStop = false;
            // 
            // TxtValorAbono
            // 
            this.TxtValorAbono.Enabled = false;
            this.TxtValorAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorAbono.Location = new System.Drawing.Point(134, 48);
            this.TxtValorAbono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtValorAbono.Name = "TxtValorAbono";
            this.TxtValorAbono.Size = new System.Drawing.Size(139, 28);
            this.TxtValorAbono.TabIndex = 8;
            this.TxtValorAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtValorAbono.Validated += new System.EventHandler(this.TxtValorAbono_Validated);
            // 
            // LblValorAbono
            // 
            this.LblValorAbono.AutoSize = true;
            this.LblValorAbono.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorAbono.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblValorAbono.Location = new System.Drawing.Point(20, 52);
            this.LblValorAbono.Name = "LblValorAbono";
            this.LblValorAbono.Size = new System.Drawing.Size(106, 20);
            this.LblValorAbono.TabIndex = 82;
            this.LblValorAbono.Text = "Valor Abono:";
            // 
            // DtpFechaAbono
            // 
            this.DtpFechaAbono.CustomFormat = "yyyy/MM/dd";
            this.DtpFechaAbono.Enabled = false;
            this.DtpFechaAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaAbono.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaAbono.Location = new System.Drawing.Point(135, 17);
            this.DtpFechaAbono.Name = "DtpFechaAbono";
            this.DtpFechaAbono.Size = new System.Drawing.Size(138, 27);
            this.DtpFechaAbono.TabIndex = 7;
            this.DtpFechaAbono.Value = new System.DateTime(2021, 1, 25, 0, 0, 0, 0);
            // 
            // LblFechaAbono
            // 
            this.LblFechaAbono.AutoSize = true;
            this.LblFechaAbono.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaAbono.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblFechaAbono.Location = new System.Drawing.Point(13, 22);
            this.LblFechaAbono.Name = "LblFechaAbono";
            this.LblFechaAbono.Size = new System.Drawing.Size(113, 20);
            this.LblFechaAbono.TabIndex = 80;
            this.LblFechaAbono.Text = "Fecha Abono:";
            // 
            // GbxPrestamo
            // 
            this.GbxPrestamo.Controls.Add(this.TxtValorCuota);
            this.GbxPrestamo.Controls.Add(this.LblValorCuota);
            this.GbxPrestamo.Controls.Add(this.TxtValorPrestamo);
            this.GbxPrestamo.Controls.Add(this.DtpFechaPrestamo);
            this.GbxPrestamo.Controls.Add(this.LblFechaPrestamo);
            this.GbxPrestamo.Controls.Add(this.LblNumeroCuotas);
            this.GbxPrestamo.Controls.Add(this.LblValorPrestamo);
            this.GbxPrestamo.Controls.Add(this.TxtNumeroCuotas);
            this.GbxPrestamo.Location = new System.Drawing.Point(11, 48);
            this.GbxPrestamo.Name = "GbxPrestamo";
            this.GbxPrestamo.Size = new System.Drawing.Size(564, 86);
            this.GbxPrestamo.TabIndex = 80;
            this.GbxPrestamo.TabStop = false;
            // 
            // TxtValorCuota
            // 
            this.TxtValorCuota.Enabled = false;
            this.TxtValorCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorCuota.Location = new System.Drawing.Point(411, 49);
            this.TxtValorCuota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtValorCuota.Name = "TxtValorCuota";
            this.TxtValorCuota.Size = new System.Drawing.Size(139, 28);
            this.TxtValorCuota.TabIndex = 6;
            this.TxtValorCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtValorCuota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorCuota_KeyPress);
            this.TxtValorCuota.Validated += new System.EventHandler(this.TxtValorCuota_Validated);
            // 
            // LblValorCuota
            // 
            this.LblValorCuota.AutoSize = true;
            this.LblValorCuota.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorCuota.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblValorCuota.Location = new System.Drawing.Point(297, 53);
            this.LblValorCuota.Name = "LblValorCuota";
            this.LblValorCuota.Size = new System.Drawing.Size(102, 20);
            this.LblValorCuota.TabIndex = 84;
            this.LblValorCuota.Text = "Valor Cuota:";
            // 
            // TxtValorPrestamo
            // 
            this.TxtValorPrestamo.Enabled = false;
            this.TxtValorPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorPrestamo.Location = new System.Drawing.Point(147, 49);
            this.TxtValorPrestamo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtValorPrestamo.Name = "TxtValorPrestamo";
            this.TxtValorPrestamo.Size = new System.Drawing.Size(139, 28);
            this.TxtValorPrestamo.TabIndex = 5;
            this.TxtValorPrestamo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtValorPrestamo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorPrestamo_KeyPress);
            this.TxtValorPrestamo.Validated += new System.EventHandler(this.TxtValorPrestamo_Validated);
            // 
            // DtpFechaPrestamo
            // 
            this.DtpFechaPrestamo.CustomFormat = "yyyy/MM/dd";
            this.DtpFechaPrestamo.Enabled = false;
            this.DtpFechaPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaPrestamo.Location = new System.Drawing.Point(148, 18);
            this.DtpFechaPrestamo.Name = "DtpFechaPrestamo";
            this.DtpFechaPrestamo.Size = new System.Drawing.Size(138, 27);
            this.DtpFechaPrestamo.TabIndex = 4;
            this.DtpFechaPrestamo.Value = new System.DateTime(2021, 1, 25, 0, 0, 0, 0);
            // 
            // LblFechaPrestamo
            // 
            this.LblFechaPrestamo.AutoSize = true;
            this.LblFechaPrestamo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaPrestamo.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblFechaPrestamo.Location = new System.Drawing.Point(4, 21);
            this.LblFechaPrestamo.Name = "LblFechaPrestamo";
            this.LblFechaPrestamo.Size = new System.Drawing.Size(131, 20);
            this.LblFechaPrestamo.TabIndex = 81;
            this.LblFechaPrestamo.Text = "Fecha Prestamo:";
            // 
            // LblNumeroCuotas
            // 
            this.LblNumeroCuotas.AutoSize = true;
            this.LblNumeroCuotas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeroCuotas.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblNumeroCuotas.Location = new System.Drawing.Point(321, 21);
            this.LblNumeroCuotas.Name = "LblNumeroCuotas";
            this.LblNumeroCuotas.Size = new System.Drawing.Size(151, 20);
            this.LblNumeroCuotas.TabIndex = 80;
            this.LblNumeroCuotas.Text = "Numero de Cuotas:";
            // 
            // LblValorPrestamo
            // 
            this.LblValorPrestamo.AutoSize = true;
            this.LblValorPrestamo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorPrestamo.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblValorPrestamo.Location = new System.Drawing.Point(11, 53);
            this.LblValorPrestamo.Name = "LblValorPrestamo";
            this.LblValorPrestamo.Size = new System.Drawing.Size(124, 20);
            this.LblValorPrestamo.TabIndex = 79;
            this.LblValorPrestamo.Text = "Valor Prestamo:";
            // 
            // TxtNumeroCuotas
            // 
            this.TxtNumeroCuotas.Enabled = false;
            this.TxtNumeroCuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumeroCuotas.Location = new System.Drawing.Point(486, 17);
            this.TxtNumeroCuotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNumeroCuotas.MaxLength = 15;
            this.TxtNumeroCuotas.Name = "TxtNumeroCuotas";
            this.TxtNumeroCuotas.Size = new System.Drawing.Size(64, 28);
            this.TxtNumeroCuotas.TabIndex = 78;
            this.TxtNumeroCuotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblRegistroNombre
            // 
            this.LblRegistroNombre.AutoSize = true;
            this.LblRegistroNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistroNombre.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblRegistroNombre.Location = new System.Drawing.Point(292, 23);
            this.LblRegistroNombre.Name = "LblRegistroNombre";
            this.LblRegistroNombre.Size = new System.Drawing.Size(72, 20);
            this.LblRegistroNombre.TabIndex = 71;
            this.LblRegistroNombre.Text = "Nombre:";
            // 
            // LblObservaciones
            // 
            this.LblObservaciones.AutoSize = true;
            this.LblObservaciones.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObservaciones.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblObservaciones.Location = new System.Drawing.Point(20, 147);
            this.LblObservaciones.Name = "LblObservaciones";
            this.LblObservaciones.Size = new System.Drawing.Size(125, 20);
            this.LblObservaciones.TabIndex = 64;
            this.LblObservaciones.Text = "Observaciones:";
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.Enabled = false;
            this.TxtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObservaciones.Location = new System.Drawing.Point(158, 140);
            this.TxtObservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtObservaciones.MaxLength = 0;
            this.TxtObservaciones.Multiline = true;
            this.TxtObservaciones.Name = "TxtObservaciones";
            this.TxtObservaciones.Size = new System.Drawing.Size(717, 58);
            this.TxtObservaciones.TabIndex = 9;
            this.TxtObservaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtObservaciones_KeyPress);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.ActiveBorderThickness = 1;
            this.BtnCancelar.ActiveCornerRadius = 20;
            this.BtnCancelar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnCancelar.ActiveForecolor = System.Drawing.Color.White;
            this.BtnCancelar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.BackgroundImage")));
            this.BtnCancelar.ButtonText = "CANCELAR";
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.DarkGray;
            this.BtnCancelar.IdleBorderThickness = 1;
            this.BtnCancelar.IdleCornerRadius = 20;
            this.BtnCancelar.IdleFillColor = System.Drawing.Color.Black;
            this.BtnCancelar.IdleForecolor = System.Drawing.Color.DarkKhaki;
            this.BtnCancelar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnCancelar.Location = new System.Drawing.Point(1078, 133);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(140, 60);
            this.BtnCancelar.TabIndex = 53;
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.ActiveBorderThickness = 1;
            this.BtnGrabar.ActiveCornerRadius = 20;
            this.BtnGrabar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnGrabar.ActiveForecolor = System.Drawing.Color.White;
            this.BtnGrabar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnGrabar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnGrabar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGrabar.BackgroundImage")));
            this.BtnGrabar.ButtonText = "GRABAR";
            this.BtnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGrabar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGrabar.ForeColor = System.Drawing.Color.DarkGray;
            this.BtnGrabar.IdleBorderThickness = 1;
            this.BtnGrabar.IdleCornerRadius = 20;
            this.BtnGrabar.IdleFillColor = System.Drawing.Color.Black;
            this.BtnGrabar.IdleForecolor = System.Drawing.Color.DarkKhaki;
            this.BtnGrabar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnGrabar.Location = new System.Drawing.Point(928, 75);
            this.BtnGrabar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(140, 60);
            this.BtnGrabar.TabIndex = 52;
            this.BtnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.ActiveBorderThickness = 1;
            this.BtnNuevo.ActiveCornerRadius = 20;
            this.BtnNuevo.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnNuevo.ActiveForecolor = System.Drawing.Color.White;
            this.BtnNuevo.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnNuevo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.BackgroundImage")));
            this.BtnNuevo.ButtonText = "NUEVO";
            this.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.DarkGray;
            this.BtnNuevo.IdleBorderThickness = 1;
            this.BtnNuevo.IdleCornerRadius = 20;
            this.BtnNuevo.IdleFillColor = System.Drawing.Color.Black;
            this.BtnNuevo.IdleForecolor = System.Drawing.Color.DarkKhaki;
            this.BtnNuevo.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnNuevo.Location = new System.Drawing.Point(928, 17);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(5);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(140, 60);
            this.BtnNuevo.TabIndex = 49;
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // CmbNombre
            // 
            this.CmbNombre.Enabled = false;
            this.CmbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbNombre.FormattingEnabled = true;
            this.CmbNombre.Location = new System.Drawing.Point(370, 20);
            this.CmbNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbNombre.Name = "CmbNombre";
            this.CmbNombre.Size = new System.Drawing.Size(505, 28);
            this.CmbNombre.TabIndex = 3;
            this.CmbNombre.TextChanged += new System.EventHandler(this.CmbNombre_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnReporte);
            this.groupBox4.Controls.Add(this.CmbFiltroBuscar);
            this.groupBox4.Controls.Add(this.BtnFiltroBuscar);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(10, 208);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(1236, 70);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filtros:";
            // 
            // BtnReporte
            // 
            this.BtnReporte.ActiveBorderThickness = 1;
            this.BtnReporte.ActiveCornerRadius = 20;
            this.BtnReporte.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnReporte.ActiveForecolor = System.Drawing.Color.White;
            this.BtnReporte.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnReporte.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnReporte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnReporte.BackgroundImage")));
            this.BtnReporte.ButtonText = "REPORTE";
            this.BtnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporte.ForeColor = System.Drawing.Color.DarkGray;
            this.BtnReporte.IdleBorderThickness = 1;
            this.BtnReporte.IdleCornerRadius = 20;
            this.BtnReporte.IdleFillColor = System.Drawing.Color.Black;
            this.BtnReporte.IdleForecolor = System.Drawing.Color.DarkKhaki;
            this.BtnReporte.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnReporte.Location = new System.Drawing.Point(1047, 11);
            this.BtnReporte.Margin = new System.Windows.Forms.Padding(5);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(170, 53);
            this.BtnReporte.TabIndex = 45;
            this.BtnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // CmbFiltroBuscar
            // 
            this.CmbFiltroBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFiltroBuscar.FormattingEnabled = true;
            this.CmbFiltroBuscar.Location = new System.Drawing.Point(91, 20);
            this.CmbFiltroBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbFiltroBuscar.Name = "CmbFiltroBuscar";
            this.CmbFiltroBuscar.Size = new System.Drawing.Size(535, 28);
            this.CmbFiltroBuscar.TabIndex = 38;
            // 
            // BtnFiltroBuscar
            // 
            this.BtnFiltroBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnFiltroBuscar.Location = new System.Drawing.Point(642, 15);
            this.BtnFiltroBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnFiltroBuscar.Name = "BtnFiltroBuscar";
            this.BtnFiltroBuscar.Size = new System.Drawing.Size(102, 38);
            this.BtnFiltroBuscar.TabIndex = 3;
            this.BtnFiltroBuscar.Text = "Buscar...";
            this.BtnFiltroBuscar.UseVisualStyleBackColor = false;
            this.BtnFiltroBuscar.Click += new System.EventHandler(this.BtnFiltroBuscar_Click);
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
            // DgvPrestamos
            // 
            this.DgvPrestamos.AllowUserToDeleteRows = false;
            this.DgvPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvPrestamos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvPrestamos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.DgvPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvPrestamos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvPrestamos.ColumnHeadersHeight = 30;
            this.DgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvPrestamos.EnableHeadersVisualStyles = false;
            this.DgvPrestamos.GridColor = System.Drawing.Color.SteelBlue;
            this.DgvPrestamos.Location = new System.Drawing.Point(9, 285);
            this.DgvPrestamos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvPrestamos.Name = "DgvPrestamos";
            this.DgvPrestamos.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPrestamos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvPrestamos.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.DgvPrestamos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvPrestamos.RowTemplate.Height = 24;
            this.DgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPrestamos.Size = new System.Drawing.Size(1237, 414);
            this.DgvPrestamos.TabIndex = 45;
            // 
            // FrmMantenimientoPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1282, 763);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmMantenimientoPrestamos";
            this.Text = "Mantenimiento de Prestamos para Empleados";
            this.Load += new System.EventHandler(this.FrmMantenimientoPrestamos_Load);
            this.tabControl1.ResumeLayout(false);
            this.TpgResumen.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleados)).EndInit();
            this.TpgRegistro.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.GbxAbono.ResumeLayout(false);
            this.GbxAbono.PerformLayout();
            this.GbxPrestamo.ResumeLayout(false);
            this.GbxPrestamo.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrestamos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TpgRegistro;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label LblRegistroNombre;
        private System.Windows.Forms.Label LblObservaciones;
        private System.Windows.Forms.TextBox TxtObservaciones;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnCancelar;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnGrabar;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnNuevo;
        private System.Windows.Forms.ComboBox CmbNombre;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox CmbFiltroBuscar;
        private System.Windows.Forms.Button BtnFiltroBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvPrestamos;
        private System.Windows.Forms.RadioButton RbtAbono;
        private System.Windows.Forms.RadioButton RbtPrestamo;
        private System.Windows.Forms.GroupBox GbxAbono;
        private System.Windows.Forms.TextBox TxtValorAbono;
        private System.Windows.Forms.Label LblValorAbono;
        private System.Windows.Forms.DateTimePicker DtpFechaAbono;
        private System.Windows.Forms.Label LblFechaAbono;
        private System.Windows.Forms.GroupBox GbxPrestamo;
        private System.Windows.Forms.TextBox TxtValorCuota;
        private System.Windows.Forms.Label LblValorCuota;
        private System.Windows.Forms.TextBox TxtValorPrestamo;
        private System.Windows.Forms.DateTimePicker DtpFechaPrestamo;
        private System.Windows.Forms.Label LblFechaPrestamo;
        private System.Windows.Forms.Label LblNumeroCuotas;
        private System.Windows.Forms.Label LblValorPrestamo;
        private System.Windows.Forms.TextBox TxtNumeroCuotas;
        private System.Windows.Forms.TabPage TpgResumen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnFiltroEmpleadoBuscar;
        private System.Windows.Forms.TextBox TxtFiltroEmpleadoBuscar;
        private System.Windows.Forms.Label LblFiltroNombre;
        private System.Windows.Forms.DataGridView DgvEmpleados;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnReporte;
    }
}