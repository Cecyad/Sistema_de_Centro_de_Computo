using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace FCEATCC
{
    public partial class Frmessage : Form
    {
        Conexion cone = new Conexion();
        Clsusuario usuario = new Clsusuario();
        public string dir;
        public string gen;
        public Frmessage()
        {
            InitializeComponent();
        }

        private void BTNOK_Click(object sender, EventArgs e)
        {
           

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

                    usuario._nempleado = fila["Nempleado"].ToString();
                    usuario._nombre = fila["Nombre"].ToString();
                    usuario._cvetusu = "1";
                    usuario.grabaracademicos();


                }

            }
            catch (Exception)
            { MessageBox.Show("Falló la conexión con Excel."); }
            this.Hide();
        }

        private void BTNCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
