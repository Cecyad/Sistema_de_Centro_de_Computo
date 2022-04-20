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
    public partial class Frmgeneracion : Form
    {
        Clsfacultad facultad = new Clsfacultad();
        public Frmgeneracion()
        {
            InitializeComponent();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            txtclavee.Text = "";
            txtgeneracion.Text = "";
            txtclavee.Enabled = false;
            toolStripButton2.Text = "Grabar";
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            facultad._cvegen = txtclavee.Text;
            facultad.eliminargeneracion();

            facultad.llenargridgeneracion(dgvgeneracion);

            txtclavee.Text = "";
            txtgeneracion.Text = "";

            toolStripButton2.Text = "Grabar";
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
            txtclavee.Enabled = false;
            txtgeneracion.Enabled = false;
        }

        private void Frmgeneracion_Load(object sender, EventArgs e)
        {
            txtclavee.Focus();
            txtclavee.Text = "";
            txtgeneracion.Text = "";
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
            txtclavee.Enabled = false;
            txtgeneracion.Enabled = false;

            facultad.llenargridgeneracion(dgvgeneracion);

            dgvgeneracion.Columns[0].HeaderText = "Clave";
            dgvgeneracion.Columns[1].HeaderText = "Generación";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (txtclavee.Text.Length != 0)
            {
                facultad._cvegen = txtclavee.Text;
                facultad._generacion = txtgeneracion.Text;

                try
                {
                    if (toolStripButton2.Text == "Grabar")
                    {
                        facultad.grabargeneracion();
                    }
                    else
                    {
                        facultad.actualizargeneracion();

                        toolStripButton2.Text = "Grabar";
                        toolStripButton2.Enabled = false;
                        toolStripButton3.Enabled = false;
                        toolStripButton4.Enabled = false;
                        txtclavee.Enabled = false;
                        txtgeneracion.Enabled = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("LA GENERACIÓN YA SE ENCUENTRA REGISTRADA O NO ES VALIDA");
                }

                facultad.llenargridgeneracion(dgvgeneracion);
                txtclavee.Text = "";
                txtgeneracion.Text = "";
                toolStripButton2.Enabled = false;
                toolStripButton3.Enabled = false;
                toolStripButton4.Enabled = false;
                txtclavee.Enabled = false;
                txtgeneracion.Enabled = false;
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
            txtclavee.Enabled = false;
            txtgeneracion.Enabled = true;
            txtclavee.Text = "";
            txtgeneracion.Text = "";

            toolStripButton2.Text = "Grabar";
            txtclavee.Focus();
        }

        private void dgvgeneracion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            toolStripButton2.Text = "Modificar";
            facultad._cvegen = dgvgeneracion.CurrentRow.Cells[0].Value.ToString();
            txtclavee.Text = dgvgeneracion.CurrentRow.Cells[0].Value.ToString();
            facultad.buscargeneracion(txtclavee, txtgeneracion);

            toolStripButton2.Enabled = true;
            toolStripButton3.Enabled = true;
            toolStripButton4.Enabled = true;
            txtclavee.Enabled = false;
            txtgeneracion.Enabled = true;
        }

        private void txtclavee_KeyPress(object sender, KeyPressEventArgs e)
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
                txtgeneracion.Focus();
            }
        }
    }
}
