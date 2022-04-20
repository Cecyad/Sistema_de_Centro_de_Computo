using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;
using System.Globalization;


namespace FCEATCC
{
    public partial class Frmreports : Form
    {
        Clsfacultad facultad = new Clsfacultad();

        public int adm = 0;
        public int celda = 11;
        public int pria = 0;
        public int sega = 0;
        public int terca = 0;
        public int cuarta = 0;
        public int quinta = 0;
        public int prii = 0;
        public int segi = 0;
        public int terci = 0;
        public int cuarti = 0;
        public int quinti = 0;
        public int pric = 0;
        public int segc = 0;
        public int tercc = 0;
        public int cuartc = 0;
        public int quintc = 0;
        public int priin = 0;
        public int segin = 0;
        public int tercin = 0;
        public int cuartin = 0;
        public int quintin = 0;
        public int prid = 0;
        public int segd = 0;
        public int tercd = 0;
        public int cuartd = 0;
        public int quintd = 0;
        public string nombreMes;
        Clsreservacion reservacion = new Clsreservacion();

        public Frmreports()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Cursor.Current = Cursors.WaitCursor;
            

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            string c = System.Windows.Forms.Application.ExecutablePath.ToString();
            string ubicacion = c.Replace("FCEATCC.exe", "reportes");
            excel.Application.Workbooks.Add(@"" + ubicacion + "\\Formatoo.xlsx");

            
            System.Data.DataTable carrera = new System.Data.DataTable();
            carrera = reservacion.cargarcarrera();

            System.Data.DataTable idusu = new System.Data.DataTable();
            System.Data.DataTable infusu = new System.Data.DataTable();
            reservacion._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
            idusu = reservacion.Traeralumnosxdia();
            try
            {
                foreach (System.Data.DataRow fila in idusu.Rows)
                {

                    string idusuari = fila["idusuarios"].ToString();
                    if (idusuari.Length <= 5)
                    {
                        adm = adm + 1;
                    }
                    else
                    {

                        reservacion._idusuarios = idusuari;
                        System.Windows.Forms.TextBox cvecar = new System.Windows.Forms.TextBox();
                        System.Windows.Forms.TextBox grado = new System.Windows.Forms.TextBox();
                        reservacion.buscarid(cvecar, grado);

                        if (cvecar.Text == "")
                        {
                            adm = adm + 1;
                        }
                        if (cvecar.Text != "")
                        {
                            DataRow[] datos = carrera.Select("cvecarrera='" + cvecar.Text + "'");
                            DataRow drow = datos[0];
                            string car = drow["descripcion"].ToString();

                            if (car == "NEGOCIOS AGROTECNOLÓGICOS")
                            {
                                if (grado.Text == "1")
                                { pria = pria + 1; }
                                if (grado.Text == "2")
                                { sega = sega + 1; }
                                if (grado.Text == "3")
                                { terca = terca + 1; }
                                if (grado.Text == "4")
                                { cuarta = cuarta + 1; }
                                if (grado.Text == "5")
                                { quinta = quinta + 1; }
                            }
                            if (car == "NEGOCIOS INTERNACIONALES")
                            {
                                if (grado.Text == "1")
                                { prii = prii + 1; }
                                if (grado.Text == "2")
                                { segi = segi + 1; }
                                if (grado.Text == "3")
                                { terci = terci + 1; }
                                if (grado.Text == "4")
                                { cuarti = cuarti + 1; }
                                if (grado.Text == "5")
                                { quinti = quinti + 1; }
                            }
                            if (car == "CONTADURÍA PÚBLICA FISCAL")
                            {
                                if (grado.Text == "1")
                                { pric = pric + 1; }
                                if (grado.Text == "2")
                                { segc = segc + 1; }
                                if (grado.Text == "3")
                                { tercc = tercc + 1; }
                                if (grado.Text == "4")
                                { cuartc = cuartc + 1; }
                                if (grado.Text == "5")
                                { quintc = quintc + 1; }
                            }
                            if (car == "INFORMÁTICA")
                            {
                                if (grado.Text == "1")
                                { priin = priin + 1; }
                                if (grado.Text == "2")
                                { segin = segin + 1; }
                                if (grado.Text == "3")
                                { tercin = tercin + 1; }
                                if (grado.Text == "4")
                                { cuartin = cuartin + 1; }
                                if (grado.Text == "5")
                                { quintin = quintin + 1; }
                            }
                            if (car == "DISEÑO GRÁFICO EMPRESARIAL")
                            {
                                if (grado.Text == "1")
                                { prid = prid + 1; }
                                if (grado.Text == "2")
                                { segd = segd + 1; }
                                if (grado.Text == "3")
                                { tercd = tercd + 1; }
                                if (grado.Text == "4")
                                { cuartd = cuartd + 1; }
                                if (grado.Text == "5")
                                { quintd = quintd + 1; }
                            }
                        }
                    }

                    
                }

                excel.Cells[7, 7] = DateTime.Now.ToLongDateString();
                excel.Cells[10, 3] = pric;
                excel.Cells[10, 4] = pria;
                excel.Cells[10, 5] = prii;
                excel.Cells[10, 6] = priin;
                excel.Cells[10, 7] = prid;
                excel.Cells[11, 3] = segc;
                excel.Cells[11, 4] = sega;
                excel.Cells[11, 5] = segi;
                excel.Cells[11, 6] = segin;
                excel.Cells[11, 7] = segd;
                excel.Cells[12, 3] = tercc;
                excel.Cells[12, 4] = terca;
                excel.Cells[12, 5] = terci;
                excel.Cells[12, 6] = tercin;
                excel.Cells[12, 7] = tercd;
                excel.Cells[13, 3] = cuartc;
                excel.Cells[13, 4] = cuarta;
                excel.Cells[13, 5] = cuarti;
                excel.Cells[13, 6] = cuartin;
                excel.Cells[13, 7] = cuartd;
                excel.Cells[14, 3] = quintc;
                excel.Cells[14, 4] = quinta;
                excel.Cells[14, 5] = quinti;
                excel.Cells[14, 6] = quintin;
                excel.Cells[14, 7] = quintd;


                

                excel.Visible = true;
            }
            catch
            { }




