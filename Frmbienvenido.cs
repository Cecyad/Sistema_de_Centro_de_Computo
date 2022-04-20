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
    public partial class Frmbienvenido : Form
    {
        public string idsis;
        public string contra;
        public string id;
        Clsfacultad facultad = new Clsfacultad();
        Conexion conexion = new Conexion();

        public Frmbienvenido()
        {
            InitializeComponent();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (txtusu.Text.Length > 1 && txtpassword.Text.Length > 1)
            {
                idsis = txtusu.Text;
                contra = txtpassword.Text;

                facultad._usuariosis = idsis;
                facultad._pasword = contra;

                id = facultad.buscaususis();
                if (id.Length > 1)
                {
    
                    Program.Idsis = idsis;
                    Frmadmin re = new Frmadmin();
                    this.Hide();
                    re.ShowDialog();
                    




                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrectos");
                    txtusu.Text = "";
                    txtpassword.Text = "";
                    txtusu.Focus();
                }
                
            }
            else
            { MessageBox.Show("Escribir Usuario y Contraseña"); }
           
        }

        private void Frmbienvenido_Load(object sender, EventArgs e)
        {
            conexion.conectar2();

            if (conexion.con.State == ConnectionState.Open)
            {
                txtpassword.Focus();
            }
            else
            {
                Application.Exit();
            }
        }

        private void txtusu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtpassword.Focus();
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtusu.Text.Length > 1 && txtpassword.Text.Length > 1)
                {
                    idsis = txtusu.Text;
                    contra = txtpassword.Text;

                    facultad._usuariosis = idsis;
                    facultad._pasword = contra;

                    id = facultad.buscaususis();
                    if (id.Length > 1)
                    {

                        Program.Idsis = idsis;
                        Frmadmin re = new Frmadmin();
                        this.Hide();
                        re.ShowDialog();





                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña Incorrectos");
                        txtusu.Text = "";
                        txtpassword.Text = "";
                        txtusu.Focus();
                    }

                }
                else
                { MessageBox.Show("Escribir Usuario y Contraseña"); }


            }
        }

        private void Frmbienvenido_Activated(object sender, EventArgs e)
        {
            txtusu.Focus();

        }
    }
}
