namespace ActivosFijos.Formularios
{
    partial class FrmMantenimientoActivos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TpgListado = new System.Windows.Forms.TabPage();
            this.BtnReportes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnFiltroBuscar = new System.Windows.Forms.Button();
            this.CmbFiltroArea = new System.Windows.Forms.ComboBox();
            this.TxtFiltroNombre = new System.Windows.Forms.TextBox();
            this.LblFiltroArea = new System.Windows.Forms.Label();
            this.LblFiltroNombre = new System.Windows.Forms.Label();
            this.BtnVisualizar = new System.Windows.Forms.Button();
            this.DgvActivos = new System.Windows.Forms.DataGridView();
            this.TpgMantenimiento = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPctjeIva = new System.Windows.Forms.TextBox();
            this.LblPctjeIva = new System.Windows.Forms.Label();
            this.CmbPropietarios = new System.Windows.Forms.ComboBox();
            this.LblPropietario = new System.Windows.Forms.Label();
            this.DtpFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.TxtValorTotal = new System.Windows.Forms.TextBox();
            this.TxtValorIva = new System.Windows.Forms.TextBox();
            this.TxtValorBaseIva = new System.Windows.Forms.TextBox();
            this.TxtValorBase0 = new System.Windows.Forms.TextBox();
            this.LblFechaCompra = new System.Windows.Forms.Label();
            this.LblValorTotal = new System.Windows.Forms.Label();
            this.LblIva = new System.Windows.Forms.Label();
            this.LblBaseIva = new System.Windows.Forms.Label();
            this.LblBase0 = new System.Windows.Forms.Label();
            this.TxtObservaciones = new System.Windows.Forms.TextBox();
            this.LblObservaciones = new System.Windows.Forms.Label();
            this.TxtArchivo = new System.Windows.Forms.TextBox();
            this.LblArchivo = new System.Windows.Forms.Label();
            this.CmbArea = new System.Windows.Forms.ComboBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.LblArea = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.LblEstado = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.TpgListado.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvActivos)).BeginInit();
            this.TpgMantenimiento.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.TpgListado);
            this.tabControl1.Controls.Add(this.TpgMantenimiento);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(56, 30);
            this.tabControl1.Location = new System.Drawing.Point(4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1265, 747);
            this.tabControl1.TabIndex = 22;
            // 
            // TpgListado
            // 
            this.TpgListado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TpgListado.Controls.Add(this.BtnReportes);
            this.TpgListado.Controls.Add(this.groupBox2);
            this.TpgListado.Controls.Add(this.BtnVisualizar);
            this.TpgListado.Controls.Add(this.DgvActivos);
            this.TpgListado.Location = new System.Drawing.Point(4, 34);
            this.TpgListado.Name = "TpgListado";
            this.TpgListado.Padding = new System.Windows.Forms.Padding(3);
            this.TpgListado.Size = new System.Drawing.Size(1257, 709);
            this.TpgListado.TabIndex = 0;
            this.TpgListado.Text = "Listado";
            // 
            // BtnReportes
            // 
            this.BtnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReportes.Location = new System.Drawing.Point(1150, 16);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Size = new System.Drawing.Size(101, 53);
            this.BtnReportes.TabIndex = 25;
            this.BtnReportes.Text = "Reporte";
            this.BtnReportes.UseVisualStyleBackColor = false;
            this.BtnReportes.Click += new System.EventHandler(this.BtnReportes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnFiltroBuscar);
            this.groupBox2.Controls.Add(this.CmbFiltroArea);
            this.groupBox2.Controls.Add(this.TxtFiltroNombre);
            this.groupBox2.Controls.Add(this.LblFiltroArea);
            this.groupBox2.Controls.Add(this.LblFiltroNombre);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1042, 70);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros de búsqueda:";
            // 
            // BtnFiltroBuscar
            // 
            this.BtnFiltroBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnFiltroBuscar.Location = new System.Drawing.Point(944, 16);
            this.BtnFiltroBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnFiltroBuscar.Name = "BtnFiltroBuscar";
            this.BtnFiltroBuscar.Size = new System.Drawing.Size(85, 45);
            this.BtnFiltroBuscar.TabIndex = 3;
            this.BtnFiltroBuscar.Text = "Buscar...";
            this.BtnFiltroBuscar.UseVisualStyleBackColor = false;
            this.BtnFiltroBuscar.Click += new System.EventHandler(this.BtnFiltroBuscar_Click);
            // 
            // CmbFiltroArea
            // 
            this.CmbFiltroArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFiltroArea.FormattingEnabled = true;
            this.CmbFiltroArea.Location = new System.Drawing.Point(500, 23);
            this.CmbFiltroArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbFiltroArea.Name = "CmbFiltroArea";
            this.CmbFiltroArea.Size = new System.Drawing.Size(426, 28);
            this.CmbFiltroArea.TabIndex = 2;
            // 
            // TxtFiltroNombre
            // 
            this.TxtFiltroNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFiltroNombre.Location = new System.Drawing.Point(80, 24);
            this.TxtFiltroNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtFiltroNombre.Name = "TxtFiltroNombre";
            this.TxtFiltroNombre.Size = new System.Drawing.Size(353, 27);
            this.TxtFiltroNombre.TabIndex = 1;
            // 
            // LblFiltroArea
            // 
            this.LblFiltroArea.AutoSize = true;
            this.LblFiltroArea.Location = new System.Drawing.Point(452, 28);
            this.LblFiltroArea.Name = "LblFiltroArea";
            this.LblFiltroArea.Size = new System.Drawing.Size(42, 18);
            this.LblFiltroArea.TabIndex = 1;
            this.LblFiltroArea.Text = "Area:";
            // 
            // LblFiltroNombre
            // 
            this.LblFiltroNombre.AutoSize = true;
            this.LblFiltroNombre.Location = new System.Drawing.Point(8, 28);
            this.LblFiltroNombre.Name = "LblFiltroNombre";
            this.LblFiltroNombre.Size = new System.Drawing.Size(66, 18);
            this.LblFiltroNombre.TabIndex = 0;
            this.LblFiltroNombre.Text = "Nombre:";
            // 
            // BtnVisualizar
            // 
            this.BtnVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVisualizar.Location = new System.Drawing.Point(1062, 16);
            this.BtnVisualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnVisualizar.Name = "BtnVisualizar";
            this.BtnVisualizar.Size = new System.Drawing.Size(82, 54);
            this.BtnVisualizar.TabIndex = 24;
            this.BtnVisualizar.Text = "FOTO";
            this.BtnVisualizar.UseVisualStyleBackColor = false;
            this.BtnVisualizar.Click += new System.EventHandler(this.BtnVisualizar_Click);
            // 
            // DgvActivos
            // 
            this.DgvActivos.AllowUserToDeleteRows = false;
            this.DgvActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvActivos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvActivos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.DgvActivos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvActivos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvActivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DgvActivos.ColumnHeadersHeight = 30;
            this.DgvActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvActivos.DefaultCellStyle = dataGridViewCellStyle10;
            this.DgvActivos.EnableHeadersVisualStyles = false;
            this.DgvActivos.GridColor = System.Drawing.Color.SteelBlue;
            this.DgvActivos.Location = new System.Drawing.Point(6, 81);
            this.DgvActivos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvActivos.Name = "DgvActivos";
            this.DgvActivos.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvActivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DgvActivos.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.DgvActivos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DgvActivos.RowTemplate.Height = 24;
            this.DgvActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvActivos.Size = new System.Drawing.Size(1245, 623);
            this.DgvActivos.TabIndex = 22;
            this.DgvActivos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvActivos_CellClick);
            // 
            // TpgMantenimiento
            // 
            this.TpgMantenimiento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TpgMantenimiento.Controls.Add(this.groupBox1);
            this.TpgMantenimiento.Controls.Add(this.BtnNuevo);
            this.TpgMantenimiento.Controls.Add(this.BtnModificar);
            this.TpgMantenimiento.Controls.Add(this.BtnEliminar);
            this.TpgMantenimiento.Controls.Add(this.BtnGrabar);
            this.TpgMantenimiento.Controls.Add(this.BtnCancelar);
            this.TpgMantenimiento.Location = new System.Drawing.Point(4, 34);
            this.TpgMantenimiento.Name = "TpgMantenimiento";
            this.TpgMantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.TpgMantenimiento.Size = new System.Drawing.Size(1257, 709);
            this.TpgMantenimiento.TabIndex = 1;
            this.TpgMantenimiento.Text = "Mantenimiento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblEstado);
            this.groupBox1.Controls.Add(this.CmbEstado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtPctjeIva);
            this.groupBox1.Controls.Add(this.LblPctjeIva);
            this.groupBox1.Controls.Add(this.CmbPropietarios);
            this.groupBox1.Controls.Add(this.LblPropietario);
            this.groupBox1.Controls.Add(this.DtpFechaCompra);
            this.groupBox1.Controls.Add(this.TxtValorTotal);
            this.groupBox1.Controls.Add(this.TxtValorIva);
            this.groupBox1.Controls.Add(this.TxtValorBaseIva);
            this.groupBox1.Controls.Add(this.TxtValorBase0);
            this.groupBox1.Controls.Add(this.LblFechaCompra);
            this.groupBox1.Controls.Add(this.LblValorTotal);
            this.groupBox1.Controls.Add(this.LblIva);
            this.groupBox1.Controls.Add(this.LblBaseIva);
            this.groupBox1.Controls.Add(this.LblBase0);
            this.groupBox1.Controls.Add(this.TxtObservaciones);
            this.groupBox1.Controls.Add(this.LblObservaciones);
            this.groupBox1.Controls.Add(this.TxtArchivo);
            this.groupBox1.Controls.Add(this.LblArchivo);
            this.groupBox1.Controls.Add(this.CmbArea);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.TxtId);
            this.groupBox1.Controls.Add(this.LblArea);
            this.groupBox1.Controls.Add(this.LblNombre);
            this.groupBox1.Controls.Add(this.LblCodigo);
            this.groupBox1.Location = new System.Drawing.Point(10, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1236, 635);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(207, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "%";
            // 
            // TxtPctjeIva
            // 
            this.TxtPctjeIva.Enabled = false;
            this.TxtPctjeIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPctjeIva.Location = new System.Drawing.Point(143, 368);
            this.TxtPctjeIva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPctjeIva.Name = "TxtPctjeIva";
            this.TxtPctjeIva.Size = new System.Drawing.Size(58, 28);
            this.TxtPctjeIva.TabIndex = 17;
            this.TxtPctjeIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtPctjeIva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPctjeIva_KeyPress);
            // 
            // LblPctjeIva
            // 
            this.LblPctjeIva.AutoSize = true;
            this.LblPctjeIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPctjeIva.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblPctjeIva.Location = new System.Drawing.Point(110, 373);
            this.LblPctjeIva.Name = "LblPctjeIva";
            this.LblPctjeIva.Size = new System.Drawing.Size(30, 18);
            this.LblPctjeIva.TabIndex = 0;
            this.LblPctjeIva.Text = "Iva:";
            // 
            // CmbPropietarios
            // 
            this.CmbPropietarios.Enabled = false;
            this.CmbPropietarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPropietarios.FormattingEnabled = true;
            this.CmbPropietarios.Location = new System.Drawing.Point(142, 484);
            this.CmbPropietarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbPropietarios.Name = "CmbPropietarios";
            this.CmbPropietarios.Size = new System.Drawing.Size(491, 28);
            this.CmbPropietarios.TabIndex = 20;
            // 
            // LblPropietario
            // 
            this.LblPropietario.AutoSize = true;
            this.LblPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPropietario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblPropietario.Location = new System.Drawing.Point(56, 488);
            this.LblPropietario.Name = "LblPropietario";
            this.LblPropietario.Size = new System.Drawing.Size(84, 18);
            this.LblPropietario.TabIndex = 0;
            this.LblPropietario.Text = "Propietario:";
            // 
            // DtpFechaCompra
            // 
            this.DtpFechaCompra.CustomFormat = "yyyy/MM/dd";
            this.DtpFechaCompra.Enabled = false;
            this.DtpFechaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaCompra.Location = new System.Drawing.Point(142, 252);
            this.DtpFechaCompra.Name = "DtpFechaCompra";
            this.DtpFechaCompra.Size = new System.Drawing.Size(147, 27);
            this.DtpFechaCompra.TabIndex = 14;
            this.DtpFechaCompra.Value = new System.DateTime(2020, 3, 18, 0, 0, 0, 0);
            // 
            // TxtValorTotal
            // 
            this.TxtValorTotal.Enabled = false;
            this.TxtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorTotal.Location = new System.Drawing.Point(143, 445);
            this.TxtValorTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtValorTotal.Name = "TxtValorTotal";
            this.TxtValorTotal.Size = new System.Drawing.Size(147, 28);
            this.TxtValorTotal.TabIndex = 19;
            this.TxtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtValorTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorTotal_KeyPress);
            // 
            // TxtValorIva
            // 
            this.TxtValorIva.Enabled = false;
            this.TxtValorIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorIva.Location = new System.Drawing.Point(142, 406);
            this.TxtValorIva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtValorIva.Name = "TxtValorIva";
            this.TxtValorIva.Size = new System.Drawing.Size(147, 28);
            this.TxtValorIva.TabIndex = 18;
            this.TxtValorIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtValorIva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorIva_KeyPress);
            // 
            // TxtValorBaseIva
            // 
            this.TxtValorBaseIva.Enabled = false;
            this.TxtValorBaseIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorBaseIva.Location = new System.Drawing.Point(143, 329);
            this.TxtValorBaseIva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtValorBaseIva.Name = "TxtValorBaseIva";
            this.TxtValorBaseIva.Size = new System.Drawing.Size(147, 28);
            this.TxtValorBaseIva.TabIndex = 16;
            this.TxtValorBaseIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtValorBaseIva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorBaseIva_KeyPress);
            // 
            // TxtValorBase0
            // 
            this.TxtValorBase0.Enabled = false;
            this.TxtValorBase0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorBase0.Location = new System.Drawing.Point(143, 290);
            this.TxtValorBase0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtValorBase0.Name = "TxtValorBase0";
            this.TxtValorBase0.Size = new System.Drawing.Size(147, 28);
            this.TxtValorBase0.TabIndex = 15;
            this.TxtValorBase0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtValorBase0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorBase0_KeyPress);
            // 
            // LblFechaCompra
            // 
            this.LblFechaCompra.AutoSize = true;
            this.LblFechaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaCompra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblFechaCompra.Location = new System.Drawing.Point(9, 257);
            this.LblFechaCompra.Name = "LblFechaCompra";
            this.LblFechaCompra.Size = new System.Drawing.Size(131, 18);
            this.LblFechaCompra.TabIndex = 0;
            this.LblFechaCompra.Text = "Fecha de Compra:";
            // 
            // LblValorTotal
            // 
            this.LblValorTotal.AutoSize = true;
            this.LblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblValorTotal.Location = new System.Drawing.Point(57, 450);
            this.LblValorTotal.Name = "LblValorTotal";
            this.LblValorTotal.Size = new System.Drawing.Size(83, 18);
            this.LblValorTotal.TabIndex = 0;
            this.LblValorTotal.Text = "Valor Total:";
            // 
            // LblIva
            // 
            this.LblIva.AutoSize = true;
            this.LblIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIva.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblIva.Location = new System.Drawing.Point(72, 412);
            this.LblIva.Name = "LblIva";
            this.LblIva.Size = new System.Drawing.Size(68, 18);
            this.LblIva.TabIndex = 0;
            this.LblIva.Text = "Valor Iva:";
            // 
            // LblBaseIva
            // 
            this.LblBaseIva.AutoSize = true;
            this.LblBaseIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBaseIva.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblBaseIva.Location = new System.Drawing.Point(34, 335);
            this.LblBaseIva.Name = "LblBaseIva";
            this.LblBaseIva.Size = new System.Drawing.Size(106, 18);
            this.LblBaseIva.TabIndex = 0;
            this.LblBaseIva.Text = "Valor Base Iva:";
            // 
            // LblBase0
            // 
            this.LblBase0.AutoSize = true;
            this.LblBase0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBase0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblBase0.Location = new System.Drawing.Point(44, 295);
            this.LblBase0.Name = "LblBase0";
            this.LblBase0.Size = new System.Drawing.Size(96, 18);
            this.LblBase0.TabIndex = 0;
            this.LblBase0.Text = "Valor Base 0:";
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.Enabled = false;
            this.TxtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObservaciones.Location = new System.Drawing.Point(142, 192);
            this.TxtObservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtObservaciones.MaxLength = 100;
            this.TxtObservaciones.Multiline = true;
            this.TxtObservaciones.Name = "TxtObservaciones";
            this.TxtObservaciones.Size = new System.Drawing.Size(588, 49);
            this.TxtObservaciones.TabIndex = 13;
            this.TxtObservaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtObservaciones_KeyPress);
            // 
            // LblObservaciones
            // 
            this.LblObservaciones.AutoSize = true;
            this.LblObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObservaciones.Location = new System.Drawing.Point(28, 211);
            this.LblObservaciones.Name = "LblObservaciones";
            this.LblObservaciones.Size = new System.Drawing.Size(112, 18);
            this.LblObservaciones.TabIndex = 0;
            this.LblObservaciones.Text = "Observaciones:";
            // 
            // TxtArchivo
            // 
            this.TxtArchivo.Enabled = false;
            this.TxtArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtArchivo.Location = new System.Drawing.Point(142, 53);
            this.TxtArchivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtArchivo.Name = "TxtArchivo";
            this.TxtArchivo.Size = new System.Drawing.Size(131, 28);
            this.TxtArchivo.TabIndex = 0;
            // 
            // LblArchivo
            // 
            this.LblArchivo.AutoSize = true;
            this.LblArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArchivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblArchivo.Location = new System.Drawing.Point(79, 58);
            this.LblArchivo.Name = "LblArchivo";
            this.LblArchivo.Size = new System.Drawing.Size(61, 18);
            this.LblArchivo.TabIndex = 0;
            this.LblArchivo.Text = "Archivo:";
            // 
            // CmbArea
            // 
            this.CmbArea.Enabled = false;
            this.CmbArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbArea.FormattingEnabled = true;
            this.CmbArea.Location = new System.Drawing.Point(142, 90);
            this.CmbArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbArea.Name = "CmbArea";
            this.CmbArea.Size = new System.Drawing.Size(576, 30);
            this.CmbArea.TabIndex = 11;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Enabled = false;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(142, 131);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNombre.MaxLength = 120;
            this.TxtNombre.Multiline = true;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(932, 49);
            this.TxtNombre.TabIndex = 12;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(142, 16);
            this.TxtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtId.MaxLength = 10;
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(56, 28);
            this.TxtId.TabIndex = 0;
            // 
            // LblArea
            // 
            this.LblArea.AutoSize = true;
            this.LblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblArea.Location = new System.Drawing.Point(98, 97);
            this.LblArea.Name = "LblArea";
            this.LblArea.Size = new System.Drawing.Size(42, 18);
            this.LblArea.TabIndex = 0;
            this.LblArea.Text = "Area:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblNombre.Location = new System.Drawing.Point(74, 152);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(66, 18);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblCodigo.Location = new System.Drawing.Point(80, 22);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(60, 18);
            this.LblCodigo.TabIndex = 0;
            this.LblCodigo.Text = "Codigo:";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.Location = new System.Drawing.Point(10, 649);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(120, 50);
            this.BtnNuevo.TabIndex = 5;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Location = new System.Drawing.Point(166, 649);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(120, 50);
            this.BtnModificar.TabIndex = 6;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(323, 649);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(120, 50);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGrabar.Location = new System.Drawing.Point(483, 649);
            this.BtnGrabar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(120, 50);
            this.BtnGrabar.TabIndex = 8;
            this.BtnGrabar.Text = "Grabar";
            this.BtnGrabar.UseVisualStyleBackColor = false;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(640, 649);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(120, 50);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // CmbEstado
            // 
            this.CmbEstado.Enabled = false;
            this.CmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO",
            "BAJA"});
            this.CmbEstado.Location = new System.Drawing.Point(142, 522);
            this.CmbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(148, 28);
            this.CmbEstado.TabIndex = 21;
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblEstado.Location = new System.Drawing.Point(81, 526);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(59, 18);
            this.LblEstado.TabIndex = 22;
            this.LblEstado.Text = "Estado:";
            // 
            // FrmMantenimientoActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1278, 759);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMantenimientoActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Activos Fijos";
            this.Load += new System.EventHandler(this.FrmMantenimientoActivos_Load);
            this.tabControl1.ResumeLayout(false);
            this.TpgListado.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvActivos)).EndInit();
            this.TpgMantenimiento.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TpgListado;
        private System.Windows.Forms.TabPage TpgMantenimiento;
        private System.Windows.Forms.Button BtnReportes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnFiltroBuscar;
        private System.Windows.Forms.ComboBox CmbFiltroArea;
        private System.Windows.Forms.TextBox TxtFiltroNombre;
        private System.Windows.Forms.Label LblFiltroArea;
        private System.Windows.Forms.Label LblFiltroNombre;
        private System.Windows.Forms.Button BtnVisualizar;
        private System.Windows.Forms.DataGridView DgvActivos;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGrabar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPctjeIva;
        private System.Windows.Forms.Label LblPctjeIva;
        private System.Windows.Forms.ComboBox CmbPropietarios;
        private System.Windows.Forms.Label LblPropietario;
        private System.Windows.Forms.DateTimePicker DtpFechaCompra;
        private System.Windows.Forms.TextBox TxtValorTotal;
        private System.Windows.Forms.TextBox TxtValorIva;
        private System.Windows.Forms.TextBox TxtValorBaseIva;
        private System.Windows.Forms.TextBox TxtValorBase0;
        private System.Windows.Forms.Label LblFechaCompra;
        private System.Windows.Forms.Label LblValorTotal;
        private System.Windows.Forms.Label LblIva;
        private System.Windows.Forms.Label LblBaseIva;
        private System.Windows.Forms.Label LblBase0;
        private System.Windows.Forms.TextBox TxtObservaciones;
        private System.Windows.Forms.Label LblObservaciones;
        private System.Windows.Forms.TextBox TxtArchivo;
        private System.Windows.Forms.Label LblArchivo;
        private System.Windows.Forms.ComboBox CmbArea;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label LblArea;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.ComboBox CmbEstado;
    }
}