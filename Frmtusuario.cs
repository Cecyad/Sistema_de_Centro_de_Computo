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
    public partial class Frmtusuario : Form
    {
        Clsfacultad facultad = new Clsfacultad();

        public Frmtusuario()
        {
            InitializeComponent();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            txtcve.Text = "";
            txtusu.Text = "";
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
            txtcve.Enabled = true;
            txtusu.Enabled = true;
            txtcve.Text = "";
            txtusu.Text = "";

            toolStripButton2.Text = "Grabar";
            txtcve.Focus();
        }

        private void Frmtusuario_Load(object sender, EventArgs e)
        {
            txtcve.Text = "";
            txtusu.Text = "";
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;


            facultad.llenargridtusu(dgvtusu);

            dgvtusu.Columns[0].HeaderText = "Clave";
            dgvtusu.Columns[1].HeaderText = "Usuario";

            txtcve.Enabled = false;
            txtusu.Enabled = false;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult buttton = MessageBox.Show("Esta seguro que desea elimnar el tipo de usuario: " + txtusu.Text, "Eliminar tipo de usuario", MessageBoxButtons.OKCancel);
            if (buttton == DialogResult.OK)
            {
                facultad._cveusu = txtcve.Text;
                facultad.eliminartusu();   
            }

            facultad.llenargridtusu(dgvtusu);
            txtcve.Text = "";
            txtusu.Text = "";

            toolStripButton2.Text = "Grabar";
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
            txtcve.Enabled = false;
            txtusu.Enabled = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (txtcve.Text.Length != 0)
            {
                facultad._cveusu = txtcve.Text;
                facultad._tusu = txtusu.Text;

                try
                {
                    if (toolStripButton2.Text == "Grabar")
                    {
                        facultad.grabartusu();
                    }
                    else
                    {
                        facultad.actualizartusu();

                        toolStripButton2.Text = "Grabar";
                        toolStripButton2.Enabled = false;
                        toolStripButton3.Enabled = false;
                        toolStripButton4.Enabled = false;
                        txtcve.Enabled = false;
                        txtusu.Enabled = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("EL TIPO DE USUARIO YA SE ENCUENTRA REGISTRADO O NO ES VALIDO");
                }

                facultad.llenargridtusu(dgvtusu);
                txtcve.Text = "";
                txtusu.Text = "";
                toolStripButton2.Enabled = false;
                toolStripButton3.Enabled = false;
                toolStripButton4.Enabled = false;
                txtcve.Enabled = false;
                txtusu.Enabled = false;
            }
            else
            {
                MessageBox.Show("ESCRIBA DATOS EN LOS CAMPOS");
            }
        }

        private void dgvtusu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            toolStripButton2.Text = "Modificar";
            facultad._cveusu = dgvtusu.CurrentRow.Cells[0].Value.ToString();
            facultad.buscartusu(txtcve, txtusu);

            toolStripButton2.Enabled = true;
            toolStripButton3.Enabled = true;
            toolStripButton4.Enabled = true;
            txtcve.Enabled = false;
            txtusu.Enabled = true;
        }

        private void txtcve_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtusu.Focus();
            }
        }
    }
}
