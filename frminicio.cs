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
    public partial class frminicio : Form
    {
        Conexion conexion = new Conexion();

        public frminicio()
        {
            InitializeComponent();
        }

        private void frminicio_Load(object sender, EventArgs e)
        {
            conexion.conectar2();
            if (conexion.con.State == ConnectionState.Open)
            {
                if (Conexion.pantalla == "1")
                {
                    Frmres re = new Frmres();
                    re.ShowDialog();
                }
                else
                {
                    Frmresmaestros frm = new Frmresmaestros();
                    frm.Show();

                    Frmres res = new Frmres();
                    res.ShowDialog();
                }

                this.Close();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
