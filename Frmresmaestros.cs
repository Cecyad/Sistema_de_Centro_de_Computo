using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace FCEATCC
{
    public partial class Frmresmaestros : Form
    {
        Conexion conexion = new Conexion();

        public string id1, id2, id3, id4, id5, id6, id7, id8, id9, id10, id11, id12, id13, id14, id15, id16, id17, id18;
        public string blq1, blq2, blq3, blq4, blq5, blq6, blq7, blq8, blq9, blq10, blq11, blq12, blq13, blq14, blq15, blq16, blq17, blq18;

        public int contador = 0;
        public DataTable tiempo = new DataTable();
        public DataTable BLOQUE = new DataTable();
        public int bloquehh1=0;
        public int bloquehh2=0;
        public int bloquehh3=0;
        public int bloquehh4=0;
        public int bloquehh5=0;
        public int bloquehh6=0;
        public int bloquehh7 = 0;
        public int bloquehh8 = 0;
        public int bloquehh9 = 0;
        public int bloquehh10 = 0;
        public int bloquehh11 = 0;
        public int bloquehh12 = 0;
        public int bloquehh13 = 0;
        public int bloquehh14 = 0;
        public int bloquehh15 = 0;
        public int bloquehh16 = 0;
        public int bloquehh17 = 0;
        public int bloquehh18 = 0;

        public int uno = 0, dos = 0, tres = 0, cuatro = 0, cinco = 0, seis = 0, siete = 0, ocho = 0, nueve = 0, diez = 0, once = 0, doce = 0, trece = 0, catorce = 0, quince = 0, diesiseis = 0, diesisiete = 0, diesiocho = 0;


        public string PM;
        public string PMT;
        public string SM;
        public string SMT;
        public string TM;
        public string TMT;
        public string CM;
        public string CMT;
        public string QM;
        public string QMT;
        public string SSM;
        public string SSMT;
        public string PT;
        public string PTT;
        public string ST;
        public string STT;
        public string TT;
        public string TTT;
        public string CT;
        public string CTT;
        public string QT;
        public string QTT;
        public string SST;
        public string SSTT;
        public string PN;
        public string PNT;
        public string SN;
        public string SNT;
        public string TN;
        public string TNT;
        public string CN;
        public string CNT;
        public string QN;
        public string QNT;
        public string SSN;
        public string SSNT;

        SpeechSynthesizer synth = new SpeechSynthesizer();
        Clsreservacion reservar = new Clsreservacion();
        Clsfacultad facultad = new Clsfacultad();
        public Frmresmaestros()
        {
            InitializeComponent();
        }

        private void Frmresmaestros_Load(object sender, EventArgs e)
        {
            
            this.Location = Screen.AllScreens[1].WorkingArea.Location;
            int ancho = Convert.ToInt32(Conexion.ancho);
            int alto = Convert.ToInt32(Conexion.alto);

            //this.Size = new Size(ancho, alto);
            //this.Size = new si();


            string bloque;
            string fecha;
            string dia;
            int coun = 0;

            int contar = Convert.ToInt32(reservar.contarresmaestro());


            
            BLOQUE = reservar.traerbloque();

            for (int z = 0; z <= contar; z++)
            {
                bloq1();
                bloq2();
                bloq3();
                bloq4();
                bloq5();
                bloq6();
                bloq7();
                bloq8();
                bloq9();
                bloq10();
                bloq11();
                bloq12();
                bloq13();
                bloq14();
                bloq15();
                bloq16();
                bloq17();
                bloq18();

            }      

            DataTable dr = new DataTable();
            dr = reservar.traerfecha();




            for (int i = 0; i <= contar; i++)
            {
                if (coun <= Convert.ToInt32(contar) - 1)
                {
                    DataRow row = dr.Rows[coun];
                    fecha = Convert.ToString(row["fecha"]);
                    bloque = Convert.ToString(row["nbloque"]);

                    string cadena = fecha;
                    string[] datos = cadena.Split('-');
                    int fe = Convert.ToInt32(datos[0]);
                    int cha = Convert.ToInt32(datos[1]);
                    int che = Convert.ToInt32(datos[2]);
                    DateTime dateValue = new DateTime(fe, cha, che);
                    dia = dateValue.ToString("dddd");


                    if (dia == "lunes")
                    {
                        if (bloque == PM)
                        {
                            btnprimeralun.Visible = true;
                            btnprimeralun.BackColor = Color.Yellow;
                        }
                        if (bloque == SM)
                        {
                            btnsegundalunes.Visible = true;
                            btnsegundalunes.BackColor = Color.Yellow;
                        }
                        if (bloque == TM)
                        {
                            btnterceralunes.Visible = true;
                            btnterceralunes.BackColor = Color.Yellow;
                        }
                        if (bloque == CM)
                        {
                            btncuartalunes.Visible = true;
                            btncuartalunes.BackColor = Color.Yellow;
                        }
                        if (bloque == QM)
                        {
                            btnquintalunes.Visible = true;
                            btnquintalunes.BackColor = Color.Yellow;
                        }
                        if (bloque == SSM)
                        {
                            btnsestalunes.Visible = true;
                            btnsestalunes.BackColor = Color.Yellow;
                        }
                        if (bloque == PT)
                        {
                            btnprimeratardelunes.Visible = true;
                            btnprimeratardelunes.BackColor = Color.Yellow;
                        }
                        if (bloque == ST)
                        {
                            btnsegundatardelunes.Visible = true;
                            btnsegundatardelunes.BackColor = Color.Yellow;
                        }
                        if (bloque == TT)
                        {
                            btnterceratardelunes.Visible = true;
                            btnterceratardelunes.BackColor = Color.Yellow;
                        }
                        if (bloque == CT)
                        {
                            btncuartatardelunes.Visible = true;
                            btncuartatardelunes.BackColor = Color.Yellow;
                        }
                        if (bloque == QT)
                        {
                            btnquintatardelunes.Visible = true;
                            btnquintatardelunes.BackColor = Color.Yellow;
                        }
                        if (bloque == SST)
                        {
                            btnsestatardelunes.Visible = true;
                            btnsestatardelunes.BackColor = Color.Yellow;
                        }
                        if (bloque == PN)
                        {
                            btnprimeranochelunes.Visible = true;
                            btnprimeranochelunes.BackColor = Color.Yellow;
                        }
                        if (bloque == SN)
                        {
                            btnsegundanochelunes.Visible = true;
                            btnsegundanochelunes.BackColor = Color.Yellow;
                        }
                        if (bloque == TN)
                        {
                            btnterceranochelunes.Visible = true;
                            btnterceranochelunes.BackColor = Color.Yellow;
                        }
                        if (bloque == CN)
                        {
                            btncuartanochelunes.Visible = true;
                            btncuartanochelunes.BackColor = Color.Yellow;
                        }
                        if (bloque == QN)
                        {
                            btnquintanochelunes.Visible = true;
                            btnquintanochelunes.BackColor = Color.Yellow;
                        }
                        if (bloque == SSN)
                        {
                            btnsestanochelunes.Visible = true;
                            btnsestanochelunes.BackColor = Color.Yellow;
                        }


                    }
                    if (dia == "martes")
                    {
                        if (bloque == PM)
                        {
                            btnprimeramartes.Visible = true;
                            btnprimeramartes.BackColor = Color.Yellow;
                        }
                        if (bloque == SM)
                        {
                            btnsegundamartes.Visible = true;
                            btnsegundamartes.BackColor = Color.Yellow;
                        }
                        if (bloque == TM)
                        {
                            btnterceramartes.Visible = true;
                            btnterceramartes.BackColor = Color.Yellow;
                        }
                        if (bloque == CM)
                        {
                            btncuartamartes.Visible = true;
                            btncuartamartes.BackColor = Color.Yellow;
                        }
                        if (bloque == QM)
                        {
                            btnquintamartes.Visible = true;
                            btnquintamartes.BackColor = Color.Yellow;
                        }
                        if (bloque == SSM)
                        {
                            btnsestamartes.Visible = true;
                            btnsestamartes.BackColor = Color.Yellow;
                        }
                        if (bloque == PT)
                        {
                            btnprimeratardemartes.Visible = true;
                            btnprimeratardemartes.BackColor = Color.Yellow;
                        }
                        if (bloque == ST)
                        {
                            btnsegundatardemartes.Visible = true;
                            btnsegundatardemartes.BackColor = Color.Yellow;
                        }
                        if (bloque == TT)
                        {
                            btnterceratardemartes.Visible = true;
                            btnterceratardemartes.BackColor = Color.Yellow;
                        }
                        if (bloque == CT)
                        {
                            btncuartatardemartes.Visible = true;
                            btncuartatardemartes.BackColor = Color.Yellow;
                        }
                        if (bloque == QT)
                        {
                            btnquintatardemartes.Visible = true;
                            btnquintatardemartes.BackColor = Color.Yellow;
                        }
                        if (bloque == SST)
                        {
                            btnsestatardemartes.Visible = true;
                            btnsestatardemartes.BackColor = Color.Yellow;
                        }
                        if (bloque == PN)
                        {
                            btnprimeranochemartes.Visible = true;
                            btnprimeranochemartes.BackColor = Color.Yellow;
                        }
                        if (bloque == SN)
                        {
                            btnsegundanochemartes.Visible = true;
                            btnsegundanochemartes.BackColor = Color.Yellow;
                        }
                        if (bloque == TN)
                        {
                            btnterceranochemartes.Visible = true;
                            btnterceranochemartes.BackColor = Color.Yellow;
                        }
                        if (bloque == CN)
                        {
                            btncuartanochemartes.Visible = true;
                            btncuartanochemartes.BackColor = Color.Yellow;
                        }
                        if (bloque == QN)
                        {
                            btnquintanochemartes.Visible = true;
                            btnquintanochemartes.BackColor = Color.Yellow;
                        }
                        if (bloque == SSN)
                        {
                            btnsestanochemartes.Visible = true;
                            btnsestanochemartes.BackColor = Color.Yellow;
                        }
                    }
                    if (dia == "miércoles")
                    {
                        if (bloque == PM)
                        {
                            btnprimeramiercoles.Visible = true;
                            btnprimeramiercoles.BackColor = Color.Yellow;
                        }
                        if (bloque == SM)
                        {
                            btnsegundamiercoles.Visible = true;
                            btnsegundamiercoles.BackColor = Color.Yellow;
                        }
                        if (bloque == TM)
                        {
                            btnterceramiercoles.Visible = true;
                            btnterceramiercoles.BackColor = Color.Yellow;
                        }
                        if (bloque == CM)
                        {
                            btncuartamiercoles.Visible = true;
                            btncuartamiercoles.BackColor = Color.Yellow;
                        }
                        if (bloque == QM)
                        {
                            btnquintamiercoles.Visible = true;
                            btnquintamiercoles.BackColor = Color.Yellow;
                        }
                        if (bloque == SSM)
                        {
                            btnsestamiercoles.Visible = true;
                            btnsestamiercoles.BackColor = Color.Yellow;
                        }
                        if (bloque == PT)
                        {
                            btnprimeratardemiercoles.Visible = true;
                            btnprimeratardemiercoles.BackColor = Color.Yellow;
                        }
                        if (bloque == ST)
                        {
                            btnsegundatardemiercoles.Visible = true;
                            btnsegundatardemiercoles.BackColor = Color.Yellow;
                        }
                        if (bloque == TT)
                        {
                            btnterceratardemiercoles.Visible = true;
                            btnterceratardemiercoles.BackColor = Color.Yellow;
                        }
                        if (bloque == CT)
                        {
                            btncuartatardemiercoles.Visible = true;
                            btncuartatardemiercoles.BackColor = Color.Yellow;
                        }
                        if (bloque == QT)
                        {
                            btnquintatardemiercoles.Visible = true;
                            btnquintatardemiercoles.BackColor = Color.Yellow;
                        }
                        if (bloque == SST)
                        {
                            btnsestatardemiercoles.Visible = true;
                            btnsestatardemiercoles.BackColor = Color.Yellow;
                        }
                        if (bloque == PN)
                        {
                            btnprimeranochemiercoles.Visible = true;
                            btnprimeranochemiercoles.BackColor = Color.Yellow;
                        }
                        if (bloque == SN)
                        {
                            btnsegundanochemiercoles.Visible = true;
                            btnsegundanochemiercoles.BackColor = Color.Yellow;
                        }
                        if (bloque == TN)
                        {
                            btnterceranochemiercoles.Visible = true;
                            btnterceranochemiercoles.BackColor = Color.Yellow;
                        }
                        if (bloque == CN)
                        {
                            btncuartanochemiercoles.Visible = true;
                            btncuartanochemiercoles.BackColor = Color.Yellow;
                        }
                        if (bloque == QN)
                        {
                            btnquintanochemiercoles.Visible = true;
                            btnquintanochemiercoles.BackColor = Color.Yellow;
                        }
                        if (bloque == SSN)
                        {
                            btnsestanochemiercoles.Visible = true;
                            btnsestanochemiercoles.BackColor = Color.Yellow;
                        }
                    }
                    if (dia == "jueves")
                    {
                        if (bloque == PM)
                        {
                            btnprimerajueves.Visible = true;
                            btnprimerajueves.BackColor = Color.Yellow;
                        }
                        if (bloque == SM)
                        {
                            btnsegundajueves.Visible = true;
                            btnsegundajueves.BackColor = Color.Yellow;
                        }
                        if (bloque == TM)
                        {
                            btntercerajueves.Visible = true;
                            btntercerajueves.BackColor = Color.Yellow;
                        }
                        if (bloque == CM)
                        {
                            btncuartajueves.Visible = true;
                            btncuartajueves.BackColor = Color.Yellow;
                        }
                        if (bloque == QM)
                        {
                            btnquintajueves.Visible = true;
                            btnquintajueves.BackColor = Color.Yellow;
                        }
                        if (bloque == SSM)
                        {
                            btnsestajueves.Visible = true;
                            btnsestajueves.BackColor = Color.Yellow;
                        }
                        if (bloque == PT)
                        {
                            btnprimeratardejueves.Visible = true;
                            btnprimeratardejueves.BackColor = Color.Yellow;
                        }
                        if (bloque == ST)
                        {
                            btnsegundatardejueves.Visible = true;
                            btnsegundatardejueves.BackColor = Color.Yellow;
                        }
                        if (bloque == TT)
                        {
                            btnterceratardejueves.Visible = true;
                            btnterceratardejueves.BackColor = Color.Yellow;
                        }
                        if (bloque == CT)
                        {
                            btncuartatardejueves.Visible = true;
                            btncuartatardejueves.BackColor = Color.Yellow;
                        }
                        if (bloque == QT)
                        {
                            btnquintatardejueves.Visible = true;
                            btnquintatardejueves.BackColor = Color.Yellow;
                        }
                        if (bloque == SST)
                        {
                            btnsestatardejueves.Visible = true;
                            btnsestatardejueves.BackColor = Color.Yellow;
                        }
                        if (bloque == PN)
                        {
                            btnprimeranochejueves.Visible = true;
                            btnprimeranochejueves.BackColor = Color.Yellow;
                        }
                        if (bloque == SN)
                        {
                            btnsegundanochejueves.Visible = true;
                            btnsegundanochejueves.BackColor = Color.Yellow;
                        }
                        if (bloque == TN)
                        {
                            btnterceranochejueves.Visible = true;
                            btnterceranochejueves.BackColor = Color.Yellow;
                        }
                        if (bloque == CN)
                        {
                            btncuartanochejueves.Visible = true;
                            btncuartanochejueves.BackColor = Color.Yellow;
                        }
                        if (bloque == QN)
                        {
                            btnquintanochejueves.Visible = true;
                            btnquintanochejueves.BackColor = Color.Yellow;
                        }
                        if (bloque == SSN)
                        {
                            btnsestanochejueves.Visible = true;
                            btnsestanochejueves.BackColor = Color.Yellow;
                        }
                    }
                    if (dia == "viernes")
                    {
                        if (bloque == PM)
                        {
                            btnprimeraviernes.Visible = true;
                            btnprimeraviernes.BackColor = Color.Yellow;
                        }
                        if (bloque == SM)
                        {
                            btnsegundaviernes.Visible = true;
                            btnsegundaviernes.BackColor = Color.Yellow;
                        }
                        if (bloque == TM)
                        {
                            btnterceraviernes.Visible = true;
                            btnterceraviernes.BackColor = Color.Yellow;
                        }
                        if (bloque == CM)
                        {
                            btncuartaviertes.Visible = true;
                            btncuartaviertes.BackColor = Color.Yellow;
                        }
                        if (bloque == QM)
                        {
                            btnquintaviernes.Visible = true;
                            btnquintaviernes.BackColor = Color.Yellow;
                        }
                        if (bloque == SSM)
                        {
                            btnsestaviernes.Visible = true;
                            btnsestaviernes.BackColor = Color.Yellow;
                        }
                        if (bloque == PT)
                        {
                            btnprimeratardeviernes.Visible = true;
                            btnprimeratardeviernes.BackColor = Color.Yellow;
                        }
                        if (bloque == ST)
                        {
                            btnsegundatardeviernes.Visible = true;
                            btnsegundatardeviernes.BackColor = Color.Yellow;
                        }
                        if (bloque == TT)
                        {
                            btnterceratardeviernes.Visible = true;
                            btnterceratardeviernes.BackColor = Color.Yellow;
                        }
                        if (bloque == CT)
                        {
                            btncuartatardeviernes.Visible = true;
                            btncuartatardeviernes.BackColor = Color.Yellow;
                        }
                        if (bloque == QT)
                        {
                            btnquintatardeviernes.Visible = true;
                            btnquintatardeviernes.BackColor = Color.Yellow;
                        }
                        if (bloque == SST)
                        {
                            btnsestatardeviernes.Visible = true;
                            btnsestatardeviernes.BackColor = Color.Yellow;
                        }
                        if (bloque == PN)
                        {
                            btnprimeranocheviernes.Visible = true;
                            btnprimeranocheviernes.BackColor = Color.Yellow;
                        }
                        if (bloque == SN)
                        {
                            btnsegundanocheviernes.Visible = true;
                            btnsegundanocheviernes.BackColor = Color.Yellow;
                        }
                        if (bloque == TN)
                        {
                            btnterceranocheviernes.Visible = true;
                            btnterceranocheviernes.BackColor = Color.Yellow;
                        }
                        if (bloque == CN)
                        {
                            btncuartanocheviernes.Visible = true;
                            btncuartanocheviernes.BackColor = Color.Yellow;
                        }
                        if (bloque == QN)
                        {
                            btnquintanocheviernes.Visible = true;
                            btnquintanocheviernes.BackColor = Color.Yellow;
                        }
                        if (bloque == SSN)
                        {
                            btnsestanocheviernes.Visible = true;
                            btnsestanocheviernes.BackColor = Color.Yellow;
                        }
                    }
                    coun = coun + 1;
                    //ciclo = ciclo + 1;

                }
            }



            hora.Visible = false;
            panel.Visible = true;

            

           // DataTable tiempo = new DataTable();
            reservar._tiempo = DateTime.Now.ToString("yyyy-MM-dd");
            tiempo = reservar.traertiempo();

            





            int contiempo = Convert.ToInt32(reservar.contartiempo());

        
                if (contiempo == 1)
                {
                BLOQUE1();
                }
                if (contiempo == 2)
                {
                BLOQUE1();
                BLOQUE2();
                }
                if (contiempo == 3)
                {
                BLOQUE1();
                BLOQUE2();
                BLOQUE3();
                }
                if (contiempo == 4)
                {
                BLOQUE1();
                BLOQUE2();
                BLOQUE3();
                BLOQUE4();
                }
                if (contiempo == 5)
                {
                BLOQUE1();
                BLOQUE2();
                BLOQUE3();
                BLOQUE4();
                BLOQUE5();
                }
                if (contiempo == 6)
                {
                BLOQUE1();
                BLOQUE2();
                BLOQUE3();
                BLOQUE4();
                BLOQUE5();
                BLOQUE6();
                }
                if (contiempo == 7)
                {
                BLOQUE1();
                BLOQUE2();
                BLOQUE3();
                BLOQUE4();
                BLOQUE5();
                BLOQUE6();
                BLOQUE7();
                }
                if (contiempo == 8)
                {
                BLOQUE1();
                BLOQUE2();
                BLOQUE3();
                BLOQUE4();
                BLOQUE5();
                BLOQUE6();
                BLOQUE7();
                BLOQUE8();
                }
                if (contiempo == 9)
                {
                BLOQUE1();
                BLOQUE2();
                BLOQUE3();
                BLOQUE4();
                BLOQUE5();
                BLOQUE6();
                BLOQUE7();
                BLOQUE8();
                BLOQUE9();
                }
                if (contiempo == 10)
                {
                BLOQUE1();
                BLOQUE2();
                BLOQUE3();
                BLOQUE4();
                BLOQUE5();
                BLOQUE6();
                BLOQUE7();
                BLOQUE8();
                BLOQUE9();
                BLOQUE10();
                }
                if (contiempo == 11)
                {
                BLOQUE1();
                BLOQUE2();
                BLOQUE3();
                BLOQUE4();
                BLOQUE5();
                BLOQUE6();
                BLOQUE7();
                BLOQUE8();
                BLOQUE9();
                BLOQUE10();
                BLOQUE11();
                }
                if (contiempo == 12)
                {
                BLOQUE1();
                BLOQUE2();
                BLOQUE3();
                BLOQUE4();
                BLOQUE5();
                BLOQUE6();
                BLOQUE7();
                BLOQUE8();
                BLOQUE9();
                BLOQUE10();
                BLOQUE11();
                BLOQUE12();
                }
                if (contiempo == 13)
                {
                BLOQUE1();
                BLOQUE2();
                BLOQUE3();
                BLOQUE4();
                BLOQUE5();
                BLOQUE6();
                BLOQUE7();
                BLOQUE8();
                BLOQUE9();
                BLOQUE10();
                BLOQUE11();
                BLOQUE12();
                BLOQUE13();
                }
                if (contiempo == 14)
                {
                BLOQUE1();
                BLOQUE2();
                BLOQUE3();
                BLOQUE4();
                BLOQUE5();
                BLOQUE6();
                BLOQUE7();
                BLOQUE8();
                BLOQUE9();
                BLOQUE10();
                BLOQUE11();
                BLOQUE12();
                BLOQUE13();
                BLOQUE14();
                }
                if (contiempo == 15)
                {
                BLOQUE1();
                BLOQUE2();
                BLOQUE3();
                BLOQUE4();
                BLOQUE5();
                BLOQUE6();
                BLOQUE7();
                BLOQUE8();
                BLOQUE9();
                BLOQUE10();
                BLOQUE11();
                BLOQUE12();
                BLOQUE13();
                BLOQUE14();
                BLOQUE15();
                }
                if (contiempo == 16)
                {
                BLOQUE1();
                BLOQUE2();
                BLOQUE3();
                BLOQUE4();
                BLOQUE5();
                BLOQUE6();
                BLOQUE7();
                BLOQUE8();
                BLOQUE9();
                BLOQUE10();
                BLOQUE11();
                BLOQUE12();
                BLOQUE13();
                BLOQUE14();
                BLOQUE15();
                BLOQUE16();
                }
                if (contiempo == 17)
                {
                BLOQUE1();
                BLOQUE2();
                BLOQUE3();
                BLOQUE4();
                BLOQUE5();
                BLOQUE6();
                BLOQUE7();
                BLOQUE8();
                BLOQUE9();
                BLOQUE10();
                BLOQUE11();
                BLOQUE12();
                BLOQUE13();
                BLOQUE14();
                BLOQUE15();
                BLOQUE16();
                BLOQUE17();
                }
                if (contiempo == 18)
                {
                BLOQUE1();
                BLOQUE2();
                BLOQUE3();
                BLOQUE4();
                BLOQUE5();
                BLOQUE6();
                BLOQUE7();
                BLOQUE8();
                BLOQUE9();
                BLOQUE10();
                BLOQUE11();
                BLOQUE12();
                BLOQUE13();
                BLOQUE14();
                BLOQUE15();
                BLOQUE16();
                BLOQUE17();
                BLOQUE18();
                }
            reservar._fechares = DateTime.Now.ToString("yyyy-MM-dd");
            reservar._bloq = "1";
            id1 = reservar.traermaestrores();
            blq1 = reservar.traergrupores();
        }
        public void bloq1()
        {
            DataRow PMAÑANA = BLOQUE.Rows[0];
            PM = Convert.ToString(PMAÑANA["nbloque"]);
            PMT = Convert.ToString(PMAÑANA["tiempo"]);
           
        }
        public void bloq2()
        {
            DataRow SMAÑANA = BLOQUE.Rows[1];
            SM = Convert.ToString(SMAÑANA["nbloque"]);
            SMT = Convert.ToString(SMAÑANA["tiempo"]);
            
        }
        public void bloq3()
        {
            DataRow TMAÑANA = BLOQUE.Rows[2];
            TM = Convert.ToString(TMAÑANA["nbloque"]);
            TMT = Convert.ToString(TMAÑANA["tiempo"]);
            
        }
        public void bloq4()
        {
            DataRow CMAÑANA = BLOQUE.Rows[3];
            CM = Convert.ToString(CMAÑANA["nbloque"]);
            CMT = Convert.ToString(CMAÑANA["tiempo"]);
            
        }
        public void bloq5()
        {
            DataRow QMAÑANA = BLOQUE.Rows[4];
            QM = Convert.ToString(QMAÑANA["nbloque"]);
            QMT = Convert.ToString(QMAÑANA["tiempo"]);
            
        }
        public void bloq6()
        {
            DataRow SSMAÑANA = BLOQUE.Rows[5];
            SSM = Convert.ToString(SSMAÑANA["nbloque"]);
            SSMT = Convert.ToString(SSMAÑANA["tiempo"]);
            
        }
        public void bloq7()
        {
            DataRow PTARDE = BLOQUE.Rows[6];
            PT = Convert.ToString(PTARDE["nbloque"]);
            PTT = Convert.ToString(PTARDE["tiempo"]);
            
        }
        public void bloq8()
        {
            DataRow STARDE = BLOQUE.Rows[7];
            ST = Convert.ToString(STARDE["nbloque"]);
            STT = Convert.ToString(STARDE["tiempo"]);
            
        }
        public void bloq9()
        {
            DataRow TTARDE = BLOQUE.Rows[8];
            TT = Convert.ToString(TTARDE["nbloque"]);
            TTT = Convert.ToString(TTARDE["tiempo"]);
            
        }
        public void bloq10()
        {
            DataRow CTARDE = BLOQUE.Rows[9];
            CT = Convert.ToString(CTARDE["nbloque"]);
            CTT = Convert.ToString(CTARDE["tiempo"]);
            
        }
        public void bloq11()
        {
            DataRow QTARDE = BLOQUE.Rows[10];
            QT = Convert.ToString(QTARDE["nbloque"]);
            QTT = Convert.ToString(QTARDE["tiempo"]);
            
        }
        public void bloq12()
        {
            DataRow SSTARDE = BLOQUE.Rows[11];
            SST = Convert.ToString(SSTARDE["nbloque"]);
            SSTT = Convert.ToString(SSTARDE["tiempo"]);
            
        }
        public void bloq13()
        {
            DataRow PNOCHE = BLOQUE.Rows[12];
            PN = Convert.ToString(PNOCHE["nbloque"]);
            PNT = Convert.ToString(PNOCHE["tiempo"]);
            
        }
        public void bloq14()
        {
            DataRow SNOCHE = BLOQUE.Rows[13];
            SN = Convert.ToString(SNOCHE["nbloque"]);
            SNT = Convert.ToString(SNOCHE["tiempo"]);
            
        }
        public void bloq15()
        {
            DataRow TNOCHE = BLOQUE.Rows[14];
            TN = Convert.ToString(TNOCHE["nbloque"]);
            TNT = Convert.ToString(TNOCHE["tiempo"]);
            
        }
        public void bloq16()
        {
            DataRow CNOCHE = BLOQUE.Rows[15];
            CN = Convert.ToString(CNOCHE["nbloque"]);
            CNT = Convert.ToString(CNOCHE["tiempo"]);
            
        }
        public void bloq17()
        {
            DataRow QNOCHE = BLOQUE.Rows[16];
            QN = Convert.ToString(QNOCHE["nbloque"]);
            QNT = Convert.ToString(QNOCHE["tiempo"]);
            
        }
        public void bloq18()
        {
            DataRow SSNOCHE = BLOQUE.Rows[17];
            SSN = Convert.ToString(SSNOCHE["nbloque"]);
            SSNT = Convert.ToString(SSNOCHE["tiempo"]);
        }
       

        public void BLOQUE1()
        {
            DataRow tiempo1 = tiempo.Rows[0];
            bloquehh1 = Convert.ToInt32(tiempo1["nbloque"]);
        }
        public void BLOQUE2()
        {
            DataRow tiempo2 = tiempo.Rows[1];
            bloquehh2 = Convert.ToInt32(tiempo2["nbloque"]);
        }
        public void BLOQUE3()
        {
            DataRow tiempo3 = tiempo.Rows[2];
            bloquehh3 = Convert.ToInt32(tiempo3["nbloque"]);
        }
        public void BLOQUE4()
        {
            DataRow tiempo4 = tiempo.Rows[3];
            bloquehh4 = Convert.ToInt32(tiempo4["nbloque"]);
        }

        public void BLOQUE5()
        {
            DataRow tiempo5 = tiempo.Rows[4];
            bloquehh5 = Convert.ToInt32(tiempo5["nbloque"]);
        }
        public void BLOQUE6()
        {
            DataRow tiempo6 = tiempo.Rows[5];
            bloquehh6 = Convert.ToInt32(tiempo6["nbloque"]); 
        }
        public void BLOQUE7()
        {
            DataRow tiempo7 = tiempo.Rows[6];
            bloquehh7 = Convert.ToInt32(tiempo7["nbloque"]);
        }
        public void BLOQUE8()
        {
            DataRow tiempo8 = tiempo.Rows[7];
            bloquehh8 = Convert.ToInt32(tiempo8["nbloque"]);
        }
        public void BLOQUE9()
        {
            DataRow tiempo9 = tiempo.Rows[8];
            bloquehh9 = Convert.ToInt32(tiempo9["nbloque"]);
        }
        public void BLOQUE10()
        {
            DataRow tiempo10 = tiempo.Rows[9];
            bloquehh10 = Convert.ToInt32(tiempo10["nbloque"]);
        }
        public void BLOQUE11()
        {
            DataRow tiempo11 = tiempo.Rows[10];
            bloquehh11 = Convert.ToInt32(tiempo11["nbloque"]);
        }
        public void BLOQUE12()
        {
            DataRow tiempo12 = tiempo.Rows[11];
            bloquehh12 = Convert.ToInt32(tiempo12["nbloque"]);
        }
        public void BLOQUE13()
        {
            DataRow tiempo13 = tiempo.Rows[12];
            bloquehh13 = Convert.ToInt32(tiempo13["nbloque"]);
        }
        public void BLOQUE14()
        {
            DataRow tiempo14 = tiempo.Rows[13];
            bloquehh14 = Convert.ToInt32(tiempo14["nbloque"]);
        }
        public void BLOQUE15()
        {
            DataRow tiempo15 = tiempo.Rows[14];
            bloquehh15 = Convert.ToInt32(tiempo15["nbloque"]);
        }
        public void BLOQUE16()
        {
            DataRow tiempo16 = tiempo.Rows[15];
            bloquehh16 = Convert.ToInt32(tiempo16["nbloque"]);
        }
        public void BLOQUE17()
        {
            DataRow tiempo17 = tiempo.Rows[16];
            bloquehh17 = Convert.ToInt32(tiempo17["nbloque"]);
        }
        public void BLOQUE18()
        {
            DataRow tiempo18 = tiempo.Rows[17];
            bloquehh18 = Convert.ToInt32(tiempo18["nbloque"]);
        }
        
        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
        public void liberar()
        {
            reservar._estadou = "RESERVADA";
            string res = reservar.traerestado();
            reservar._reser = res;
            int con = Convert.ToInt32(reservar.contarmaquinaporeserv());
            if (con != 0)
            {
                string valor;
                string es;
                int c = 0;
                string valor2;
                string liberada;

                DataTable inf = new DataTable();
                inf = reservar.traeridnumaquina();

                for (int z = 1; z <= con; z++)
                {
                    DataRow row = inf.Rows[c];
                    valor = Convert.ToString(row["nmaquina"]);
                    valor2 = Convert.ToString(row["idusuario"]);
                    reservar._estadou = "LIBERADA POR SISTEMA";
                    liberada = reservar.traerestado();
                    reservar._cvestado = liberada;


                    reservar._horas = DateTime.Now.ToShortTimeString();
                    reservar._nmaquina = valor;
                    reservar._idusuarios = valor2;
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    string HORAE = reservar.traerhorae();
                    reservar._horae = HORAE;
                    reservar.actualizarreservaciohoras();

                    facultad._idusuario = "";
                    reservar._estadou = "DISPONIBLE";
                    es = reservar.traerestado();
                    facultad._cveestado = es;
                    facultad._nmaquina = valor;
                    facultad.actualizarmaquinaID();

                    c = c + 1;
                }
            }
        }

        private void reloj_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToLongTimeString();
            hora1();
            hora2();
            hora3();
            hora4();
            hora5();
            hora6();
            hora7();
            hora8();
            hora9();
            hora10();
            hora11();
            hora12();
            hora13();
            hora14();
            hora15();
            hora16();
            hora17();
            hora18();
            

            if (dos != 0 && (DateTime.Now.ToShortTimeString() == "07:40" || DateTime.Now.ToShortTimeString() == "07:45" || DateTime.Now.ToShortTimeString() == "07:50"))
            {

                if (hora.Text == "07:40:00")
                {
                    reservar._bloq = "2";
                    id2 = reservar.traermaestrores();
                    blq2 = reservar.traergrupores();
                    if (id1 == id2 && blq1 == blq2){ }
                    else {lapso1();}
                }
                if (hora.Text == "07:45:00")
                {
                    reservar._bloq = "2";
                    id2 = reservar.traermaestrores();
                    blq2 = reservar.traergrupores();
                    if (id1 == id2 && blq1 == blq2) { }
                    else{ lapso2(); }
                }
                if (hora.Text == "07:50:00")
                {
                    reservar._bloq = "2";
                    id2 = reservar.traermaestrores();
                    blq2 = reservar.traergrupores();
                    if (id1 == id2 && blq1 == blq2) { }
                    else{ lapso3(); }
                }
                
            }
            if (dos == 0 && DateTime.Now.ToShortTimeString() == "07:50")
            {
                if (hora.Text == "07:50:00")
                {
                    liberar();
                }
            }
            if (tres != 0 && (DateTime.Now.ToShortTimeString() == "08:30" || DateTime.Now.ToShortTimeString() == "08:35" || DateTime.Now.ToShortTimeString() == "08:40"))
            {

                if (hora.Text == "08:30:00")
                {
                    reservar._bloq = "3";
                    id3 = reservar.traermaestrores();
                    blq3 = reservar.traergrupores();
                    if (id2 == id3 && blq2 == blq3) {  }
                    else { lapso1(); }
                }
                if (hora.Text == "08:35:00")
                {
                    reservar._bloq = "3";
                    id3 = reservar.traermaestrores();
                    blq3 = reservar.traergrupores();
                    if (id2 == id3 && blq2 == blq3) { }
                    else{ lapso2(); }
                }
                if (hora.Text == "08:40:00")
                {
                    reservar._bloq = "3";
                    id3 = reservar.traermaestrores();
                    blq3 = reservar.traergrupores();
                    if (id2 == id3 && blq2 == blq3) { }
                    else{ lapso3(); }
                }
                
            }
            if (tres == 0 && DateTime.Now.ToShortTimeString() == "08:40")
            {
                if (hora.Text == "08:40:00")
                {
                    liberar();
                }
            }
            if (cuatro != 0 && (DateTime.Now.ToShortTimeString() == "09:50" || DateTime.Now.ToShortTimeString() == "09:55" || DateTime.Now.ToShortTimeString() == "10:00"))
            {

                if (hora.Text == "09:50:00")
                {
                    reservar._bloq = "4";
                    id4 = reservar.traermaestrores();
                    blq4 = reservar.traergrupores();
                    if (id3 == id4 && blq3 == blq4) { }
                    else{ lapso1(); }
                }
                if (hora.Text == "09:55:00")
                {
                    reservar._bloq = "4";
                    id4 = reservar.traermaestrores();
                    blq4 = reservar.traergrupores();
                    if (id3 == id4 && blq3 == blq4) { }
                    else { lapso2(); }
                }
                if (hora.Text == "10:00:00")
                {
                    reservar._bloq = "4";
                    id4 = reservar.traermaestrores();
                    blq4 = reservar.traergrupores();
                    if (id3 == id4 && blq3 == blq4) { }
                    else{ lapso3(); }
                }
                
            }
            if (cuatro == 0 && DateTime.Now.ToShortTimeString() == "10:00")
            {
                if (hora.Text == "10:00:00")
                {
                    liberar();
                }
            }

            if (cinco != 0 && (DateTime.Now.ToShortTimeString() == "10:40" || DateTime.Now.ToShortTimeString() == "10:45" || DateTime.Now.ToShortTimeString() == "10:50"))
            {

                if (hora.Text == "10:40:00")
                {
                    reservar._bloq = "5";
                    id5 = reservar.traermaestrores();
                    blq5 = reservar.traergrupores();
                    if (id4 == id5 && blq4 == blq5) { }
                    else{ lapso1(); }
                }
                if (hora.Text == "10:45:00")
                {
                    reservar._bloq = "5";
                    id5 = reservar.traermaestrores();
                    blq5 = reservar.traergrupores();
                    if (id4 == id5 && blq4 == blq5) { }
                    else{ lapso2(); }
                }
                if (hora.Text == "10:50:00")
                {
                    reservar._bloq = "5";
                    id5 = reservar.traermaestrores();
                    blq5 = reservar.traergrupores();
                    if (id4 == id5 && blq4 == blq5) { }
                    else{ lapso3(); }
                }
                
            }
            if (cinco == 0 && DateTime.Now.ToShortTimeString() == "10:50")
            {
                if (hora.Text == "10:50:00")
                {
                    liberar();
                }
            }
            if (seis != 0 && (DateTime.Now.ToShortTimeString() == "11:30" || DateTime.Now.ToShortTimeString() == "11:35" || DateTime.Now.ToShortTimeString() == "11:40"))
            {

                if (hora.Text == "11:30:00")
                {
                    reservar._bloq = "6";
                    id6 = reservar.traermaestrores();
                    blq6 = reservar.traergrupores();
                    if (id5 == id6 && blq5 == blq6) { }
                    else{ lapso1(); }
                }
                if (hora.Text == "11:35:00")
                {
                    reservar._bloq = "6";
                    id6 = reservar.traermaestrores();
                    blq6 = reservar.traergrupores();
                    if (id5 == id6 && blq5 == blq6) { }
                    else{ lapso2(); }
                }
                if (hora.Text == "11:40:00")
                {
                    reservar._bloq = "6";
                    id6 = reservar.traermaestrores();
                    blq6 = reservar.traergrupores();
                    if (id5 == id6 && blq5 == blq6) { }
                    else{ lapso3(); }
                }
                
            }
            if (seis == 0 && DateTime.Now.ToShortTimeString() == "11:40")
            {
                if (hora.Text == "11:40:00")
                {
                    liberar();
                }
            }
            if (siete != 0 && (DateTime.Now.ToShortTimeString() == "12:50" || DateTime.Now.ToShortTimeString() == "12:55" || DateTime.Now.ToShortTimeString() == "13:00"))
            {

                if (hora.Text == "12:50:00")
                {
                    reservar._bloq = "7";
                    id7 = reservar.traermaestrores();
                    blq7 = reservar.traergrupores();
                    if (id6 == id7 && blq6 == blq7) { }
                    else{ lapso1(); }
                }
                if (hora.Text == "12:55:00")
                {
                    reservar._bloq = "7";
                    id7 = reservar.traermaestrores();
                    blq7 = reservar.traergrupores();
                    if (id6 == id7 && blq6 == blq7) { }
                    else{ lapso2(); }
                }
                if (hora.Text == "13:00:00")
                {
                    reservar._bloq = "7";
                    id7 = reservar.traermaestrores();
                    blq7 = reservar.traergrupores();
                    if (id6 == id7 && blq6 == blq7) { }
                    else{ lapso3(); }
                }
                
            }
            if (siete == 0 && DateTime.Now.ToShortTimeString() == "13:00")
            {
                if (hora.Text == "13:00:00")
                {
                    liberar();
                }
            }
            if (ocho != 0 && (DateTime.Now.ToShortTimeString() == "13:40" || DateTime.Now.ToShortTimeString() == "13:45" || DateTime.Now.ToShortTimeString() == "13:50"))
            {

                if (hora.Text == "13:40:00")
                {
                    reservar._bloq = "8";
                    id8 = reservar.traermaestrores();
                    blq8 = reservar.traergrupores();
                    if (id7 == id8 && blq7 == blq8) { }
                    else{ lapso1(); }
                }
                if (hora.Text == "13:45:00")
                {
                    reservar._bloq = "8";
                    id8 = reservar.traermaestrores();
                    blq8 = reservar.traergrupores();
                    if (id7 == id8 && blq7 == blq8) { }
                    else{ lapso2(); }
                }
                if (hora.Text == "13:50:00")
                {
                    reservar._bloq = "8";
                    id8 = reservar.traermaestrores();
                    blq8 = reservar.traergrupores();
                    if (id7 == id8 && blq7 == blq8) { }
                    else{ lapso3(); }
                }
                
            }
            if (ocho == 0 && DateTime.Now.ToShortTimeString() == "13:50")
            {
                if (hora.Text == "13:50:00")
                {
                    liberar();
                }
            }
            if (nueve != 0 && (DateTime.Now.ToShortTimeString() == "14:30" || DateTime.Now.ToShortTimeString() == "14:35" || DateTime.Now.ToShortTimeString() == "14:40"))
            {

                if (hora.Text == "14:30:00")
                {
                    reservar._bloq = "9";
                    id9 = reservar.traermaestrores();
                    blq9 = reservar.traergrupores();
                    if (id8 == id9 && blq8 == blq9) { }
                    else{ lapso1(); }
                }
                if (hora.Text == "14:35:00")
                {
                    reservar._bloq = "9";
                    id9 = reservar.traermaestrores();
                    blq9 = reservar.traergrupores();
                    if (id8 == id9 && blq8 == blq9) { }
                    else{ lapso2(); }
                }
                if (hora.Text == "14:40:00")
                {
                    reservar._bloq = "9";
                    id9 = reservar.traermaestrores();
                    blq9 = reservar.traergrupores();
                    if (id8 == id9 && blq8 == blq9) { }
                    else{ lapso3(); }
                }
                
            }
            if (nueve == 0 && DateTime.Now.ToShortTimeString() == "14:40")
            {
                if (hora.Text == "14:40:00")
                {
                    liberar();
                }
            }
            if (diez != 0 && (DateTime.Now.ToShortTimeString() == "15:20" || DateTime.Now.ToShortTimeString() == "15:25" || DateTime.Now.ToShortTimeString() == "15:30"))
            {

                if (hora.Text == "15:20:00")
                {
                    reservar._bloq = "10";
                    id10 = reservar.traermaestrores();
                    blq10 = reservar.traergrupores();
                    if (id9 == id10 && blq9 == blq10) { }
                    else{ lapso1(); }
                }
                if (hora.Text == "15:25:00")
                {
                    reservar._bloq = "10";
                    id10 = reservar.traermaestrores();
                    blq10 = reservar.traergrupores();
                    if (id9 == id10 && blq9 == blq10) { }
                    else{ lapso2(); }
                }
                if (hora.Text == "15:30:00")
                {
                    reservar._bloq = "10";
                    id10 = reservar.traermaestrores();
                    blq10 = reservar.traergrupores();
                    if (id9 == id10 && blq9 == blq10) { }
                    else{ lapso3(); }
                }
                
            }
            if (diez == 0 && DateTime.Now.ToShortTimeString() == "15:30")
            {
                if (hora.Text == "15:30:00")
                {
                    liberar();
                }
            }
            if (once != 0 && (DateTime.Now.ToShortTimeString() == "16:10" || DateTime.Now.ToShortTimeString() == "16:15" || DateTime.Now.ToShortTimeString() == "16:20"))
            {

                if (hora.Text == "16:10:00")
                {
                    reservar._bloq = "11";
                    id11 = reservar.traermaestrores();
                    blq11 = reservar.traergrupores();
                    if (id10 == id11 && blq10 == blq11) { }
                    else{ lapso1(); }
                }
                if (hora.Text == "16:15:00")
                {
                    reservar._bloq = "11";
                    id11 = reservar.traermaestrores();
                    blq11 = reservar.traergrupores();
                    if (id10 == id11 && blq10 == blq11) { }
                    else{ lapso2(); }
                }
                if (hora.Text == "16:20:00")
                {
                    reservar._bloq = "11";
                    id11 = reservar.traermaestrores();
                    blq11 = reservar.traergrupores();
                    if (id10 == id11 && blq10 == blq11) { }
                    else{ lapso3(); }
                }
                
            }
            if (once == 0 && DateTime.Now.ToShortTimeString() == "16:20")
            {
                if (hora.Text == "16:20:00")
                {
                    liberar();
                }
            }
            if (doce != 0 && (DateTime.Now.ToShortTimeString() == "17:00" || DateTime.Now.ToShortTimeString() == "17:05" || DateTime.Now.ToShortTimeString() == "17:10"))
            {

                if (hora.Text == "17:00:00")
                {
                    reservar._bloq = "12";
                    id12 = reservar.traermaestrores();
                    blq12 = reservar.traergrupores();
                    if (id11 == id12 && blq11 == blq12) { }
                    else{ lapso1(); }
                }
                if (hora.Text == "17:05:00")
                {
                    reservar._bloq = "12";
                    id12 = reservar.traermaestrores();
                    blq12 = reservar.traergrupores();
                    if (id11 == id12 && blq11 == blq12) { }
                    else{ lapso2(); }
                }
                if (hora.Text == "17:10:00")
                {
                    reservar._bloq = "12";
                    id12 = reservar.traermaestrores();
                    blq12 = reservar.traergrupores();
                    if (id11 == id12 && blq11 == blq12) { }
                    else{ lapso3(); }
                }
                
            }
            if (doce == 0 && DateTime.Now.ToShortTimeString() == "17:10")
            {
                if (hora.Text == "17:10:00")
                {
                    liberar();
                }
            }
            if (trece != 0 && (DateTime.Now.ToShortTimeString() == "17:50" || DateTime.Now.ToShortTimeString() == "17:55" || DateTime.Now.ToShortTimeString() == "18:00"))
            {

                if (hora.Text == "17:50:00")
                {
                    reservar._bloq = "13";
                    id13 = reservar.traermaestrores();
                    blq13 = reservar.traergrupores();
                    if (id12 == id13 && blq12 == blq13) { }
                    else{ lapso1(); }
                }

                if (hora.Text == "17:55:00")
                {
                    reservar._bloq = "13";
                    id13 = reservar.traermaestrores();
                    blq13 = reservar.traergrupores();
                    if (id12 == id13 && blq12 == blq13) { }
                    else{ lapso2(); }
                }
                if (hora.Text == "18:00:00")
                {
                    reservar._bloq = "13";
                    id13 = reservar.traermaestrores();
                    blq13 = reservar.traergrupores();
                    if (id12 == id13 && blq12 == blq13) { }
                    else{ lapso3(); }
                }
                
            }
            if (trece == 0 && DateTime.Now.ToShortTimeString() == "18:00")
            {
                if (hora.Text == "18:00:00")
                {
                    liberar();
                }
            }
            if (catorce != 0 && (DateTime.Now.ToShortTimeString() == "18:30" || DateTime.Now.ToShortTimeString() == "18:35" || DateTime.Now.ToShortTimeString() == "18:40"))
            {

                if (hora.Text == "18:30:00")
                {
                    reservar._bloq = "14";
                    id14 = reservar.traermaestrores();
                    blq14 = reservar.traergrupores();
                    if (id13 == id14 && blq13 == blq14) { }
                    else{ lapso1(); }
                }
                if (hora.Text == "18:35:00")
                {
                    reservar._bloq = "14";
                    id14 = reservar.traermaestrores();
                    blq14 = reservar.traergrupores();
                    if (id13 == id14 && blq13 == blq14) { }
                    else{ lapso2(); }
                }
                if (hora.Text == "18:40:00")
                {
                    reservar._bloq = "14";
                    id14 = reservar.traermaestrores();
                    blq14 = reservar.traergrupores();
                    if (id13 == id14 && blq13 == blq14) { }
                    else{ lapso3(); }
                }
                
            }
            if (catorce == 0 && DateTime.Now.ToShortTimeString() == "18:40")
            {
                if (hora.Text == "18:40:00")
                {
                    liberar();
                }
            }
            if (quince != 0 && (DateTime.Now.ToShortTimeString() == "19:10" || DateTime.Now.ToShortTimeString() == "19:15" || DateTime.Now.ToShortTimeString() == "19:20"))
            {

                if (hora.Text == "19:10:00")
                {
                    reservar._bloq = "15";
                    id15 = reservar.traermaestrores();
                    blq15 = reservar.traergrupores();
                    if (id14 == id15 && blq14 == blq15) { }
                    else{ lapso1(); }
                }
                if (hora.Text == "19:15:00")
                {
                    reservar._bloq = "15";
                    id15 = reservar.traermaestrores();
                    blq15 = reservar.traergrupores();
                    if (id14 == id15 && blq14 == blq15) { }
                    else{ lapso2(); }
                }
                if (hora.Text == "19:20:00")
                {
                    reservar._bloq = "15";
                    id15 = reservar.traermaestrores();
                    blq15 = reservar.traergrupores();
                    if (id14 == id15 && blq14 == blq15) { }
                    else{ lapso3(); }
                }
                
            }
            if (quince == 0 && DateTime.Now.ToShortTimeString() == "19:20")
            {
                if (hora.Text == "19:20:00")
                {
                    liberar();
                }
            }
            if (diesiseis != 0 && (DateTime.Now.ToShortTimeString() == "19:50" || DateTime.Now.ToShortTimeString() == "19:55" || DateTime.Now.ToShortTimeString() == "20:00"))
            {

                if (hora.Text == "19:50:00")
                {
                    reservar._bloq = "16";
                    id16 = reservar.traermaestrores();
                    blq16 = reservar.traergrupores();
                    if (id15 == id16 && blq15 == blq16) { }
                    else{ lapso1(); }
                }
                if (hora.Text == "19:55:00")
                {
                    reservar._bloq = "16";
                    id16 = reservar.traermaestrores();
                    blq16 = reservar.traergrupores();
                    if (id15 == id16 && blq15 == blq16) { }
                    else{ lapso2(); }
                }
                if (hora.Text == "20:00:00")
                {
                    reservar._bloq = "16";
                    id16 = reservar.traermaestrores();
                    blq16 = reservar.traergrupores();
                    if (id15 == id16 && blq15 == blq16) { }
                    else{ lapso3(); }
                }
                
            }
            if (diesiseis == 0 && DateTime.Now.ToShortTimeString() == "20:00")
            {
                if (hora.Text == "20:00:00")
                {
                    liberar();
                }
            }
            if (diesisiete != 0 && (DateTime.Now.ToShortTimeString() == "20:30" || DateTime.Now.ToShortTimeString() == "20:35" || DateTime.Now.ToShortTimeString() == "20:40"))
            {

                if (hora.Text == "20:30:00")
                {
                    reservar._bloq = "17";
                    id17 = reservar.traermaestrores();
                    blq17 = reservar.traergrupores();
                    if (id16 == id17 && blq16 == blq17) { }
                    else{ lapso1(); }
                }
                if (hora.Text == "20:35:00")
                {
                    reservar._bloq = "17";
                    id17 = reservar.traermaestrores();
                    blq17 = reservar.traergrupores();
                    if (id16 == id17 && blq16 == blq17) { }
                    else{ lapso2(); }
                }
                if (hora.Text == "20:40:00")
                {
                    reservar._bloq = "17";
                    id17 = reservar.traermaestrores();
                    blq17 = reservar.traergrupores();
                    if (id16 == id17 && blq16 == blq17) { }
                    else{ lapso3(); }
                }
                
            }
            if (diesisiete == 0 && DateTime.Now.ToShortTimeString() == "20:40")
            {
                if (hora.Text == "20:40:00")
                {
                    liberar();
                }
            }
            if (diesiocho != 0 && (DateTime.Now.ToShortTimeString() == "21:10" || DateTime.Now.ToShortTimeString() == "21:15" || DateTime.Now.ToShortTimeString() == "21:20"))
            {

                if (hora.Text == "21:10:00")
                {
                    reservar._bloq = "18";
                    id18 = reservar.traermaestrores();
                    blq18 = reservar.traergrupores();
                    if (id17 == id18 && blq17 == blq18) { }
                    else{ lapso1(); }
                }
                if (hora.Text == "21:15:00")
                {
                    reservar._bloq = "18";
                    id18 = reservar.traermaestrores();
                    blq18 = reservar.traergrupores();
                    if (id17 == id18 && blq17 == blq18) { }
                    else{ lapso2(); }
                }
                if (hora.Text == "21:20:00")
                {
                    reservar._bloq = "18";
                    id18 = reservar.traermaestrores();
                    blq18 = reservar.traergrupores();
                    if (id17 == id18 && blq17 == blq18) { }
                    else{ lapso3(); }
                }
                
            }
            if (diesiocho == 0 && DateTime.Now.ToShortTimeString() == "21:20")
            {
                if (hora.Text == "21:20:00")
                {
                    liberar();
                }
            }
            if (hora.Text == "22:00:00")
            {
                lapsoultimo();
            }


        }
        public void lapso1()
        {
            reservar._estadou = "OCUPADA";
            string ocupada = reservar.traerestado();
            reservar._estadou = "RESERVADA";
            string reservada = reservar.traerestado();
            reservar._ocup = ocupada;
            reservar._reser = reservada;
            int contar = Convert.ToInt32(reservar.contarmaquina());
            if (contar != 0)
            {
                synth.SetOutputToDefaultAudioDevice();
                synth.Speak("En 10 minutos el centro de computo esta reservado, favor de guardar su trabajo.");
            }
        }
        public void lapso2()
        {
            reservar._estadou = "OCUPADA";
            string ocupada = reservar.traerestado();
            reservar._estadou = "RESERVADA";
            string reservada = reservar.traerestado();
            reservar._ocup = ocupada;
            reservar._reser = reservada;
            int contar = Convert.ToInt32(reservar.contarmaquina());
            if (contar != 0)
            {
                synth.SetOutputToDefaultAudioDevice();
                synth.Speak("En 5 minutos el centro de computo esta reservado, favor de desocupar el equipo.");
            }
        }
        public void lapso3()
        {
            reservar._estadou = "OCUPADA";
            string ocupada = reservar.traerestado();
            reservar._estadou = "RESERVADA";
            string reservada = reservar.traerestado();
            reservar._ocup = ocupada;
            reservar._reser = reservada;
            int contar = Convert.ToInt32(reservar.contarmaquina());
            if (contar != 0)
            {
                synth.SetOutputToDefaultAudioDevice();
                synth.Speak("El centro de computo esta reservado, gracias por su visita");



                string valor;
                string es;
                int c = 0;
                string valor2;
                string liberada;

                DataTable inf = new DataTable();
                inf = reservar.traerestmaquina();

                for (int z = 1; z <= contar; z++)
                {
                    DataRow row = inf.Rows[c];
                    valor = Convert.ToString(row["nmaquina"]);
                    valor2 = Convert.ToString(row["idusuario"]);
                    reservar._estadou = "LIBERADA POR SISTEMA";
                    liberada = reservar.traerestado();
                    reservar._cvestado = liberada;


                    reservar._horas = DateTime.Now.ToShortTimeString();
                    reservar._nmaquina = valor;
                    reservar._idusuarios = valor2;
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd"); 
                    string HORAE = reservar.traerhorae();
                    reservar._horae = HORAE;
                    string fechareg = reservar.traerfechareg();
                    reservar._fechareg = fechareg;
                    reservar.actualizarreservaciohoras();

                    facultad._idusuario = "";
                    reservar._estadou = "DISPONIBLE";
                    es = reservar.traerestado();
                    facultad._cveestado = es;
                    facultad._nmaquina = valor;
                    facultad.actualizarmaquinaID();

                    c = c + 1;
                }
            }
            int maquinas=1;
            facultad._cveestado = reservada;
            string idmaestro = reservar.buscaridaestroreservacion();
            int nummaq = Convert.ToInt32(facultad.contarmaquina());
            for (int v = 1; v <= nummaq; v++)
            {
                reservar._idusuarios = idmaestro;
                reservar._nmaquina = Convert.ToString(maquinas);
                reservar._horae = DateTime.Now.ToShortTimeString();
                reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd"); ;
                reservar.grabarresusuario();
                reservar._estadc = reservada;
                reservar.actualizarestmaquina();
                maquinas = maquinas + 1;
            }
        }
        public void lapsoultimo()
        {
            reservar._estadou = "OCUPADA";
            string ocupada = reservar.traerestado();
            reservar._estadou = "RESERVADA";
            string reservada = reservar.traerestado();
            reservar._ocup = ocupada;
            reservar._reser = reservada;
            int contar = Convert.ToInt32(reservar.contarmaquina());
            if (contar != 0)
            {

                string valor;
                string es;
                int c = 0;
                string valor2;
                string liberada;

                DataTable inf = new DataTable();
                inf = reservar.traerestmaquina();

                for (int z = 1; z <= contar; z++)
                {
                    DataRow row = inf.Rows[c];
                    valor = Convert.ToString(row["nmaquina"]);
                    valor2 = Convert.ToString(row["idusuario"]);
                    reservar._estadou = "LIBERADA POR SISTEMA";
                    liberada = reservar.traerestado();
                    reservar._cvestado = liberada;


                    reservar._horas = DateTime.Now.ToShortTimeString();
                    reservar._nmaquina = valor;
                    reservar._idusuarios = valor2;
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    string HORAE = reservar.traerhorae();
                    reservar._horae = HORAE;
                    string fechareg = reservar.traerfechareg();
                    reservar._fechareg = fechareg;
                    reservar.actualizarreservaciohoras();

                    facultad._idusuario = "";
                    reservar._estadou = "DISPONIBLE";
                    es = reservar.traerestado();
                    facultad._cveestado = es;
                    facultad._nmaquina = valor;
                    facultad.actualizarmaquinaID();

                    c = c + 1;
                }
            }
            int maquinas = 1;
            facultad._cveestado = reservada;
            string idmaestro = reservar.buscaridaestroreservacion();
            int nummaq = Convert.ToInt32(facultad.contarmaquina());
            for (int v = 1; v <= nummaq; v++)
            {
                reservar._idusuarios = idmaestro;
                reservar._nmaquina = Convert.ToString(maquinas);
                reservar._horae = DateTime.Now.ToShortTimeString();
                reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd"); ;
                reservar.grabarresusuario();
                reservar._estadc = reservada;
                reservar.actualizarestmaquina();
                maquinas = maquinas + 1;
            }
        }
        public void hora1()
        {
            if (bloquehh1 == 1)
            { uno = 1; }
            if (bloquehh1 == 2)
            { dos = 2; }
            if (bloquehh1 == 3)
            { tres = 3; }
            if (bloquehh1 == 4)
            { cuatro = 4; }
            if (bloquehh1 == 5)
            { cinco = 5; }
            if (bloquehh1 == 6)
            { seis = 6; }
            if (bloquehh1 == 7)
            { siete = 7; }
            if (bloquehh1 == 8)
            { ocho = 8; }
            if (bloquehh1 == 9)
            { nueve = 9; }
            if (bloquehh1 == 10)
            { diez = 10; }
            if (bloquehh1 == 11)
            { once = 11; }
            if (bloquehh1 == 12)
            { doce = 12; }
            if (bloquehh1 == 13)
            { trece = 13; }
            if (bloquehh1 == 14)
            { catorce = 14; }
            if (bloquehh1 == 15)
            { quince = 15; }
            if (bloquehh1 == 16)
            { diesiseis = 16; }
            if (bloquehh1 == 17)
            { diesisiete = 17; }
            if (bloquehh1 == 18)
            { diesiocho = 18; }
        }
        public void hora2()
        {
            if (bloquehh2 == 1)
            { uno = 1; }
            if (bloquehh2 == 2)
            { dos = 2; }
            if (bloquehh2 == 3)
            { tres = 3; }
            if (bloquehh2 == 4)
            { cuatro = 4; }
            if (bloquehh2 == 5)
            { cinco = 5; }
            if (bloquehh2 == 6)
            { seis = 6; }
            if (bloquehh2 == 7)
            { siete = 7; }
            if (bloquehh2 == 8)
            { ocho = 8; }
            if (bloquehh2 == 9)
            { nueve = 9; }
            if (bloquehh2 == 10)
            { diez = 10; }
            if (bloquehh2 == 11)
            { once = 11; }
            if (bloquehh2 == 12)
            { doce = 12; }
            if (bloquehh2 == 13)
            { trece = 13; }
            if (bloquehh2 == 14)
            { catorce = 14; }
            if (bloquehh2 == 15)
            { quince = 15; }
            if (bloquehh2 == 16)
            { diesiseis = 16; }
            if (bloquehh2 == 17)
            { diesisiete = 17; }
            if (bloquehh2 == 18)
            { diesiocho = 18; }
        }
        public void hora3()
        {
            if (bloquehh3 == 1)
            { uno = 1; }
            if (bloquehh3 == 2)
            { dos = 2; }
            if (bloquehh3 == 3)
            { tres = 3; }
            if (bloquehh3 == 4)
            { cuatro = 4; }
            if (bloquehh3 == 5)
            { cinco = 5; }
            if (bloquehh3 == 6)
            { seis = 6; }
            if (bloquehh3 == 7)
            { siete = 7; }
            if (bloquehh3 == 8)
            { ocho = 8; }
            if (bloquehh3 == 9)
            { nueve = 9; }
            if (bloquehh3 == 10)
            { diez = 10; }
            if (bloquehh3 == 11)
            { once = 11; }
            if (bloquehh3 == 12)
            { doce = 12; }
            if (bloquehh3 == 13)
            { trece = 13; }
            if (bloquehh3 == 14)
            { catorce = 14; }
            if (bloquehh3 == 15)
            { quince = 15; }
            if (bloquehh3 == 16)
            { diesiseis = 16; }
            if (bloquehh3 == 17)
            { diesisiete = 17; }
            if (bloquehh3 == 18)
            { diesiocho = 18; }
        }
        public void hora4()
        {
            if (bloquehh4 == 1)
            { uno = 1; }
            if (bloquehh4 == 2)
            { dos = 2; }
            if (bloquehh4 == 3)
            { tres = 3; }
            if (bloquehh4 == 4)
            { cuatro = 4; }
            if (bloquehh4 == 5)
            { cinco = 5; }
            if (bloquehh4 == 6)
            { seis = 6; }
            if (bloquehh4 == 7)
            { siete = 7; }
            if (bloquehh4 == 8)
            { ocho = 8; }
            if (bloquehh4 == 9)
            { nueve = 9; }
            if (bloquehh4 == 10)
            { diez = 10; }
            if (bloquehh4 == 11)
            { once = 11; }
            if (bloquehh4 == 12)
            { doce = 12; }
            if (bloquehh4 == 13)
            { trece = 13; }
            if (bloquehh4 == 14)
            { catorce = 14; }
            if (bloquehh4 == 15)
            { quince = 15; }
            if (bloquehh4 == 16)
            { diesiseis = 16; }
            if (bloquehh4 == 17)
            { diesisiete = 17; }
            if (bloquehh4 == 18)
            { diesiocho = 18; }
        }
        public void hora5()
        {
            if (bloquehh5 == 1)
            { uno = 1; }
            if (bloquehh5 == 2)
            { dos = 2; }
            if (bloquehh5 == 3)
            { tres = 3; }
            if (bloquehh5 == 4)
            { cuatro = 4; }
            if (bloquehh5 == 5)
            { cinco = 5; }
            if (bloquehh5 == 6)
            { seis = 6; }
            if (bloquehh5 == 7)
            { siete = 7; }
            if (bloquehh5 == 8)
            { ocho = 8; }
            if (bloquehh5 == 9)
            { nueve = 9; }
            if (bloquehh5 == 10)
            { diez = 10; }
            if (bloquehh5 == 11)
            { once = 11; }
            if (bloquehh5 == 12)
            { doce = 12; }
            if (bloquehh5 == 13)
            { trece = 13; }
            if (bloquehh5 == 14)
            { catorce = 14; }
            if (bloquehh5 == 15)
            { quince = 15; }
            if (bloquehh5 == 16)
            { diesiseis = 16; }
            if (bloquehh5 == 17)
            { diesisiete = 17; }
            if (bloquehh5 == 18)
            { diesiocho = 18; }
        }
        public void hora6()
        {
            if (bloquehh6 == 1)
            { uno = 1; }
            if (bloquehh6 == 2)
            { dos = 2; }
            if (bloquehh6 == 3)
            { tres = 3; }
            if (bloquehh6 == 4)
            { cuatro = 4; }
            if (bloquehh6 == 5)
            { cinco = 5; }
            if (bloquehh6 == 6)
            { seis = 6; }
            if (bloquehh6 == 7)
            { siete = 7; }
            if (bloquehh6 == 8)
            { ocho = 8; }
            if (bloquehh6 == 9)
            { nueve = 9; }
            if (bloquehh6 == 10)
            { diez = 10; }
            if (bloquehh6 == 11)
            { once = 11; }
            if (bloquehh6 == 12)
            { doce = 12; }
            if (bloquehh6 == 13)
            { trece = 13; }
            if (bloquehh6 == 14)
            { catorce = 14; }
            if (bloquehh6 == 15)
            { quince = 15; }
            if (bloquehh6 == 16)
            { diesiseis = 16; }
            if (bloquehh6 == 17)
            { diesisiete = 17; }
            if (bloquehh6 == 18)
            { diesiocho = 18; }
        }
        public void hora7()
        {
            if (bloquehh7 == 1)
            { uno = 1; }
            if (bloquehh7 == 2)
            { dos = 2; }
            if (bloquehh7 == 3)
            { tres = 3; }
            if (bloquehh7 == 4)
            { cuatro = 4; }
            if (bloquehh7 == 5)
            { cinco = 5; }
            if (bloquehh7 == 6)
            { seis = 6; }
            if (bloquehh7 == 7)
            { siete = 7; }
            if (bloquehh7 == 8)
            { ocho = 8; }
            if (bloquehh7 == 9)
            { nueve = 9; }
            if (bloquehh7 == 10)
            { diez = 10; }
            if (bloquehh7 == 11)
            { once = 11; }
            if (bloquehh7 == 12)
            { doce = 12; }
            if (bloquehh7 == 13)
            { trece = 13; }
            if (bloquehh7 == 14)
            { catorce = 14; }
            if (bloquehh7 == 15)
            { quince = 15; }
            if (bloquehh7 == 16)
            { diesiseis = 16; }
            if (bloquehh7 == 17)
            { diesisiete = 17; }
            if (bloquehh7 == 18)
            { diesiocho = 18; }
        }
        public void hora8()
        {
            if (bloquehh8 == 1)
            { uno = 1; }
            if (bloquehh8 == 2)
            { dos = 2; }
            if (bloquehh8 == 3)
            { tres = 3; }
            if (bloquehh8 == 4)
            { cuatro = 4; }
            if (bloquehh8 == 5)
            { cinco = 5; }
            if (bloquehh8 == 6)
            { seis = 6; }
            if (bloquehh8 == 7)
            { siete = 7; }
            if (bloquehh8 == 8)
            { ocho = 8; }
            if (bloquehh8 == 9)
            { nueve = 9; }
            if (bloquehh8 == 10)
            { diez = 10; }
            if (bloquehh8 == 11)
            { once = 11; }
            if (bloquehh8 == 12)
            { doce = 12; }
            if (bloquehh8 == 13)
            { trece = 13; }
            if (bloquehh8 == 14)
            { catorce = 14; }
            if (bloquehh8 == 15)
            { quince = 15; }
            if (bloquehh8 == 16)
            { diesiseis = 16; }
            if (bloquehh8 == 17)
            { diesisiete = 17; }
            if (bloquehh8 == 18)
            { diesiocho = 18; }
        }
        public void hora9()
        {
            if (bloquehh9 == 1)
            { uno = 1; }
            if (bloquehh9 == 2)
            { dos = 2; }
            if (bloquehh9 == 3)
            { tres = 3; }
            if (bloquehh9 == 4)
            { cuatro = 4; }
            if (bloquehh9 == 5)
            { cinco = 5; }
            if (bloquehh9 == 6)
            { seis = 6; }
            if (bloquehh9 == 7)
            { siete = 7; }
            if (bloquehh9 == 8)
            { ocho = 8; }
            if (bloquehh9 == 9)
            { nueve = 9; }
            if (bloquehh9 == 10)
            { diez = 10; }
            if (bloquehh9 == 11)
            { once = 11; }
            if (bloquehh9 == 12)
            { doce = 12; }
            if (bloquehh9 == 13)
            { trece = 13; }
            if (bloquehh9 == 14)
            { catorce = 14; }
            if (bloquehh9 == 15)
            { quince = 15; }
            if (bloquehh9 == 16)
            { diesiseis = 16; }
            if (bloquehh9 == 17)
            { diesisiete = 17; }
            if (bloquehh9 == 18)
            { diesiocho = 18; }
        }
        public void hora10()
        {
            if (bloquehh10 == 1)
            { uno = 1; }
            if (bloquehh10 == 2)
            { dos = 2; }
            if (bloquehh10 == 3)
            { tres = 3; }
            if (bloquehh10 == 4)
            { cuatro = 4; }
            if (bloquehh10 == 5)
            { cinco = 5; }
            if (bloquehh10 == 6)
            { seis = 6; }
            if (bloquehh10 == 7)
            { siete = 7; }
            if (bloquehh10 == 8)
            { ocho = 8; }
            if (bloquehh10 == 9)
            { nueve = 9; }
            if (bloquehh10 == 10)
            { diez = 10; }
            if (bloquehh10 == 11)
            { once = 11; }
            if (bloquehh10 == 12)
            { doce = 12; }
            if (bloquehh10 == 13)
            { trece = 13; }
            if (bloquehh10 == 14)
            { catorce = 14; }
            if (bloquehh10 == 15)
            { quince = 15; }
            if (bloquehh10 == 16)
            { diesiseis = 16; }
            if (bloquehh10 == 17)
            { diesisiete = 17; }
            if (bloquehh10 == 18)
            { diesiocho = 18; }
        }
        public void hora11()
        {
            if (bloquehh11 == 1)
            { uno = 1; }
            if (bloquehh11 == 2)
            { dos = 2; }
            if (bloquehh11 == 3)
            { tres = 3; }
            if (bloquehh11 == 4)
            { cuatro = 4; }
            if (bloquehh11 == 5)
            { cinco = 5; }
            if (bloquehh11 == 6)
            { seis = 6; }
            if (bloquehh11 == 7)
            { siete = 7; }
            if (bloquehh11 == 8)
            { ocho = 8; }
            if (bloquehh11 == 9)
            { nueve = 9; }
            if (bloquehh11 == 10)
            { diez = 10; }
            if (bloquehh11 == 11)
            { once = 11; }
            if (bloquehh11 == 12)
            { doce = 12; }
            if (bloquehh11 == 13)
            { trece = 13; }
            if (bloquehh11 == 14)
            { catorce = 14; }
            if (bloquehh11 == 15)
            { quince = 15; }
            if (bloquehh11 == 16)
            { diesiseis = 16; }
            if (bloquehh11 == 17)
            { diesisiete = 17; }
            if (bloquehh11 == 18)
            { diesiocho = 18; }
        }
        public void hora12()
        {
            if (bloquehh12 == 1)
            { uno = 1; }
            if (bloquehh12 == 2)
            { dos = 2; }
            if (bloquehh12 == 3)
            { tres = 3; }
            if (bloquehh12 == 4)
            { cuatro = 4; }
            if (bloquehh12 == 5)
            { cinco = 5; }
            if (bloquehh12 == 6)
            { seis = 6; }
            if (bloquehh12 == 7)
            { siete = 7; }
            if (bloquehh12 == 8)
            { ocho = 8; }
            if (bloquehh12 == 9)
            { nueve = 9; }
            if (bloquehh12 == 10)
            { diez = 10; }
            if (bloquehh12 == 11)
            { once = 11; }
            if (bloquehh12 == 12)
            { doce = 12; }
            if (bloquehh12 == 13)
            { trece = 13; }
            if (bloquehh12 == 14)
            { catorce = 14; }
            if (bloquehh12 == 15)
            { quince = 15; }
            if (bloquehh12 == 16)
            { diesiseis = 16; }
            if (bloquehh12 == 17)
            { diesisiete = 17; }
            if (bloquehh12 == 18)
            { diesiocho = 18; }
        }
        public void hora13()
        {
            if (bloquehh13 == 1)
            { uno = 1; }
            if (bloquehh13 == 2)
            { dos = 2; }
            if (bloquehh13 == 3)
            { tres = 3; }
            if (bloquehh13 == 4)
            { cuatro = 4; }
            if (bloquehh13 == 5)
            { cinco = 5; }
            if (bloquehh13 == 6)
            { seis = 6; }
            if (bloquehh13 == 7)
            { siete = 7; }
            if (bloquehh13 == 8)
            { ocho = 8; }
            if (bloquehh13 == 9)
            { nueve = 9; }
            if (bloquehh13 == 10)
            { diez = 10; }
            if (bloquehh13 == 11)
            { once = 11; }
            if (bloquehh13 == 12)
            { doce = 12; }
            if (bloquehh13 == 13)
            { trece = 13; }
            if (bloquehh13 == 14)
            { catorce = 14; }
            if (bloquehh13 == 15)
            { quince = 15; }
            if (bloquehh13 == 16)
            { diesiseis = 16; }
            if (bloquehh13 == 17)
            { diesisiete = 17; }
            if (bloquehh13 == 18)
            { diesiocho = 18; }
        }
        public void hora14()
        {
            if (bloquehh14 == 1)
            { uno = 1; }
            if (bloquehh14 == 2)
            { dos = 2; }
            if (bloquehh14 == 3)
            { tres = 3; }
            if (bloquehh14 == 4)
            { cuatro = 4; }
            if (bloquehh14 == 5)
            { cinco = 5; }
            if (bloquehh14 == 6)
            { seis = 6; }
            if (bloquehh14 == 7)
            { siete = 7; }
            if (bloquehh14 == 8)
            { ocho = 8; }
            if (bloquehh14 == 9)
            { nueve = 9; }
            if (bloquehh14 == 10)
            { diez = 10; }
            if (bloquehh14 == 11)
            { once = 11; }
            if (bloquehh14 == 12)
            { doce = 12; }
            if (bloquehh14 == 13)
            { trece = 13; }
            if (bloquehh14 == 14)
            { catorce = 14; }
            if (bloquehh14 == 15)
            { quince = 15; }
            if (bloquehh14 == 16)
            { diesiseis = 16; }
            if (bloquehh14 == 17)
            { diesisiete = 17; }
            if (bloquehh14 == 18)
            { diesiocho = 18; }
        }
        public void hora15()
        {
            if (bloquehh15 == 1)
            { uno = 1; }
            if (bloquehh15 == 2)
            { dos = 2; }
            if (bloquehh15 == 3)
            { tres = 3; }
            if (bloquehh15 == 4)
            { cuatro = 4; }
            if (bloquehh15 == 5)
            { cinco = 5; }
            if (bloquehh15 == 6)
            { seis = 6; }
            if (bloquehh15 == 7)
            { siete = 7; }
            if (bloquehh15 == 8)
            { ocho = 8; }
            if (bloquehh15 == 9)
            { nueve = 9; }
            if (bloquehh15 == 10)
            { diez = 10; }
            if (bloquehh15 == 11)
            { once = 11; }
            if (bloquehh15 == 12)
            { doce = 12; }
            if (bloquehh15 == 13)
            { trece = 13; }
            if (bloquehh15 == 14)
            { catorce = 14; }
            if (bloquehh15 == 15)
            { quince = 15; }
            if (bloquehh15 == 16)
            { diesiseis = 16; }
            if (bloquehh15 == 17)
            { diesisiete = 17; }
            if (bloquehh15 == 18)
            { diesiocho = 18; }
        }
        public void hora16()
        {
            if (bloquehh16 == 1)
            { uno = 1; }
            if (bloquehh16 == 2)
            { dos = 2; }
            if (bloquehh16 == 3)
            { tres = 3; }
            if (bloquehh16 == 4)
            { cuatro = 4; }
            if (bloquehh16 == 5)
            { cinco = 5; }
            if (bloquehh16 == 6)
            { seis = 6; }
            if (bloquehh16 == 7)
            { siete = 7; }
            if (bloquehh16 == 8)
            { ocho = 8; }
            if (bloquehh16 == 9)
            { nueve = 9; }
            if (bloquehh16 == 10)
            { diez = 10; }
            if (bloquehh16 == 11)
            { once = 11; }
            if (bloquehh16 == 12)
            { doce = 12; }
            if (bloquehh16 == 13)
            { trece = 13; }
            if (bloquehh16 == 14)
            { catorce = 14; }
            if (bloquehh16 == 15)
            { quince = 15; }
            if (bloquehh16 == 16)
            { diesiseis = 16; }
            if (bloquehh16 == 17)
            { diesisiete = 17; }
            if (bloquehh16 == 18)
            { diesiocho = 18; }
        }
        public void hora17()
        {
            if (bloquehh17 == 1)
            { uno = 1; }
            if (bloquehh17== 2)
            { dos = 2; }
            if (bloquehh17 == 3)
            { tres = 3; }
            if (bloquehh17 == 4)
            { cuatro = 4; }
            if (bloquehh17 == 5)
            { cinco = 5; }
            if (bloquehh17 == 6)
            { seis = 6; }
            if (bloquehh17 == 7)
            { siete = 7; }
            if (bloquehh17 == 8)
            { ocho = 8; }
            if (bloquehh17 == 9)
            { nueve = 9; }
            if (bloquehh17 == 10)
            { diez = 10; }
            if (bloquehh17 == 11)
            { once = 11; }
            if (bloquehh17 == 12)
            { doce = 12; }
            if (bloquehh17 == 13)
            { trece = 13; }
            if (bloquehh17 == 14)
            { catorce = 14; }
            if (bloquehh17 == 15)
            { quince = 15; }
            if (bloquehh17 == 16)
            { diesiseis = 16; }
            if (bloquehh17 == 17)
            { diesisiete = 17; }
            if (bloquehh17 == 18)
            { diesiocho = 18; }
        }
        public void hora18()
        {
            if (bloquehh18 == 1)
            { uno = 1; }
            if (bloquehh18 == 2)
            { dos = 2; }
            if (bloquehh18 == 3)
            { tres = 3; }
            if (bloquehh18 == 4)
            { cuatro = 4; }
            if (bloquehh18 == 5)
            { cinco = 5; }
            if (bloquehh18 == 6)
            { seis = 6; }
            if (bloquehh18 == 7)
            { siete = 7; }
            if (bloquehh18 == 8)
            { ocho = 8; }
            if (bloquehh18 == 9)
            { nueve = 9; }
            if (bloquehh18 == 10)
            { diez = 10; }
            if (bloquehh18 == 11)
            { once = 11; }
            if (bloquehh18 == 12)
            { doce = 12; }
            if (bloquehh18 == 13)
            { trece = 13; }
            if (bloquehh18 == 14)
            { catorce = 14; }
            if (bloquehh18 == 15)
            { quince = 15; }
            if (bloquehh18 == 16)
            { diesiseis = 16; }
            if (bloquehh18 == 17)
            { diesisiete = 17; }
            if (bloquehh18 == 18)
            { diesiocho = 18; }
        }

    }
}
