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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TpgListado = new System.Windows.Forms.TabPage();
            this.BtnReportes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnRecalcularDepre = new System.Windows.Forms.Button();
            this.LblFechaCorteDepre = new System.Windows.Forms.Label();
            this.DtpFechaCorteDepre = new System.Windows.Forms.DateTimePicker();
            this.BtnFiltroBuscar = new System.Windows.Forms.Button();
            this.CmbFiltroArea = new System.Windows.Forms.ComboBox();
            this.TxtFiltroNombre = new System.Windows.Forms.TextBox();
            this.LblFiltroArea = new System.Windows.Forms.Label();
            this.LblFiltroNombre = new System.Windows.Forms.Label();
            this.BtnVisualizar = new System.Windows.Forms.Button();
            this.DgvActivos = new System.Windows.Forms.DataGridView();
            this.TpgMantenimiento = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblDepreciable = new System.Windows.Forms.Label();
            this.CmbDepreciable = new System.Windows.Forms.ComboBox();
            this.LblCedulaCustodio = new System.Windows.Forms.Label();
            this.CmbCedulaCustodio = new System.Windows.Forms.ComboBox();
            this.LblRucProveedor = new System.Windows.Forms.Label();
            this.CmbRucProveedor = new System.Windows.Forms.ComboBox();
            this.LblCtaContable = new System.Windows.Forms.Label();
            this.CmbCtaContable = new System.Windows.Forms.ComboBox();
            this.LblFactura = new System.Windows.Forms.Label();
            this.TxtFactura = new System.Windows.Forms.TextBox();
            this.LblValorActual = new System.Windows.Forms.Label();
            this.TxtValorActual = new System.Windows.Forms.TextBox();
            this.LblDepreAcumulada = new System.Windows.Forms.Label();
            this.TxtDepreAcumulada = new System.Windows.Forms.TextBox();
            this.LblDepreDiaria = new System.Windows.Forms.Label();
            this.TxtDepreDiaria = new System.Windows.Forms.TextBox();
            this.LblCodBarra = new System.Windows.Forms.Label();
            this.TxtCodBarra = new System.Windows.Forms.TextBox();
            this.LblEstado = new System.Windows.Forms.Label();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPctjeIva = new System.Windows.Forms.TextBox();
            this.LblPctjeIva = new System.Windows.Forms.Label();
            this.CmbEmpresas = new System.Windows.Forms.ComboBox();
            this.LblEmpresa = new System.Windows.Forms.Label();
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
            this.LblId = new System.Windows.Forms.Label();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
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
            this.BtnReportes.TabIndex = 5;
            this.BtnReportes.Text = "Reporte";
            this.BtnReportes.UseVisualStyleBackColor = false;
            this.BtnReportes.Click += new System.EventHandler(this.BtnReportes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnRecalcularDepre);
            this.groupBox2.Controls.Add(this.LblFechaCorteDepre);
            this.groupBox2.Controls.Add(this.DtpFechaCorteDepre);
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
            this.groupBox2.Size = new System.Drawing.Size(1042, 93);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros:";
            // 
            // BtnRecalcularDepre
            // 
            this.BtnRecalcularDepre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnRecalcularDepre.Location = new System.Drawing.Point(933, 15);
            this.BtnRecalcularDepre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRecalcularDepre.Name = "BtnRecalcularDepre";
            this.BtnRecalcularDepre.Size = new System.Drawing.Size(103, 39);
            this.BtnRecalcularDepre.TabIndex = 7;
            this.BtnRecalcularDepre.Text = "Recalcular...";
            this.BtnRecalcularDepre.UseVisualStyleBackColor = false;
            // 
            // LblFechaCorteDepre
            // 
            this.LblFechaCorteDepre.AutoSize = true;
            this.LblFechaCorteDepre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaCorteDepre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblFechaCorteDepre.Location = new System.Drawing.Point(822, 15);
            this.LblFechaCorteDepre.Name = "LblFechaCorteDepre";
            this.LblFechaCorteDepre.Size = new System.Drawing.Size(99, 36);
            this.LblFechaCorteDepre.TabIndex = 40;
            this.LblFechaCorteDepre.Text = "Fecha Corte \r\nDepreciacion:";
            // 
            // DtpFechaCorteDepre
            // 
            this.DtpFechaCorteDepre.CustomFormat = "yyyy/MM/dd";
            this.DtpFechaCorteDepre.Enabled = false;
            this.DtpFechaCorteDepre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaCorteDepre.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaCorteDepre.Location = new System.Drawing.Point(760, 56);
            this.DtpFechaCorteDepre.Name = "DtpFechaCorteDepre";
            this.DtpFechaCorteDepre.Size = new System.Drawing.Size(152, 27);
            this.DtpFechaCorteDepre.TabIndex = 6;
            this.DtpFechaCorteDepre.Value = new System.DateTime(2020, 4, 13, 16, 3, 5, 0);
            // 
            // BtnFiltroBuscar
            // 
            this.BtnFiltroBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnFiltroBuscar.Location = new System.Drawing.Point(626, 16);
            this.BtnFiltroBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnFiltroBuscar.Name = "BtnFiltroBuscar";
            this.BtnFiltroBuscar.Size = new System.Drawing.Size(102, 68);
            this.BtnFiltroBuscar.TabIndex = 3;
            this.BtnFiltroBuscar.Text = "Buscar...";
            this.BtnFiltroBuscar.UseVisualStyleBackColor = false;
            this.BtnFiltroBuscar.Click += new System.EventHandler(this.BtnFiltroBuscar_Click);
            // 
            // CmbFiltroArea
            // 
            this.CmbFiltroArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFiltroArea.FormattingEnabled = true;
            this.CmbFiltroArea.Location = new System.Drawing.Point(78, 53);
            this.CmbFiltroArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbFiltroArea.Name = "CmbFiltroArea";
            this.CmbFiltroArea.Size = new System.Drawing.Size(531, 28);
            this.CmbFiltroArea.TabIndex = 2;
            // 
            // TxtFiltroNombre
            // 
            this.TxtFiltroNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFiltroNombre.Location = new System.Drawing.Point(78, 18);
            this.TxtFiltroNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtFiltroNombre.Name = "TxtFiltroNombre";
            this.TxtFiltroNombre.Size = new System.Drawing.Size(531, 27);
            this.TxtFiltroNombre.TabIndex = 1;
            // 
            // LblFiltroArea
            // 
            this.LblFiltroArea.AutoSize = true;
            this.LblFiltroArea.Location = new System.Drawing.Point(30, 58);
            this.LblFiltroArea.Name = "LblFiltroArea";
            this.LblFiltroArea.Size = new System.Drawing.Size(42, 18);
            this.LblFiltroArea.TabIndex = 1;
            this.LblFiltroArea.Text = "Area:";
            // 
            // LblFiltroNombre
            // 
            this.LblFiltroNombre.AutoSize = true;
            this.LblFiltroNombre.Location = new System.Drawing.Point(6, 22);
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
            this.BtnVisualizar.TabIndex = 4;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvActivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvActivos.ColumnHeadersHeight = 30;
            this.DgvActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvActivos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvActivos.EnableHeadersVisualStyles = false;
            this.DgvActivos.GridColor = System.Drawing.Color.SteelBlue;
            this.DgvActivos.Location = new System.Drawing.Point(6, 112);
            this.DgvActivos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvActivos.Name = "DgvActivos";
            this.DgvActivos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvActivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvActivos.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DgvActivos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvActivos.RowTemplate.Height = 24;
            this.DgvActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvActivos.Size = new System.Drawing.Size(1245, 592);
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
            this.groupBox1.Controls.Add(this.LblDepreciable);
            this.groupBox1.Controls.Add(this.CmbDepreciable);
            this.groupBox1.Controls.Add(this.LblCedulaCustodio);
            this.groupBox1.Controls.Add(this.CmbCedulaCustodio);
            this.groupBox1.Controls.Add(this.LblRucProveedor);
            this.groupBox1.Controls.Add(this.CmbRucProveedor);
            this.groupBox1.Controls.Add(this.LblCtaContable);
            this.groupBox1.Controls.Add(this.CmbCtaContable);
            this.groupBox1.Controls.Add(this.LblFactura);
            this.groupBox1.Controls.Add(this.TxtFactura);
            this.groupBox1.Controls.Add(this.LblValorActual);
            this.groupBox1.Controls.Add(this.TxtValorActual);
            this.groupBox1.Controls.Add(this.LblDepreAcumulada);
            this.groupBox1.Controls.Add(this.TxtDepreAcumulada);
            this.groupBox1.Controls.Add(this.LblDepreDiaria);
            this.groupBox1.Controls.Add(this.TxtDepreDiaria);
            this.groupBox1.Controls.Add(this.LblCodBarra);
            this.groupBox1.Controls.Add(this.TxtCodBarra);
            this.groupBox1.Controls.Add(this.LblEstado);
            this.groupBox1.Controls.Add(this.CmbEstado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtPctjeIva);
            this.groupBox1.Controls.Add(this.LblPctjeIva);
            this.groupBox1.Controls.Add(this.CmbEmpresas);
            this.groupBox1.Controls.Add(this.LblEmpresa);
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
            this.groupBox1.Controls.Add(this.LblId);
            this.groupBox1.Location = new System.Drawing.Point(10, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1236, 626);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // LblDepreciable
            // 
            this.LblDepreciable.AutoSize = true;
            this.LblDepreciable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDepreciable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblDepreciable.Location = new System.Drawing.Point(493, 444);
            this.LblDepreciable.Name = "LblDepreciable";
            this.LblDepreciable.Size = new System.Drawing.Size(112, 18);
            this.LblDepreciable.TabIndex = 41;
            this.LblDepreciable.Text = "Es Depreciable:";
            // 
            // CmbDepreciable
            // 
            this.CmbDepreciable.Enabled = false;
            this.CmbDepreciable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDepreciable.FormattingEnabled = true;
            this.CmbDepreciable.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.CmbDepreciable.Location = new System.Drawing.Point(630, 438);
            this.CmbDepreciable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbDepreciable.Name = "CmbDepreciable";
            this.CmbDepreciable.Size = new System.Drawing.Size(68, 28);
            this.CmbDepreciable.TabIndex = 28;
            // 
            // LblCedulaCustodio
            // 
            this.LblCedulaCustodio.AutoSize = true;
            this.LblCedulaCustodio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCedulaCustodio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblCedulaCustodio.Location = new System.Drawing.Point(483, 370);
            this.LblCedulaCustodio.Name = "LblCedulaCustodio";
            this.LblCedulaCustodio.Size = new System.Drawing.Size(122, 18);
            this.LblCedulaCustodio.TabIndex = 38;
            this.LblCedulaCustodio.Text = "Cedula Custodio:";
            // 
            // CmbCedulaCustodio
            // 
            this.CmbCedulaCustodio.Enabled = false;
            this.CmbCedulaCustodio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCedulaCustodio.FormattingEnabled = true;
            this.CmbCedulaCustodio.Location = new System.Drawing.Point(630, 362);
            this.CmbCedulaCustodio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbCedulaCustodio.Name = "CmbCedulaCustodio";
            this.CmbCedulaCustodio.Size = new System.Drawing.Size(535, 28);
            this.CmbCedulaCustodio.TabIndex = 26;
            // 
            // LblRucProveedor
            // 
            this.LblRucProveedor.AutoSize = true;
            this.LblRucProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRucProveedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblRucProveedor.Location = new System.Drawing.Point(493, 333);
            this.LblRucProveedor.Name = "LblRucProveedor";
            this.LblRucProveedor.Size = new System.Drawing.Size(112, 18);
            this.LblRucProveedor.TabIndex = 36;
            this.LblRucProveedor.Text = "Ruc Proveedor:";
            // 
            // CmbRucProveedor
            // 
            this.CmbRucProveedor.Enabled = false;
            this.CmbRucProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbRucProveedor.FormattingEnabled = true;
            this.CmbRucProveedor.Location = new System.Drawing.Point(630, 324);
            this.CmbRucProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbRucProveedor.Name = "CmbRucProveedor";
            this.CmbRucProveedor.Size = new System.Drawing.Size(535, 28);
            this.CmbRucProveedor.TabIndex = 25;
            // 
            // LblCtaContable
            // 
            this.LblCtaContable.AutoSize = true;
            this.LblCtaContable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCtaContable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblCtaContable.Location = new System.Drawing.Point(483, 294);
            this.LblCtaContable.Name = "LblCtaContable";
            this.LblCtaContable.Size = new System.Drawing.Size(122, 18);
            this.LblCtaContable.TabIndex = 34;
            this.LblCtaContable.Text = "Cuenta Contable:";
            // 
            // CmbCtaContable
            // 
            this.CmbCtaContable.Enabled = false;
            this.CmbCtaContable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCtaContable.FormattingEnabled = true;
            this.CmbCtaContable.Location = new System.Drawing.Point(630, 286);
            this.CmbCtaContable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbCtaContable.Name = "CmbCtaContable";
            this.CmbCtaContable.Size = new System.Drawing.Size(535, 28);
            this.CmbCtaContable.TabIndex = 24;
            // 
            // LblFactura
            // 
            this.LblFactura.AutoSize = true;
            this.LblFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFactura.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblFactura.Location = new System.Drawing.Point(531, 220);
            this.LblFactura.Name = "LblFactura";
            this.LblFactura.Size = new System.Drawing.Size(74, 18);
            this.LblFactura.TabIndex = 32;
            this.LblFactura.Text = "Factura #:";
            // 
            // TxtFactura
            // 
            this.TxtFactura.Enabled = false;
            this.TxtFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFactura.Location = new System.Drawing.Point(630, 213);
            this.TxtFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtFactura.Name = "TxtFactura";
            this.TxtFactura.Size = new System.Drawing.Size(207, 28);
            this.TxtFactura.TabIndex = 22;
            // 
            // LblValorActual
            // 
            this.LblValorActual.AutoSize = true;
            this.LblValorActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorActual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblValorActual.Location = new System.Drawing.Point(112, 487);
            this.LblValorActual.Name = "LblValorActual";
            this.LblValorActual.Size = new System.Drawing.Size(90, 18);
            this.LblValorActual.TabIndex = 30;
            this.LblValorActual.Text = "Valor Actual:";
            // 
            // TxtValorActual
            // 
            this.TxtValorActual.Enabled = false;
            this.TxtValorActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorActual.Location = new System.Drawing.Point(233, 479);
            this.TxtValorActual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtValorActual.Name = "TxtValorActual";
            this.TxtValorActual.Size = new System.Drawing.Size(169, 28);
            this.TxtValorActual.TabIndex = 0;
            this.TxtValorActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblDepreAcumulada
            // 
            this.LblDepreAcumulada.AutoSize = true;
            this.LblDepreAcumulada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDepreAcumulada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblDepreAcumulada.Location = new System.Drawing.Point(26, 449);
            this.LblDepreAcumulada.Name = "LblDepreAcumulada";
            this.LblDepreAcumulada.Size = new System.Drawing.Size(176, 18);
            this.LblDepreAcumulada.TabIndex = 28;
            this.LblDepreAcumulada.Text = "Depreciacion Acumulada:";
            // 
            // TxtDepreAcumulada
            // 
            this.TxtDepreAcumulada.Enabled = false;
            this.TxtDepreAcumulada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDepreAcumulada.Location = new System.Drawing.Point(233, 440);
            this.TxtDepreAcumulada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDepreAcumulada.Name = "TxtDepreAcumulada";
            this.TxtDepreAcumulada.Size = new System.Drawing.Size(169, 28);
            this.TxtDepreAcumulada.TabIndex = 0;
            this.TxtDepreAcumulada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblDepreDiaria
            // 
            this.LblDepreDiaria.AutoSize = true;
            this.LblDepreDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDepreDiaria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblDepreDiaria.Location = new System.Drawing.Point(61, 411);
            this.LblDepreDiaria.Name = "LblDepreDiaria";
            this.LblDepreDiaria.Size = new System.Drawing.Size(141, 18);
            this.LblDepreDiaria.TabIndex = 26;
            this.LblDepreDiaria.Text = "Depreciacion Diaria:";
            // 
            // TxtDepreDiaria
            // 
            this.TxtDepreDiaria.Enabled = false;
            this.TxtDepreDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDepreDiaria.Location = new System.Drawing.Point(233, 401);
            this.TxtDepreDiaria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDepreDiaria.Name = "TxtDepreDiaria";
            this.TxtDepreDiaria.Size = new System.Drawing.Size(169, 28);
            this.TxtDepreDiaria.TabIndex = 0;
            this.TxtDepreDiaria.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblCodBarra
            // 
            this.LblCodBarra.AutoSize = true;
            this.LblCodBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodBarra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblCodBarra.Location = new System.Drawing.Point(323, 28);
            this.LblCodBarra.Name = "LblCodBarra";
            this.LblCodBarra.Size = new System.Drawing.Size(96, 18);
            this.LblCodBarra.TabIndex = 24;
            this.LblCodBarra.Text = "CodigoBarra:";
            // 
            // TxtCodBarra
            // 
            this.TxtCodBarra.Enabled = false;
            this.TxtCodBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodBarra.Location = new System.Drawing.Point(427, 23);
            this.TxtCodBarra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCodBarra.MaxLength = 10;
            this.TxtCodBarra.Name = "TxtCodBarra";
            this.TxtCodBarra.Size = new System.Drawing.Size(135, 28);
            this.TxtCodBarra.TabIndex = 0;
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblEstado.Location = new System.Drawing.Point(546, 484);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(59, 18);
            this.LblEstado.TabIndex = 22;
            this.LblEstado.Text = "Estado:";
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
            this.CmbEstado.Location = new System.Drawing.Point(630, 476);
            this.CmbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(138, 28);
            this.CmbEstado.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(295, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "%";
            // 
            // TxtPctjeIva
            // 
            this.TxtPctjeIva.Enabled = false;
            this.TxtPctjeIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPctjeIva.Location = new System.Drawing.Point(233, 287);
            this.TxtPctjeIva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPctjeIva.Name = "TxtPctjeIva";
            this.TxtPctjeIva.Size = new System.Drawing.Size(58, 28);
            this.TxtPctjeIva.TabIndex = 19;
            this.TxtPctjeIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtPctjeIva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPctjeIva_KeyPress);
            // 
            // LblPctjeIva
            // 
            this.LblPctjeIva.AutoSize = true;
            this.LblPctjeIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPctjeIva.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblPctjeIva.Location = new System.Drawing.Point(172, 296);
            this.LblPctjeIva.Name = "LblPctjeIva";
            this.LblPctjeIva.Size = new System.Drawing.Size(30, 18);
            this.LblPctjeIva.TabIndex = 0;
            this.LblPctjeIva.Text = "Iva:";
            // 
            // CmbEmpresas
            // 
            this.CmbEmpresas.Enabled = false;
            this.CmbEmpresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEmpresas.FormattingEnabled = true;
            this.CmbEmpresas.Location = new System.Drawing.Point(630, 400);
            this.CmbEmpresas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbEmpresas.Name = "CmbEmpresas";
            this.CmbEmpresas.Size = new System.Drawing.Size(535, 28);
            this.CmbEmpresas.TabIndex = 27;
            // 
            // LblEmpresa
            // 
            this.LblEmpresa.AutoSize = true;
            this.LblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpresa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblEmpresa.Location = new System.Drawing.Point(533, 408);
            this.LblEmpresa.Name = "LblEmpresa";
            this.LblEmpresa.Size = new System.Drawing.Size(72, 18);
            this.LblEmpresa.TabIndex = 0;
            this.LblEmpresa.Text = "Empresa:";
            // 
            // DtpFechaCompra
            // 
            this.DtpFechaCompra.CustomFormat = "yyyy/MM/dd";
            this.DtpFechaCompra.Enabled = false;
            this.DtpFechaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaCompra.Location = new System.Drawing.Point(630, 251);
            this.DtpFechaCompra.Name = "DtpFechaCompra";
            this.DtpFechaCompra.Size = new System.Drawing.Size(138, 27);
            this.DtpFechaCompra.TabIndex = 23;
            this.DtpFechaCompra.Value = new System.DateTime(2020, 4, 13, 16, 3, 15, 0);
            // 
            // TxtValorTotal
            // 
            this.TxtValorTotal.Enabled = false;
            this.TxtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorTotal.Location = new System.Drawing.Point(233, 363);
            this.TxtValorTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtValorTotal.Name = "TxtValorTotal";
            this.TxtValorTotal.Size = new System.Drawing.Size(169, 28);
            this.TxtValorTotal.TabIndex = 21;
            this.TxtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtValorTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorTotal_KeyPress);
            // 
            // TxtValorIva
            // 
            this.TxtValorIva.Enabled = false;
            this.TxtValorIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorIva.Location = new System.Drawing.Point(232, 325);
            this.TxtValorIva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtValorIva.Name = "TxtValorIva";
            this.TxtValorIva.Size = new System.Drawing.Size(170, 28);
            this.TxtValorIva.TabIndex = 20;
            this.TxtValorIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtValorIva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorIva_KeyPress);
            // 
            // TxtValorBaseIva
            // 
            this.TxtValorBaseIva.Enabled = false;
            this.TxtValorBaseIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorBaseIva.Location = new System.Drawing.Point(233, 251);
            this.TxtValorBaseIva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtValorBaseIva.Name = "TxtValorBaseIva";
            this.TxtValorBaseIva.Size = new System.Drawing.Size(169, 28);
            this.TxtValorBaseIva.TabIndex = 18;
            this.TxtValorBaseIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtValorBaseIva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorBaseIva_KeyPress);
            // 
            // TxtValorBase0
            // 
            this.TxtValorBase0.Enabled = false;
            this.TxtValorBase0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorBase0.Location = new System.Drawing.Point(233, 214);
            this.TxtValorBase0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtValorBase0.Name = "TxtValorBase0";
            this.TxtValorBase0.Size = new System.Drawing.Size(169, 28);
            this.TxtValorBase0.TabIndex = 17;
            this.TxtValorBase0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtValorBase0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorBase0_KeyPress);
            // 
            // LblFechaCompra
            // 
            this.LblFechaCompra.AutoSize = true;
            this.LblFechaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaCompra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblFechaCompra.Location = new System.Drawing.Point(474, 258);
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
            this.LblValorTotal.Location = new System.Drawing.Point(119, 371);
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
            this.LblIva.Location = new System.Drawing.Point(134, 333);
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
            this.LblBaseIva.Location = new System.Drawing.Point(96, 260);
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
            this.LblBase0.Location = new System.Drawing.Point(106, 223);
            this.LblBase0.Name = "LblBase0";
            this.LblBase0.Size = new System.Drawing.Size(96, 18);
            this.LblBase0.TabIndex = 0;
            this.LblBase0.Text = "Valor Base 0:";
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.Enabled = false;
            this.TxtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObservaciones.Location = new System.Drawing.Point(233, 122);
            this.TxtObservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtObservaciones.MaxLength = 75;
            this.TxtObservaciones.Name = "TxtObservaciones";
            this.TxtObservaciones.Size = new System.Drawing.Size(932, 28);
            this.TxtObservaciones.TabIndex = 15;
            this.TxtObservaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtObservaciones_KeyPress);
            // 
            // LblObservaciones
            // 
            this.LblObservaciones.AutoSize = true;
            this.LblObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObservaciones.Location = new System.Drawing.Point(90, 129);
            this.LblObservaciones.Name = "LblObservaciones";
            this.LblObservaciones.Size = new System.Drawing.Size(112, 18);
            this.LblObservaciones.TabIndex = 0;
            this.LblObservaciones.Text = "Observaciones:";
            // 
            // TxtArchivo
            // 
            this.TxtArchivo.Enabled = false;
            this.TxtArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtArchivo.Location = new System.Drawing.Point(662, 23);
            this.TxtArchivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtArchivo.MaxLength = 10;
            this.TxtArchivo.Name = "TxtArchivo";
            this.TxtArchivo.Size = new System.Drawing.Size(147, 28);
            this.TxtArchivo.TabIndex = 0;
            // 
            // LblArchivo
            // 
            this.LblArchivo.AutoSize = true;
            this.LblArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArchivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblArchivo.Location = new System.Drawing.Point(596, 28);
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
            this.CmbArea.Location = new System.Drawing.Point(233, 159);
            this.CmbArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbArea.Name = "CmbArea";
            this.CmbArea.Size = new System.Drawing.Size(576, 30);
            this.CmbArea.TabIndex = 16;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Enabled = false;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(233, 61);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNombre.MaxLength = 150;
            this.TxtNombre.Multiline = true;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(932, 52);
            this.TxtNombre.TabIndex = 14;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(233, 23);
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
            this.LblArea.Location = new System.Drawing.Point(160, 166);
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
            this.LblNombre.Location = new System.Drawing.Point(136, 67);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(66, 18);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblId.Location = new System.Drawing.Point(179, 28);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(23, 18);
            this.LblId.TabIndex = 0;
            this.LblId.Text = "Id:";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.Location = new System.Drawing.Point(10, 643);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(120, 50);
            this.BtnNuevo.TabIndex = 8;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Location = new System.Drawing.Point(166, 643);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(120, 50);
            this.BtnModificar.TabIndex = 9;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(323, 643);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(120, 50);
            this.BtnEliminar.TabIndex = 10;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGrabar.Location = new System.Drawing.Point(483, 643);
            this.BtnGrabar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(120, 50);
            this.BtnGrabar.TabIndex = 11;
            this.BtnGrabar.Text = "Grabar";
            this.BtnGrabar.UseVisualStyleBackColor = false;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(640, 643);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(120, 50);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
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
        private System.Windows.Forms.ComboBox CmbEmpresas;
        private System.Windows.Forms.Label LblEmpresa;
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
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.Label LblValorActual;
        private System.Windows.Forms.TextBox TxtValorActual;
        private System.Windows.Forms.Label LblDepreAcumulada;
        private System.Windows.Forms.TextBox TxtDepreAcumulada;
        private System.Windows.Forms.Label LblDepreDiaria;
        private System.Windows.Forms.TextBox TxtDepreDiaria;
        private System.Windows.Forms.Label LblCodBarra;
        private System.Windows.Forms.TextBox TxtCodBarra;
        private System.Windows.Forms.Label LblFactura;
        private System.Windows.Forms.TextBox TxtFactura;
        private System.Windows.Forms.Label LblCedulaCustodio;
        private System.Windows.Forms.ComboBox CmbCedulaCustodio;
        private System.Windows.Forms.Label LblRucProveedor;
        private System.Windows.Forms.ComboBox CmbRucProveedor;
        private System.Windows.Forms.Label LblCtaContable;
        private System.Windows.Forms.ComboBox CmbCtaContable;
        private System.Windows.Forms.Label LblDepreciable;
        private System.Windows.Forms.ComboBox CmbDepreciable;
        private System.Windows.Forms.Button BtnRecalcularDepre;
        private System.Windows.Forms.Label LblFechaCorteDepre;
        private System.Windows.Forms.DateTimePicker DtpFechaCorteDepre;
    }
}