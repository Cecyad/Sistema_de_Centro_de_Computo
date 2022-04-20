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
    public partial class Frmturno : Form
    {
        Clsfacultad facultad = new Clsfacultad();
        public Frmturno()
        {
            InitializeComponent();
        }

        private void txtclavet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                txturno.Focus();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            txtclavet.Text = "";
            txturno.Text = "";
            txtclavet.Enabled = true;
            toolStripButton2.Text = "Grabar";
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripButton2.Enabled = true;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = true;
            txtclavet.Enabled = true;
            txturno.Enabled = true;
            txtclavet.Text = "";
            txturno.Text = "";

            toolStripButton2.Text = "Grabar";
            txtclavet.Focus();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult buttton = MessageBox.Show("Esta seguro que desea elimnar el turno: " + txturno.Text, "Eliminar Turno", MessageBoxButtons.OKCancel);
            if (buttton == DialogResult.OK)
            {
                facultad._cveturno = txtclavet.Text;
                facultad.eliminarturno();
            }
            facultad.llenargridturno(dgvturno);

            txtclavet.Text = "";
            txturno.Text = "";

            toolStripButton2.Text = "Grabar";
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
            txtclavet.Enabled = false;
            txturno.Enabled = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (txtclavet.Text.Length != 0)
            {
                facultad._cveturno = txtclavet.Text;
                facultad._descripcionturno = txturno.Text;

                try
                {
                    if (toolStripButton2.Text == "Grabar")
                    {
                        facultad.grabarturno();
                    }
                    else
                    {
                        facultad.actualizarturno();

                        toolStripButton2.Text = "Grabar";
                        toolStripButton2.Enabled = false;
                        toolStripButton3.Enabled = false;
                        toolStripButton4.Enabled = false;
                        txtclavet.Enabled = false;
                        txturno.Enabled = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("EL TURNO YA SE ENCUENTRA REGISTRADO O NO ES VALIDO");
                }

                facultad.llenargridturno(dgvturno);
                txtclavet.Text = "";
                txturno.Text = "";
                toolStripButton2.Enabled = false;
                toolStripButton3.Enabled = false;
                toolStripButton4.Enabled = false;
                txtclavet.Enabled = false;
                txturno.Enabled = false;
            }
            else
            {
                MessageBox.Show("ESCRIBA DATOS EN LOS CAMPOS");
            }
        }

        private void Frmturno_Load(object sender, EventArgs e)
        {
            txtclavet.Focus();
            txtclavet.Text = "";
            txturno.Text = "";
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
            txtclavet.Enabled = false;
            txturno.Enabled = false;

            facultad.llenargridturno(dgvturno);

            dgvturno.Columns[0].HeaderText = "Clave";
            dgvturno.Columns[1].HeaderText = "Turno";
        }

        private void dgvturno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            toolStripButton2.Text = "Modificar";
            facultad._cveturno = dgvturno.CurrentRow.Cells[0].Value.ToString();
            txtclavet.Text = dgvturno.CurrentRow.Cells[0].Value.ToString();
            facultad.buscarturno(txtclavet, txturno);

            toolStripButton2.Enabled = true;
            toolStripButton3.Enabled = true;
            toolStripButton4.Enabled = true;
            txtclavet.Enabled = false;
            txturno.Enabled = true;
        }
    }
}
