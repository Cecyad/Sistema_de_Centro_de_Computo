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
    public partial class Frmres : Form
    {
        Clsfacultad facultad = new Clsfacultad();
        Clsreservacion reservar = new Clsreservacion();
        public string usuario;
        public string letra;

        public Frmres()
        {
            InitializeComponent();
        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblultimo.Text = "";

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

            string liberada;
            string libre;

            if (e.KeyChar == 13)
            {

                string cadena = txtnumero.Text;
                if (txtnumero.TextLength == 8)
                {
                    string result = cadena.Substring(0, 7);
                    string result2 = cadena.Substring(cadena.Length - 1, 1);
                    letra = result + "-" + result2;
                }
                if (txtnumero.TextLength <= 5)
                { letra = txtnumero.Text; }


                facultad._idusuario = letra;

                string y = facultad.buscausuarioreservacion();

                if (y.Length >= 1)
                {
                    reservar._estadou = "LIBERADA POR USUARIO";
                    liberada = reservar.traerestado();
                    reservar._cvestado = liberada;
                    reservar._horas = DateTime.Now.ToShortTimeString();
                    reservar._idusuarios = letra;
                    reservar._nmaquina = facultad.buscanummaquinaconusuario();
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    string HORAE = reservar.traerhorae();
                    reservar._horae = HORAE;
                    string fechareg = reservar.traerfechareg();
                    reservar._fechareg = fechareg;
                    reservar.actualizarreservaciohoras();

                    string nm = facultad.buscanummaquinaconusuario();
                    facultad._idusuario = "";
                    reservar._estadou = "DISPONIBLE";
                    libre = reservar.traerestado();
                    facultad._cveestado = libre;
                    facultad._nmaquina = nm;
                    facultad.actualizarmaquinaID();
                    txtnumero.Text = "";
                    txtnumero.Focus();

                }
                else
                {
                    if (txtnumero.TextLength == 8)
                    {
                        string x = facultad.buscaridusuario();
                        if (x.Length >= 1)
                        {
                           
                            Frmreservacionus xy = new Frmreservacionus();
                            xy.y = x;
                            xy.ShowDialog();

                        }
                        txtnumero.Text = "";
                        txtnumero.Focus();
                    }
                    if (txtnumero.TextLength <= 5 && txtnumero.TextLength != 0)
                    {
                        facultad._nempleado = txtnumero.Text;
                        string ac = facultad.buscaridacademico();
                        if (ac.Length >= 1)
                        {
                            
                            Frmreservacionus xy = new Frmreservacionus();
                            xy.y = ac;
                            xy.ShowDialog();

                        }
                        txtnumero.Text = "";
                        txtnumero.Focus();
                    }
                    txtnumero.Text = "";
                }

            }
        }

        private void Frmres_Load(object sender, EventArgs e)
        {
          this.Location = Screen.AllScreens[0].WorkingArea.Location;
            Frmres res = new Frmres();
            txtnumero.Focus();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtnumero_Click(object sender, EventArgs e)
        {
            lblultimo.Text = "";

            if (tecladoo.Visible == true)
            {
                tecladoo.Visible = false;
            }
            else
            {
                tecladoo.Visible = true;
            }
            
           
        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            txtnumero.Focus();
            SendKeys.Send("{1}");
            Frmres res = new Frmres();
            ContentPanel.Size = new Size(res.Size.Width / 3, res.Size.Height / 3);
            ContentPanel.Top = (res.Height / 3) - (ContentPanel.Height / 3);
            ContentPanel.Left = (res.Width / 3) - (ContentPanel.Width / 3);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtnumero.Focus();
            SendKeys.Send("{2}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnumero.Focus();
            SendKeys.Send("{3}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtnumero.Focus();
            SendKeys.Send("{4}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtnumero.Focus();
            SendKeys.Send("{5}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtnumero.Focus();
            SendKeys.Send("{6}");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtnumero.Focus();
            SendKeys.Send("{7}");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtnumero.Focus();
            SendKeys.Send("{8}");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtnumero.Focus();
            SendKeys.Send("{9}");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtnumero.Focus();
            SendKeys.Send("{0}");
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            string liberada;
            string libre;

            string cadena = txtnumero.Text;
            if (txtnumero.TextLength == 8)
            {
                string result = cadena.Substring(0, 7);
                string result2 = cadena.Substring(cadena.Length - 1, 1);
                letra = result + "-" + result2;
            }
            if (txtnumero.TextLength <= 5)
            { letra = txtnumero.Text; }


            facultad._idusuario = letra;

            string y = facultad.buscausuarioreservacion();

            if (y.Length >= 1)
            {
                reservar._estadou = "LIBERADA POR USUARIO";
                liberada = reservar.traerestado();
                reservar._cvestado = liberada;
                reservar._horas = DateTime.Now.ToShortTimeString();
                reservar._idusuarios = letra;
                reservar._nmaquina = facultad.buscanummaquinaconusuario();
                reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                string HORAE = reservar.traerhorae();
                reservar._horae = HORAE;
                string fechareg = reservar.traerfechareg();
                reservar._fechareg = fechareg;
                reservar.actualizarreservaciohoras();

                string nm = facultad.buscanummaquinaconusuario();
                facultad._idusuario = "";
                reservar._estadou = "DISPONIBLE";
                libre = reservar.traerestado();
                facultad._cveestado = libre;
                facultad._nmaquina = nm;
                facultad.actualizarmaquinaID();
                txtnumero.Text = "";
                txtnumero.Focus();

            }
            else
            {
                if (txtnumero.TextLength == 8)
                {
                    string x = facultad.buscaridusuario();
                    if (x.Length >= 1)
                    {
                        
                        Frmreservacionus xy = new Frmreservacionus();
                        xy.y = x;
                        xy.ShowDialog();

                    }
                    txtnumero.Text = "";
                    txtnumero.Focus();
                }
                if (txtnumero.TextLength <= 5 && txtnumero.TextLength != 0)
                {
                    facultad._nempleado = txtnumero.Text;
                    string ac = facultad.buscaridacademico();
                    if (ac.Length >= 1)
                    {

                        Frmreservacionus xy = new Frmreservacionus();
                        xy.y = ac;
                        xy.ShowDialog();

                    }
                    txtnumero.Text = "";
                    txtnumero.Focus();
                }
                
                txtnumero.Text="";
                
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtnumero.Focus();
            SendKeys.Send("{BACKSPACE}");
        }

        private void Frmres_Activated(object sender, EventArgs e)
        {
            string l = Program.ultmaquina;
            if (l != null)
            {
                lblultimo.Text = "Última máquina seleccionada: " + l;
            }
            else
            {
                lblultimo.Text = "";
            }
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {
            
        }
    }
}