            pria = 0;
            sega = 0;
            terca = 0;
            cuarta = 0;
            quinta = 0;
            prii = 0;
            segi = 0;
            terci = 0;
            cuarti = 0;
            quinti = 0;
            pric = 0;
            segc = 0;
            tercc = 0;
            cuartc = 0;
            quintc = 0;
            priin = 0;
            segin = 0;
            tercin = 0;
            cuartin = 0;
            quintin = 0;
            prid = 0;
            segd = 0;
            tercd = 0;
            cuartd = 0;
            quintd = 0;
            Cursor.Current = Cursors.Default;
        }
        private void Cerrar(object o)
        {
            try
            {
                while (System.Runtime.InteropServices.Marshal.ReleaseComObject(o) > 0) ;
            }
            catch { }
            finally
            {
                o = null;
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            string u = System.Windows.Forms.Application.ExecutablePath.ToString();
            string ubicacion = u.Replace("FCEATCC.exe", "reportes");
            excel.Application.Workbooks.Add(@"" + ubicacion + "\\Formato mes.xlsx");


            

            System.Data.DataTable carrera = new System.Data.DataTable();
            carrera = reservacion.cargarcarrera();

            System.Data.DataTable idusu = new System.Data.DataTable();
            System.Data.DataTable infusu = new System.Data.DataTable();
            System.Data.DataTable usuariosmes = new System.Data.DataTable();
            string mess = Convert.ToString(DateTime.Now.Month);
            if (mess.Length <= 1)
            {
                mess = "0" + mess;
            }
            int año = DateTime.Now.Year;
            int mes = DateTime.Now.Month;
            int numdiaa = DateTime.DaysInMonth(año, mes);
            string fechi = año + "-" + mess + "-" + "01";
            string fechaf = año + "-" + mess + "-" + numdiaa;
            reservacion._inicio = fechi;
            reservacion._fin = fechaf;
            idusu = reservacion.Traeralumnosxmes();
            string di = "01";
            int dii = 1;
            idusu.DefaultView.Sort = "fechar";
            int nrorows = idusu.Rows.Count;



            for (int i = 1; i <= idusu.Rows.Count; )
            {
                
                DataRow row = idusu.Rows[0];
                string carr = row["idusuarios"].ToString();
                string d = row["fechar"].ToString();
                string f = año + "-" + mess + "-" + di;
               
                if (d == f)
                {
                    if (carr.Length <= 5)
                    {
                        adm = adm + 1;
                    }
                    else
                    {
                        reservacion._idusuarios = carr;
                        System.Windows.Forms.TextBox cvecar = new System.Windows.Forms.TextBox();
                        System.Windows.Forms.TextBox grado = new System.Windows.Forms.TextBox();
                        reservacion.buscarid(cvecar, grado);

                        if (cvecar.Text == "")
                        {
                            adm = adm + 1;
                        }
                        if (cvecar.Text != "")
                        {
                            DataRow[] datos = carrera.Select("cvecarrera='" + cvecar.Text + "'");
                            DataRow drow = datos[0];
                            string des = drow["descripcion"].ToString();

                            if (des == "NEGOCIOS AGROTECNOLÓGICOS")
                            {
                                if (grado.Text == "1")
                                { pria = pria + 1; }
                                if (grado.Text == "2")
                                { sega = sega + 1; }
                                if (grado.Text == "3")
                                { terca = terca + 1; }
                                if (grado.Text == "4")
                                { cuarta = cuarta + 1; }
                                if (grado.Text == "5")
                                { quinta = quinta + 1; }
                            }
                            if (des == "NEGOCIOS INTERNACIONALES")
                            {
                                if (grado.Text == "1")
                                { prii = prii + 1; }
                                if (grado.Text == "2")
                                { segi = segi + 1; }
                                if (grado.Text == "3")
                                { terci = terci + 1; }
                                if (grado.Text == "4")
                                { cuarti = cuarti + 1; }
                                if (grado.Text == "5")
                                { quinti = quinti + 1; }
                            }
                            if (des == "CONTADURÍA PÚBLICA FISCAL")
                            {
                                if (grado.Text == "1")
                                { pric = pric + 1; }
                                if (grado.Text == "2")
                                { segc = segc + 1; }
                                if (grado.Text == "3")
                                { tercc = tercc + 1; }
                                if (grado.Text == "4")
                                { cuartc = cuartc + 1; }
                                if (grado.Text == "5")
                                { quintc = quintc + 1; }
                            }
                            if (des == "INFORMÁTICA")
                            {
                                if (grado.Text == "1")
                                { priin = priin + 1; }
                                if (grado.Text == "2")
                                { segin = segin + 1; }
                                if (grado.Text == "3")
                                { tercin = tercin + 1; }
                                if (grado.Text == "4")
                                { cuartin = cuartin + 1; }
                                if (grado.Text == "5")
                                { quintin = quintin + 1; }
                            }
                            if (des == "DISEÑO GRÁFICO EMPRESARIAL")
                            {
                                if (grado.Text == "1")
                                { prid = prid + 1; }
                                if (grado.Text == "2")
                                { segd = segd + 1; }
                                if (grado.Text == "3")
                                { tercd = tercd + 1; }
                                if (grado.Text == "4")
                                { cuartd = cuartd + 1; }
                                if (grado.Text == "5")
                                { quintd = quintd + 1; }
                            }


                            excel.Cells[celda, 2] = pric;
                            excel.Cells[celda, 7] = pria;
                            excel.Cells[celda, 12] = prii;
                            excel.Cells[celda, 17] = priin;
                            excel.Cells[celda, 22] = prid;
                            excel.Cells[celda, 3] = segc;
                            excel.Cells[celda, 8] = sega;
                            excel.Cells[celda, 13] = segi;
                            excel.Cells[celda, 18] = segin;
                            excel.Cells[celda, 23] = segd;
                            excel.Cells[celda, 4] = tercc;
                            excel.Cells[celda, 9] = terca;
                            excel.Cells[celda, 14] = terci;
                            excel.Cells[celda, 19] = tercin;
                            excel.Cells[celda, 24] = tercd;
                            excel.Cells[celda, 5] = cuartc;
                            excel.Cells[celda, 10] = cuarta;
                            excel.Cells[celda, 15] = cuarti;
                            excel.Cells[celda, 20] = cuartin;
                            excel.Cells[celda, 25] = cuartd;
                            excel.Cells[celda, 6] = quintc;
                            excel.Cells[celda, 11] = quinta;
                            excel.Cells[celda, 16] = quinti;
                            excel.Cells[celda, 21] = quintin;
                            excel.Cells[celda, 26] = quintd;
                        }
                    }
                        idusu.Rows.Remove(row);
                    
                }
                else
                {
                    celda = celda + 1;
                    dii = dii + 1;
                    if (dii <= 9)
                    {
                        di = "0" + dii;
                    }
                    else
                    {
                        di = Convert.ToString(dii);
                    }
                    adm = 0;
                    pria = 0;
                    sega = 0;
                    terca = 0;
                    cuarta = 0;
                    quinta = 0;
                    prii = 0;
                    segi = 0;
                    terci = 0;
                    cuarti = 0;
                    quinti = 0;
                    pric = 0;
                    segc = 0;
                    tercc = 0;
                    cuartc = 0;
                    quintc = 0;
                    priin = 0;
                    segin = 0;
                    tercin = 0;
                    cuartin = 0;
                    quintin = 0;
                    prid = 0;
                    segd = 0;
                    tercd = 0;
                    cuartd = 0;
                    quintd = 0;
                    
                }
                
            }

            

                int c = DateTime.Now.Month;
                obtenerNombreMesNumero(c);
                int a = DateTime.Now.Year;
                int numdiam = DateTime.DaysInMonth(a, c);
                int nu = 11;
                int co = 1;
                for (int i =1; i<=numdiam; i++)
                {
                    excel.Cells[nu, co] = i;
                    nu = nu + 1;
                }

                excel.Cells[7, 21] ="de " + nombreMes;
                



                excel.Visible = true;
            

            pria = 0;
            sega = 0;
            terca = 0;
            cuarta = 0;
            quinta = 0;
            prii = 0;
            segi = 0;
            terci = 0;
            cuarti = 0;
            quinti = 0;
            pric = 0;
            segc = 0;
            tercc = 0;
            cuartc = 0;
            quintc = 0;
            priin = 0;
            segin = 0;
            tercin = 0;
            cuartin = 0;
            quintin = 0;
            prid = 0;
            segd = 0;
            tercd = 0;
            cuartd = 0;
            quintd = 0;
            Cursor.Current = Cursors.Default;
        }
        private string obtenerNombreMesNumero(int numeroMes)
        {
            try
            {
                DateTimeFormatInfo formatoFecha = CultureInfo.CurrentCulture.DateTimeFormat;
                nombreMes = formatoFecha.GetMonthName(numeroMes);
                return nombreMes;
            }
            catch
            {
                return "Desconocido";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (btngeneral.Visible == false)
            {
                btngeneral.Visible = true;
                btnfiltro.Visible = true;
            }
            else
            {
                btngeneral.Visible = false;
                btnfiltro.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

                string c = System.Windows.Forms.Application.ExecutablePath.ToString();
                string ubicacion = c.Replace("FCEATCC.exe", "reportes");
                excel.Application.Workbooks.Add(@"" + ubicacion + "\\informeacademicos.xlsx");

                System.Data.DataTable academicos = new System.Data.DataTable();
                academicos = reservacion.cargaracademicos();

                int f = 10;
                int cc = 2;
                int cn = 3;

                foreach (System.Data.DataRow fila in academicos.Rows)
                {
                    excel.Cells[f, cc] = fila["nempleado"].ToString();
                    excel.Cells[f, cn] = fila["nombre"].ToString();

                    f = f + 1;
                }

                excel.Visible = true;

            }
            catch
            { }
            Cursor.Current = Cursors.Default;
        }

        private void btninfcomp_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

                string c = System.Windows.Forms.Application.ExecutablePath.ToString();
                string ubicacion = c.Replace("FCEATCC.exe", "reportes");
                excel.Application.Workbooks.Add(@"" + ubicacion + "\\informemaquinas.xlsx");


                System.Data.DataTable academicos = new System.Data.DataTable();
                academicos = reservacion.cargarmaquinas();

                int f = 10;
                int cc = 2;
                int cn = 4;
                int ce = 7;

                foreach (System.Data.DataRow fila in academicos.Rows)
                {
                    excel.Cells[f, cc] = fila["maquina"].ToString();
                    excel.Cells[f, cn] = fila["descripcion"].ToString();
                    int es = Convert.ToInt32(fila["cvestado"].ToString());

                    if (es == 4)
                    {
                        excel.Cells[f, ce] = "Descompuesta";
                    }
                    else
                    {
                        excel.Cells[f, ce] = "Funcionando";
                    }


                    f = f + 1;
                }

                excel.Visible = true;

            }
            catch
            { }
            Cursor.Current = Cursors.Default;

        }

