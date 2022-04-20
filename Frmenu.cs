using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FCEATCC
{
    public partial class Frmenu : Form
    {
        Conexion cone = new Conexion();
        Clsusuario usuario = new Clsusuario();
        public string dir;
        public Frmenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frmessage mensaje = new Frmessage();
            mensaje.ShowDialog();
        }

        private void btnagregarexc_Click(object sender, EventArgs e)
        {
            IMPORTANTE IM = new IMPORTANTE();
            IM.ShowDialog();
        }

        private void btncambiar_Click(object sender, EventArgs e)
        {
            string gener = DateTime.Now.Year.ToString();
            int suma = 1 + Convert.ToInt32(gener);
            string generacion = gener + "-" + suma;

            if (MessageBox.Show("Desea Cambiar al ciclo: " + generacion + "", "Cambio de Ciclo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                usuario.actualizargrado();
                usuario.actualizargradogrupo();
                usuario.eliminargradogrupo();


                string ge = "%" + gener;
                usuario._generacion = ge;
                string o = usuario.traergen();
                usuario._cvegen = o;
                DataTable halumnos = new DataTable();
                halumnos = usuario.traerporgeneracion();

                foreach (DataRow fila in halumnos.Rows)
                {

                    usuario._idusuario = fila["IDUSUARIOS"].ToString();
                    usuario._nombre = fila["NOMBRE"].ToString();
                    usuario._cvecarrera = fila["CVECARRERA"].ToString();
                    usuario._cvegen = fila["CVEGENERACION"].ToString();
                    usuario.grabarhistorialal();
                }

                usuario._cvegen = o;
                usuario.eliminarusuarios();

                lblciclo.Text = generacion;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frmreports rep = new Frmreports();
            rep.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frmadmin adm = new Frmadmin();
            this.Hide();
            adm.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frmmaquina maq = new Frmmaquina();
            maq.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frmusuario usu = new Frmusuario();
            usu.ShowDialog();
        }

        private void Frmenu_Load(object sender, EventArgs e)
        {
            if (Program.Idsis == "ADMINISTRADOR")
            {
                btnadministrador.Visible = true;
                lbladministrador.Visible = true;
            }

            string mes = DateTime.Now.Month.ToString();

            if (mes == "1" || mes == "2" || mes == "3" || mes == "4" || mes == "5" || mes == "6" || mes == "7")
            {
                string generr = DateTime.Now.Year.ToString();
                int sumaa = Convert.ToInt32(generr) - 1;
                string generacionn = sumaa + "-" + generr;
                lblciclo.Text = generacionn;

            }
            else
            {
                string gener = DateTime.Now.Year.ToString();
                int suma = 1 + Convert.ToInt32(gener);
                string generacion = gener + "-" + suma;
                lblciclo.Text = generacion;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Frmbloque bloq = new Frmbloque();
            bloq.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frmturno TUR = new Frmturno();
            TUR.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Frmgrupo GRUP = new Frmgrupo();
            GRUP.ShowDialog();
        }

        private void btnadministrador_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRMADMINISTRADOR ADM = new FRMADMINISTRADOR();
            ADM.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Frmcarrera car = new Frmcarrera();
            car.ShowDialog();
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcontraseña contra = new frmcontraseña();
            contra.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void manualUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult buttton = MessageBox.Show("¿Desea abrir el Manual de Usuario?", "Manual de Usuario", MessageBoxButtons.OKCancel);
            if (buttton == DialogResult.OK)
            {
                string c = System.Windows.Forms.Application.ExecutablePath.ToString();
                string ubicacion = c.Replace("FCEATCC.exe", "reportes");
                Process.Start(@"" + ubicacion + "\\Manual.pdf");
            }
        }
    }
}
