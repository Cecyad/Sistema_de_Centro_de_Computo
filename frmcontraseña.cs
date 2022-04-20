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
    public partial class frmcontraseña : Form
    {
        Clsfacultad facultad = new Clsfacultad();

        public frmcontraseña()
        {
            InitializeComponent();
        }

        private void BTNCANCELAR_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNOK_Click(object sender, EventArgs e)
        {
            string id;
            facultad._usuariosis = Program.Idsis;
            facultad._pasword = txtcontraactual.Text;

            id = facultad.buscaususis();
            if (id.Length > 1)
            {
                if (txtcontranueva.Text == txtcontraconfirmacion.Text)
                {
                    facultad._cveus = Program.Idsis;
                    facultad._contrau = txtcontraconfirmacion.Text;
                    facultad.actualizartusuariosolo();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("La contraseña nueva y la confirmacion de contraseña no son iguales");
                    txtcontraactual.Text = "";
                    txtcontranueva.Text = "";
                    txtcontraconfirmacion.Text = "";
                    txtcontraactual.Focus();
                }

            }
            else
            {
                MessageBox.Show("El usuario no se encuentra registrado");
                txtcontraactual.Text = "";
                txtcontranueva.Text = "";
                txtcontraconfirmacion.Text = "";
                txtcontraactual.Focus();
            }
        }

        private void txtcontraactual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtcontranueva.Focus();
            }
        }

        private void txtcontranueva_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontranueva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtcontraconfirmacion.Focus();
            }
        }

        private void frmcontraseña_Load(object sender, EventArgs e)
        {
            string nom = facultad.buscanombreusu();
            Text = "Hola:  " + nom;

            txtcontraactual.Focus();
        }
    }

}
