using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCEATCC
{
    public partial class Frmgrupo : Form
    {
        Clsusuario usuario = new Clsusuario();
        Clsfacultad facultad = new Clsfacultad();
        public Frmgrupo()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripButton2.Enabled = true;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = true;
            txtgrado.Enabled = true;
            txtgrupo.Enabled = true;
            cmbturno.Enabled = true;
            cmbcarrera.Enabled = true;
            txtgrupo.Text = "";
            txtgrado.Text = "";

            toolStripButton2.Text = "Grabar";

            facultad.cargarcarrera(cmbcarrera);
            cmbcarrera.Text = "";

            facultad.cargarturno(cmbturno);
            cmbturno.Text = "";

            txtgrupo.Focus();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

            txtgrado.Text = "";
            txtgrupo.Text = "";
            cmbcarrera.Text = "";
            cmbturno.Text = "";
            txtgrado.Enabled = true;
            txtgrupo.Enabled = true;
            cmbcarrera.Enabled = true;
            cmbturno.Enabled = true;
            toolStripButton2.Text = "Grabar";
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
            txtgrupo.Focus();
        }

        private void Frmgrupo_Load(object sender, EventArgs e)
        {
            
            txtgrado.Text = "";
            txtgrupo.Text = "";
            cmbcarrera.Text = "";
            cmbturno.Text = "";
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
            txtgrado.Enabled = false;
            txtgrupo.Enabled = false;
            cmbturno.Enabled = false;
            cmbcarrera.Enabled = false;


            facultad.llenargridgrupo(dgvgrupo);

            dgvgrupo.Columns[0].HeaderText = "Grupo";
            dgvgrupo.Columns[3].HeaderText = "Grado";
            dgvgrupo.Columns[1].Visible = false;
            dgvgrupo.Columns[2].Visible = false;

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult buttton = MessageBox.Show("Esta seguro que desea elimnar el grupo: " + txtgrupo.Text, "Eliminar Grupo", MessageBoxButtons.OKCancel);
            if (buttton == DialogResult.OK)
            {
                facultad._grupo = txtgrupo.Text;
                facultad._grado = txtgrado.Text;
                facultad._cvecarrera = cmbcarrera.SelectedValue.ToString();
                facultad.eliminargrupo();
            }

            facultad.llenargridgrupo(dgvgrupo);
            
            txtgrado.Text = "";
            txtgrupo.Text = "";
            cmbcarrera.Text = "";
            cmbturno.Text = "";

            toolStripButton2.Text = "Grabar";
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
            txtgrado.Enabled = false;
            txtgrupo.Enabled = false;
            cmbturno.Enabled = false;
            cmbcarrera.Enabled = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (txtgrado.Text.Length != 0 && cmbcarrera.Text.Length != 0 && txtgrupo.Text.Length != 0)
            {
                try
                {
                    facultad._grado = txtgrado.Text;
                    facultad._grupo = txtgrupo.Text;
                    facultad._cvecarrera = cmbcarrera.SelectedValue.ToString();
                    facultad._cveturno = cmbturno.SelectedValue.ToString();

                }
                catch (Exception)
                {
                    MessageBox.Show("LOS CAMPOS DEL FORMULARIO NO SON VALIDOS");
                }

                try
                {
                    if (toolStripButton2.Text == "Grabar")
                    {
                        facultad.grabargrupo();
                    }
                    else
                    {
                        facultad.actualizargrupo();

                        toolStripButton2.Text = "Grabar";
                        toolStripButton2.Enabled = false;
                        toolStripButton3.Enabled = false;
                        toolStripButton4.Enabled = false;
                        txtgrado.Enabled = false;
                        txtgrupo.Enabled = false;
                        cmbturno.Enabled = false;
                        cmbcarrera.Enabled = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("EL GRUPO YA SE ENCUENTRA O NO ES VALIDO");
                }

                facultad.llenargridgrupo(dgvgrupo);
                txtgrupo.Text = "";
                txtgrado.Text = "";
                cmbcarrera.Text = "";
                cmbturno.Text = "";
                toolStripButton2.Enabled = false;
                toolStripButton3.Enabled = false;
                toolStripButton4.Enabled = false;
                txtgrado.Enabled = false;
                txtgrupo.Enabled = false;
                cmbturno.Enabled = false;
                cmbcarrera.Enabled = false;
            }
            else
            {
                MessageBox.Show("ESCRIBA DATOS EN LOS CAMPOS");
            }
        }

        private void dgvgrupo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            toolStripButton2.Text = "Modificar";
            txtgrado.Text = dgvgrupo.CurrentRow.Cells[3].Value.ToString();
            
            txtgrupo.Text = dgvgrupo.CurrentRow.Cells[0].Value.ToString();
            string CARRERA = dgvgrupo.CurrentRow.Cells[1].Value.ToString();
            string TURNO = dgvgrupo.CurrentRow.Cells[2].Value.ToString();


            facultad.cargarcarrera(cmbcarrera);
            cmbcarrera.SelectedValue = CARRERA;

            facultad.cargarturno(cmbturno);
            cmbturno.SelectedValue = TURNO;

            toolStripButton2.Enabled = true;
            toolStripButton3.Enabled = true;
            toolStripButton4.Enabled = true;
            txtgrado.Enabled = false;
            txtgrupo.Enabled = false;
            cmbcarrera.Enabled = false;
            cmbturno.Enabled = true;
        }

        private void cmbcarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtcvegrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtgrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtgrado.Focus();
            }
        }

        private void txtgrupo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
