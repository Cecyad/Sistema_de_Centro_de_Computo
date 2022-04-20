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
    public partial class Frmadmin : Form
    {
        Clsfacultad facultad = new Clsfacultad();
        public int s = 0; //Variable donde se guarda cuantas maquinas existen registradas.

        public string n;

        public int contador = 0;

        public Frmadmin()
        {
            InitializeComponent();
        }

        private void Frmadmin_Load(object sender, EventArgs e)
        {
            string valor;
            string es;
            TextBox estado = new TextBox();



            int c = 0;
            DataTable dr = new DataTable();
            //facultad._cc = "1";
            dr = facultad.traerestmaquina();

            Button[] botones = new Button[40] { BTN1, BTN2, BTN3, BTN4, BTN5, BTN6, BTN7, BTN8, BTN9, BTN10, BTN11, BTN12, BTN13, BTN14, BTN15, BTN16, BTN17, BTN18, BTN19, BTN20, BTN21, BTN22, BTN23, BTN24, BTN25, BTN26, BTN27, BTN28, BTN29, BTN30, BTN31, BTN32, BTN33, BTN34, BTN35, BTN36, BTN37, BTN38, BTN39, BTN40 };
            acomodar(botones);

            /*string contar = facultad.contarmaquina();
            D = Convert.ToInt32(contar) - 1;*/

            
            btnreservar.Visible = true;
            btnmenu.Visible = true;
            btnc1.Visible = true;
            btnc2.Visible = true;
            btnc3.Visible = true;
            btnc4.Visible = true;



           
            string contar = facultad.contarmaquina();

            s = Convert.ToInt32(contar) - 1;
            VISIBLE(botones);
            //try
            //{
                for (int z = 0; z <= s; z++)
                {

                    DataRow row = dr.Rows[c];
                    valor = Convert.ToString(row["cvestado"]);
                    es = valor;
                    facultad._cveestado = es;
                    facultad.buscarnomestado(estado);
                    if (estado.Text == "DISPONIBLE")
                    {
                        botones[z].BackColor = Color.Lime;
                    }
                    if (estado.Text == "OCUPADA")
                    {
                        botones[z].BackColor = Color.Red;
                    }
                    if (estado.Text == "RESERVADA")
                    {
                        botones[z].BackColor = Color.Yellow;
                    }
                    if (estado.Text == "NO DISPONIBLE")
                    {
                        botones[z].BackColor = Color.Navy;
                    }
                    c++;
                }
            //}
            //catch (Exception)
            //{
              //  MessageBox.Show("EL NUMERO DE MAQUINAS GRABADAS ES SUPERIOR AL NUMERO EXISTENTES EN EL SISTEMA");
            //}


        }
        public void VISIBLE(Button[] x)
        {
            for (int d = 0; d <=s; d++)
            {
                x[d].Visible = true;
            }
        }
        public void acomodar(Button[] x)
        {
            //Convert.ToInt32(Conexion.y);
            int x1 = 80;
            int y1 = 50; 
            int c = 0;
            for (int r = 0; r <= 39; r++)
            {
                x[r].Width = Convert.ToInt32(Conexion.xa);
                x[r].Height = Convert.ToInt32(Conexion.ya);

                x[r].Left = x1;
                x[r].Top = y1;

                if (c == 3)
                {
                    x1 = x1 + x[r].Width + 50;
                }
                else
                {
                    if (c == 7)
                    {
                        y1 = y1 + x[r].Height + 5;
                        c = -1;
                        x1 = 80;

                    }
                    else
                    {
                        x1 = x1 + x[r].Width + 5;
                    }

                }
                c++;

            }

            btnc1.Width = 120;
            btnc1.Height = 80;
            btnc2.Width = 120;
            btnc2.Height = 80;
            btnc3.Width = 120;
            btnc3.Height = 80;
            btnc4.Width = 120;
            btnc4.Height = 80;
            btnmenu.Width = 120;
            btnmenu.Height = 80;
            btnreservar.Width = 120;
            btnreservar.Height = 80;


            btnc1.Text = "DISPONIBLE";
            btnc2.Text = "OCUPADA";
            btnc3.Text = "RESERVADA";
            btnc4.Text = "NO DISPONIBLE";

            btnmenu.Enabled = true;
            btnreservar.Enabled = true;

            btnc1.BackColor = Color.Lime;
            btnc2.BackColor = Color.Red;
            btnc3.BackColor = Color.Yellow;
            btnc4.BackColor = Color.Navy;

            x1 = x[39].Left + 110;
            btnmenu.Top = 50;
            btnmenu.Left = x1 + 50;
            btnreservar.Top = btnmenu.Top + btnmenu.Height + 10;
            btnreservar.Left = x1 + 50;
            btnc1.Top = btnreservar.Height + 10 + btnreservar.Top;
            btnc1.Left = x1 + 50;
            btnc2.Top = btnc1.Height + 10 + btnc1.Top;
            btnc2.Left = x1 + 50;
            btnc3.Top = btnc2.Height + 10 + btnc2.Top;
            btnc3.Left = x1 + 50;
            btnc4.Top = btnc3.Height + 10 + btnc3.Top;
            btnc4.Left = x1 + 50;





        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            BTN1.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "1";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "1";
            ad.ShowDialog();
            BTN1.Cursor = Cursors.Default;
        }

        private void Frmadmin_Activated(object sender, EventArgs e)
        {
            string valor;
            string es;
            TextBox estado = new TextBox();



            int c = 0;
            DataTable dr = new DataTable();
            dr = facultad.traerestmaquina();

            string contar;
            contar = facultad.contarmaquina();

            Button[] botones = new Button[40] { BTN1, BTN2, BTN3, BTN4, BTN5, BTN6, BTN7, BTN8, BTN9, BTN10, BTN11, BTN12, BTN13, BTN14, BTN15, BTN16, BTN17, BTN18, BTN19, BTN20, BTN21, BTN22, BTN23, BTN24, BTN25, BTN26, BTN27, BTN28, BTN29, BTN30, BTN31, BTN32, BTN33, BTN34, BTN35, BTN36, BTN37, BTN38, BTN39, BTN40 };


            int s = Convert.ToInt32(contar) - 1;
            //try
            //{
                for (int z = 0; z <= s; z++)
                {

                    DataRow row = dr.Rows[c];
                    valor = Convert.ToString(row["cvestado"]);
                    es = valor;
                    facultad._cveestado = es;
                    facultad.buscarnomestado(estado);
                    if (estado.Text == "DISPONIBLE")
                    {
                        botones[z].BackColor = Color.Lime;
                    }
                    if (estado.Text == "OCUPADA")
                    {
                        botones[z].BackColor = Color.Red;
                    }
                    if (estado.Text == "RESERVADA")
                    {
                        botones[z].BackColor = Color.Yellow;
                    }
                    if (estado.Text == "NO DISPONIBLE")
                    {
                        botones[z].BackColor = Color.Navy;
                    }
                    c++;
                }
            //}
           // catch (Exception)
            //{
             //   MessageBox.Show("EL NUMERO DE MAQUINAS GRABADAS ES SUPERIOR AL NUMERO EXISTENTES EN EL SISTEMA");
            //}
        }

        private void BTN2_Click(object sender, EventArgs e)
        {
            BTN2.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "2";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "2";
            ad.ShowDialog();
            BTN2.Cursor = Cursors.Default;
        }

        private void BTN3_Click(object sender, EventArgs e)
        {
            BTN3.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "3";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "3";
            ad.ShowDialog();
            BTN3.Cursor = Cursors.Default;
        }

        private void BTN4_Click(object sender, EventArgs e)
        {
            BTN4.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "4";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "4";
            ad.ShowDialog();
            BTN4.Cursor = Cursors.Default;
        }

        private void BTN5_Click(object sender, EventArgs e)
        {
            BTN5.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "5";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "5";
            ad.ShowDialog();
            BTN5.Cursor = Cursors.Default;
        }

        private void BTN6_Click(object sender, EventArgs e)
        {
            BTN6.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "6";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "6";
            ad.ShowDialog();
            BTN6.Cursor = Cursors.Default;
        }

        private void BTN7_Click(object sender, EventArgs e)
        {
            BTN7.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "7";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "7";
            ad.ShowDialog();
            BTN7.Cursor = Cursors.Default;
        }

        private void BTN8_Click(object sender, EventArgs e)
        {
            BTN8.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "8";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "8";
            ad.ShowDialog();
            BTN8.Cursor = Cursors.Default;
        }

        private void BTN9_Click(object sender, EventArgs e)
        {
            BTN9.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "9";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "9";
            ad.ShowDialog();
            BTN9.Cursor = Cursors.Default;
        }

        private void BTN10_Click(object sender, EventArgs e)
        {
            BTN10.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "10";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "10";
            ad.ShowDialog();
            BTN10.Cursor = Cursors.Default;
        }

        private void BTN11_Click(object sender, EventArgs e)
        {
            BTN11.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "11";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "11";
            ad.ShowDialog();
            BTN11.Cursor = Cursors.Default;
        }

        private void BTN12_Click(object sender, EventArgs e)
        {
            BTN12.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "12";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "12";
            ad.ShowDialog();
            BTN12.Cursor = Cursors.Default;
        }

        private void BTN13_Click(object sender, EventArgs e)
        {
            BTN13.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "13";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "13";
            ad.ShowDialog();
            BTN13.Cursor = Cursors.Default;
        }

        private void BTN14_Click(object sender, EventArgs e)
        {
            BTN14.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "14";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "14";
            ad.ShowDialog();
            BTN14.Cursor = Cursors.Default;
        }

        private void BTN15_Click(object sender, EventArgs e)
        {

            BTN15.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "15";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "15";
            ad.ShowDialog();
            BTN15.Cursor = Cursors.Default;
        }

        private void BTN16_Click(object sender, EventArgs e)
        {
            BTN16.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "16";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "16";
            ad.ShowDialog();
            BTN16.Cursor = Cursors.Default;
        }

        private void BTN17_Click(object sender, EventArgs e)
        {
            BTN17.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "17";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "17";
            ad.ShowDialog();
            BTN17.Cursor = Cursors.Default;
        }

        private void BTN18_Click(object sender, EventArgs e)
        {
            BTN18.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "18";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "18";
            ad.ShowDialog();
            BTN18.Cursor = Cursors.Default;
        }

        private void BTN19_Click(object sender, EventArgs e)
        {
            BTN19.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "19";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "19";
            ad.ShowDialog();
            BTN19.Cursor = Cursors.Default;
        }

        private void BTN20_Click(object sender, EventArgs e)
        {
            BTN20.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "20";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "20";
            ad.ShowDialog();
            BTN20.Cursor = Cursors.Default;
        }

        private void BTN21_Click(object sender, EventArgs e)
        {
            BTN21.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "21";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "21";
            ad.ShowDialog();
            BTN21.Cursor = Cursors.Default;
        }

        private void BTN22_Click(object sender, EventArgs e)
        {
            BTN22.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "22";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "22";
            ad.ShowDialog();
            BTN22.Cursor = Cursors.Default;
        }

        private void BTN23_Click(object sender, EventArgs e)
        {
            BTN23.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "23";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "23";
            ad.ShowDialog();
            BTN23.Cursor = Cursors.Default;
        }

        private void BTN24_Click(object sender, EventArgs e)
        {
            BTN24.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "24";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "24";
            ad.ShowDialog();
            BTN24.Cursor = Cursors.Default;
        }

        private void BTN25_Click(object sender, EventArgs e)
        {
            BTN25.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "25";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "25";
            ad.ShowDialog();
            BTN25.Cursor = Cursors.Default;
        }

        private void BTN26_Click(object sender, EventArgs e)
        {
            BTN26.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "26";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "26";
            ad.ShowDialog();
            BTN26.Cursor = Cursors.Default;
        }

        private void BTN27_Click(object sender, EventArgs e)
        {
            BTN27.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "27";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "27";
            ad.ShowDialog();
            BTN27.Cursor = Cursors.Default;
        }

        private void BTN28_Click(object sender, EventArgs e)
        {
            BTN28.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "28";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "28";
            ad.ShowDialog();
            BTN28.Cursor = Cursors.Default;
        }

        private void BTN29_Click(object sender, EventArgs e)
        {
            BTN29.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "29";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "29";
            ad.ShowDialog();
            BTN29.Cursor = Cursors.Default;
        }

        private void BTN30_Click(object sender, EventArgs e)
        {
            BTN30.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "30";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "30";
            ad.ShowDialog();
            BTN30.Cursor = Cursors.Default;
        }

        private void BTN31_Click(object sender, EventArgs e)
        {
            BTN31.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "31";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "31";
            ad.ShowDialog();
            BTN31.Cursor = Cursors.Default;
        }

        private void BTN32_Click(object sender, EventArgs e)
        {
            BTN32.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "32";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "32";
            ad.ShowDialog();
            BTN32.Cursor = Cursors.Default;
        }

        private void BTN33_Click(object sender, EventArgs e)
        {
            BTN33.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "33";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "33";
            ad.ShowDialog();
            BTN33.Cursor = Cursors.Default;
        }

        private void BTN34_Click(object sender, EventArgs e)
        {
            BTN34.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "34";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "34";
            ad.ShowDialog();
            BTN34.Cursor = Cursors.Default;
        }

        private void BTN35_Click(object sender, EventArgs e)
        {
            BTN35.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "35";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "35";
            ad.ShowDialog();
            BTN35.Cursor = Cursors.Default;
        }

        private void BTN36_Click(object sender, EventArgs e)
        {
            BTN36.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "36";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "36";
            ad.ShowDialog();
            BTN36.Cursor = Cursors.Default;
        }

        private void BTN37_Click(object sender, EventArgs e)
        {
            BTN37.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "37";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "37";
            ad.ShowDialog();
            BTN37.Cursor = Cursors.Default;
        }

        private void BTN38_Click(object sender, EventArgs e)
        {
            BTN38.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "38";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "38";
            ad.ShowDialog();
            BTN38.Cursor = Cursors.Default;
        }

        private void BTN39_Click(object sender, EventArgs e)
        {
            BTN39.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "39";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "39";
            ad.ShowDialog();
            BTN39.Cursor = Cursors.Default;
        }

        private void BTN40_Click(object sender, EventArgs e)
        {
            BTN40.Cursor = Cursors.WaitCursor;
            facultad._nmaquina = "40";
            n = facultad.buscarestadomaq();
            FrmAdmin2 ad = new FrmAdmin2();
            ad.es = n;
            ad.m = "40";
            ad.ShowDialog();
            BTN40.Cursor = Cursors.Default;
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            Frmenu menu = new Frmenu();
            this.Hide();
            menu.ShowDialog();
        }

        private void btnreservar_Click(object sender, EventArgs e)
        {
            Frmreservarm reservar = new Frmreservarm();
            reservar.ShowDialog();
        }
    }
}
