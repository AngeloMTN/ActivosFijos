
namespace ActivosFijos.Formularios
{
    partial class FrmMantenimientoEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantenimientoEmpleados));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnFiltroBuscar = new System.Windows.Forms.Button();
            this.TxtFiltroNombre = new System.Windows.Forms.TextBox();
            this.LblFiltroNombre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DtpFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.LblFechaEntrada = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.LblCedula = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.DgvEmpleados = new System.Windows.Forms.DataGridView();
            this.BtnGrabar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnEliminar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnModificar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnNuevo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnFiltroBuscar);
            this.groupBox2.Controls.Add(this.TxtFiltroNombre);
            this.groupBox2.Controls.Add(this.LblFiltroNombre);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 108);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(755, 63);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros de búsqueda:";
            // 
            // BtnFiltroBuscar
            // 
            this.BtnFiltroBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnFiltroBuscar.ForeColor = System.Drawing.Color.Black;
            this.BtnFiltroBuscar.Location = new System.Drawing.Point(659, 16);
            this.BtnFiltroBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnFiltroBuscar.Name = "BtnFiltroBuscar";
            this.BtnFiltroBuscar.Size = new System.Drawing.Size(91, 39);
            this.BtnFiltroBuscar.TabIndex = 2;
            this.BtnFiltroBuscar.Text = "Buscar...";
            this.BtnFiltroBuscar.UseVisualStyleBackColor = false;
            this.BtnFiltroBuscar.Click += new System.EventHandler(this.BtnFiltroBuscar_Click);
            // 
            // TxtFiltroNombre
            // 
            this.TxtFiltroNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFiltroNombre.Location = new System.Drawing.Point(77, 25);
            this.TxtFiltroNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtFiltroNombre.Name = "TxtFiltroNombre";
            this.TxtFiltroNombre.Size = new System.Drawing.Size(560, 28);
            this.TxtFiltroNombre.TabIndex = 1;
            // 
            // LblFiltroNombre
            // 
            this.LblFiltroNombre.AutoSize = true;
            this.LblFiltroNombre.Location = new System.Drawing.Point(5, 28);
            this.LblFiltroNombre.Name = "LblFiltroNombre";
            this.LblFiltroNombre.Size = new System.Drawing.Size(72, 20);
            this.LblFiltroNombre.TabIndex = 0;
            this.LblFiltroNombre.Text = "Nombre:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DtpFechaEntrada);
            this.groupBox1.Controls.Add(this.LblFechaEntrada);
            this.groupBox1.Controls.Add(this.TxtCedula);
            this.groupBox1.Controls.Add(this.LblCedula);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.TxtId);
            this.groupBox1.Controls.Add(this.LblNombre);
            this.groupBox1.Controls.Add(this.LblId);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(755, 93);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // DtpFechaEntrada
            // 
            this.DtpFechaEntrada.CustomFormat = "yyyy/MM/dd";
            this.DtpFechaEntrada.Enabled = false;
            this.DtpFechaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaEntrada.Location = new System.Drawing.Point(580, 20);
            this.DtpFechaEntrada.Name = "DtpFechaEntrada";
            this.DtpFechaEntrada.Size = new System.Drawing.Size(138, 27);
            this.DtpFechaEntrada.TabIndex = 10;
            this.DtpFechaEntrada.Value = new System.DateTime(2021, 1, 21, 0, 0, 0, 0);
            // 
            // LblFechaEntrada
            // 
            this.LblFechaEntrada.AutoSize = true;
            this.LblFechaEntrada.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaEntrada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblFechaEntrada.Location = new System.Drawing.Point(440, 26);
            this.LblFechaEntrada.Name = "LblFechaEntrada";
            this.LblFechaEntrada.Size = new System.Drawing.Size(120, 20);
            this.LblFechaEntrada.TabIndex = 57;
            this.LblFechaEntrada.Text = "Fecha Entrada:";
            // 
            // TxtCedula
            // 
            this.TxtCedula.Enabled = false;
            this.TxtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCedula.Location = new System.Drawing.Point(273, 19);
            this.TxtCedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCedula.MaxLength = 15;
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(135, 28);
            this.TxtCedula.TabIndex = 8;
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCedula.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblCedula.Location = new System.Drawing.Point(190, 23);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(67, 20);
            this.LblCedula.TabIndex = 55;
            this.LblCedula.Text = "Cedula:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Enabled = false;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(100, 56);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNombre.MaxLength = 50;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(618, 28);
            this.TxtNombre.TabIndex = 9;
            // 
            // TxtId
            // 
            this.TxtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TxtId.Enabled = false;
            this.TxtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(100, 19);
            this.TxtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtId.MaxLength = 10;
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(67, 28);
            this.TxtId.TabIndex = 3;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(16, 61);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(72, 20);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(60, 26);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(28, 20);
            this.LblId.TabIndex = 0;
            this.LblId.Text = "Id:";
            // 
            // DgvEmpleados
            // 
            this.DgvEmpleados.AllowUserToDeleteRows = false;
            this.DgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.DgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.DgvEmpleados.Location = new System.Drawing.Point(12, 175);
            this.DgvEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvEmpleados.Name = "DgvEmpleados";
            this.DgvEmpleados.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvEmpleados.RowTemplate.Height = 24;
            this.DgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEmpleados.Size = new System.Drawing.Size(755, 521);
            this.DgvEmpleados.TabIndex = 11;
            this.DgvEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmpleados_CellClick);
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
            this.BtnGrabar.Location = new System.Drawing.Point(625, 703);
            this.BtnGrabar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(140, 60);
            this.BtnGrabar.TabIndex = 7;
            this.BtnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
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
            this.BtnCancelar.Location = new System.Drawing.Point(471, 703);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(140, 60);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.ActiveBorderThickness = 1;
            this.BtnEliminar.ActiveCornerRadius = 20;
            this.BtnEliminar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnEliminar.ActiveForecolor = System.Drawing.Color.White;
            this.BtnEliminar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.BackgroundImage")));
            this.BtnEliminar.ButtonText = "ELIMINAR";
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.DarkGray;
            this.BtnEliminar.IdleBorderThickness = 1;
            this.BtnEliminar.IdleCornerRadius = 20;
            this.BtnEliminar.IdleFillColor = System.Drawing.Color.Black;
            this.BtnEliminar.IdleForecolor = System.Drawing.Color.DarkKhaki;
            this.BtnEliminar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnEliminar.Location = new System.Drawing.Point(321, 703);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(140, 60);
            this.BtnEliminar.TabIndex = 5;
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.ActiveBorderThickness = 1;
            this.BtnModificar.ActiveCornerRadius = 20;
            this.BtnModificar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnModificar.ActiveForecolor = System.Drawing.Color.White;
            this.BtnModificar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnModificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnModificar.BackgroundImage")));
            this.BtnModificar.ButtonText = "MODIFICAR";
            this.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.DarkGray;
            this.BtnModificar.IdleBorderThickness = 1;
            this.BtnModificar.IdleCornerRadius = 20;
            this.BtnModificar.IdleFillColor = System.Drawing.Color.Black;
            this.BtnModificar.IdleForecolor = System.Drawing.Color.DarkKhaki;
            this.BtnModificar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnModificar.Location = new System.Drawing.Point(171, 703);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(140, 60);
            this.BtnModificar.TabIndex = 4;
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
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
            this.BtnNuevo.Location = new System.Drawing.Point(21, 703);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(5);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(140, 60);
            this.BtnNuevo.TabIndex = 3;
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // FrmMantenimientoEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(788, 763);
            this.Controls.Add(this.BtnGrabar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvEmpleados);
            this.Name = "FrmMantenimientoEmpleados";
            this.Text = "Mantenimiento Empleados";
            this.Load += new System.EventHandler(this.FrmMantenimientoEmpleados_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnFiltroBuscar;
        private System.Windows.Forms.TextBox TxtFiltroNombre;
        private System.Windows.Forms.Label LblFiltroNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.DataGridView DgvEmpleados;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnGrabar;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnCancelar;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnEliminar;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnModificar;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnNuevo;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label LblCedula;
        private System.Windows.Forms.DateTimePicker DtpFechaEntrada;
        private System.Windows.Forms.Label LblFechaEntrada;
    }
}