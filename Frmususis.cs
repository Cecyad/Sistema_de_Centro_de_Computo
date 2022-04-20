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
    public partial class Frmususis : Form
    {
        Clsfacultad facultad = new Clsfacultad();
        public Frmususis()
        {
            InitializeComponent();
        }

        private void txtclavee_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 13)
            {
                txtnombre.Focus();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            txtclavee.Text = "";
            txtnombre.Text = "";
            txtcontra.Text = "";
            txtclavee.Enabled = true;
            toolStripButton2.Text = "Grabar";
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult buttton = MessageBox.Show("Esta seguro que desea elimnar a: " + txtnombre.Text, "Eliminar Usuario", MessageBoxButtons.OKCancel);
            if (buttton == DialogResult.OK)
            {
                if (txtclavee.Text != "ADMINISTRADOR")
                {
                    facultad._cveus = txtclavee.Text;
                    facultad.eliminartusuario();
                }
                if (txtclavee.Text == "ADMINISTRADOR")
                {
                    MessageBox.Show("No es posible eliminar al usuario ADMINISTRADOR");
                }

            }
            facultad.llenargridtusuario(dgvtusuario);

            txtclavee.Text = "";
            txtnombre.Text = "";
            txtcontra.Text = "";

            toolStripButton2.Text = "Grabar";
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
            txtclavee.Enabled = false;
            txtnombre.Enabled = false;
            txtcontra.Enabled = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (txtclavee.Text.Length != 0)
            {
                facultad._cveus = txtclavee.Text;
                facultad._nombreu = txtnombre.Text;
                facultad._contrau = txtcontra.Text;

                try
                {
                    if (toolStripButton2.Text == "Grabar")
                    {
                        facultad.grabartusuario();
                    }
                    else
                    {
                        facultad.actualizartusuario();

                        toolStripButton2.Text = "Grabar";
                        toolStripButton2.Enabled = false;
                        toolStripButton3.Enabled = false;
                        toolStripButton4.Enabled = false;
                        txtclavee.Enabled = false;
                        txtnombre.Enabled = false;
                        txtcontra.Enabled = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("EL USUARIO YA SE ENCUENTRA REGISTRADO O NO ES VALIDO");
                }

                facultad.llenargridtusuario(dgvtusuario);
                txtclavee.Text = "";
                txtnombre.Text = "";
                txtcontra.Text = "";
                toolStripButton2.Enabled = false;
                toolStripButton3.Enabled = false;
                toolStripButton4.Enabled = false;
                txtclavee.Enabled = false;
                txtnombre.Enabled = false;
                txtcontra.Enabled = false;
            }
            else
            {
                MessageBox.Show("ESCRIBA DATOS EN LOS CAMPOS");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripButton2.Enabled = true;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = true;
            txtclavee.Enabled = true;
            txtnombre.Enabled = true;
            txtcontra.Enabled = true;
            txtclavee.Text = "";
            txtnombre.Text = "";
            txtcontra.Text = "";

            toolStripButton2.Text = "Grabar";
            txtclavee.Focus();
        }

        private void Frmtipousuario_Load(object sender, EventArgs e)
        {
           
            txtclavee.Text = "";
            txtnombre.Text = "";
            txtcontra.Text = "";
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
            txtclavee.Enabled = false;
            txtnombre.Enabled = false;
            txtcontra.Enabled = false;

            facultad.llenargridtusuario(dgvtusuario);

            dgvtusuario.Columns[0].HeaderText = "ID";
            dgvtusuario.Columns[1].HeaderText = "NOMBRE";
            dgvtusuario.Columns[2].HeaderText = "CONTRASEÑA";
            dgvtusuario.Columns[2].Visible = false;

            txtclavee.Focus();
        }

        private void dgvtusuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            toolStripButton2.Text = "Modificar";
            facultad._cveus = dgvtusuario.CurrentRow.Cells[0].Value.ToString();
            txtclavee.Text = dgvtusuario.CurrentRow.Cells[0].Value.ToString();
            facultad.buscartusuario(txtclavee, txtnombre,txtcontra);

            toolStripButton2.Enabled = true;
            toolStripButton3.Enabled = true;
            toolStripButton4.Enabled = true;
            txtclavee.Enabled = false;
            txtnombre.Enabled = true;
            txtcontra.Enabled = true;
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtcontra.Focus();
            }
        }
    }
}
