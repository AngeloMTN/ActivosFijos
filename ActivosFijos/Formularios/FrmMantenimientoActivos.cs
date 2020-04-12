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
        private static readonly string rutaArchivo = Settings.Default.RutaDelArchivo;
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
            CmbPropietarios.DataSource = ClsQueryActivos.CargarComboBoxPropietarios();
            CmbPropietarios.DisplayMember = "proNombre";
            CmbPropietarios.ValueMember = "proId";


        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            opcion = "add";

            BtnNuevo.Visible = false;
            BtnEliminar.Visible = false;
            BtnGrabar.Visible = true;
            BtnCancelar.Visible = true;
            BtnModificar.Visible = false;

            TxtFiltroNombre.Enabled = false;
            CmbFiltroArea.Enabled = false;

            TxtNombre.Enabled = true;
            CmbArea.Enabled = true;
            TxtObservaciones.Enabled = true;
            DtpFechaCompra.Enabled = true;
            TxtValorBase0.Enabled = true;
            TxtValorBaseIva.Enabled = true;
            TxtPctjeIva.Enabled = true;
            TxtValorIva.Enabled = true;
            TxtValorTotal.Enabled = true;
            CmbPropietarios.Enabled = true;
            CmbEstado.Enabled = true;

            TxtId.Text = "";
            TxtArchivo.Text = "";
            CmbArea.Text = "";
            TxtNombre.Text = "";
            TxtObservaciones.Text = "";
            DtpFechaCompra.Value = DateTime.Today;
            TxtValorBase0.Text = "0.00";
            TxtValorBaseIva.Text = "0.00";
            TxtPctjeIva.Text = "0.0";
            TxtValorIva.Text = "0.00";
            TxtValorTotal.Text = "0.00";
            CmbPropietarios.Text = "";
            CmbEstado.SelectedIndex = 0;

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
                        DgvActivos.DataSource = sql.MostrarDatos();

                        MessageBox.Show("Datos Eliminados OK...", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                CmbEstado.Enabled = true;

                CmbArea.Enabled = true;
                TxtNombre.Enabled = true;
                TxtObservaciones.Enabled = true;
                DtpFechaCompra.Enabled = true;
                TxtValorBase0.Enabled = true;
                TxtValorBaseIva.Enabled = true;
                TxtPctjeIva.Enabled = true;
                TxtValorIva.Enabled = true;
                TxtValorTotal.Enabled = true;
                CmbPropietarios.Enabled = true;

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
                string ppt = CmbPropietarios.SelectedValue.ToString().Trim();
                int area = int.Parse(are);
                string arch = String.Format("{0:000}", area);
                string arch1 = String.Format("{0:000000}", secNew);
                string archivo = ppt + "-" + arch + "-" + arch1;
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

                if (sql.Insertar(secNew.ToString(), archivo, are, TxtNombre.Text, TxtObservaciones.Text, Convert.ToDouble(TxtValorBase0.Text), Convert.ToDouble(TxtValorBaseIva.Text), Convert.ToDouble(TxtPctjeIva.Text), Convert.ToDouble(TxtValorIva.Text), Convert.ToDouble(TxtValorTotal.Text), Convert.ToDateTime(DtpFechaCompra.Value), ppt, estado))
                {
                    TxtArchivo.Text = archivo;
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
                string ppt = CmbPropietarios.SelectedValue.ToString().Trim();
                int are = int.Parse(area);
                string arch = String.Format("{0:000}", are);
                string archivo = ppt + "-" + arch + "-" + TxtArchivo.Text.Substring(6, 6);
                string ext = ".jpg";
                string oldName = rutaArchivo + TxtArchivo.Text + ext;
                string nameOld = TxtArchivo.Text + ext;
                string newName = archivo + ext;
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

                if (sql.Actualizar(TxtId.Text, archivo, area, TxtNombre.Text, TxtObservaciones.Text, Convert.ToDouble(TxtValorBase0.Text), Convert.ToDouble(TxtValorBaseIva.Text), Convert.ToDouble(TxtPctjeIva.Text), Convert.ToDouble(TxtValorIva.Text), Convert.ToDouble(TxtValorTotal.Text), DtpFechaCompra.Value, ppt, estado))
                {
                    for (int i = 0; i < Directory.EnumerateFiles(rutaArchivo).Count(); i++)
                    {
                        FileInfo k = new FileInfo(Directory.GetFiles(rutaArchivo)[i]);
                        if (k.Name == TxtArchivo.Text + ext)
                        {
                            if (nameOld != newName)
                            {
                                myComputer.FileSystem.RenameFile(oldName, newName);
                                break;
                            }
                        }
                    }

                    //Proceso para actualizar unicamente el area cuando ya exista el archivo
                    TxtArchivo.Text = archivo;
                    DgvActivos.DataSource = sql.MostrarDatos();

                    MessageBox.Show("Datos Modificados OK...", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Validar que el archivo no exista para poder crearlo en caso de que selecciono
                    //Cancelar en el cuadro de dialogo que se selecciona la foto
                    var _Files = from file in new DirectoryInfo(rutaArchivo).GetFiles()
                                 where file.Name.Substring(6, 10).Equals(Convert.ToString(archivo).Substring(6, 6) + ".jpg")
                                 select file;

                    if (_Files.Count() == 0)
                    {
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
                            oldName = ofd.FileName;
                            newName = rutaArchivo + nomArch;
                            myComputer.FileSystem.MoveFile(oldName, newName);
                            myComputer.FileSystem.RenameFile(newName, archivo + extencion);
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
            CmbEstado.Enabled = false;

            CmbArea.Enabled = false;
            TxtNombre.Enabled = false;
            TxtObservaciones.Enabled = false;
            DtpFechaCompra.Enabled = false;
            TxtValorBase0.Enabled = false;
            TxtValorBaseIva.Enabled = false;
            TxtPctjeIva.Enabled = false;
            TxtValorIva.Enabled = false;
            TxtValorTotal.Enabled = false;
            CmbPropietarios.Enabled = false;
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
            CmbEstado.Enabled = false;

            CmbArea.Enabled = false;
            TxtNombre.Enabled = false;
            TxtObservaciones.Enabled = false;
            DtpFechaCompra.Enabled = false;
            TxtValorBase0.Enabled = false;
            TxtValorBaseIva.Enabled = false;
            TxtPctjeIva.Enabled = false;
            TxtValorIva.Enabled = false;
            TxtValorTotal.Enabled = false;
            CmbPropietarios.Enabled = false;
            CmbEstado.SelectedIndex = 0;
        }

        private void FrmMantenimientoActivos_Load(object sender, EventArgs e)
        {
            DgvActivos.DataSource = sql.MostrarDatos();
            BtnGrabar.Visible = false;
            BtnCancelar.Visible = false;
            CmbEstado.SelectedIndex = 0;

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
                    TxtId.Text = Convert.ToString(fila.Cells[0].Value);
                    TxtArchivo.Text = Convert.ToString(fila.Cells[1].Value);
                    CmbArea.SelectedValue = Convert.ToInt32(fila.Cells[2].Value);
                    TxtNombre.Text = Convert.ToString(fila.Cells[4].Value);
                    TxtObservaciones.Text = Convert.ToString(fila.Cells[5].Value);
                    double base0 = Convert.ToDouble(fila.Cells[6].Value);
                    TxtValorBase0.Text = base0.ToString("#,###.00").Trim();
                    double baseiva = Convert.ToDouble(fila.Cells[7].Value);
                    TxtValorBaseIva.Text = baseiva.ToString("#,###.00").Trim();
                    double pctiva = Convert.ToDouble(fila.Cells[8].Value);
                    TxtPctjeIva.Text = pctiva.ToString("###.00").Trim();
                    double iva = Convert.ToDouble(fila.Cells[9].Value);
                    TxtValorIva.Text = iva.ToString("#,###.00").Trim();
                    double vaortotal = Convert.ToDouble(fila.Cells[10].Value);
                    TxtValorTotal.Text = vaortotal.ToString("#,###.00").Trim();
                    DtpFechaCompra.Value = Convert.ToDateTime(fila.Cells[11].Value);
                    CmbPropietarios.SelectedValue = Convert.ToInt32(fila.Cells[12].Value);
                    switch (Convert.ToString(fila.Cells[14].Value).Trim())
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

                    CmbArea.Enabled = false;
                    TxtNombre.Enabled = false;
                    TxtObservaciones.Enabled = false;
                    DtpFechaCompra.Enabled = false;
                    TxtValorBase0.Enabled = false;
                    TxtValorBaseIva.Enabled = false;
                    TxtPctjeIva.Enabled = false;
                    TxtValorIva.Enabled = false;
                    TxtValorTotal.Enabled = false;
                    CmbPropietarios.Enabled = false;

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
    }
}
