using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace FCEATCC
{
    public partial class Frmreservacionus : Form
    {
        Clsfacultad facultad = new Clsfacultad();
        Conexion conexion = new Conexion();
        Clsreservacion reservar = new Clsreservacion();
        Frmres hola = new Frmres();
        public string n;

        public string y; //id del usuario formulario res

       
        public string z;

        public string h;

        public int contador=0;

        public int s=0;

        public string estado;


        public Frmreservacionus()
        {
            InitializeComponent();
        }

        private void Frmreservacionus_Load(object sender, EventArgs e)
        {
            if (y.Length <= 5)
            {
                btnc5.Visible = true;
            }

            string valor;
            string es;
            
           


            int c = 0;
            DataTable dr = new DataTable();
            //facultad._cc = h;
            //facultad._cc = "1";
            dr = facultad.traerestmaquina();

            Button[] botones = new Button[40] { BTN1, BTN2, BTN3, BTN4, BTN5, BTN6, BTN7, BTN8, BTN9, BTN10, BTN11, BTN12, BTN13, BTN14, BTN15, BTN16, BTN17, BTN18, BTN19, BTN20, BTN21, BTN22, BTN23, BTN24, BTN25, BTN26, BTN27, BTN28, BTN29, BTN30, BTN31, BTN32, BTN33, BTN34, BTN35, BTN36, BTN37, BTN38,BTN39, BTN40};
            acomodar(botones);
            //VISIBLE(botones);

            btnc1.Visible = true;
            btnc2.Visible = true;
            btnc3.Visible = true;
            btnc4.Visible = true;


            string contar;
            //facultad._cc = h;
            //facultad._cc = conexion.obtenercc();
            contar = facultad.contarmaquina();

           

            s = Convert.ToInt32(contar)-1;

            
            try
            {
                DataTable DT = new DataTable();
                DT = facultad.traerestadoo();
                for (int z = 0; z <= s; z++)
                {

                    DataRow row = dr.Rows[c];
                    valor = Convert.ToString(row["cvestado"]);
                    es = valor;
                    DataRow[] datos = DT.Select("cveestado='"+ es + "'");
                    if (datos.Length > 0)
                    {

                        DataRow drow = datos[0];
                        estado = drow["descripcion"].ToString();
                    }
                    if (estado.ToString() == "DISPONIBLE")
                    {
                        botones[z].BackColor = Color.Lime;
                    }
                    if (estado.ToString() == "OCUPADA")
                    {
                        botones[z].BackColor = Color.Red;
                        botones[z].Enabled = false;
                    }
                    if (estado.ToString() == "RESERVADA")
                    {
                        botones[z].BackColor = Color.Yellow;
                        botones[z].Enabled = false;
                    }
                    if (estado.ToString() == "NO DISPONIBLE")
                    {
                        botones[z].BackColor = Color.Navy;
                        botones[z].Enabled = false;
                    }
                    c++;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("EL NUMERO DE MAQUINAS GRABADAS ES SUPERIOR AL NUMERO EXISTENTES EN EL SISTEMA");
            }

            VISIBLE(botones);



        }
        public void VISIBLE(Button[] x)
        {
            for (int i=0; i<=s; i++)
            {
                x[i].Visible = true;
            }
        }
        public void acomodar(Button[] x)
        {
            int x1=80, y1=50, c=0;
            for (int r = 0; r <= 39; r++)
            {
                x[r].Width = Convert.ToInt32(Conexion.x);
                x[r].Height = Convert.ToInt32(Conexion.y);

                x[r].Left = x1;
                x[r].Top = y1;

                if (c == 3)
                {
                    x1 =x1 + x[r].Width + 50;
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
            btnc5.Width = 120;
            btnc5.Height = 80;

            btnc1.Text = "DISPONIBLE";
            btnc2.Text = "OCUPADA";
            btnc3.Text = "RESERVADA";
            btnc4.Text = "NO DISPONIBLE";

            btnc1.BackColor = Color.Lime;
            btnc2.BackColor = Color.Red;
            btnc3.BackColor = Color.Yellow;
            btnc4.BackColor = Color.Navy;

            x1 = x[39].Left + 120;
            btnc1.Top = 80;
            btnc1.Left = x1 + 120;
            btnc2.Top = btnc1.Top + btnc1.Height + 10;
            btnc2.Left = x1 + 120;
            btnc3.Top = btnc2.Height + 10 + btnc2.Top;
            btnc3.Left = x1 + 120;
            btnc4.Top = btnc3.Height + 10 + btnc3.Top;
            btnc4.Left = x1 + 120;
            btnc5.Top = btnc4.Height + 10 + btnc4.Top;
            btnc5.Left = x1 + 120;





        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (contador == 15 )
            {
                this.Close();
                
            }
            

            contador++;
            label1.Text = contador.ToString();
        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "1";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {
               

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    //timer1.Stop();
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "1";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "1";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();
                    //reservar.actualizarreservacionumaq();

                    facultad.actualizarestmaquina();

                    
                    
                    this.Close();

                //}
            }
            else
            { }
        }

        private void BTN2_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "2";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "2";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "2";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();


                    facultad.actualizarestmaquina();

                    
                  //  timer1.Stop();
                    this.Close();

                //}
            }
            else
            { }

        }

        private void BTN4_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "4";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "4";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "4";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();

                //  timer1.Stop();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN3_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "3";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "3";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "3";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();

               
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN5_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "5";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "5";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "5";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN6_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "6";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "6";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "6";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN9_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "9";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                   
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "9";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "9";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN7_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "7";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "7";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "7";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN8_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "8";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "8";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "8";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN10_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "10";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

               // if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "10";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "10";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN11_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "11";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "11";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "11";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN12_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "12";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                   
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "12";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "12";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN13_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "13";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "13";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "13";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN14_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "14";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "14";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "14";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN15_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "15";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "15";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "15";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN16_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "16";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "16";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "16";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN17_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "17";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "17";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "17";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN18_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "18";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "18";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "18";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN19_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "19";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "19";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "19";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN20_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "20";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "20";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "20";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN21_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "21";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "21";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "21";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN22_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "22";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                   
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "22";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "22";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN23_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "23";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "23";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "23";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN24_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "24";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "24";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "24";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN25_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "25";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "25";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "25";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN26_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "26";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "26";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "26";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN27_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "27";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "27";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "27";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                // }
            }
            else
            { }
        }

        private void BTN28_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "28";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "28";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "28";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN29_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "29";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                   
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "29";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "29";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN30_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "30";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "30";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "30";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN31_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "31";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "31";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "31";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN32_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "32";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "32";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "32";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN33_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "33";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                   
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "33";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "33";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN34_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "34";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "34";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "34";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN35_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "35";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "35";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "35";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN36_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "36";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "36";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "36";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN37_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "37";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "37";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "37";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN38_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "38";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "38";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "38";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN39_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "39";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "39";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "39";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void BTN40_Click(object sender, EventArgs e)
        {
            facultad._nmaquina = "40";
            n=facultad.buscarestadomaq();
            facultad._cveestado = n;
            z=facultad.buscarestado();
            if (z == "DISPONIBLE")
            {

                //if (MessageBox.Show("Desea elegir la computadora?", "Centro de Computo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //{
                    
                    facultad._cveestado = "2";
                    facultad._idusuario = y;
                    facultad._nmaquina = "40";

                    reservar._idusuarios = y;
                    reservar._nmaquina = "40";
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    reservar._horae = DateTime.Now.ToShortTimeString();
                    reservar.grabarresusuario();

                    facultad.actualizarestmaquina();
                this.Close();

                //}
            }
            else
            { }
        }

        private void btnc5_Click(object sender, EventArgs e)
        {
            frmreservacionxmaestro xy = new frmreservacionxmaestro();
            xy.x = y;
            xy.ShowDialog();
        }
    }
}
