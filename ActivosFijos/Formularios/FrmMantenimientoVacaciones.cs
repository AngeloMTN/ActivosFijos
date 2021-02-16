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
    public partial class FrmMantenimientoVacaciones : Form
    {
        public string opcion = null;

        readonly ClsQueryVacaciones sql = new ClsQueryVacaciones();

        public FrmMantenimientoVacaciones()
        {
            InitializeComponent();

            CargarComboBox();

        }

        public void CargarComboBox()
        {
            CmbRegistroNombre.DataSource = ClsQueryVacaciones.CargarComboBoxRegistroNombre();
            CmbRegistroNombre.DisplayMember = "empNombre";
            CmbRegistroNombre.ValueMember = "empId";

            CmbFiltroRegistroBuscar.DataSource = ClsQueryVacaciones.CargarComboBoxFiltroRegistroNombre();
            CmbFiltroRegistroBuscar.DisplayMember = "empNombre";
            CmbFiltroRegistroBuscar.ValueMember = "empId";

        }

        private void FrmMantenimientoVacaciones_Load(object sender, EventArgs e)
        {
            BtnEmpleadoGrabar.Visible = false;
            BtnEmpleadoModificar.Visible = false;
            BtnEmpleadoEliminar.Visible = false;
            BtnEmpleadoCancelar.Visible = false;
            BtnEmpleadoCancelar.Visible = false;

            BtnRegistroGrabar.Visible = false;
            BtnRegistroEliminar.Visible = false;
            BtnRegistroCancelar.Visible = false;
            BtnImprimirSolicitud.Visible = false;

            CmbRegistroNombre.SelectedIndex = -1;
            CmbFiltroRegistroBuscar.SelectedIndex = -1;

            DtpFechaEntrada.Value = DateTime.Today;
            DtpRegistroFechaEntrada.Value = Convert.ToDateTime("1900/01/01");
            DtpFechaRetorno.Value = DateTime.Today;
            DtpFechaSalida.Value = DateTime.Today;

            sql.RecalcularVacaciones();

            DgvEmpleados.DataSource = sql.MostrarDatos();

            DgvRegistroVacaciones.DataSource = sql.MostrarDatosVacaciones();
        }

        private void BtnEmpleadoNuevo_Click(object sender, EventArgs e)
        {
            opcion = "add";

            BtnEmpleadoNuevo.Visible = false;
            BtnEmpleadoEliminar.Visible = false;
            BtnEmpleadoGrabar.Visible = true;
            BtnEmpleadoCancelar.Visible = true;
            BtnEmpleadoModificar.Visible = false;

            BtnEmpleadoGrabar.Enabled = true;
            BtnEmpleadoModificar.Enabled = true;
            BtnEmpleadoEliminar.Enabled = true;
            BtnEmpleadoCancelar.Enabled = true;
            TxtFiltroEmpleadoBuscar.Enabled = false;
            BtnFiltroEmpleadoBuscar.Enabled = false;

            TxtCedula.Enabled = true;
            TxtNombre.Enabled = true;
            DtpFechaEntrada.Enabled = true;

            TxtId.Text = "";
            TxtCedula.Text = "";
            TxtNombre.Text = "";
            DtpFechaEntrada.Value = DateTime.Today;

        }

        private void BtnEmpleadoModificar_Click(object sender, EventArgs e)
        {
            opcion = "upd";
            BtnEmpleadoNuevo.Visible = false;
            BtnEmpleadoEliminar.Visible = false;
            BtnEmpleadoModificar.Visible = false;
            BtnEmpleadoCancelar.Visible = true;
            BtnEmpleadoGrabar.Visible = true;

            TxtCedula.Enabled = true;
            TxtNombre.Enabled = true;
            DtpFechaEntrada.Enabled = true;
        }

        private void BtnEmpleadoEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Confirma que desea Eliminar el Empleado...?", "", MessageBoxButtons.YesNo);
            if (resp == DialogResult.Yes)
            {
                if (TxtCedula.Text.Trim() != "")
                {
                    if (sql.Eliminar(TxtId.Text))
                    {
                        DgvEmpleados.DataSource = sql.MostrarDatos();

                        TxtId.Text = "";
                        TxtCedula.Text = "";
                        TxtNombre.Text = "";
                        DtpFechaEntrada.Value = DateTime.Today;

                        BtnEmpleadoNuevo.Visible = true;
                        BtnEmpleadoEliminar.Visible = false;
                        BtnEmpleadoModificar.Visible = false;
                        BtnEmpleadoCancelar.Visible = false;
                        BtnEmpleadoGrabar.Visible = false;

                        TxtFiltroEmpleadoBuscar.Enabled = true;
                        BtnFiltroEmpleadoBuscar.Enabled = true;

                        MessageBox.Show("Datos Eliminados OK...", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al Eliminar datos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Primero seleccione cualquier fila dando click para proceder con la Eliminación...", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void BtnEmpleadoGrabar_Click(object sender, EventArgs e)
        {
            if (opcion == "add")
            {
                if (TxtCedula.Text.Trim() != "")
                {
                    string secMax = sql.SecuenciaId();
                    Int32 secNew = Convert.ToInt32(secMax) + 1;

                    if (sql.Insertar(secNew.ToString(), TxtCedula.Text, TxtNombre.Text, Convert.ToDateTime(DtpFechaEntrada.Value)))
                    {
                        DgvEmpleados.DataSource = sql.MostrarDatos();
                        CargarComboBox();
                        CmbRegistroNombre.SelectedIndex = -1;
                        CmbFiltroRegistroBuscar.SelectedIndex = -1;

                        MessageBox.Show("Datos Insertados OK...", "Inserción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al Insertar datos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Falta llenar datos, imposible Grabar...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (opcion == "upd")
            {
                if (TxtCedula.Text.Trim() != "")
                {
                    if (sql.Actualizar(TxtId.Text, TxtCedula.Text, TxtNombre.Text, Convert.ToDateTime(DtpFechaEntrada.Value)))
                    {
                        DgvEmpleados.DataSource = sql.MostrarDatos();
                        CargarComboBox();
                        CmbRegistroNombre.SelectedIndex = -1;
                        CmbFiltroRegistroBuscar.SelectedIndex = -1;

                        MessageBox.Show("Datos Modificados OK...", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al Modificar datos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Primero seleccione cualquier fila dando click para proceder con la Modificacion...", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            BtnEmpleadoNuevo.Visible = true;
            BtnEmpleadoEliminar.Visible = false;
            BtnEmpleadoGrabar.Visible = false;
            BtnEmpleadoCancelar.Visible = false;
            BtnEmpleadoModificar.Visible = false;

            TxtCedula.Enabled = false;
            TxtNombre.Enabled = false;
            DtpFechaEntrada.Enabled = false;

            TxtCedula.Text = "";
            TxtNombre.Text = "";
            DtpFechaEntrada.Value = DateTime.Today;

            TxtFiltroEmpleadoBuscar.Enabled = true;
            BtnFiltroEmpleadoBuscar.Enabled = true;
        }

        private void BtnEmpleadoCancelar_Click(object sender, EventArgs e)
        {
            BtnEmpleadoNuevo.Visible = true;
            BtnEmpleadoGrabar.Visible = false;
            BtnEmpleadoModificar.Visible = false;
            BtnEmpleadoEliminar.Visible = false;
            BtnEmpleadoCancelar.Visible = false;

            TxtId.Text = "";
            TxtCedula.Text = "";
            TxtNombre.Text = "";
            DtpFechaEntrada.Value = DateTime.Today;

            TxtCedula.Enabled = false;
            TxtNombre.Enabled = false;
            DtpFechaEntrada.Enabled = false;

            TxtFiltroEmpleadoBuscar.Enabled = true;
            BtnFiltroEmpleadoBuscar.Enabled = true;

        }

        private void DgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int totalFilas = DgvEmpleados.Rows.Count - 2;
            int filaSeleccionada = DgvEmpleados.CurrentRow.Index;

            if (e.RowIndex != -1 && e.RowIndex <= totalFilas)
            {
                if (filaSeleccionada >= 0 && filaSeleccionada <= totalFilas)
                {
                    DataGridViewRow fila = DgvEmpleados.Rows[e.RowIndex];
                    TxtId.Text = Convert.ToString(fila.Cells[0].Value);
                    TxtCedula.Text = Convert.ToString(fila.Cells[1].Value);
                    TxtNombre.Text = Convert.ToString(fila.Cells[2].Value);
                    DtpFechaEntrada.Value = Convert.ToDateTime(fila.Cells[3].Value);

                    TxtCedula.Enabled = false;
                    TxtNombre.Enabled = false;
                    DtpFechaEntrada.Enabled = false;
                }
                else
                {
                    sql.LimpiarCampos(this, groupBox2, groupBox3, groupBox4, groupBox5);
                }

                BtnEmpleadoModificar.Visible = true;
                BtnEmpleadoEliminar.Visible = true;
                BtnEmpleadoCancelar.Visible = true;

            }

        }

        private void BtnFiltroEmpleadoBuscar_Click(object sender, EventArgs e)
        {
            if (TxtFiltroEmpleadoBuscar.Text != "")
            {
                DgvEmpleados.DataSource = sql.Buscar(TxtFiltroEmpleadoBuscar.Text);
            }
            else
            {
                DgvEmpleados.DataSource = sql.MostrarDatos();
            }

        }

        private void BtnRegistroNuevo_Click(object sender, EventArgs e)
        {
            opcion = "add";

            BtnRegistroNuevo.Visible = false;
            BtnRegistroEliminar.Visible = false;
            BtnRegistroGrabar.Visible = true;
            BtnRegistroCancelar.Visible = true;
            BtnImprimirSolicitud.Visible = true;

            CmbRegistroNombre.Enabled = true;
            DtpFechaSalida.Enabled = true;
            DtpFechaRetorno.Enabled = true;
            TxtObservaciones.Enabled = true;

            CmbFiltroRegistroBuscar.Enabled = false;
            BtnFiltroRegistroBuscar.Enabled = false;

            CmbFiltroRegistroBuscar.SelectedItem = 0;
            DtpRegistroFechaEntrada.Value = Convert.ToDateTime("1900/01/01");
            DtpFechaRetorno.Value = DateTime.Today;
            DtpFechaSalida.Value = DateTime.Today;
            TxtDiasTomados.Text = "";
            TxtObservaciones.Text = "";

        }

        private void BtnRegistroEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Confirma que desea Eliminar el Registro...?", "", MessageBoxButtons.YesNo);
            if (resp == DialogResult.Yes)
            {
                if (TxtIdRegistro.Text.Trim() != "")
                {
                    if (sql.EliminarVacaciones(TxtIdRegistro.Text))
                    {
                        sql.RecalcularVacaciones();

                        DgvRegistroVacaciones.DataSource = sql.MostrarDatosVacaciones();

                        TxtIdRegistro.Text = "";
                        CmbRegistroNombre.SelectedIndex = -1;
                        DtpRegistroFechaEntrada.Value = Convert.ToDateTime("1900/01/01");
                        DtpFechaRetorno.Value = DateTime.Today;
                        DtpFechaSalida.Value = DateTime.Today;
                        TxtDiasTomados.Text = "";
                        TxtObservaciones.Text = "";

                        BtnRegistroNuevo.Visible = true;
                        BtnRegistroEliminar.Visible = false;
                        BtnRegistroCancelar.Visible = false;
                        BtnRegistroGrabar.Visible = false;
                        BtnImprimirSolicitud.Visible = false;

                        CmbFiltroRegistroBuscar.Enabled = true;
                        BtnFiltroRegistroBuscar.Enabled = true;

                        MessageBox.Show("Datos Eliminados OK...", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al Eliminar datos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Primero seleccione cualquier fila dando click para proceder con la Eliminación...", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void BtnRegistroGrabar_Click(object sender, EventArgs e)
        {
            if (opcion == "add")
            {
                if (TxtDiasTomados.Text.Trim() != "")
                {
                    string secMax = sql.SecuenciaIdVacaciones();
                    Int32 secNew = Convert.ToInt32(secMax) + 1;
                    TxtIdRegistro.Text = secNew.ToString();
                    string[] ced = CmbRegistroNombre.Text.ToString().Trim().Split('-');
                    string cedula = ced[0].Trim();

                    if (sql.InsertarVacaciones(secNew.ToString(),
                                               cedula,
                                               Convert.ToDateTime(DtpFechaSalida.Value),
                                               Convert.ToDateTime(DtpFechaRetorno.Value),
                                               TxtDiasTomados.Text.ToString(),
                                               TxtObservaciones.Text,
                                               TxtAntiguedad.Text,
                                               TxtDiasPorAnio.Text,
                                               TxtSaldo.Text))
                    {
                        MessageBox.Show("Datos Insertados OK...", "Inserción", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        BtnImprimirSolicitud.PerformClick();

                        sql.RecalcularVacaciones();
                        DgvEmpleados.DataSource = sql.MostrarDatos();
                        DgvRegistroVacaciones.DataSource = sql.MostrarDatosVacaciones();
                        CmbRegistroNombre.SelectedIndex = -1;

                    }
                    else
                    {
                        MessageBox.Show("Error al Insertar datos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Falta llenar datos, imposible Grabar...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            BtnRegistroNuevo.Visible = true;
            BtnRegistroEliminar.Visible = false;
            BtnRegistroGrabar.Visible = false;
            BtnRegistroCancelar.Visible = false;
            BtnImprimirSolicitud.Visible = false;

            DtpRegistroFechaEntrada.Value = Convert.ToDateTime("1900/01/01");
            DtpFechaSalida.Value = DateTime.Today;
            DtpFechaRetorno.Value = DateTime.Today;
            TxtDiasTomados.Text = "";
            TxtObservaciones.Text = "";
            TxtAntiguedad.Text = "";
            TxtDiasPorAnio.Text = "";
            TxtSaldo.Text = "";

            CmbRegistroNombre.Enabled = false;
            DtpFechaSalida.Enabled = false;
            DtpFechaRetorno.Enabled = false;
            TxtObservaciones.Enabled = false;

            CmbFiltroRegistroBuscar.Enabled = true;
            BtnFiltroRegistroBuscar.Enabled = true;

        }

        private void BtnRegistroCancelar_Click(object sender, EventArgs e)
        {
            BtnRegistroNuevo.Visible = true;
            BtnRegistroGrabar.Visible = false;
            BtnRegistroEliminar.Visible = false;
            BtnRegistroCancelar.Visible = false;
            BtnImprimirSolicitud.Visible = false;

            TxtIdRegistro.Text = "";
            CmbRegistroNombre.SelectedIndex = -1;
            DtpRegistroFechaEntrada.Value = Convert.ToDateTime("1900/01/01");
            DtpFechaRetorno.Value = DateTime.Today;
            DtpFechaSalida.Value = DateTime.Today;
            TxtDiasTomados.Text = "";
            TxtObservaciones.Text = "";

            CmbRegistroNombre.Enabled = false;
            DtpFechaSalida.Enabled = false;
            DtpFechaRetorno.Enabled = false;
            TxtObservaciones.Enabled = false;


            CmbFiltroRegistroBuscar.Enabled = true;
            BtnFiltroRegistroBuscar.Enabled = true;

        }

        private void BtnFiltroRegistroBuscar_Click(object sender, EventArgs e)
        {
            if (CmbFiltroRegistroBuscar.SelectedIndex != -1)
            {
                string[] ced = CmbFiltroRegistroBuscar.Text.ToString().Trim().Split('-');
                string cedula = ced[0].Trim();

                DgvRegistroVacaciones.DataSource = sql.BuscarVacaciones(cedula);
                CmbFiltroRegistroBuscar.SelectedIndex = -1;
            }
            else
            {
                DgvRegistroVacaciones.DataSource = sql.MostrarDatosVacaciones();
            }

        }

        private void DgvRegistroVacaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int totalFilas = DgvRegistroVacaciones.Rows.Count - 2;
            int filaSeleccionada = DgvRegistroVacaciones.CurrentRow.Index;

            if (e.RowIndex != -1 && e.RowIndex <= totalFilas)
            {
                if (filaSeleccionada >= 0 && filaSeleccionada <= totalFilas)
                {
                    DataGridViewRow fila = DgvRegistroVacaciones.Rows[e.RowIndex];
                    TxtIdRegistro.Text = Convert.ToString(fila.Cells[0].Value);
                    int indexreg = CmbRegistroNombre.FindString(Convert.ToString(fila.Cells[1].Value).Trim());
                    CmbRegistroNombre.SelectedIndex = indexreg;
                    DtpRegistroFechaEntrada.Value = Convert.ToDateTime(fila.Cells[3].Value);
                    DtpFechaSalida.Value = Convert.ToDateTime(fila.Cells[4].Value);
                    DtpFechaRetorno.Value = Convert.ToDateTime(fila.Cells[5].Value);
                    TxtDiasTomados.Text = Convert.ToString(fila.Cells[6].Value);
                    TxtObservaciones.Text = Convert.ToString(fila.Cells[7].Value);
                    TxtAntiguedad.Text = Convert.ToString(fila.Cells[8].Value);
                    TxtDiasPorAnio.Text = Convert.ToString(fila.Cells[9].Value);
                    TxtSaldo.Text = Convert.ToString(fila.Cells[10].Value);

                    TxtCedula.Enabled = false;
                    TxtNombre.Enabled = false;
                    DtpFechaEntrada.Enabled = false;
                }
                else
                {
                    sql.LimpiarCampos(this, groupBox2, groupBox3, groupBox4, groupBox5);
                }

                BtnRegistroEliminar.Visible = true;
                BtnRegistroCancelar.Visible = true;
                BtnImprimirSolicitud.Visible = true;

            }
        }

        private void DtpFechaSalida_ValueChanged(object sender, EventArgs e)
        {
            if (DtpFechaSalida.Value <= DtpFechaRetorno.Value)
            {
                TimeSpan dias = DtpFechaRetorno.Value - DtpFechaSalida.Value;
                TxtDiasTomados.Text = dias.Days.ToString();
            }
            else
            {
                MessageBox.Show("La fecha de Salida debe ser menor o igual a la fecha de Retorno ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DtpFechaRetorno_ValueChanged(object sender, EventArgs e)
        {
            if (DtpFechaRetorno.Value >= DtpFechaSalida.Value)
            {
                TimeSpan dias = DtpFechaRetorno.Value - DtpFechaSalida.Value;
                TxtDiasTomados.Text = dias.Days.ToString();
            }
            else
            {
                MessageBox.Show("La fecha de Retorno debe ser mayor o igual a la fecha de Salida ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbRegistroNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] ced = CmbRegistroNombre.Text.ToString().Trim().Split('-');
            string cedula = ced[0].Trim();

            foreach (DataGridViewRow Row in DgvEmpleados.Rows)
            {
                string valor = Convert.ToString(Row.Cells["Cedula"].Value).Trim();

                if (valor == cedula && cedula != "" )
                {
                    //DgvEmpleados.Rows[strFila].DefaultCellStyle.BackColor = Color.Red;

                    string ant = Convert.ToString(Row.Cells["Antiguedad"].Value).Trim();
                    string[] antig = ant.Split('|');
                    TxtAntiguedad.Text = antig[0].Trim();
                    DtpRegistroFechaEntrada.Value = Convert.ToDateTime(Row.Cells["Entrada"].Value);
                    TxtDiasPorAnio.Text = Convert.ToString(Row.Cells["DiasPorAnio"].Value).Trim();
                    TxtSaldo.Text = Convert.ToString(Row.Cells["Saldo"].Value).Trim();
                    break;
                }
            }
        }

        private void BtnImprimirSolicitud_Click(object sender, EventArgs e)
        {
            string[] ced = CmbRegistroNombre.Text.ToString().Trim().Split('-');
            string cedula = ced[0].Trim();

            FrmReporteSolicitudVacaciones rpt = new FrmReporteSolicitudVacaciones();

            ClsDatosSolicitudVacaciones data = new ClsDatosSolicitudVacaciones
            {
                RegId = Convert.ToInt32(TxtIdRegistro.Text.Trim()),
                RegCedula = cedula,
                EmpNombre = CmbRegistroNombre.Text.Trim(),
                EmpFechaEntrada = DtpRegistroFechaEntrada.Value.ToString().Trim(),
                RegAntiguedad = TxtAntiguedad.Text.Trim(),
                RegDiasPorAnio = TxtDiasPorAnio.Text.Trim(),
                RegSaldo = TxtSaldo.Text.Trim(),
                RegFechaSalida = DtpFechaSalida.Value.ToString().Trim(),
                RegFechaRetorno = DtpFechaRetorno.Value.ToString().Trim(),
                RegDiasTomados = TxtDiasTomados.Text.Trim(),
                RegObservaciones = TxtObservaciones.Text.Trim(),
                RegFechaCreacion = Convert.ToString(DateTime.Now)
            };

            rpt.DatosSV.Add(data);
            rpt.ShowDialog();

        }
    }
}
