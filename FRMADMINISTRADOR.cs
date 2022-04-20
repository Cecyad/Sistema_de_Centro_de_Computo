using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCEATCC
{
    public partial class FRMADMINISTRADOR : Form
    {

        Clsusuario usuario = new Clsusuario();
        public string dir;
        Clsfacultad facultad = new Clsfacultad();
        
        public FRMADMINISTRADOR()
        {
            InitializeComponent();
        }

        private void reloj_Load(object sender, EventArgs e)
        {

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmenu MENU = new Frmenu();
            MENU.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frmususis sis = new Frmususis();
            sis.ShowDialog();
        }

        private void btnestados_Click(object sender, EventArgs e)
        {
            Frmestado est = new Frmestado();
            est.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BTNAGREGAR.Cursor = Cursors.WaitCursor;
            MessageBox.Show("Asegurese de tener abierta la hoja de Excel.                                         " +
                "Asegurese de que solo contenga una hoja y su nombre sea: Hoja1          " +
                "La primera columna de la hoja de calculo debe decir: ID, " +
                "La segunda: NOMBRE, "+
                "La tercera: CVE, " +
                "La cuarta: LICENCIATURA, " +
                "La quinta: GRADO, La sesta: GRUPO, " +
                "La septima: TURNO(NOTA: 1 = Matutino, " +
                "2 = Vespertino, 3 = Nocturno)");

            string file_name = string.Empty;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dir = @openFileDialog1.FileName;
            }
            BTNAGREGAR.Cursor = Cursors.WaitCursor;
            String sConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + dir + ";" + "Extended Properties=Excel 8.0;";

            

            OleDbConnection objConn = new OleDbConnection(sConnectionString);

            objConn.Open();

            OleDbCommand objCmdSelect = new OleDbCommand("SELECT * FROM [Hoja1$]", objConn);

            OleDbDataAdapter objAdapter1 = new OleDbDataAdapter();

            objAdapter1.SelectCommand = objCmdSelect;

            DataSet objDataset1 = new DataSet();

            objAdapter1.Fill(objDataset1);

            objConn.Close();

            foreach (DataRow fila in objDataset1.Tables[0].Rows)
            {
                string comp = fila["ID"].ToString();
                if (comp.Length > 1)
                {

                    usuario._idusuario = fila["ID"].ToString();
                    usuario._nombre = fila["NOMBRE"].ToString();
                    usuario._grado = fila["GRADO"].ToString();
                    usuario._grupo = fila["GRUPO"].ToString();
                    usuario._cvecarrera = fila["CVE"].ToString();
                    usuario._carrera = fila["LICENCIATURA"].ToString();
                    usuario._Turno = fila["TURNO"].ToString();
                    usuario._tusuario = "2";

                    if (usuario._cvecarrera == "14")
                    {

                        if (usuario._grado == "5")
                        { usuario._generacion = "2014-2019"; }
                        if (usuario._grado == "4")
                        { usuario._generacion = "2015-2019"; }
                        if (usuario._grado == "3")
                        { usuario._generacion = "2016-2020"; }
                        if (usuario._grado == "2")
                        { usuario._generacion = "2017-2021"; }
                        if (usuario._grado == "1")
                        { usuario._generacion = "2018-2022"; }


                        string gen = usuario.buscaduplicadosgen();
                        if (gen != "")
                        { }
                        else
                        {
                            usuario.grabargeneracion();
                        }
                    }
                    if (usuario._cvecarrera != "14")
                    {
                        if (usuario._grado == "5")
                        { usuario._generacion = "2014-2019"; }
                        if (usuario._grado == "4")
                        { usuario._generacion = "2015-2020"; }
                        if (usuario._grado == "3")
                        { usuario._generacion = "2016-2021"; }
                        if (usuario._grado == "2")
                        { usuario._generacion = "2017-2022"; }
                        if (usuario._grado == "1")
                        { usuario._generacion = "2018-2023"; }

                        string gen = usuario.buscaduplicadosgen();
                        if (gen != "")
                        { }
                        else
                        {
                            usuario.grabargeneracion();
                        }
                        usuario._cvegeneracion = gen;
                    }
                    usuario.grabar();

                    string carrera = usuario.buscaduplicadoscarrera();
                    if (carrera != "")
                    { }
                    else
                    {
                        usuario.grabarcarrera();
                    }

                    string dup = usuario.buscaduplicadosgrupo();
                    if (dup != "")
                    {
                    }
                    else
                    {
                        usuario.grabargrupo();
                    }
                }
            }

            BTNAGREGAR.Cursor = Cursors.Default;
        }

        private void btnmaquina_Click(object sender, EventArgs e)
        {
            btnmaquina.Cursor = Cursors.WaitCursor;

            MessageBox.Show("Asegurese de tener abierta la hoja de Excel.                                         " +
                "Asegurese de que solo contenga una hoja y su nombre sea: Hoja1          " +
                "La primera columna de la hoja de calculo debe decir: Numero : " +
                "La segunda: Descripcion ");

            string file_name = string.Empty;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dir = @openFileDialog1.FileName;
            }

            btnmaquina.Cursor = Cursors.WaitCursor;
            String sConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + dir + ";" + "Extended Properties=Excel 8.0;";

            
            OleDbConnection objConn = new OleDbConnection(sConnectionString);

            objConn.Open();

            OleDbCommand objCmdSelect = new OleDbCommand("SELECT * FROM [Hoja1$]", objConn);

            OleDbDataAdapter objAdapter1 = new OleDbDataAdapter();

            objAdapter1.SelectCommand = objCmdSelect;

            DataSet objDataset1 = new DataSet();

            objAdapter1.Fill(objDataset1);

            objConn.Close();

            foreach (DataRow fila in objDataset1.Tables[0].Rows)
            {    
                facultad._nmaquina = fila["Numero"].ToString();
                facultad._descripcionmaq = fila["Descripcion"].ToString();
                facultad._cveestado = "1";
                facultad._idusuario = "";
                facultad.grabarmaquina();
                
            }

           btnmaquina.Cursor = Cursors.Default;
            MessageBox.Show("Registro exitoso");
        }

        private void BTNTUSU_Click(object sender, EventArgs e)
        {
            Frmtusuario sis = new Frmtusuario();
            sis.ShowDialog();
        }
    }
}
