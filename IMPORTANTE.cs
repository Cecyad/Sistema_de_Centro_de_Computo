using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FCEATCC
{
    public partial class IMPORTANTE : Form
    {
        Conexion cone = new Conexion();
        Clsusuario usuario = new Clsusuario();
        Clsfacultad facultad = new Clsfacultad();
        public string dir;
        public string gen;

        public IMPORTANTE()
        {
            InitializeComponent();
        }

        private void IMPORTANTE_Load(object sender, EventArgs e)
        {
            txtgeneracion.Focus();
        }

        private void BTNCANCELAR_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BTNOK_Click(object sender, EventArgs e)
        {

            if (txtgeneracion.TextLength != 0)
            {
                BTNOK.Cursor = Cursors.WaitCursor;
                string generacion = txtgeneracion.Text;
                facultad._generacion = generacion;
                facultad.grabargeneracion();
                usuario._gen = generacion;
                gen = usuario.traergeneracion();

                try
                {
                    string file_name = string.Empty;

                    OpenFileDialog openFileDialog1 = new OpenFileDialog();

                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        dir = @openFileDialog1.FileName;
                    }
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
                            usuario._grado = "1";
                            usuario._grupo = fila["GRUPO"].ToString();
                            usuario._cvecarrera = fila["CVE"].ToString();
                            usuario._Turno = fila["TURNO"].ToString();
                            usuario._carrera = fila["LICENCIATURA"].ToString();
                            usuario._tusuario = "2";
                            usuario._cvegeneracion = gen;

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

                }
                catch (Exception)
                { MessageBox.Show("Falló la conexión con Excel."); }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Escriba la generación");
                txtgeneracion.Focus();
            }
            BTNOK.Cursor = Cursors.Default;
        }

        private void btnagregarexc_Click(object sender, EventArgs e)
        {

        }

        private void txtgeneracion_KeyPress(object sender, KeyPressEventArgs e)
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
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (txtgeneracion.TextLength != 0)
            {
                DialogResult buttton = MessageBox.Show("Esta seguro que desea elimnar la generación " + txtgeneracion.Text, "Eliminar Generación", MessageBoxButtons.OKCancel);
                if (buttton == DialogResult.OK)
                {
                    btneliminar.Cursor = Cursors.WaitCursor;
                    string gene = txtgeneracion.Text;
                    usuario._gen = gene;
                    string gener = usuario.traergeneracion();
                    facultad._generacion = gener;
                    facultad.eliminarporgeneracion();
                    facultad.eliminargen();
                }

            }
            else
            {
                MessageBox.Show("Escriba la generación");
                txtgeneracion.Focus();
            }
                
            btneliminar.Cursor = Cursors.Default;
            this.Hide();
        }
    }
    
}
