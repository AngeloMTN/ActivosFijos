using ActivosFijos.Clases;
using ActivosFijos.Properties;
using Microsoft.VisualBasic.Devices;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace ActivosFijos.Formularios
{
    public partial class FrmMantenimientoActivos : Form
    {
        public static readonly string rutaArchivo = Settings.Default.RutaDelArchivo;
        public string nombreArchivo = null;
        public string opcion = null;

        readonly ClsQueryActivos sql = new ClsQueryActivos();

        public FrmMantenimientoActivos()
        {
            InitializeComponent();
            CmbFiltroArea.DataSource = ClsQueryActivos.CargarComboBoxAreas();
            CmbFiltroArea.DisplayMember = "areNombre";
            CmbFiltroArea.ValueMember = "areId";

            CmbArea.DataSource = ClsQueryActivos.CargarComboBoxAreas();
            CmbArea.DisplayMember = "areNombre";
            CmbArea.ValueMember = "areId";

            CmbCtaContable.DataSource = ClsQueryActivos.CargarComboBoxPlanCuentas();
            CmbCtaContable.DisplayMember = "pctNombre";
            CmbCtaContable.ValueMember = "pctId";

            CmbCedulaCustodio.DataSource = ClsQueryActivos.CargarComboBoxCustodios();
            CmbCedulaCustodio.DisplayMember = "cusNombre";
            CmbCedulaCustodio.ValueMember = "cusId";

            CmbRucProveedor.DataSource = ClsQueryActivos.CargarComboBoxProveedores();
            CmbRucProveedor.DisplayMember = "proNombre";
            CmbRucProveedor.ValueMember = "proId";

            CmbEmpresas.DataSource = ClsQueryActivos.CargarComboBoxEmpresas();
            CmbEmpresas.DisplayMember = "empNombre";
            CmbEmpresas.ValueMember = "empId";

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            opcion = "add";

            BtnNuevo.Visible = false;
            BtnEliminar.Visible = false;
            BtnGrabar.Visible = true;
            BtnCancelar.Visible = true;
            BtnModificar.Visible = false;

            BtnGrabar.Enabled = true;
            BtnCancelar.Enabled = true;
            TxtFiltroNombre.Enabled = false;
            CmbFiltroArea.Enabled = false;
            BtnFiltroBuscar.Enabled = false;
            DtpFechaCorteDepre.Enabled = false;
            BtnRecalcularDepre.Enabled = false;

            TxtCodBarra.Enabled = false;
            TxtNombre.Enabled = true;
            TxtObservaciones.Enabled = true;
            CmbArea.Enabled = true;
            CmbCtaContable.Enabled = true;
            CmbCedulaCustodio.Enabled = true;
            TxtFactura.Enabled = true;
            DtpFechaCompra.Enabled = true;
            CmbRucProveedor.Enabled = true;
            TxtValorBase0.Enabled = true;
            TxtValorBaseIva.Enabled = true;
            TxtPctjeIva.Enabled = true;
            TxtValorIva.Enabled = false;
            TxtValorTotal.Enabled = false;
            TxtDepreDiaria.Enabled = false;
            TxtDepreAcumulada.Enabled = false;
            TxtValorActual.Enabled = false;
            DtpFechaCorteDepre.Enabled = true;
            CmbDepreciable.Enabled = true;
            CmbEstado.Enabled = true;
            CmbEmpresas.Enabled = true;

            TxtId.Text = "";
            TxtCodBarra.Text = "";
            string archivo = sql.SecuenciaArchivo(rutaArchivo);
            TxtArchivo.Text = archivo;

            TxtNombre.Text = "";
            TxtObservaciones.Text = "";
            CmbArea.SelectedIndex = 0;
            CmbCtaContable.SelectedIndex = 0;
            CmbCedulaCustodio.SelectedIndex = 0;
            TxtFactura.Text = "";
            DtpFechaCompra.Value = DateTime.Today;
            CmbRucProveedor.SelectedIndex = 0;
            TxtValorBase0.Text = "0.00";
            TxtValorBaseIva.Text = "0.00";
            TxtPctjeIva.Text = "0.0";
            TxtValorIva.Text = "0.00";
            TxtValorTotal.Text = "0.00";
            TxtDepreDiaria.Text = "0.00";
            TxtDepreAcumulada.Text = "0.00";
            TxtValorActual.Text = "0.00";
            DtpFinVidaUtilContable.Value = DateTime.Today;
            DtpFechaCorteDepre.Value = DateTime.Today;
            CmbDepreciable.SelectedIndex = 0;
            CmbEstado.SelectedIndex = 0;
            CmbEmpresas.SelectedIndex = 0;

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (TxtId.Text.Trim() != "")
            {
                DialogResult resp = MessageBox.Show("Confirma que desea Eliminar el Activo...?", "", MessageBoxButtons.YesNo);
                if (resp == DialogResult.Yes)
                {
                    if (sql.Eliminar(TxtId.Text))
                    {
                        Computer myComputer = new Computer();
                        DgvActivos.DataSource = sql.MostrarDatos();
                        MessageBox.Show("Datos Eliminados OK...", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Validar que el archivo exista para poder eliminarlo
                        var _Files = from file in new DirectoryInfo(rutaArchivo).GetFiles()
                                     where file.Name.Equals(Convert.ToString(TxtArchivo.Text).Trim() + ".jpg")
                                     select file;

                        if (_Files.Count() > 0)
                        {
                            myComputer.FileSystem.DeleteFile(rutaArchivo +  Convert.ToString(TxtArchivo.Text).Trim() + ".jpg");
                            MessageBox.Show("El archivo asociado " + TxtArchivo.Text.Trim() + ".JPG se Elimino OK...", "Eliminación Archivo JPG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        sql.LimpiarCampos(this, groupBox1);
                        CmbEstado.SelectedIndex = 0;
                        BtnFiltroBuscar.PerformClick();

                    }
                    else
                    {
                        MessageBox.Show("Error al Eliminar Activo...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Primero seleccione cualquier fila dando click para proceder con la Modificacion...", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (TxtId.Text.Trim() != "")
            {
                opcion = "upd";

                BtnNuevo.Visible = false;
                BtnEliminar.Visible = false;
                BtnGrabar.Visible = true;
                BtnCancelar.Visible = true;
                BtnModificar.Visible = false;

                TxtFiltroNombre.Enabled = false;
                CmbFiltroArea.Enabled = false;
                BtnFiltroBuscar.Enabled = false;
                DtpFechaCorteDepre.Enabled = false;
                BtnRecalcularDepre.Enabled = false;

                CmbArea.Enabled = true;
                TxtNombre.Enabled = true;
                TxtObservaciones.Enabled = true;
                TxtValorBase0.Enabled = true;
                TxtValorBaseIva.Enabled = true;
                TxtPctjeIva.Enabled = true;
                TxtValorIva.Enabled = false;
                TxtValorTotal.Enabled = false;
                TxtFactura.Enabled = true;
                DtpFechaCompra.Enabled = true;
                CmbCtaContable.Enabled = true;
                CmbRucProveedor.Enabled = true;
                CmbCedulaCustodio.Enabled = true;
                CmbEmpresas.Enabled = true;
                CmbDepreciable.Enabled = true;
                CmbEstado.Enabled = true;

            }
            else
            {
                MessageBox.Show("Primero seleccione cualquier fila dando click para proceder con la Modificacion...", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BtnFiltroBuscar_Click(object sender, EventArgs e)
        {
            string filtroNivel1 = CmbFiltroArea.Text.Substring(0, CmbFiltroArea.Text.IndexOf("-") - 1).Trim();
            if (TxtFiltroNombre.Text != "" && filtroNivel1 != "0")
            {
                DgvActivos.DataSource = sql.Buscar(TxtFiltroNombre.Text, filtroNivel1);
            }
            else
            {
                if (TxtFiltroNombre.Text != "" || filtroNivel1 == "0")
                {
                    DgvActivos.DataSource = sql.Buscar(TxtFiltroNombre.Text, filtroNivel1);
                }
                else
                {
                    if (TxtFiltroNombre.Text == "" || filtroNivel1 != "0")
                    {
                        DgvActivos.DataSource = sql.Buscar(TxtFiltroNombre.Text, filtroNivel1);
                    }
                    else
                    {
                        DgvActivos.DataSource = sql.MostrarDatos();
                    }
                }
            }

        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            Computer myComputer = new Computer();
            if (opcion == "add")
            {
                string secMax = sql.SecuenciaId();
                if (secMax == "")
                {
                    secMax = "0";
                }

                Int32 secNew = Convert.ToInt32(secMax) + 1;
                string are = CmbArea.SelectedValue.ToString().Trim();
                string epr = CmbEmpresas.SelectedValue.ToString().Trim();
                int area = int.Parse(are);
                string arch = String.Format("{0:000}", area);
                string archivo = TxtArchivo.Text;
                string cbarra = String.Format("{0:000000}", secNew);
                string[] cta = CmbCtaContable.Text.ToString().Trim().Split('-');
                string ctaCtb = cta[0];
                string vidaUtil = cta[2];
                string[] rucs = CmbRucProveedor.Text.ToString().Trim().Split(' ');
                string ruc = rucs[0];
                string[] ced = CmbCedulaCustodio.Text.ToString().Trim().Split(' ');
                string cedula = ced[0];

                string dpr = "";
                if (CmbDepreciable.SelectedItem.ToString().Trim() == "SI")
                    dpr = "S";
                else
                    dpr = "N";
                string estado = "";
                switch (CmbEstado.SelectedIndex)
                {
                    case 0:
                        estado = "ACTIVO";
                        break;
                    case 1:
                        estado = "INACTIVO";
                        break;
                    case 2:
                        estado = "BAJA";
                        break;
                }

                if (sql.Insertar(secNew.ToString(),
                                 cbarra,
                                 archivo,
                                 TxtNombre.Text,
                                 TxtObservaciones.Text,
                                 are,
                                 ctaCtb,
                                 cedula,
                                 TxtFactura.Text,
                                 Convert.ToDateTime(DtpFechaCompra.Value),
                                 ruc,
                                 Convert.ToDouble(TxtValorBase0.Text),
                                 Convert.ToDouble(TxtValorBaseIva.Text),
                                 Convert.ToDouble(TxtPctjeIva.Text),
                                 Convert.ToDouble(TxtValorIva.Text),
                                 Convert.ToDouble(TxtValorTotal.Text),
                                 0.00,
                                 0.00,
                                 0.00,
                                 Convert.ToDateTime("1900-12-31"),
                                 Convert.ToDateTime("1900-12-31"),
                                 dpr,
                                 estado,
                                 epr,
                                 vidaUtil))
                {
                    TxtCodBarra.Text = cbarra;
                    DgvActivos.DataSource = sql.MostrarDatos();
                    MessageBox.Show("Datos Insertados OK...", "Inserción", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Asignar el nombre correspondiente al archivo jpg
                    OpenFileDialog ofd = new OpenFileDialog
                    {
                        Filter = "Archivos|*.jpg|Todos|*.*"
                    };
                    var resultado = ofd.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        string extencion = ofd.FileName.Substring(ofd.FileName.IndexOf("."));
                        string nomArch = ofd.SafeFileName;
                        string oldName = ofd.FileName;
                        string newName = rutaArchivo + nomArch;
                        myComputer.FileSystem.MoveFile(oldName, newName);
                        myComputer.FileSystem.RenameFile(newName, archivo + extencion);
                        MessageBox.Show("El archivo JPG se guardo OK...", "Creación Archivo JPG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se guardo la Foto del Activo...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error al Insertar datos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (opcion == "upd")
            {
                string area = CmbArea.SelectedValue.ToString().Trim();
                string epr = CmbEmpresas.SelectedValue.ToString().Trim();

                string[] cta = CmbCtaContable.Text.ToString().Trim().Split(' ');
                string ctaCtb = cta[0];
                string[] rucs = CmbRucProveedor.Text.ToString().Trim().Split(' ');
                string ruc = rucs[0];
                string[] ced = CmbCedulaCustodio.Text.ToString().Trim().Split(' ');
                string cedula = ced[0];

                string dpr = "";
                if (CmbDepreciable.SelectedItem.ToString().Trim() == "SI")
                    dpr = "S";
                else
                    dpr = "N";

                string estado = "";
                switch (CmbEstado.SelectedIndex)
                {
                    case 0:
                        estado = "ACTIVO";
                        break;
                    case 1:
                        estado = "INACTIVO";
                        break;
                    case 2:
                        estado = "BAJA";
                        break;
                }

                if (sql.Actualizar(TxtId.Text,
                                   TxtNombre.Text,
                                   TxtObservaciones.Text,
                                   area,
                                   ctaCtb,
                                   cedula,
                                   TxtFactura.Text,
                                   Convert.ToDateTime(DtpFechaCompra.Value),
                                   ruc,
                                   Convert.ToDouble(TxtValorBase0.Text),
                                   Convert.ToDouble(TxtValorBaseIva.Text),
                                   Convert.ToDouble(TxtPctjeIva.Text),
                                   Convert.ToDouble(TxtValorIva.Text),
                                   Convert.ToDouble(TxtValorTotal.Text),
                                   Convert.ToDouble(TxtDepreDiaria.Text),
                                   Convert.ToDouble(TxtDepreAcumulada.Text),
                                   Convert.ToDouble(TxtValorActual.Text),
                                   dpr,
                                   estado,
                                   epr))
                {
                    DgvActivos.DataSource = sql.MostrarDatos();

                    MessageBox.Show("Datos Modificados OK...", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Validar que el archivo no exista para poder crearlo en caso de que selecciono
                    //Cancelar en el cuadro de dialogo que se selecciona la foto
                    var _Files = from file in new DirectoryInfo(rutaArchivo).GetFiles()
                                 where file.Name.Equals(Convert.ToString(TxtArchivo.Text).Trim() + ".jpg")
                                 select file;

                    if (_Files.Count() == 0)
                    {
                        //Asignar el nombre correspondiente al archivo jpg
                        OpenFileDialog ofd = new OpenFileDialog
                        {
                            Filter = "Archivos|*.jpg|Todos|*.*"
                        };
                        DialogResult resultado = ofd.ShowDialog();

                        if (resultado == DialogResult.OK)
                        {
                            string extencion = ofd.FileName.Substring(ofd.FileName.IndexOf("."));
                            string nomArch = ofd.SafeFileName;
                            string oldName = ofd.FileName;
                            string newName = rutaArchivo + nomArch;
                            myComputer.FileSystem.MoveFile(oldName, newName);
                            myComputer.FileSystem.RenameFile(newName, TxtArchivo.Text.Trim() + extencion);
                            MessageBox.Show("El archivo JPG se guardo OK...", "Creación Archivo JPG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                     
                        }
                        else
                        {
                            MessageBox.Show("No se guardo la Foto del Activo...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error al Modificar datos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            BtnNuevo.Visible = true;
            BtnEliminar.Visible = true;
            BtnGrabar.Visible = false;
            BtnCancelar.Visible = false;
            BtnModificar.Visible = true;

            TxtFiltroNombre.Enabled = true;
            CmbFiltroArea.Enabled = true;
            BtnFiltroBuscar.Enabled = true;
            DtpFechaCorteDepre.Enabled = true;
            BtnRecalcularDepre.Enabled = true;

            TxtCodBarra.Enabled = false;
            CmbArea.Enabled = false;
            TxtNombre.Enabled = false;
            TxtObservaciones.Enabled = false;
            TxtValorBase0.Enabled = false;
            TxtValorBaseIva.Enabled = false;
            TxtPctjeIva.Enabled = false;
            TxtValorIva.Enabled = false;
            TxtValorTotal.Enabled = false;
            TxtFactura.Enabled = false;
            DtpFechaCompra.Enabled = false;
            CmbCtaContable.Enabled = false;
            CmbRucProveedor.Enabled = false;
            CmbCedulaCustodio.Enabled = false;
            CmbEmpresas.Enabled = false;
            CmbDepreciable.Enabled = false;
            CmbEstado.Enabled = false;

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            BtnNuevo.Visible = true;
            BtnEliminar.Visible = true;
            BtnGrabar.Visible = false;
            BtnCancelar.Visible = false;
            BtnModificar.Visible = true;

            TxtFiltroNombre.Enabled = true;
            CmbFiltroArea.Enabled = true;
            BtnFiltroBuscar.Enabled = true;
            DtpFechaCorteDepre.Enabled = true;
            BtnRecalcularDepre.Enabled = true;

            TxtCodBarra.Enabled = false;
            CmbArea.Enabled = false;
            TxtNombre.Enabled = false;
            TxtObservaciones.Enabled = false;
            TxtValorBase0.Enabled = false;
            TxtValorBaseIva.Enabled = false;
            TxtPctjeIva.Enabled = false;
            TxtValorIva.Enabled = false;
            TxtValorTotal.Enabled = false;
            TxtFactura.Enabled = false;
            DtpFechaCompra.Enabled = false;
            CmbCtaContable.Enabled = false;
            CmbRucProveedor.Enabled = false;
            CmbCedulaCustodio.Enabled = false;
            CmbEmpresas.Enabled = false;
            CmbDepreciable.Enabled = false;
            CmbEstado.Enabled = false;
            CmbEstado.SelectedIndex = 0;
        }

        private void FrmMantenimientoActivos_Load(object sender, EventArgs e)
        {
            DgvActivos.DataSource = sql.MostrarDatos();
            BtnGrabar.Visible = false;
            BtnCancelar.Visible = false;
            DtpFechaCompra.Value = DateTime.Today;
            DtpFechaCorteDepre.Value = DateTime.Today;
            CmbDepreciable.SelectedIndex = 0;
            CmbEstado.SelectedIndex = 0;

            BtnCancelar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnGrabar.Enabled = false;
            BtnModificar.Enabled = false;
            BtnVisualizar.Enabled = false;
            BtnRecalcularDepre.Enabled = false;
        }

        private void DgvActivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int totalFilas = DgvActivos.Rows.Count;
                int filaSeleccionada = DgvActivos.CurrentRow.Index;
                if (filaSeleccionada >= 0 && filaSeleccionada != totalFilas - 1)
                {
                    DataGridViewRow fila = DgvActivos.Rows[e.RowIndex];
                    TxtId.Text = Convert.ToString(fila.Cells[0].Value).Trim();
                    TxtCodBarra.Text = Convert.ToString(fila.Cells[1].Value).Trim();
                    TxtArchivo.Text = Convert.ToString(fila.Cells[2].Value).Trim();
                    TxtNombre.Text = Convert.ToString(fila.Cells[3].Value).Trim();
                    TxtObservaciones.Text = Convert.ToString(fila.Cells[4].Value).Trim();
                    CmbArea.SelectedValue = Convert.ToInt32(fila.Cells[5].Value);
                    int indexcta = CmbCtaContable.FindString(Convert.ToString(fila.Cells[7].Value).Trim());
                    CmbCtaContable.SelectedIndex = indexcta;
                    int indexcus = CmbCedulaCustodio.FindString(Convert.ToString(fila.Cells[9].Value).Trim());
                    CmbCedulaCustodio.SelectedIndex = indexcus;
                    TxtFactura.Text = Convert.ToString(fila.Cells[11].Value).Trim();
                    DtpFechaCompra.Value = Convert.ToDateTime(fila.Cells[12].Value);
                    int indexpro = CmbRucProveedor.FindString(Convert.ToString(fila.Cells[13].Value).Trim());
                    CmbRucProveedor.SelectedIndex = indexpro;
                    double base0 = Convert.ToDouble(fila.Cells[15].Value);
                    TxtValorBase0.Text = base0.ToString("#,###.00").Trim();
                    double baseiva = Convert.ToDouble(fila.Cells[16].Value);
                    TxtValorBaseIva.Text = baseiva.ToString("#,###.00").Trim();
                    double pctiva = Convert.ToDouble(fila.Cells[17].Value);
                    TxtPctjeIva.Text = pctiva.ToString("###.00").Trim();
                    double iva = Convert.ToDouble(fila.Cells[18].Value);
                    TxtValorIva.Text = iva.ToString("#,###.00").Trim();
                    double valortotal = Convert.ToDouble(fila.Cells[19].Value);
                    TxtValorTotal.Text = valortotal.ToString("#,###.00").Trim();
                    double deprediaria = Convert.ToDouble(fila.Cells[20].Value);
                    TxtDepreDiaria.Text = deprediaria.ToString("#,###.00").Trim();
                    double depreacumulada = Convert.ToDouble(fila.Cells[21].Value);
                    TxtDepreAcumulada.Text = depreacumulada.ToString("#,###.00").Trim();
                    double vaolractual = Convert.ToDouble(fila.Cells[22].Value);
                    TxtValorActual.Text = vaolractual.ToString("#,###.00").Trim();
                    DtpFinVidaUtilContable.Value = Convert.ToDateTime(fila.Cells[23].Value);
                    DtpFechaCorteDepre.Value = Convert.ToDateTime(fila.Cells[24].Value);
                    if (Convert.ToString(fila.Cells[25].Value).Trim() == "S")
                        CmbDepreciable.SelectedIndex = 0;
                    else
                        CmbDepreciable.SelectedIndex = 1;
                    switch (Convert.ToString(fila.Cells[26].Value).Trim())
                    {
                        case "ACTIVO":
                            CmbEstado.SelectedIndex = 0;
                            break;
                        case "INACTIVO":
                            CmbEstado.SelectedIndex = 1;
                            break;
                        case "BAJA":
                            CmbEstado.SelectedIndex = 2;
                            break;
                    }
                    CmbEmpresas.SelectedValue = Convert.ToInt32(fila.Cells[27].Value);

                    TxtCodBarra.Enabled = false;
                    CmbArea.Enabled = false;
                    TxtNombre.Enabled = false;
                    TxtObservaciones.Enabled = false;
                    TxtValorBase0.Enabled = false;
                    TxtValorBaseIva.Enabled = false;
                    TxtPctjeIva.Enabled = false;
                    TxtValorIva.Enabled = false;
                    TxtValorTotal.Enabled = false;
                    TxtFactura.Enabled = false;
                    DtpFechaCompra.Enabled = false;
                    CmbCtaContable.Enabled = false;
                    CmbRucProveedor.Enabled = false;
                    CmbCedulaCustodio.Enabled = false;
                    CmbEmpresas.Enabled = false;
                    CmbDepreciable.Enabled = false;
                    CmbEstado.Enabled = false;

                    BtnCancelar.Enabled = true;
                    BtnEliminar.Enabled = true;
                    BtnGrabar.Enabled = true;
                    BtnModificar.Enabled = true;
                    BtnVisualizar.Enabled = true;
                    BtnRecalcularDepre.Enabled = true;
                    DtpFechaCorteDepre.Enabled = true;

                    nombreArchivo = null;

                    var _Files = from file in new DirectoryInfo(rutaArchivo).GetFiles()
                                 where file.Name.Equals(Convert.ToString(fila.Cells[2].Value) + ".jpg")
                                 select file;

                    if (_Files.Count() == 0)
                    {
                        nombreArchivo = null;
                    }
                    else
                    {
                        nombreArchivo += Convert.ToString(fila.Cells[2].Value) + ".jpg";
                    }
                }
            }

        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsObtenerConexion.ValidarCaracteres(e);
        }

        private void TxtObservaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsObtenerConexion.ValidarCaracteres(e);
        }

        private void TxtValorBase0_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsObtenerConexion.ValidarNumeros(e);
        }

        private void TxtValorBaseIva_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsObtenerConexion.ValidarNumeros(e);
        }

        private void TxtPctjeIva_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsObtenerConexion.ValidarNumeros(e);
        }

        private void TxtValorIva_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsObtenerConexion.ValidarNumeros(e);
        }

        private void TxtValorTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsObtenerConexion.ValidarNumeros(e);
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            FrmReporteActivos rpt = new FrmReporteActivos();

            for (int i = 0; i < DgvActivos.Rows.Count - 1; i++)
            {
                ClsDatos data = new ClsDatos
                {
                    ActId = Convert.ToInt32(DgvActivos.Rows[i].Cells[0].Value),
                    ActArchivo = Convert.ToString(DgvActivos.Rows[i].Cells[1].Value),
                    AreId = Convert.ToInt32(DgvActivos.Rows[i].Cells[2].Value),
                    AreNombre = Convert.ToString(DgvActivos.Rows[i].Cells[3].Value),
                    ActNombre = Convert.ToString(DgvActivos.Rows[i].Cells[4].Value),
                    ActObservaciones = Convert.ToString(DgvActivos.Rows[i].Cells[5].Value),
                    ActValorBase0 = Convert.ToDouble(DgvActivos.Rows[i].Cells[6].Value),
                    ActValorBaseIva = Convert.ToDouble(DgvActivos.Rows[i].Cells[7].Value),
                    ActPctjeIva = Convert.ToDouble(DgvActivos.Rows[i].Cells[8].Value),
                    ActValorIva = Convert.ToDouble(DgvActivos.Rows[i].Cells[9].Value),
                    ActValorTotal = Convert.ToDouble(DgvActivos.Rows[i].Cells[10].Value),
                    ActFechaCompra = Convert.ToString(DgvActivos.Rows[i].Cells[11].Value),
                    ProId = Convert.ToInt32(DgvActivos.Rows[i].Cells[12].Value),
                    ProNombre = Convert.ToString(DgvActivos.Rows[i].Cells[13].Value),
                    ActEstado = Convert.ToString(DgvActivos.Rows[i].Cells[14].Value)
                };

                rpt.Datos.Add(data);
            }
            rpt.ShowDialog();

        }

        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            if (TxtId.Text.Trim() != "")
            {
                string nomArch = TxtArchivo.Text.Trim() + ".jpg";
                var _Files = from file in new DirectoryInfo(rutaArchivo).GetFiles()
                             where file.Name.Equals(nomArch)
                             select file;

                if (_Files.Count() > 0)
                {
                    Process.Start(rutaArchivo + nomArch);
                }
                else
                {
                    MessageBox.Show("No existe la Foto del Activo...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Primero seleccione cualquier fila dando click para proceder con la Visualizacion...", "Ver Foto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnRecalcularDepre_Click(object sender, EventArgs e)
        {
            if (TxtId.Text.Trim() != "")
            {
                DialogResult resp = MessageBox.Show("Confirma que desea ReCalcular la Depreciación...?", "", MessageBoxButtons.YesNo);
                if (resp == DialogResult.Yes)
                {
                    sql.Recalcular(DtpFechaCorteDepre.Value);
                    MessageBox.Show("Depreciación ReCalculada OK...", "ReCalcular Depreciación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    /*
                    if (sql.Recalcular(DtpFechaCorteDepre.Value, DtpFechaCompra.Value))
                    {
                        DgvActivos.DataSource = sql.MostrarDatos();

                        MessageBox.Show("Depreciación ReCalculada OK...", "ReCalcular Depreciación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CmbEstado.SelectedIndex = 0;
                        BtnFiltroBuscar.PerformClick();

                    }
                    else
                    {
                        MessageBox.Show("Error al Eliminar Activo...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    */
                }
            }
            else
            {
                MessageBox.Show("Primero seleccione cualquier fila dando click para proceder con la Modificacion...", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void TxtValorBase0_Leave(object sender, EventArgs e)
        {
            var vt = Convert.ToDouble(TxtValorBase0.Text) + Convert.ToDouble(TxtValorBaseIva.Text) + Convert.ToDouble(TxtValorIva.Text);
            TxtValorTotal.Text = Convert.ToString(vt);

        }

        private void TxtValorBaseIva_Leave(object sender, EventArgs e)
        {
            var vt = Convert.ToDouble(TxtValorBase0.Text) + Convert.ToDouble(TxtValorBaseIva.Text) + Convert.ToDouble(TxtValorIva.Text);
            TxtValorTotal.Text = Convert.ToString(vt);

        }

        private void TxtPctjeIva_Leave(object sender, EventArgs e)
        {
            var vi = Convert.ToDouble(TxtValorBaseIva.Text) * (Convert.ToDouble(TxtPctjeIva.Text) / 100);
            TxtValorIva.Text = Convert.ToString(vi);
            var vt = Convert.ToDouble(TxtValorBase0.Text) + Convert.ToDouble(TxtValorBaseIva.Text) + Convert.ToDouble(TxtValorIva.Text);
            TxtValorTotal.Text = Convert.ToString(vt);
        }
    }
}
