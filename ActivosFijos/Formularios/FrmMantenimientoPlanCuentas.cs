using ActivosFijos.Clases;
using System;
using System.Windows.Forms;


namespace ActivosFijos.Formularios
{
    public partial class FrmMantenimientoPlanCuentas : Form
    {
        readonly ClsQueryPlanCuentas sql = new ClsQueryPlanCuentas();

        public FrmMantenimientoPlanCuentas()
        {
            InitializeComponent();
        }

        public string opcion = null;

        private void BtnFiltroBuscar_Click(object sender, EventArgs e)
        {
            if (TxtFiltroNombre.Text != "")
            {
                DgvPlanCuentas.DataSource = sql.Buscar(TxtFiltroNombre.Text);
            }
            else
            {
                DgvPlanCuentas.DataSource = sql.MostrarDatos();
            }

        }

        private void DgvPlanCuentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int totalFilas = DgvPlanCuentas.Rows.Count;
                int filaSeleccionada = DgvPlanCuentas.CurrentRow.Index;
                if (filaSeleccionada >= 0 && filaSeleccionada != totalFilas - 1)
                {
                    DataGridViewRow fila = DgvPlanCuentas.Rows[e.RowIndex];
                    TxtCodigo.Text = Convert.ToString(fila.Cells[0].Value);
                    TxtCuenta.Text = Convert.ToString(fila.Cells[1].Value);
                    TxtNombre.Text = Convert.ToString(fila.Cells[2].Value);

                    TxtCuenta.Enabled = false;
                    TxtNombre.Enabled = false;
                }
            }
        }

        private void FrmMantenimientoPlanCuentas_Load(object sender, EventArgs e)
        {
            DgvPlanCuentas.DataSource = sql.MostrarDatos();
            BtnGrabar.Visible = false;
            BtnCancelar.Visible = false;

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            opcion = "add";

            BtnNuevo.Visible = false;
            BtnEliminar.Visible = false;
            BtnGrabar.Visible = true;
            BtnCancelar.Visible = true;
            BtnModificar.Visible = false;

            TxtCuenta.Enabled = true;
            TxtNombre.Enabled = true;

            TxtCodigo.Text = "";
            TxtCuenta.Text = "";
            TxtNombre.Text = "";

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            opcion = "upd";

            BtnNuevo.Visible = false;
            BtnEliminar.Visible = false;
            BtnGrabar.Visible = true;
            BtnCancelar.Visible = true;
            BtnModificar.Visible = false;

            TxtCuenta.Enabled = true; 
            TxtNombre.Enabled = true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Confirma que desea Eliminar la Cuenta...?", "", MessageBoxButtons.YesNo);
            if (resp == DialogResult.Yes)
            {
                if (TxtCuenta.Text.Trim() != "")
                {
                    if (sql.Eliminar(TxtCodigo.Text))
                    {
                        DgvPlanCuentas.DataSource = sql.MostrarDatos();

                        TxtCodigo.Text = "";
                        TxtCuenta.Text = "";
                        TxtNombre.Text = "";

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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            BtnNuevo.Visible = true;
            BtnEliminar.Visible = true;
            BtnGrabar.Visible = false;
            BtnCancelar.Visible = false;
            BtnModificar.Visible = true;

            TxtCuenta.Enabled = false; 
            TxtNombre.Enabled = false;
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            if (opcion == "add")
            {
                if (TxtCuenta.Text.Trim() != "")
                {
                    string secMax = sql.SecuenciaId();
                    Int32 secNew = Convert.ToInt32(secMax) + 1;

                    if (sql.Insertar(secNew.ToString(), TxtCuenta.Text.Trim(), TxtNombre.Text.Trim()))
                    {
                        DgvPlanCuentas.DataSource = sql.MostrarDatos();
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
                if (TxtCodigo.Text.Trim() != "")
                {
                    if (sql.Actualizar(TxtCodigo.Text.Trim(), TxtCuenta.Text.Trim(), TxtNombre.Text.Trim()))
                    {
                        DgvPlanCuentas.DataSource = sql.MostrarDatos();
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

            TxtCuenta.Enabled = false;
            TxtNombre.Enabled = false;

            TxtCodigo.Text = "";
            TxtCuenta.Text = "";
            TxtNombre.Text = "";
        }
    }
}
