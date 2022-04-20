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
    public partial class Frmbloque : Form
    {
        Clsfacultad facultad = new Clsfacultad();
        public Frmbloque()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Location = Screen.AllScreens[1].WorkingArea.Location;

            txtbloque.Text = "";
            txtiempo.Text = "";
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
           

            facultad.llenargridbloque(dgvbloque);

            dgvbloque.Columns[0].HeaderText = "Bloque";
            dgvbloque.Columns[1].HeaderText = "Tiempo";

            txtbloque.Enabled = false;
            txtiempo.Enabled = false;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripButton2.Enabled = true;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = true;
            txtbloque.Enabled = true;
            txtiempo.Enabled = true;
            txtbloque.Text = "";
            txtiempo.Text = "";
            
            toolStripButton2.Text = "Grabar";
            txtbloque.Focus();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            txtbloque.Text = "";
            txtiempo.Text = "";
            toolStripButton2.Text = "Grabar";
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult buttton = MessageBox.Show("Esta seguro que desea elimnar el horario: " + txtiempo.Text, "Eliminar Horario", MessageBoxButtons.OKCancel);
            if (buttton == DialogResult.OK)
            {
                facultad._nbloque = txtbloque.Text;
                facultad.eliminarbloque();
            }

            facultad.llenargridbloque(dgvbloque);

            txtbloque.Text = "";
            txtiempo.Text = "";

            toolStripButton2.Text = "Grabar";
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
            txtbloque.Enabled = false;
            txtiempo.Enabled = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (txtbloque.Text.Length != 0)
            {
                facultad._nbloque = txtbloque.Text;
                facultad._tiempo = txtiempo.Text;
                
                try
                {
                    if (toolStripButton2.Text == "Grabar")
                    {
                        facultad.grabarbloque();
                    }
                    else
                    {
                        facultad.actualizarbloque();

                        toolStripButton2.Text = "Grabar";
                        toolStripButton2.Enabled = false;
                        toolStripButton3.Enabled = false;
                        toolStripButton4.Enabled = false;
                        txtbloque.Enabled = false;
                        txtiempo.Enabled = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("EL BLOQUE YA SE ENCUENTRA REGISTRADO O NO ES VALIDO");
                }

                facultad.llenargridbloque(dgvbloque);
                txtbloque.Text = "";
                txtiempo.Text = "";
                toolStripButton2.Enabled = false;
                toolStripButton3.Enabled = false;
                toolStripButton4.Enabled = false;
                txtbloque.Enabled = false;
                txtiempo.Enabled = false;
            }
            else
            {
                MessageBox.Show("ESCRIBA DATOS EN LOS CAMPOS");
            }
        }

        private void dgvbloque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            toolStripButton2.Text = "Modificar";
            facultad._nbloque = dgvbloque.CurrentRow.Cells[0].Value.ToString();
            txtbloque.Text = dgvbloque.CurrentRow.Cells[0].Value.ToString();
            facultad.buscarbloque(txtbloque,txtiempo);

            toolStripButton2.Enabled = true;
            toolStripButton3.Enabled = true;
            toolStripButton4.Enabled = true;
            txtbloque.Enabled = true;
            txtiempo.Enabled = true;
        }

        private void txtbloque_KeyPress(object sender, KeyPressEventArgs e)
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
                txtiempo.Focus();
            }
        }

        private void dgvbloque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
