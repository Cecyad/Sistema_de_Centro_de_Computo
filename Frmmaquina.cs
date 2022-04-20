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
    public partial class Frmmaquina : Form
    {
        Clsfacultad facultad = new Clsfacultad();
        public Frmmaquina()
        {
            InitializeComponent();
        }

        private void Frmmaquina_Load(object sender, EventArgs e)
        {
            cmbcentroc.Text = "PRINCIPAL";
            
            txtdes.Text = "";
            txtdes.Text = "";
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
            txtnumero.Enabled = false;
            txtdes.Enabled = false;
            //cmbcentroc.Text = "PRINCIPAL";
            cmbestado.Enabled = false;
            cmbcentroc.Enabled = false;
            facultad.cargarestmaquina(cmbestado);
            cmbestado.Text = "";

            facultad.llenargridmaquina(dgvmaquina);

            dgvmaquina.Columns[0].HeaderText = "Numero";
            dgvmaquina.Columns[1].HeaderText = "Usuario";
            dgvmaquina.Columns[2].HeaderText = "CC";
            dgvmaquina.Columns[3].HeaderText = "Maquina";
            dgvmaquina.Columns[4].HeaderText = "Estado";
            dgvmaquina.Columns[2].Visible = false;
            dgvmaquina.Columns[4].Visible = false;
            dgvmaquina.Columns[1].Visible = false;
            txtnumero.Focus();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
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
                txtdes.Focus();
            }
        }


        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            txtnumero.Text = "";
            txtdes.Text = "";
            cmbestado.Text = "";
            cmbcentroc.Text = "";
            txtnumero.Enabled = true;
            toolStripButton2.Text = "Grabar";
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            facultad._nmaquina =txtnumero.Text;
            DialogResult buttton = MessageBox.Show("Esta seguro que desea elimnar la computadora: " + txtnumero.Text, "Eliminar Maquina", MessageBoxButtons.OKCancel);
            if (buttton == DialogResult.OK)
            {
                facultad.eliminarmaquina();
            }
            facultad.llenargridmaquina(dgvmaquina);

            txtnumero.Text = "";
            txtdes.Text = "";
            cmbestado.Text = "";
            cmbcentroc.Text = "";
            cmbcentroc.Enabled = false;

            toolStripButton2.Text = "Grabar";
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
            txtnumero.Enabled = false;
            txtdes.Enabled = false;
            cmbestado.Enabled = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (txtnumero.Text.Length != 0 && cmbestado.Text.Length != 0)
            {
                try
                {
                    facultad._nmaquina = txtnumero.Text;
                    facultad._descripcionmaq = txtdes.Text;
                    facultad._cveestado = cmbestado.SelectedValue.ToString();
                    facultad._idusuario = "";
                    
                    if (cmbcentroc.Text == "PRINCIPAL")
                    {
                        //facultad._cc = Convert.ToString(1);
                    }
                    if (cmbcentroc.Text == "SEGUNDO")
                    {
                        //facultad._cc = Convert.ToString(2);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("LOS CAMPOS DEL FORMULARIO NO SON VALIDOS");
                }

                try
                {
                    if (toolStripButton2.Text == "Grabar")
                    {
                        facultad.grabarmaquina();
                    }
                    else
                    {
                        facultad.actualizarmaquina();

                        toolStripButton2.Text = "Grabar";
                        toolStripButton2.Enabled = false;
                        toolStripButton3.Enabled = false;
                        toolStripButton4.Enabled = false;
                        txtnumero.Enabled = false;
                        txtdes.Enabled = false;
                        cmbestado.Enabled = false;
                    }
                }
                catch (Exception)
                {
                     MessageBox.Show("LA MAQUINA YA SE ENCUENTRA REGISTRADA O NO ES VALIDA");
                }

                facultad.llenargridmaquina(dgvmaquina);
                txtnumero.Text = "";
                txtdes.Text = "";
                cmbestado.Text = "";
                cmbcentroc.Text = "";
                cmbcentroc.Enabled = false;
                toolStripButton2.Enabled = false;
                toolStripButton3.Enabled = false;
                toolStripButton4.Enabled = false;
                txtnumero.Enabled = false;
                txtdes.Enabled = false;
                cmbestado.Enabled = false;
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
            txtnumero.Enabled = true;
            txtdes.Enabled = true;
            cmbestado.Enabled = true;
            cmbcentroc.Enabled = false;
            cmbcentroc.Text = "PRINCIPAL";
            txtnumero.Text = "";
            txtdes.Text = "";
            
            facultad.cargarestmaquina(cmbestado);
            cmbestado.Text = "";

            toolStripButton2.Text = "Grabar";
            txtnumero.Focus();
        }

        private void txtusuario_KeyPress_1(object sender, KeyPressEventArgs e)
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

        }

        private void dgvmaquina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            toolStripButton2.Text = "Modificar";
            facultad._nmaquina = dgvmaquina.CurrentRow.Cells[0].Value.ToString();
            //facultad._cc= dgvmaquina.CurrentRow.Cells[2].Value.ToString();
            txtnumero.Text = dgvmaquina.CurrentRow.Cells[0].Value.ToString();
            string b = dgvmaquina.CurrentRow.Cells[2].Value.ToString();
            if (b == "1")
            {
                cmbcentroc.Text = "PRINCIPAL";
            }
            if (b == "2")
            {
                cmbcentroc.Text = "SEGUNDO";
            }
            txtdes.Text= dgvmaquina.CurrentRow.Cells[3].Value.ToString();
            string x = dgvmaquina.CurrentRow.Cells[4].Value.ToString();



            facultad._cveestado = x;
            facultad.cargarestmaquina(cmbestado);
            cmbestado.SelectedValue = x;


            toolStripButton2.Enabled = true;
            toolStripButton3.Enabled = true;
            toolStripButton4.Enabled = true;
            txtnumero.Enabled = false;
            txtdes.Enabled = true;
            cmbestado.Enabled = true;
        }

        private void cmbestado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        private void cmbcentroc_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        private void cmbestado_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }
    }

}
