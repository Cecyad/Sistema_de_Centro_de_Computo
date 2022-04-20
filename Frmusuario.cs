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
    public partial class Frmusuario : Form
    {
        Clsusuario usuario = new Clsusuario();
        public Frmusuario()
        {
            InitializeComponent();
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                txtnombre.Focus();
            }
        }

        private void txtgrado_KeyPress(object sender, KeyPressEventArgs e)
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
                txtgrupo.Focus();
            }
        }

        private void txtgrupo_KeyPress(object sender, KeyPressEventArgs e)
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

       

        private void Frmusuario_Load(object sender, EventArgs e)
        {
            txtid.Focus();

            txtid.Text = "";
            txtnombre.Text = "";
            txtgrado.Text = "";
            txtgrupo.Text = "";
            
          
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
            txtid.Enabled = false;
            txtnombre.Enabled = false;
            txtgrado.Enabled = false;
            txtgrupo.Enabled = false;
            cmbcarrera.Enabled = false;
            cmbgen.Enabled = false;
            cmbusuario.Enabled = false;

            usuario.llenargrid(dgvusuario);

            dgvusuario.Columns[0].HeaderText = "Usuario";
            dgvusuario.Columns[1].HeaderText = "Nombre";
            dgvusuario.Columns[2].HeaderText = "Grado";
            dgvusuario.Columns[3].HeaderText = "Grupo";
            dgvusuario.Columns[4].HeaderText = "Clave carrera";
            dgvusuario.Columns[5].HeaderText = "Tipo";
            dgvusuario.Columns[6].HeaderText = "Generacion";
            dgvusuario.Columns[4].Visible = false;
            dgvusuario.Columns[5].Visible = false;
            dgvusuario.Columns[6].Visible = false;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtnombre.Text = "";
            txtgrado.Text = "";
            txtgrupo.Text = "";
            
            cmbcarrera.Text = "";
            cmbgen.Text = "";

            cmbusuario.Text = "";

            txtid.Enabled = true;
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
                usuario._idusuario = txtid.Text;
                usuario.eliminar();
            }

            usuario.llenargrid(dgvusuario);

            txtid.Text = "";
            txtnombre.Text = "";
            txtgrado.Text = "";
            txtgrupo.Text = "";
            
            cmbcarrera.Text = "";
            cmbgen.Text = "";

            cmbusuario.Text = "";

            toolStripButton2.Text = "Grabar";
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;

            txtid.Enabled = false;
            txtnombre.Enabled = false;
            txtgrado.Enabled = false;
            txtgrupo.Enabled = false;
            
            cmbcarrera.Enabled = false;
            cmbgen.Enabled = false;

            cmbusuario.Enabled = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Length != 0 && cmbusuario.Text.Length != 0)
            {

                    usuario._idusuario = txtid.Text;
                    usuario._nombre = txtnombre.Text;
                    usuario._grado = txtgrado.Text;
                    usuario._grupo = txtgrupo.Text;
                    usuario._cvecarrera = cmbcarrera.SelectedValue.ToString();
                    usuario._generacion = cmbgen.SelectedValue.ToString();
                    //usuario._sexo = cmbsexo.SelectedValue.ToString();
                    usuario._tusuario = cmbusuario.SelectedValue.ToString();

                   
                

                try
                {
                    if (toolStripButton2.Text == "Grabar")
                    {
                        if (cmbusuario.Text == "ALUMNO")
                        { usuario.grabar(); }
                        if (cmbusuario.Text == "DOCENTE")
                        { usuario.grabaracad(); }
                        
                    }
                    else
                    {
                        usuario.actualizar();

                        toolStripButton2.Text = "Grabar";
                        toolStripButton2.Enabled = false;
                        toolStripButton3.Enabled = false;
                        toolStripButton4.Enabled = false;
                        txtid.Enabled = false;
                        txtnombre.Enabled = false;
                        txtgrado.Enabled = false;
                        txtgrupo.Enabled = false;
                       
                        cmbcarrera.Enabled = false;
                        cmbgen.Enabled = false;

                        cmbusuario.Enabled = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("EL USUARIO YA SE ENCUENTRA REGISTRADO O NO ES VALIDO");
                }

                usuario.llenargrid(dgvusuario);
                txtid.Text = "";
                txtnombre.Text = "";
                txtgrado.Text = "";
                txtgrupo.Text = "";
                
                cmbcarrera.Text = "";
                cmbgen.Text = "";

                cmbusuario.Text = "";
                toolStripButton2.Enabled = false;
                toolStripButton3.Enabled = false;
                toolStripButton4.Enabled = false;
                txtid.Enabled = false;
                txtnombre.Enabled = false;
                txtgrado.Enabled = false;
                txtgrupo.Enabled = false;
                
                cmbcarrera.Enabled = false;
                cmbgen.Enabled = false;

                cmbusuario.Enabled = false;
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
            txtid.Enabled = true;
            txtnombre.Enabled = true;
            txtgrado.Enabled = true;
            txtgrupo.Enabled = true;
           
            cmbcarrera.Enabled = true;
            cmbgen.Enabled = true;

            cmbusuario.Enabled = true;

            txtid.Text = "";
            txtnombre.Text = "";
            txtgrado.Text = "";
            txtgrupo.Text = "";
            
            cmbgen.Text = "";

            cmbusuario.Text = "";

           
            usuario.cargargeneracion(cmbgen);
            cmbgen.Text = "";
            usuario.cargartusuario(cmbusuario);
            cmbusuario.Text = "";
            usuario.cargarcarrera(cmbcarrera);
            cmbcarrera.Text = "";

            toolStripButton2.Text = "Grabar";

            txtid.Focus();
        }

        private void dgvusuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string a;
            string b;
            string c;
            toolStripButton2.Text = "Modificar";
            usuario._idusuario = dgvusuario.CurrentRow.Cells[0].Value.ToString();
            txtid.Text = dgvusuario.CurrentRow.Cells[0].Value.ToString();
            usuario.buscarusuario(txtid, txtnombre, txtgrado, txtgrupo, cmbcarrera, cmbusuario, cmbgen);

            
            
            
            a = cmbcarrera.Text;
            usuario._cvecarrera = a;
            usuario.cargarcarrerausuario(cmbcarrera);
            cmbcarrera.SelectedValue = a;

            b = cmbusuario.Text;
            usuario._tusuario = b;
            usuario.cargartusuario(cmbusuario);
            cmbusuario.SelectedValue = b;

            c = cmbgen.Text;
            usuario._generacion = c;
            usuario.cargargeneracion(cmbgen);
            cmbgen.SelectedValue = c;

            
            toolStripButton2.Enabled = true;
            toolStripButton3.Enabled = true;
            toolStripButton4.Enabled = true;
            txtid.Enabled = false;
            txtnombre.Enabled = true;
            txtgrado.Enabled = true;
            txtgrupo.Enabled = true;
            
            
            cmbcarrera.Enabled = true;
            cmbgen.Enabled = true;
           
            cmbusuario.Enabled = true;

            lblgrupo.Visible = true;
            lblcarrera.Visible = true;
            lblgrado.Visible = true;
            lblgeneracion.Visible = true;
            txtgrado.Visible = true;
            txtgrupo.Visible = true;
            cmbcarrera.Visible = true;
            cmbgen.Visible = true;
        }

       

        private void cmbcarrera_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        

        private void cmbusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbgen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtgrado.Focus();
            }
        }

        private void cmbusuario_SelectionChangeCommitted(object sender, EventArgs e)
        {
            

        }

        private void cmbusuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbusuario.Text == "ALUMNO")
            {
                lblgrupo.Visible = true;
                lblcarrera.Visible = true;
                lblgrado.Visible = true;
                lblgeneracion.Visible = true;
                txtgrado.Visible = true;
                txtgrupo.Visible = true;
                cmbcarrera.Visible = true;
                cmbgen.Visible = true;
            }
            if (cmbusuario.Text == "DOCENTE")
            {
                lblgrupo.Visible = false;
                lblcarrera.Visible = false;
                lblgrado.Visible = false;
                lblgeneracion.Visible = false;
                txtgrado.Visible = false;
                txtgrupo.Visible = false;
                cmbcarrera.Visible = false;
                cmbgen.Visible = false;
            }
        }
    }
}