        private void btninffecha_Click(object sender, EventArgs e)
        {
            if (lblfecha1.Visible == false)
            {
                lblfecha1.Visible = true;
                lblfecha2.Visible = true;
                dtp1.Visible = true;
                dtp2.Visible = true;
                btnbuscar.Visible = true;
            }
            else
            {
                lblfecha1.Visible = false;
                lblfecha2.Visible = false;
                dtp1.Visible = false;
                dtp2.Visible = false;
                btnbuscar.Visible = false;
            }
            

            
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            lblfecha1.Visible = false;
            lblfecha2.Visible = false;
            dtp1.Visible = false;
            dtp2.Visible = false;
            btnbuscar.Visible = false;

            DateTime oldDate = dtp1.Value;
            DateTime newDate = dtp2.Value.AddDays(1);

            TimeSpan ts = newDate - oldDate;

            int diferenciadias = ts.Days;

            Cursor.Current = Cursors.WaitCursor;

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            string u = System.Windows.Forms.Application.ExecutablePath.ToString();
            string ubicacion = u.Replace("FCEATCC.exe", "reportes");
            excel.Application.Workbooks.Add(@"" + ubicacion + "\\Formato fecha.xlsx");

            System.Data.DataTable carrera = new System.Data.DataTable();
            carrera = reservacion.cargarcarrera();

            System.Data.DataTable idusu = new System.Data.DataTable();
            System.Data.DataTable infusu = new System.Data.DataTable();
            System.Data.DataTable usuariosmes = new System.Data.DataTable();


            int año = DateTime.Now.Year;
            int mes = DateTime.Now.Month;
            string mess = dtp1.Value.ToString("MM");
            if (mess.Length <= 1)
            {
                mess = "0" + mess;
            }

            reservacion._inicio = dtp1.Value.ToString("yyyy-MM-dd");
            reservacion._fin = dtp2.Value.ToString("yyyy-MM-dd");

            idusu = reservacion.Traeralumnosxmes();
            
            DateTime dii = dtp1.Value;
            string di = dtp1.Value.ToString("dd");
            idusu.DefaultView.Sort = "fechar";
            int nrorows = idusu.Rows.Count;
            celda = 11;



            for (int i = 1; i <= idusu.Rows.Count;)
            {

                DataRow row = idusu.Rows[0];
                string carr = row["idusuarios"].ToString();
                string d = row["fechar"].ToString();
                string f = año + "-" + mess + "-" + di;

                if (d == f)
                {
                    if (carr.Length <= 5)
                    {
                        adm = adm + 1;
                    }
                    else
                    {
                        reservacion._idusuarios = carr;
                        System.Windows.Forms.TextBox cvecar = new System.Windows.Forms.TextBox();
                        System.Windows.Forms.TextBox grado = new System.Windows.Forms.TextBox();
                        reservacion.buscarid(cvecar, grado);

                        if (cvecar.Text == "")
                        {
                            adm = adm + 1;
                        }
                        if (cvecar.Text != "")
                        {
                            DataRow[] datos = carrera.Select("CVECARRERA='" + cvecar.Text + "'");
                            DataRow drow = datos[0];
                            string des = drow["descripcion"].ToString();

                            if (des == "NEGOCIOS AGROTECNOLÓGICOS")
                            {
                                if (grado.Text == "1")
                                { pria = pria + 1; }
                                if (grado.Text == "2")
                                { sega = sega + 1; }
                                if (grado.Text == "3")
                                { terca = terca + 1; }
                                if (grado.Text == "4")
                                { cuarta = cuarta + 1; }
                                if (grado.Text == "5")
                                { quinta = quinta + 1; }
                            }
                            if (des == "NEGOCIOS INTERNACIONALES")
                            {
                                if (grado.Text == "1")
                                { prii = prii + 1; }
                                if (grado.Text == "2")
                                { segi = segi + 1; }
                                if (grado.Text == "3")
                                { terci = terci + 1; }
                                if (grado.Text == "4")
                                { cuarti = cuarti + 1; }
                                if (grado.Text == "5")
                                { quinti = quinti + 1; }
                            }
                            if (des == "CONTADURÍA PÚBLICA FISCAL")
                            {
                                if (grado.Text == "1")
                                { pric = pric + 1; }
                                if (grado.Text == "2")
                                { segc = segc + 1; }
                                if (grado.Text == "3")
                                { tercc = tercc + 1; }
                                if (grado.Text == "4")
                                { cuartc = cuartc + 1; }
                                if (grado.Text == "5")
                                { quintc = quintc + 1; }
                            }
                            if (des == "INFORMÁTICA")
                            {
                                if (grado.Text == "1")
                                { priin = priin + 1; }
                                if (grado.Text == "2")
                                { segin = segin + 1; }
                                if (grado.Text == "3")
                                { tercin = tercin + 1; }
                                if (grado.Text == "4")
                                { cuartin = cuartin + 1; }
                                if (grado.Text == "5")
                                { quintin = quintin + 1; }
                            }
                            if (des == "DISEÑO GRÁFICO EMPRESARIAL")
                            {
                                if (grado.Text == "1")
                                { prid = prid + 1; }
                                if (grado.Text == "2")
                                { segd = segd + 1; }
                                if (grado.Text == "3")
                                { tercd = tercd + 1; }
                                if (grado.Text == "4")
                                { cuartd = cuartd + 1; }
                                if (grado.Text == "5")
                                { quintd = quintd + 1; }
                            }


                            excel.Cells[celda, 2] = pric;
                            excel.Cells[celda, 7] = pria;
                            excel.Cells[celda, 12] = prii;
                            excel.Cells[celda, 17] = priin;
                            excel.Cells[celda, 22] = prid;
                            excel.Cells[celda, 3] = segc;
                            excel.Cells[celda, 8] = sega;
                            excel.Cells[celda, 13] = segi;
                            excel.Cells[celda, 18] = segin;
                            excel.Cells[celda, 23] = segd;
                            excel.Cells[celda, 4] = tercc;
                            excel.Cells[celda, 9] = terca;
                            excel.Cells[celda, 14] = terci;
                            excel.Cells[celda, 19] = tercin;
                            excel.Cells[celda, 24] = tercd;
                            excel.Cells[celda, 5] = cuartc;
                            excel.Cells[celda, 10] = cuarta;
                            excel.Cells[celda, 15] = cuarti;
                            excel.Cells[celda, 20] = cuartin;
                            excel.Cells[celda, 25] = cuartd;
                            excel.Cells[celda, 6] = quintc;
                            excel.Cells[celda, 11] = quinta;
                            excel.Cells[celda, 16] = quinti;
                            excel.Cells[celda, 21] = quintin;
                            excel.Cells[celda, 26] = quintd;
                        }
                    }
                    idusu.Rows.Remove(row);
                }
                else
                {
                    celda = celda + 1;
                    
                    dii = dii.AddDays(1);
                    di = dii.ToString("dd");
                    mess = dii.ToString("MM");

                    if (mess.Length <= 1)
                    {
                        mess = "0" + mess;
                    }

                    if (di.Length <= 1)
                    {
                        di = "0" + di;
                    }
                    adm = 0;
                    pria = 0;
                    sega = 0;
                    terca = 0;
                    cuarta = 0;
                    quinta = 0;
                    prii = 0;
                    segi = 0;
                    terci = 0;
                    cuarti = 0;
                    quinti = 0;
                    pric = 0;
                    segc = 0;
                    tercc = 0;
                    cuartc = 0;
                    quintc = 0;
                    priin = 0;
                    segin = 0;
                    tercin = 0;
                    cuartin = 0;
                    quintin = 0;
                    prid = 0;
                    segd = 0;
                    tercd = 0;
                    cuartd = 0;
                    quintd = 0;

                }

            }



            int c = Convert.ToInt32(dtp1.Value.ToString("MM"));
            int a = Convert.ToInt32(dtp1.Value.ToString("yyyy"));
            int numdiam = DateTime.DaysInMonth(a, c);
            int diaa= Convert.ToInt32(dtp1.Value.ToString("dd"));
            int nu = 11;
            int co = 1;
            string final;
            string rangoi;
            int contador = 1;
            for (int i = 1; i <= diferenciadias; i++)
            {
                if ((diaa == 30 && numdiam == 30) || (diaa == 31 && numdiam == 31) || (diaa == 28 && numdiam == 28) || (diaa == 29 && numdiam == 29))
                {
                    excel.Cells[nu, co] = diaa;
                   
                    excel.Cells[nu, co].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightBlue);
                    excel.Cells[nu, co].Font.Bold = true;
                    int lo = nu + 1;
                    
                    diaa = 1;
                    DateTime ol = dtp1.Value;
                    DateTime yer = ol.AddMonths(contador);
                    c = Convert.ToInt32(yer.ToString("MM"));
                    a = Convert.ToInt32(yer.ToString("yyyy"));

                    numdiam = DateTime.DaysInMonth(a, c);
                    nu = nu + 1;
                    contador = contador + 1;
                }
                else
                {
                    excel.Cells[nu, co] = diaa;
                    excel.Cells[nu, co].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightBlue);
                    excel.Cells[nu, co].Font.Bold = true;
                    diaa = diaa + 1;
                    nu = nu + 1;
                }
                if (diferenciadias == i)
                {
                    final = "z" + nu;

                    excel.Cells[nu, co] = "Total";
                    excel.Cells[nu, co].Font.Bold = true;
                    rangoi = "b" + nu;

                   


                    Microsoft.Office.Interop.Excel.Range Sum_Range = excel.get_Range("b"+nu+":z"+ nu);
                    Sum_Range.Formula = "=sum(b11:b" + (nu - 1).ToString() + ")";
                    Sum_Range.Font.Bold = true;

                    excel.Cells[nu, co].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightBlue);

