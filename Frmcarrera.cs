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
    public partial class Frmcarrera : Form
    {
        Clsfacultad facultad = new Clsfacultad();
        public Frmcarrera()
        {
            InitializeComponent();
        }

        private void dgvusuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            toolStripButton2.Text = "Modificar";
            facultad._cvecarrera = dgvcarrera.CurrentRow.Cells[0].Value.ToString();
            txtclave.Text = dgvcarrera.CurrentRow.Cells[0].Value.ToString();
            facultad.buscarcarrera(txtclave, txtcarrera);

            toolStripButton2.Enabled = true;
            toolStripButton3.Enabled = true;
            toolStripButton4.Enabled = true;
            txtclave.Enabled = false;
            txtcarrera.Enabled = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripButton2.Enabled = true;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = true;
            txtclave.Enabled = true;
            txtcarrera.Enabled = true;
            txtclave.Text = "";
            txtcarrera.Text = "";

            toolStripButton2.Text = "Grabar";
            txtclave.Focus();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            txtclave.Text = "";
            txtcarrera.Text = "";
            txtclave.Enabled = false;
            txtcarrera.Enabled = false;
            toolStripButton2.Text = "Grabar";
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult buttton = MessageBox.Show("Esta seguro que desea elimnar la carrera: " + txtcarrera.Text, "Eliminar Carrera", MessageBoxButtons.OKCancel);
            if (buttton == DialogResult.OK)
            {
                facultad._cvecarrera = txtclave.Text;
                facultad.eliminacarrera();
            }

            facultad.llenargridcarrera(dgvcarrera);

            txtclave.Text = "";
            txtcarrera.Text = "";

            toolStripButton2.Text = "Grabar";
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
            txtclave.Enabled = false;
            txtcarrera.Enabled = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (txtclave.Text.Length != 0)
            {
                facultad._cvecarrera = txtclave.Text;
                facultad._descripcionca = txtcarrera.Text;

                try
                {
                    if (toolStripButton2.Text == "Grabar")
                    {
                        facultad.grabarcarrera();
                    }
                    else
                    {
                        facultad.actualizarcarrera();

                        toolStripButton2.Text = "Grabar";
                        toolStripButton2.Enabled = false;
                        toolStripButton3.Enabled = false;
                        toolStripButton4.Enabled = false;
                        txtclave.Enabled = false;
                        txtcarrera.Enabled = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("LA CARRERA YA SE ENCUENTRA REGISTRADA O NO ES VALIDA");
                }

                facultad.llenargridcarrera(dgvcarrera);
                txtclave.Text = "";
                txtcarrera.Text = "";
                toolStripButton2.Enabled = false;
                toolStripButton3.Enabled = false;
                toolStripButton4.Enabled = false;
                txtclave.Enabled = false;
                txtcarrera.Enabled = false;
            }
            else
            {
                MessageBox.Show("ESCRIBA DATOS EN LOS CAMPOS");
            }
        }

        private void Frmcarrera_Load(object sender, EventArgs e)
        {
            
            txtclave.Text = "";
            txtcarrera.Text = "";
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
            txtclave.Enabled = false;
            txtcarrera.Enabled = false;

            facultad.llenargridcarrera(dgvcarrera);

            dgvcarrera.Columns[0].HeaderText = "Clave";
            dgvcarrera.Columns[1].HeaderText = "Carrera";
        }

        private void txtclave_KeyPress(object sender, KeyPressEventArgs e)
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
                txtcarrera.Focus();
            }
        }
    }
}
