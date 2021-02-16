using ActivosFijos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivosFijos.Formularios
{
    public partial class FrmMantenimientoPrestamos : Form
    {
        public string opcion = null;

        readonly ClsQueryPrestamos sql = new ClsQueryPrestamos();

        public FrmMantenimientoPrestamos()
        {
            InitializeComponent();
            CargarComboBox();
        }

        public void CargarComboBox()
        {
            CmbNombre.DataSource = ClsQueryPrestamos.CargarComboBoxNombre();
            CmbNombre.DisplayMember = "empNombre";
            CmbNombre.ValueMember = "empId";

            CmbFiltroBuscar.DataSource = ClsQueryPrestamos.CargarComboBoxFiltroNombre();
            CmbFiltroBuscar.DisplayMember = "empNombre";
            CmbFiltroBuscar.ValueMember = "empId";

        }

        private void FrmMantenimientoPrestamos_Load(object sender, EventArgs e)
        {
            DgvEmpleados.DataSource = sql.MostrarDatosEmpleados();
            DgvPrestamos.DataSource = sql.MostrarDatos();
            BtnGrabar.Visible = false;
            BtnCancelar.Visible = false;
            BtnImprimirSolicitud.Visible = false;

            CmbNombre.SelectedIndex = -1;
            DtpFechaPrestamo.Value = DateTime.Today;
            DtpFechaAbono.Value = DateTime.Today;
            CmbFiltroBuscar.SelectedIndex = -1;

            RbtPrestamo.Enabled = false;
            RbtAbono.Enabled = false;
            DtpFechaPrestamo.Enabled = false;
            TxtValorPrestamo.Enabled = false;
            TxtNumeroCuotas.Enabled = false;
            TxtValorCuota.Enabled = false;
            DtpFechaAbono.Enabled = false;
            TxtValorAbono.Enabled = false;
        }

        private void RbtPrestamo_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtPrestamo.Checked == true)
            {
                CmbNombre.Enabled = true;
                RbtAbono.Enabled = false;
                RbtPrestamo.Enabled = false;
                BtnGrabar.Visible = true;
                BtnNuevo.Visible = false;
            }
        }

        private void RbtAbono_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtAbono.Checked == true)
            {
                CmbNombre.Enabled = true;
                RbtAbono.Enabled = false;
                RbtPrestamo.Enabled = false;
                BtnGrabar.Visible = true;
                BtnNuevo.Visible = false;
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            opcion = "add";

            BtnNuevo.Visible = false;
            BtnCancelar.Visible = true;

            BtnGrabar.Enabled = true;
            BtnCancelar.Enabled = true;
            CmbFiltroBuscar.Enabled = false;
            BtnFiltroBuscar.Enabled = false;
            

            CmbNombre.SelectedIndex = -1;
            DtpFechaPrestamo.Value = DateTime.Today;
            TxtValorPrestamo.Text = "0";
            TxtNumeroCuotas.Text = "0";
            TxtValorCuota.Text = "0";
            DtpFechaAbono.Value = DateTime.Today;
            TxtValorAbono.Text = "0";
            TxtObservaciones.Text = "";
            CmbFiltroBuscar.SelectedIndex = -1;

            RbtPrestamo.Enabled = true;
            RbtAbono.Enabled = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            BtnNuevo.Visible = true;
            BtnGrabar.Visible = false;
            BtnCancelar.Visible = false;

            CmbNombre.SelectedIndex = -1;
            DtpFechaPrestamo.Value = DateTime.Today;
            TxtValorPrestamo.Text = "0";
            TxtNumeroCuotas.Text = "0";
            TxtValorCuota.Text = "0";
            DtpFechaAbono.Value = DateTime.Today;
            TxtValorAbono.Text = "0";
            TxtObservaciones.Text = "";

            RbtAbono.Checked = false;
            RbtPrestamo.Checked = false;

            RbtPrestamo.Enabled = false;
            RbtAbono.Enabled = false;
            CmbNombre.Enabled = false;
            DtpFechaPrestamo.Enabled = false;
            TxtValorPrestamo.Enabled = false;
            TxtNumeroCuotas.Enabled = false;
            TxtValorCuota.Enabled = false;
            DtpFechaAbono.Enabled = false;
            TxtValorAbono.Enabled = false;
            TxtObservaciones.Enabled = false;

            CmbFiltroBuscar.Enabled = true;
            BtnFiltroBuscar.Enabled = true;

        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            if (opcion == "add")
            {
                if (CmbNombre.Text.Trim() != "")
                {
                    string secMax = sql.SecuenciaId();

                    Int32 secNew = Convert.ToInt32(secMax) + 1;
                    string[] ced = CmbNombre.Text.ToString().Trim().Split('-');
                    var cedula = ced[0].Trim();

                    var svc = sql.RecuperarSaldo(cedula);

                    string[] res = svc.ToString().Trim().Split('|');
                    var saldo = res[0];
                    var valorcuota = res[1];

                    var newsaldo = (Convert.ToDecimal(TxtValorPrestamo.Text.Trim()) + Convert.ToDecimal(saldo.Trim()) - Convert.ToDecimal(TxtValorAbono.Text.Trim())).ToString();

                    if (RbtAbono.Checked == true)
                        DtpFechaPrestamo.Value = Convert.ToDateTime("1900/01/01");
                    else
                    {
                        DtpFechaAbono.Value = Convert.ToDateTime("1900/01/01");
                        valorcuota = TxtValorCuota.Text.Trim();
                    }

                    if (sql.Insertar(secNew.ToString(),
                                     cedula,
                                     Convert.ToDateTime(DtpFechaPrestamo.Value),
                                     Convert.ToDecimal(TxtValorPrestamo.Text.Trim()),
                                     Convert.ToInt32(TxtNumeroCuotas.Text.Trim()),
                                     Convert.ToDecimal(TxtValorCuota.Text.Trim()),
                                     Convert.ToDateTime(DtpFechaAbono.Value),
                                     Convert.ToDecimal(TxtValorAbono.Text.Trim()),
                                     TxtObservaciones.Text,
                                     newsaldo))
                    {
                        sql.ActualizarSaldo(cedula, newsaldo, valorcuota);

                        DgvPrestamos.DataSource = sql.MostrarDatos();
                        DgvEmpleados.DataSource = sql.MostrarDatosEmpleados();
                        CargarComboBox();
                        CmbNombre.SelectedIndex = -1;
                        CmbFiltroBuscar.SelectedIndex = -1;

                        MessageBox.Show("Datos Insertados OK...", "Inserción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al Insertar datos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (opcion == "upd")
            {
            }

            BtnNuevo.Visible = true;
            BtnGrabar.Visible = false;
            BtnCancelar.Visible = false;

            CmbNombre.SelectedIndex = -1;
            DtpFechaPrestamo.Value = DateTime.Today;
            TxtValorPrestamo.Text = "0";
            TxtNumeroCuotas.Text = "0";
            TxtValorCuota.Text = "0";
            DtpFechaAbono.Value = DateTime.Today;
            TxtValorAbono.Text = "0";
            TxtObservaciones.Text = "";

            RbtAbono.Checked = false;
            RbtPrestamo.Checked = false;

            RbtPrestamo.Enabled = false;
            RbtAbono.Enabled = false;
            CmbNombre.Enabled = false;
            DtpFechaPrestamo.Enabled = false;
            TxtValorPrestamo.Enabled = false;
            TxtNumeroCuotas.Enabled = false;
            TxtValorCuota.Enabled = false;
            DtpFechaAbono.Enabled = false;
            TxtValorAbono.Enabled = false;
            TxtObservaciones.Enabled = false;

            CmbFiltroBuscar.Enabled = true;
            BtnFiltroBuscar.Enabled = true;

        }

        private void TxtValorPrestamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsObtenerConexion.ValidarNumeros(e);
        }

        private void TxtValorCuota_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsObtenerConexion.ValidarNumeros(e);
        }

        private void TxtObservaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsObtenerConexion.ValidarCaracteres(e);
        }

        private void TxtValorPrestamo_Validated(object sender, EventArgs e)
        {
            if (TxtValorPrestamo.Text != "")
            {
                if (Convert.ToDecimal(TxtValorPrestamo.Text) <= 0)
                    MessageBox.Show("Valor invalido...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Valor invalido...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TxtValorCuota_Validated(object sender, EventArgs e)
        {
            if (TxtValorCuota.Text != "")
            {
                if (Convert.ToDecimal(TxtValorCuota.Text) > 0)
                    if (Convert.ToDecimal(TxtValorCuota.Text) <= Convert.ToDecimal(TxtValorPrestamo.Text))
                    {
                        TxtNumeroCuotas.Text = Math.Truncate(Convert.ToDecimal(TxtValorPrestamo.Text) / Convert.ToDecimal(TxtValorCuota.Text)).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Valor invalido...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                else
                {
                    MessageBox.Show("Valor invalido...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Valor invalido...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtValorAbono_Validated(object sender, EventArgs e)
        {
            if (TxtValorAbono.Text != "")
            {
                if (Convert.ToDecimal(TxtValorAbono.Text) <= 0)
                    MessageBox.Show("Valor invalido...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Valor invalido...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnFiltroBuscar_Click(object sender, EventArgs e)
        {
            if (CmbFiltroBuscar.SelectedIndex != -1)
            {
                string[] ced = CmbFiltroBuscar.Text.ToString().Trim().Split('-');
                string cedula = ced[0].Trim();

                DgvPrestamos.DataSource = sql.Buscar(cedula);
                CmbFiltroBuscar.SelectedIndex = -1;
            }
            else
            {
                DgvPrestamos.DataSource = sql.MostrarDatos();
            }
        }

        private void CmbNombre_TextChanged(object sender, EventArgs e)
        {
            if (RbtPrestamo.Checked == true)
            {
                DtpFechaAbono.Enabled = false;
                TxtValorAbono.Enabled = false;

                DtpFechaPrestamo.Enabled = true;
                TxtValorPrestamo.Enabled = true;
                TxtValorCuota.Enabled = true;
                TxtObservaciones.Enabled = true;
            }
            if (RbtAbono.Checked == true)
            {
                DtpFechaAbono.Enabled = true;
                TxtValorAbono.Enabled = true;
                TxtObservaciones.Enabled = true;

                DtpFechaPrestamo.Enabled = false;
                TxtValorPrestamo.Enabled = false;
                TxtValorCuota.Enabled = false;
            }
        }
    }
}