                    excel.get_Range("b11", final).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.AliceBlue);
                    excel.get_Range("a11", final).Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
                    excel.get_Range("a11", final).Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
                    excel.get_Range("a11", final).Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
                    excel.get_Range("a11", final).Borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
                    excel.get_Range("a11", final).Borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
                    excel.get_Range("a11", final).Borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;

                }
                
            }

            excel.Cells[7, 21] = dtp1.Value.ToString("dd-MM-yyyy") + " al " + dtp2.Value.ToString("dd-MM-yyyy");




            excel.Visible = true;


            pria = 0;
            sega = 0;
            terca = 0;
            cuarta = 0;
            quinta = 0;
            prii = 0;
            segi = 0;
            terci = 0;
            cuarti = 0;
            quinti = 0;
            pric = 0;
            segc = 0;
            tercc = 0;
            cuartc = 0;
            quintc = 0;
            priin = 0;
            segin = 0;
            tercin = 0;
            cuartin = 0;
            quintin = 0;
            prid = 0;
            segd = 0;
            tercd = 0;
            cuartd = 0;
            quintd = 0;
            Cursor.Current = Cursors.Default;

            lblfecha1.Visible = false;
            lblfecha2.Visible = false;
            dtp1.Visible = false;
            dtp2.Visible = false;
        }

        private void btngeneral_Click(object sender, EventArgs e)
        {
            btngeneral.Visible = false;
            btnfiltro.Visible = false;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

                string c = System.Windows.Forms.Application.ExecutablePath.ToString();
                string ubicacion = c.Replace("FCEATCC.exe", "reportes");
                excel.Application.Workbooks.Add(@"" + ubicacion + "\\informealumnos.xlsx");

                System.Data.DataTable usuarios = new System.Data.DataTable();
                usuarios = reservacion.cargarusuariosss();

                int f = 10;
                int cc = 2;
                int cn = 3;

                foreach (System.Data.DataRow fila in usuarios.Rows)
                {
                    excel.Cells[f, cc] = fila["idusuario"].ToString();
                    excel.Cells[f, cn] = fila["nombre"].ToString();

                    f = f + 1;
                }

                excel.Visible = true;
            }
            catch
            { }

            Cursor.Current = Cursors.Default;
        }

        private void btnfiltro_Click(object sender, EventArgs e)
        {

            if (lblcarrera.Visible == false)
            {
                lblcarrera.Visible = true;
                cmbcarrera.Visible = true;
                lblgrado.Visible = true;
                cmbgrado.Visible = true;
                lblgrupo.Visible = true;
                cmbgrupo.Visible = true;
                btnbus.Visible = true;


                facultad.cargarcarrera(cmbcarrera);
                cmbcarrera.Text = "";
                cmbgrado.Text = "";
                cmbgrupo.Text = "";
            }
            else
            {
                lblcarrera.Visible = false;
                cmbcarrera.Visible = false;
                lblgrado.Visible = false;
                cmbgrado.Visible = false;
                lblgrupo.Visible = false;
                cmbgrupo.Visible = false;
                btnbus.Visible = false;
            }
        }

        private void cmbcarrera_SelectionChangeCommitted(object sender, EventArgs e)
        {
            facultad._cvecarrera = cmbcarrera.SelectedValue.ToString();
            facultad.cargargrado(cmbgrado);
            cmbgrado.Text = "";
        }

        private void btnbus_Click(object sender, EventArgs e)
        {
            

            Cursor.Current = Cursors.WaitCursor;
            //try
            //{
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

                string c = System.Windows.Forms.Application.ExecutablePath.ToString();
                string ubicacion = c.Replace("FCEATCC.exe", "reportes");
                excel.Application.Workbooks.Add(@"" + ubicacion + "\\informealumnos.xlsx");

                System.Data.DataTable usuarios = new System.Data.DataTable();
                if (cmbcarrera.Text != "" && cmbgrado.Text == "" && cmbgrupo.Text == "")
                {
                    facultad._cvecarrera = cmbcarrera.SelectedValue.ToString();
                    usuarios = facultad.cargausuacar();
                }
                if (cmbcarrera.Text != "" && cmbgrado.Text != "" && cmbgrupo.Text == "")
                {
                    facultad._cvecarrera = cmbcarrera.SelectedValue.ToString();
                    facultad._cvegrado = cmbgrado.SelectedValue.ToString();
                    usuarios = facultad.cargausua();
                }
                if (cmbcarrera.Text != "" && cmbgrado.Text != "" && cmbgrupo.Text != "")
                {
                    facultad._cvecarrera = cmbcarrera.SelectedValue.ToString();
                    facultad._cvegrado = cmbgrado.SelectedValue.ToString();
                    facultad._grupo = cmbgrupo.SelectedValue.ToString();
                    usuarios = facultad.cargarusuariosss();
                }
                

                int f = 10;
                int cc = 2;
                int cn = 3;

                foreach (System.Data.DataRow fila in usuarios.Rows)
                {
                    excel.Cells[f, cc] = fila["idusuario"].ToString();
                    excel.Cells[f, cn] = fila["nombre"].ToString();

                    f = f + 1;
                }

                string ca = cmbcarrera.Text;
                string gra = cmbgrado.Text;
                string gru = cmbgrupo.Text;

            if (cmbcarrera.Text != "" && cmbgrado.Text == "" && cmbgrupo.Text == "")
            { excel.Cells[8, 4] = "Carrera: " + ca;  }
            if (cmbcarrera.Text != "" && cmbgrado.Text != "" && cmbgrupo.Text == "")
            { excel.Cells[8, 4] = ca + "  " + gra + "Grado"; }
            if (cmbcarrera.Text != "" && cmbgrado.Text != "" && cmbgrupo.Text != "")
            { excel.Cells[8, 4] = ca + "  " + gra + "-" + gru;  }


            

                excel.Visible = true;
            //}
            //catch
            //{ }

            Cursor.Current = Cursors.Default;
            lblcarrera.Visible = false;
            cmbcarrera.Visible = false;
            lblgrado.Visible = false;
            cmbgrado.Visible = false;
            lblgrupo.Visible = false;
            cmbgrupo.Visible = false;
            btnbus.Visible = false;
            btngeneral.Visible = false;
            btnfiltro.Visible = false;
        }

        private void cmbgrado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            facultad._cvegrado = cmbgrado.SelectedValue.ToString();
            facultad.cargargrupoo(cmbgrupo);
            cmbgrupo.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            string u = System.Windows.Forms.Application.ExecutablePath.ToString();
            string ubicacion = u.Replace("FCEATCC.exe", "reportes");
            excel.Application.Workbooks.Add(@"" + ubicacion + "\\informenoliberados.xlsx");

            System.Data.DataTable estado = new System.Data.DataTable();
            System.Data.DataTable alum = new System.Data.DataTable();
            string estadosis;
            reservacion._estadou = "LIBERADA POR ADMINISTRADOR";
            estadosis = reservacion.traerestado();
            string estadoadm;
            reservacion._estadou = "LIBERADA POR SISTEMA";
            estadoadm = reservacion.traerestado();

            reservacion._estadmin = estadoadm;
            reservacion._estsis = estadosis;
            estado = reservacion.traerest();

            int f = 10;
            int cc = 1;
            int cn = 3;
            int cu = 6;
            int ca = 2;
            int gra = 7;
            int gru = 8;
            int car = 9;

            foreach (System.Data.DataRow fila in estado.Rows)
            {
                string idusuari = fila["idusuarios"].ToString();
                if (idusuari.Length <= 5)
                {
                }
                else
                {
                    reservacion._alumno = fila["idusuarios"].ToString();
                    alum = reservacion.traeralumno();
                    foreach (System.Data.DataRow fill in alum.Rows)
                    {
                        excel.Cells[f, cn] = fill["nombre"].ToString();
                        if (fill["nombre"].ToString() != "")
                        {
                            excel.Cells[f, gra] = fill["grado"].ToString();
                            excel.Cells[f, gru] = fill["grupo"].ToString();
                            reservacion._cvecarrera = fill["cvecarrera"].ToString();
                            string c = reservacion.buscarcarrer();
                            excel.Cells[f, car] = c;

                            excel.Cells[f, cc] = fila["idusuarios"].ToString();
                            excel.Cells[f, ca] = fila["nmaquina"].ToString();
                            excel.Cells[f, cu] = fila["fechar"].ToString();
                        }
                        else
                        {
                            estado.Rows.Remove(fila);
                        }
                        
                    }
                    f = f + 1;
                }

                
            }

            excel.Visible = true;

            Cursor.Current = Cursors.Default;


        }
    }

}

