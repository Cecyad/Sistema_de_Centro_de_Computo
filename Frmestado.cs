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
    public partial class Frmestado : Form
    {
        Clsfacultad facultad = new Clsfacultad();
        public Frmestado()
        {
            InitializeComponent();
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
                txtestado.Focus();
            }
           
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            txtclavee.Text = "";
            txtestado.Text = "";
            txtclavee.Enabled = true;
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
            txtclavee.Enabled = true;
            txtestado.Enabled = true;
            txtclavee.Text = "";
            txtestado.Text = "";

            toolStripButton2.Text = "Grabar";
            txtclavee.Focus();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult buttton = MessageBox.Show("Esta seguro que desea elimnar el estado: " + txtestado.Text, "Eliminar Estado", MessageBoxButtons.OKCancel);
            if (buttton == DialogResult.OK)
            {
                facultad._cveestado = txtclavee.Text;
                facultad.eliminarESTADO();
            }
            facultad.llenargridestado(dgvestado);

            txtclavee.Text = "";
            txtestado.Text = "";

            toolStripButton2.Text = "Grabar";
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
            txtclavee.Enabled = false;
            txtestado.Enabled = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (txtclavee.Text.Length != 0)
            {
                facultad._cveestado = txtclavee.Text;
                facultad._descripcionest = txtestado.Text;

                try
                {
                    if (toolStripButton2.Text == "Grabar")
                    {
                        facultad.grabarestado();
                    }
                    else
                    {
                        facultad.actualizarestado();

                        toolStripButton2.Text = "Grabar";
                        toolStripButton2.Enabled = false;
                        toolStripButton3.Enabled = false;
                        toolStripButton4.Enabled = false;
                        txtclavee.Enabled = false;
                        txtestado.Enabled = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("EL ESTADO YA SE ENCUENTRA REGISTRADO O NO ES VALIDO");
                }

                facultad.llenargridestado(dgvestado);
                txtclavee.Text = "";
                txtestado.Text = "";
                toolStripButton2.Enabled = false;
                toolStripButton3.Enabled = false;
                toolStripButton4.Enabled = false;
                txtclavee.Enabled = false;
                txtestado.Enabled = false;
            }
            else
            {
                MessageBox.Show("ESCRIBA DATOS EN LOS CAMPOS");
            }
        }

        private void Frmestado_Load(object sender, EventArgs e)
        {
            
            txtclavee.Text = "";
            txtestado.Text = "";
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
            txtclavee.Enabled = false;
            txtestado.Enabled = false;

            facultad.llenargridestado(dgvestado);

            dgvestado.Columns[0].HeaderText = "Clave";
            dgvestado.Columns[1].HeaderText = "Estado";

            txtclavee.Focus();
        }

        private void dgvestado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            toolStripButton2.Text = "Modificar";
            facultad._cveestado = dgvestado.CurrentRow.Cells[0].Value.ToString();
            //txtclavee.Text = dgvestado.CurrentRow.Cells[0].Value.ToString();
            facultad.buscarestado(txtclavee, txtestado);

            toolStripButton2.Enabled = true;
            toolStripButton3.Enabled = true;
            toolStripButton4.Enabled = true;
            txtclavee.Enabled = false;
            txtestado.Enabled = true;
        }
    }
}
