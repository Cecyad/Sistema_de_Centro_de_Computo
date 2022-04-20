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
    public partial class frmreservacionxmaestro : Form
    {
        Clsfacultad facultad = new Clsfacultad();
        public string x; //id del usuario
        public DataTable BLOQUE = new DataTable();
        Clsreservacion reservar = new Clsreservacion();


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

        public frmreservacionxmaestro()
        {
            InitializeComponent();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

            txtidmaestro.Text = "";
            cmbcarrera.Text = "";
            cmbgrupo.Text = "";
            cmbhora.Text = "";
            dtmfecha.Text = DateTime.Now.ToShortDateString();
            cmbgrupo.Visible = false;
            lblgrupo.Visible = false;


            txtidmaestro.Enabled = true;
            toolStripButton2.Text = "Grabar";
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult buttton = MessageBox.Show("Esta seguro que desea elimnar la reservación: " + txtidmaestro.Text, "Eliminar Reservación", MessageBoxButtons.OKCancel);
            if (buttton == DialogResult.OK)
            {
                facultad._idmaestro = txtidmaestro.Text;
                facultad._fechares = dtmfecha.Value.ToString("yyyy-MM-dd");
                facultad._nbloque = cmbhora.SelectedValue.ToString();


                facultad.eliminaresmaestro();
                VISIBLE();

            }

            facultad._idmaestro = x;
            facultad.llenargridreservarm2(dgvreservar);



            txtidmaestro.Text = "";
            cmbcarrera.Visible = true;
            lblcarrera.Visible = true;
            cmbcarrera.Text = "";
            cmbgrupo.Text = "";
            cmbhora.Text = "";


            toolStripButton2.Text = "Grabar";
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;

            txtidmaestro.Enabled = false;
            cmbcarrera.Enabled = false;
            cmbgrupo.Enabled = false;
            cmbhora.Enabled = false;

            cmbgrupo.Visible = false;
            lblgrupo.Visible = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripButton2.Enabled = true;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = true;
            txtidmaestro.Enabled = false;
            cmbhora.Enabled = true;
            cmbgrupo.Enabled = true;
            cmbcarrera.Enabled = true;
            txtidmaestro.Text = x;
            cmbgrupo.Visible = false;
            lblgrupo.Visible = false;
            cmbcarrera.Visible = true;
            lblcarrera.Visible = true;


            facultad.cargarcarrera(cmbcarrera);
            cmbcarrera.Text = "";

            facultad.cargarbloque(cmbhora);
            cmbhora.Text = "";

            toolStripButton2.Text = "Grabar";
            txtidmaestro.Focus();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            if (txtidmaestro.Text.Length != 0 && cmbhora.Text.Length != 0 && cmbgrupo.Visible == true)
            {
                    try
                    {
                        facultad._idmaestro = x;
                        facultad._fechares = dtmfecha.Value.ToString("yyyy-MM-dd");
                        facultad._grupo = cmbgrupo.SelectedValue.ToString();
                        facultad._nbloque = cmbhora.SelectedValue.ToString();
                        //facultad._cc = "1";

                        facultad._estado = "RESERVADA";
                        string estado = facultad.buscarcvestadoconombre();

                        facultad._cveestado = estado;

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("LOS CAMPOS DEL FORMULARIO NO SON VALIDOS");
                    }

                    try
                    {
                        string dup = facultad.buscaduplicadosr();

                        if (toolStripButton2.Text == "Grabar")
                        {


                            if (dup != "")
                            {
                                MessageBox.Show("La fecha y hora ya ha sido reservada.");

                            }
                            else
                            {
                                facultad.grabarreservacionmaestro2();
                                VISIBLE();

                            }

                        }
                        else
                        {
                            if (dup != "")
                            {
                                MessageBox.Show("La fecha y hora ya ha sido reservada.");

                            }
                            else
                            {
                                facultad.actualizarreservacionmaestro();
                                VISIBLE();

                                toolStripButton2.Text = "Grabar";
                                toolStripButton2.Enabled = false;
                                toolStripButton3.Enabled = false;
                                toolStripButton4.Enabled = false;

                                txtidmaestro.Enabled = false;
                                cmbcarrera.Enabled = false;
                                cmbgrupo.Enabled = false;
                                cmbhora.Enabled = false;
                            }
                        }
                    }
                    catch (Exception)
                    {
                       MessageBox.Show("LA RESERVACIÓN YA SE ENCUENTRA O NO ES VALIDA");
                    }

                facultad._idmaestro = txtidmaestro.Text;
                facultad.llenargridreservarm2(dgvreservar);
                txtidmaestro.Text = "";
                cmbhora.Text = "";
                cmbgrupo.Text = "";
                cmbcarrera.Text = "";
                lblgrupo.Visible = false;
                cmbgrupo.Visible = false;

                toolStripButton2.Enabled = false;
                toolStripButton3.Enabled = false;
                toolStripButton4.Enabled = false;
                txtidmaestro.Enabled = false;
                cmbcarrera.Enabled = false;
                cmbgrupo.Enabled = false;
                cmbhora.Enabled = false;
            }
            else
            {
                MessageBox.Show("ESCRIBA DATOS EN LOS CAMPOS");
            }
        }

        private void cmbcarrera_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblgrupo.Visible = true;
            cmbgrupo.Visible = true;

            facultad._cvecarrera = cmbcarrera.SelectedValue.ToString();
            facultad.cargargrupo(cmbgrupo);
            cmbgrupo.Text = "";
        }
        public void VISIBLE()
        {
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
            panel.Visible = true;
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

        private void frmreservacionxmaestro_Load(object sender, EventArgs e)
        {
            VISIBLE();
            txtidmaestro.Text = x;
            cmbcarrera.Visible = true;
            lblcarrera.Visible = true;
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
            txtidmaestro.Enabled = false;
            cmbcarrera.Enabled = false;
            cmbgrupo.Enabled = false;
            cmbhora.Enabled = false;
            dtmfecha.Value = DateTime.Now;

            facultad.cargarcarrera(cmbcarrera);
            cmbcarrera.Text = "";

            facultad.cargarbloque(cmbhora);
            cmbhora.Text = "";

            facultad._idmaestro = txtidmaestro.Text;
            facultad.llenargridreservarm2(dgvreservar);

            dgvreservar.Columns[0].HeaderText = "Maestro";
            dgvreservar.Columns[1].HeaderText = "Fecha";
            dgvreservar.Columns[2].HeaderText = "Grupo";
            dgvreservar.Columns[3].HeaderText = "Reservacion";
            dgvreservar.Columns[6].HeaderText = "Registro";
            dgvreservar.Columns[4].Visible = false;
            dgvreservar.Columns[5].Visible = false;
            dgvreservar.Columns[6].Visible = false;
            dgvreservar.Columns[3].Visible = false;


            txtidmaestro.Focus();
        }

        private void dgvreservar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            toolStripButton2.Text = "Modificar";

            txtidmaestro.Text = dgvreservar.CurrentRow.Cells[0].Value.ToString();
            dtmfecha.Text = dgvreservar.CurrentRow.Cells[1].Value.ToString();

            cmbgrupo.Visible = true;
            lblgrupo.Visible = true;

            string grupo = dgvreservar.CurrentRow.Cells[2].Value.ToString();
            facultad._grupo = dgvreservar.CurrentRow.Cells[2].Value.ToString();
            facultad.cargargruporgrid(cmbgrupo);
            cmbgrupo.SelectedValue = grupo;

            cmbcarrera.Visible = false;
            lblcarrera.Visible = false;

            string hora = dgvreservar.CurrentRow.Cells[3].Value.ToString();
            facultad.cargarbloque(cmbhora);
            cmbhora.SelectedValue = hora;

            toolStripButton2.Enabled = true;
            toolStripButton3.Enabled = true;
            toolStripButton4.Enabled = true;
            txtidmaestro.Enabled = false;
            dtmfecha.Enabled = true;
            cmbgrupo.Enabled = false;
            cmbhora.Enabled = true;
        }
    }
}
