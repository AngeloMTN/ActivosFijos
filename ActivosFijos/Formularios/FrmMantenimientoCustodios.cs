using ActivosFijos.Clases;
using System;
using System.Windows.Forms;

namespace ActivosFijos.Formularios
{
    public partial class FrmMantenimientoCustodios : Form
    {
        readonly ClsQueryCustodios sql = new ClsQueryCustodios();

        public FrmMantenimientoCustodios()
        {
            InitializeComponent();
        }

        public string opcion = null;

        private void BtnFiltroBuscar_Click(object sender, EventArgs e)
        {
            if (TxtFiltroNombre.Text != "")
            {
                DgvCustodios.DataSource = sql.Buscar(TxtFiltroNombre.Text);
            }
            else
            {
                DgvCustodios.DataSource = sql.MostrarDatos();
            }

        }

        private void DgvCustodios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int totalFilas = DgvCustodios.Rows.Count;
                int filaSeleccionada = DgvCustodios.CurrentRow.Index;
                if (filaSeleccionada >= 0 && filaSeleccionada != totalFilas - 1)
                {
                    DataGridViewRow fila = DgvCustodios.Rows[e.RowIndex];
                    TxtCodigo.Text = Convert.ToString(fila.Cells[0].Value);
                    TxtCedula.Text = Convert.ToString(fila.Cells[1].Value);
                    TxtNombre.Text = Convert.ToString(fila.Cells[2].Value);

                    TxtNombre.Enabled = false;
                }
            }
        }

        private void FrmMantenimientoCustodios_Load(object sender, EventArgs e)
        {
            DgvCustodios.DataSource = sql.MostrarDatos();
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

            TxtCedula.Enabled = true;
            TxtNombre.Enabled = true;

            TxtCodigo.Text = "";
            TxtCedula.Text = "";
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

            TxtCedula.Enabled = true;
            TxtNombre.Enabled = true;

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Confirma que desea Eliminar el Custodio...?", "", MessageBoxButtons.YesNo);
            if (resp == DialogResult.Yes)
            {
                if (TxtCodigo.Text.Trim() != "")
                {
                    if (sql.Eliminar(TxtCodigo.Text))
                    {
                        DgvCustodios.DataSource = sql.MostrarDatos();

                        TxtCodigo.Text = "";
                        TxtCedula.Text = "";
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

            TxtCedula.Enabled = false;
            TxtNombre.Enabled = false;
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            if (opcion == "add")
            {
                if (TxtCedula.Text.Trim() != "")
                {
                    string secMax = sql.SecuenciaId();
                    Int32 secNew = Convert.ToInt32(secMax) + 1;

                    if (sql.Insertar(secNew.ToString(), TxtCedula.Text.Trim(), TxtNombre.Text.Trim()))
                    {
                        DgvCustodios.DataSource = sql.MostrarDatos();
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
                    if (sql.Actualizar(TxtCodigo.Text.Trim(), TxtCedula.Text.Trim(), TxtNombre.Text.Trim()))
                    {
                        DgvCustodios.DataSource = sql.MostrarDatos();
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

            TxtCodigo.Text = "";
            TxtCedula.Text = "";
            TxtNombre.Text = "";

        }
    }
}
