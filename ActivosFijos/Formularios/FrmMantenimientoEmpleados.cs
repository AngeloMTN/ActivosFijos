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
    public partial class FrmMantenimientoEmpleados : Form
    {
        readonly ClsQueryEmpleados sql = new ClsQueryEmpleados();

        public FrmMantenimientoEmpleados()
        {
            InitializeComponent();
        }

        public string opcion = null;

        private void FrmMantenimientoEmpleados_Load(object sender, EventArgs e)
        {
            DgvEmpleados.DataSource = sql.MostrarDatos();
            BtnGrabar.Visible = false;
            BtnCancelar.Visible = false;
        }

        private void BtnFiltroBuscar_Click(object sender, EventArgs e)
        {
            if (TxtFiltroNombre.Text != "")
            {
                DgvEmpleados.DataSource = sql.Buscar(TxtFiltroNombre.Text);
            }
            else
            {
                DgvEmpleados.DataSource = sql.MostrarDatos();
            }

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            opcion = "add";

            BtnNuevo.Visible = false;
            BtnEliminar.Visible = false;
            BtnGrabar.Visible = true;
            BtnCancelar.Visible = true;
            BtnModificar.Visible = false;

            TxtCedula.Enabled = true;
            TxtNombre.Enabled = true;
            DtpFechaEntrada.Enabled = true;

            TxtId.Text = "";
            TxtCedula.Text = "";
            TxtNombre.Text = "";
            DtpFechaEntrada.Value = DateTime.Today;

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            opcion = "upd";

            BtnNuevo.Visible = false;
            BtnEliminar.Visible = false;
            BtnGrabar.Visible = true;
            BtnCancelar.Visible = true;
            BtnModificar.Visible = false;

            TxtCedula.Enabled = true;
            TxtNombre.Enabled = true;
            DtpFechaEntrada.Enabled = true;

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //Validar que no exista la cedula del empleado que se va a borrar 
            //en la tabla PrestamosEmpleados y RegistroVacaciones
            int nroFilas = sql.ValidarRelacionados(TxtCedula.Text.Trim());
            if (nroFilas > 0)
            {
                MessageBox.Show("ERROR: No se puede Eliminar porque existe registro(s) relacionados en las tablas PrestamosEmpleados o RegistroVacaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult resp = MessageBox.Show("Confirma que desea Eliminar el Empleado...?", "", MessageBoxButtons.YesNo);
                if (resp == DialogResult.Yes)
                {
                    if (TxtId.Text.Trim() != "")
                    {
                        if (sql.Eliminar(TxtId.Text))
                        {
                            DgvEmpleados.DataSource = sql.MostrarDatos();

                            TxtId.Text = "";
                            TxtCedula.Text = "";
                            TxtNombre.Text = "";
                            DtpFechaEntrada.Value = DateTime.Today;

                            MessageBox.Show("Datos Eliminados OK...", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al Eliminar datos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Primero seleccione cualquier fila dando click para proceder con la Modificacion...", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            BtnNuevo.Visible = true;
            BtnEliminar.Visible = true;
            BtnGrabar.Visible = false;
            BtnCancelar.Visible = false;
            BtnModificar.Visible = true;

            TxtCedula.Enabled = false;
            TxtNombre.Enabled = false;
            DtpFechaEntrada.Enabled = false;

            TxtId.Text = "";
            TxtCedula.Text = "";
            TxtNombre.Text = "";
            DtpFechaEntrada.Value = DateTime.Today;

        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            if (opcion == "add")
            {
                if (TxtCedula.Text.Trim() != "")
                {
                    string secMax = sql.SecuenciaId();
                    Int32 secNew = Convert.ToInt32(secMax) + 1;

                    if (sql.Insertar(secNew.ToString(), TxtCedula.Text.Trim(), TxtNombre.Text.Trim(), DtpFechaEntrada.Value.ToString()))
                    {
                        DgvEmpleados.DataSource = sql.MostrarDatos();
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
                if (TxtId.Text.Trim() != "")
                {
                    if (sql.Actualizar(TxtId.Text.Trim(), TxtCedula.Text.Trim(), TxtNombre.Text.Trim(), DtpFechaEntrada.Value))
                    {
                        DgvEmpleados.DataSource = sql.MostrarDatos();
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

            BtnNuevo.Visible = true;
            BtnEliminar.Visible = true;
            BtnGrabar.Visible = false;
            BtnCancelar.Visible = false;
            BtnModificar.Visible = true;

            TxtCedula.Enabled = false;
            TxtNombre.Enabled = false;
            DtpFechaEntrada.Enabled = false;

            TxtId.Text = "";
            TxtCedula.Text = "";
            TxtNombre.Text = "";
            DtpFechaEntrada.Value = DateTime.Today;

        }

        private void DgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int totalFilas = DgvEmpleados.Rows.Count;
                int filaSeleccionada = DgvEmpleados.CurrentRow.Index;
                if (filaSeleccionada >= 0 && filaSeleccionada != totalFilas - 1)
                {
                    DataGridViewRow fila = DgvEmpleados.Rows[e.RowIndex];
                    TxtId.Text = Convert.ToString(fila.Cells[0].Value);
                    TxtCedula.Text = Convert.ToString(fila.Cells[1].Value);
                    TxtNombre.Text = Convert.ToString(fila.Cells[2].Value);
                    DtpFechaEntrada.Value = Convert.ToDateTime(fila.Cells[3].Value);
                    TxtNombre.Enabled = false;
                }
            }

        }
    }
}
