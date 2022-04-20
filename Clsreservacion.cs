using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FCEATCC
{
    class Clsreservacion : Conexion
    {
        
        string alumno, estadmin, estsis, inicio, fin, cvecarrera, estadc, reser, ocup, bloq, fechares, estadou, tiempo, idusuariosis, idmaestro, fecha, grupo, cvestado, permiso, nbloque, cc, idusuarios, fechareg, horae, horas, nmaquina;

        public string _alumno
        {
            get { return alumno; }
            set { alumno = value; }
        }
        public string _estsis
        {
            get { return estsis; }
            set { estsis = value; }
        }
        public string _estadmin
        {
            get { return estadmin; }
            set { estadmin = value; }
        }
        public string _inicio
        {
            get { return inicio; }
            set { inicio = value; }
        }
        public string _fin
        {
            get { return fin; }
            set { fin = value; }
        }
        public string _cvecarrera
        {
            get { return cvecarrera; }
            set { cvecarrera = value; }
        }
        public string _estadc
        {
            get { return estadc; }
            set { estadc = value; }
        }
        public string _reser
        {
            get { return reser; }
            set { reser = value; }
        }
        public string _ocup
        {
            get { return ocup; }
            set { ocup = value; }
        }
        public string _bloq
        {
            get { return bloq; }
            set { bloq = value; }
        }
        public string _fechares
        {
            get { return fechares; }
            set { fechares = value; }
        }
        public string _estadou
        {
            get { return estadou; }
            set { estadou = value; }
        }
        public string _tiempo
        {
            get { return tiempo; }
            set { tiempo = value; }
        }
        public string _idusuariosis
        {
            get { return idusuariosis; }
            set { idusuariosis = value; }
        }
        public string _idmaestro
        {
            get { return idmaestro; }
            set { idmaestro = value; }
        }
        public string _fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public string _grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }
        public string _cvestado
        {
            get { return cvestado; }
            set { cvestado = value; }
        }
        public string _permiso
        {
            get { return permiso; }
            set { permiso = value; }
        }
        public string _nbloque
        {
            get { return nbloque; }
            set { nbloque = value; }
        }
        public string _cc
        {
            get { return cc; }
            set { cc = value; }
        }
        public string _idusuarios
        {
            get { return idusuarios; }
            set { idusuarios = value; }
        }
        public string _fechareg
        {
            get { return fechareg; }
            set { fechareg = value; }
        }
        public string _horae
        {
            get { return horae; }
            set { horae = value; }
        }
        public string _horas
        {
            get { return horas; }
            set { horas = value; }
        }
        public string _nmaquina
        {
            get { return nmaquina; }
            set { nmaquina = value; }
        }

        public void grabarresmaestros()
        {

            try
            {
                conectar2();
                MySqlCommand cm = new MySqlCommand("INSERT INTO tblreservacionm VALUES ('" + idmaestro + "','" + fecha + "','" + grupo + "','" + nbloque + "','" + cc + "','" + cvestado + "','" + idusuariosis + "');", con);
                cm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("LA RESERVACIÓN YA SE ENCUENTRA O NO ES VALIDA");
            }
        }
        public void eliminarresmaestros()
        {
            conectar2();
            MySqlCommand cm = new MySqlCommand("DELETE FROM tblreservacionm WHERE fecha='" + fecha + "' & nbloque='" + nbloque, con);
            cm.ExecuteNonQuery();
            con.Close();
        }
        public void actualizarresmaestros()
        {
            conectar2();
            cc = Conexion.ccomputo;
            MySqlCommand cm = new MySqlCommand("UPDATE tblreservacionm SET idmaestro='" + idmaestro + "',grupo='" + grupo + "',cvestado='" + cvestado + "',idusuariosis='" + idusuariosis + "',cc='" + cc + "'WHERE fecha='" + fecha + "' & nbloque='" + nbloque + "'", con);


            cm.ExecuteNonQuery();
            con.Close();
        }
        public void llenargridresmaestros(DataGridView d1)
        {
            conectar2();

            MySqlCommand cmdd = new MySqlCommand("SELECT * FROM tblreservacionm", con);

            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataTable dt = new DataTable();
            traer.Fill(dt);
            d1.DataSource = dt;
        }

        public void grabarresusuario()
        {

            try
            {
                conectar2();
                cc = Conexion.ccomputo;
                Program.ultmaquina = nmaquina; 
                MySqlCommand cm = new MySqlCommand("INSERT INTO tblreservacionu VALUES ('" + idusuarios + "','" + nmaquina + "','" + "','" + horae + "','" + "','" + fechareg + "','" + cc + "');", con);
                cm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("LA RESERVACIÓN YA SE ENCUENTRA O NO ES VALIDA");
            }
        }
        public void eliminarresusuario()
        {
            conectar2();
            MySqlCommand cm = new MySqlCommand("DELETE FROM tblreservacionu WHERE idusuarios='" + idusuarios + "' & horae='" + horae + "' & fechar='" + fechareg, con);
            cm.ExecuteNonQuery();
            con.Close();
        }
        public void actualizarresusuario()
        {
            conectar2();
            MySqlCommand cm = new MySqlCommand("UPDATE tblreservacionu SET idusuarios='" + idusuarios + "',fechar='" + fechareg + "',horas='" + horas + "',cvestado='" + cvestado + "'WHERE horae='" + horae + "' & nmaquina='" + nmaquina + "'", con);


            cm.ExecuteNonQuery();
            con.Close();
        }
        public void llenargridresusuario(DataGridView d1)
        {
            conectar2();

            MySqlCommand cmdd = new MySqlCommand("SELECT * FROM tblreservacionu", con);

            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataTable dt = new DataTable();
            traer.Fill(dt);
            d1.DataSource = dt;
        }
        public void grabarreservacionu()
        {

            try
            {
                conectar2();
                cc = Conexion.ccomputo;
                MySqlCommand cm = new MySqlCommand("INSERT INTO tblreservacionu VALUES ('" + idmaestro + "','" + fecha + "','" + grupo + "','" + nbloque + "','" + cc + "','" + cvestado + "','" + idusuariosis + "');", con);
                cm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("LA RESERVACIÓN YA SE ENCUENTRA O NO ES VALIDA");
            }
        }
        public void actualizarreservacionumaq()
        {
            conectar2();
            MySqlCommand cm = new MySqlCommand("UPDATE tblreservacionu SET nmaquina='" + nmaquina + "'WHERE idusuarios='" + idusuarios + "'AND horae = '" + horae + "' AND fechar = '" + fechareg + "'; ", con);


            cm.ExecuteNonQuery();
            con.Close();
        }
        public void actualizarreservaciohoras()
        {
            try
            {
                conectar2();
                cc = Conexion.ccomputo;
                MySqlCommand cm = new MySqlCommand("UPDATE tblreservacionu SET horas='" + horas + "',cvestado='" + cvestado + "' WHERE idusuarios='" + idusuarios + "' AND horae = '" + horae + "' AND fechar = '" + fechareg + "' AND cc = '" + cc + "';", con);


                cm.ExecuteNonQuery();
            }
            catch
            { MessageBox.Show("Error con el servidor."); }
            finally
            {
                con.Close();
            }
        }
        public string traerhorae()
        {
            string o = "";
            conectar2();

            MySqlCommand cmdd = new MySqlCommand("Select horae from tblreservacionu WHERE idusuarios ='" + idusuarios + "' AND nmaquina = '" + nmaquina + "' AND fechar = '" + fechareg + "' AND horas = '" + " " + "';", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                o = leer["horae"].ToString();
                con.Close();
            }
            else
            {
                o = "";
                con.Close();
            }
            return o;
        }
        public string traerestado()
        {  
                string o = "";
                conectar2();

                MySqlCommand cmdd = new MySqlCommand("Select cveestado from tblestado WHERE descripcion ='" + estadou + "';", con);
                MySqlDataReader leer = cmdd.ExecuteReader();

                if (leer.Read())
                {
                    o = leer["cveestado"].ToString();
                    con.Close();

                }
                else
                {
                    o = "";
                    con.Close();
                }

                return o;
        }
        public string traerfechareg()
        {
            string o = "";
            conectar2();

            MySqlCommand cmdd = new MySqlCommand("Select fechar from tblreservacionu WHERE idusuarios ='" + idusuarios + "' AND horae = '" + horae + "';", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                o = leer["fechar"].ToString();
                con.Close();

            }
            else
            {
                o = "";
                con.Close();
            }
            return o;
        }
        public DataTable traerfecha()
        {
            conectar2();
            DataTable d1 = new DataTable();

            MySqlCommand cmdd = new MySqlCommand("select fecha, nbloque from tblreservacionm where YEARweek(tblreservacionm.fecha) = YEARweek(CURRENT_date)", con);
            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataSet dtDatos = new DataSet();
            traer.Fill(dtDatos, "PRODUCO");
            return dtDatos.Tables[0];
        }
        public DataTable traeralumno()
        {
            conectar2();
            DataTable d1 = new DataTable();

            MySqlCommand cmdd = new MySqlCommand("select * from tblusuarios where idusuario='"+alumno+"'", con);
            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataSet dtDatos = new DataSet();
            traer.Fill(dtDatos, "PRODUCO");
            return dtDatos.Tables[0];
        }
        public DataTable traerest()
        {
            conectar2();
            DataTable d2 = new DataTable();
            MySqlCommand cmdd = new MySqlCommand("select * from tblreservacionu where cvestado='"+ estadmin + "'or cvestado='"+ estsis + "';", con);
            MySqlDataAdapter tra = new MySqlDataAdapter(cmdd);

            DataSet datdatos = new DataSet();
            tra.Fill(datdatos, "Pro");
            return datdatos.Tables[0];


        }
      
        public DataTable traerbloque()
        {
            conectar2();
            DataTable d1 = new DataTable();

            MySqlCommand cmdd = new MySqlCommand("select * from tblbloque", con);
            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataSet dtDatos = new DataSet();
            traer.Fill(dtDatos, "BLOQUE");
            return dtDatos.Tables[0];
        }
        public String contarresmaestro()
        {
            conectar2();
            MySqlCommand contar = new MySqlCommand("SELECT COUNT(*) FROM tblreservacionm where YEARweek(tblreservacionm.fecha) = YEARweek(CURRENT_date)", con);
            string cant = contar.ExecuteScalar().ToString();
            return cant;


        }
        public DataTable traertiempo()
        {
            conectar2();
            DataTable d1 = new DataTable();

            MySqlCommand cmdd = new MySqlCommand("select nbloque from tblreservacionm where fecha='" + tiempo + "'", con);
            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataSet dtDatos = new DataSet();
            traer.Fill(dtDatos, "tiempo");
            return dtDatos.Tables[0];
        }
        public String contartiempo()
        {
            conectar2();
            MySqlCommand contar = new MySqlCommand("SELECT COUNT(*) FROM tblreservacionm where fecha='" + tiempo + "'", con);
            string cant = contar.ExecuteScalar().ToString();
            return cant;


        }
        public string traerusuariomaquina()
        {
            string o = "";
            conectar2();
            cc = Conexion.ccomputo;

            MySqlCommand cmdd = new MySqlCommand("Select idusuario from tblmaquina WHERE nmaquina ='" + nmaquina + "' AND cc = '" + cc + "';", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                o = leer["idusuario"].ToString();

            }
            else
            {
                o = "";
            }
            return o;
        }
        public String contarmaquina()
        {
            conectar2();
            cc = Conexion.ccomputo;
            MySqlCommand contar = new MySqlCommand("SELECT COUNT(*) FROM tblmaquina where (cvestado='" + ocup + "'OR cvestado='" + reser + "')AND cc='" + cc + "'", con);
            string cant = contar.ExecuteScalar().ToString();
            return cant;


        }
        public String contarmaquina2()
        {
            conectar2();
            cc = Conexion.ccomputo;
            MySqlCommand contar = new MySqlCommand("SELECT COUNT(*) FROM tblmaquina where cvestado='" + reser + "'AND cc='" + cc + "'", con);
            string cant = contar.ExecuteScalar().ToString();
            return cant;


        }
        public String contarmaquinaporeserv()
        {
            conectar2();
            cc = Conexion.ccomputo;
            MySqlCommand contar = new MySqlCommand("SELECT COUNT(*) FROM tblmaquina where cvestado='" + reser + "'AND cc='" + cc + "'", con);
            string cant = contar.ExecuteScalar().ToString();
            return cant;


        }
        public DataTable traerestmaquina()
        {
            conectar2();
            cc = Conexion.ccomputo;
            DataTable d1 = new DataTable();

            MySqlCommand cmdd = new MySqlCommand("SELECT nmaquina, idusuario FROM tblmaquina Where (cvestado='" + ocup + "'OR cvestado='" + reser + "')AND cc='" + cc + "'", con);
            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataSet dtDatos = new DataSet();
            traer.Fill(dtDatos, "PRODUCO");
            return dtDatos.Tables[0];
        }
        public DataTable traerestmaquina2()
        {
            conectar2();
            cc = Conexion.ccomputo;
            DataTable d1 = new DataTable();

            MySqlCommand cmdd = new MySqlCommand("SELECT nmaquina, idusuario FROM tblmaquina Where cvestado='" + reser + "'AND cc='" + cc + "'", con);
            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataSet dtDatos = new DataSet();
            traer.Fill(dtDatos, "PRODUCO");
            return dtDatos.Tables[0];
        }
        public DataTable traeridnumaquina()
        {
            conectar2();
            cc = Conexion.ccomputo;
            DataTable d1 = new DataTable();

            MySqlCommand cmdd = new MySqlCommand("SELECT nmaquina, idusuario FROM tblmaquina Where cvestado='" + reser + "'AND cc='" + cc + "'", con);
            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataSet dtDatos = new DataSet();
            traer.Fill(dtDatos, "Maquina");
            return dtDatos.Tables[0];
        }
        public string traermaestrores()
        {
            string o = "";
            conectar2();
            cc = Conexion.ccomputo;

            MySqlCommand cmdd = new MySqlCommand("Select idmaestro from tblreservacionm WHERE fecha ='" + fechares + "'AND nbloque='"+ bloq + "' AND cc = '" + cc + "';", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                o = leer["idmaestro"].ToString();

            }
            else
            {
                o = "";
            }
            return o;
        }
        public string traergrupores()
        {
            string o = "";
            conectar2();
            cc = Conexion.ccomputo;

            MySqlCommand cmdd = new MySqlCommand("Select grupo from tblreservacionm WHERE fecha ='" + fechares + "'AND nbloque='" + bloq + "' AND cc = '" + cc + "';", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                o = leer["grupo"].ToString();

            }
            else
            {
                o = "";
            }
            return o;


        }
        public string buscaridaestroreservacion()
        {
            string o = "";

            conectar2();

            cc = Conexion.ccomputo;

            MySqlCommand cmdd = new MySqlCommand("Select idmaestro from tblreservacionm WHERE fecha ='" + fechares + "' AND nbloque='" + bloq + "' AND cc='" + cc + "';", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                o = leer["idmaestro"].ToString();

            }
            else
            {
                o = "";
            }
            return o;
        }
        public void actualizarestmaquina()
        {
            conectar2();
            cc = Conexion.ccomputo;
            MySqlCommand cm = new MySqlCommand("UPDATE tblmaquina SET cvestado='" + estadc + "',idusuario='" + idusuarios + "'WHERE nmaquina='" + nmaquina + "' AND cc='" + cc + "';", con);


            cm.ExecuteNonQuery();
            con.Close();
        }
        public DataTable Traeralumnosxdia()
        {
            conectar2();
            cc = Conexion.ccomputo;
            DataTable d1 = new DataTable();

            MySqlCommand cmdd = new MySqlCommand("select idusuarios from tblreservacionu where fechar='" + fechareg + "' AND cc='" + cc + "';", con);
            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataSet dtDatos = new DataSet();
            traer.Fill(dtDatos, "Idusuarios");
            return dtDatos.Tables[0];
        }
        public void buscarid(TextBox car, TextBox grado)
        {

            conectar2();
            try
            {
                MySqlCommand cmdd = new MySqlCommand("Select cvecarrera, grado from tblusuarios WHERE idusuario ='" + idusuarios + "';", con);
                MySqlDataReader leer = cmdd.ExecuteReader();
                if (leer.Read())
                {
                    car.Text = leer["cvecarrera"].ToString();
                    grado.Text = leer["grado"].ToString();
                }
                else
                {
                    car.Text = "";
                    grado.Text = "";
                }
            }
            catch
            {  }
            //return c;
        }
        public string buscarcarrer()
        {
            string o = "";
            conectar2();
            MySqlCommand cmdd = new MySqlCommand("Select descripcion from tblcarrera WHERE cvecarrera ='" + cvecarrera + "';", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                o = leer["descripcion"].ToString();

            }
            else
            {
                o = "";
            }
            return o;
        }
       
        public DataTable cargarcarrera()
        {
            conectar2();
            cc = Conexion.ccomputo;
            DataTable d1 = new DataTable();

            MySqlCommand cmdd = new MySqlCommand("Select * from tblcarrera", con);
            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataSet dtDatos = new DataSet();
            traer.Fill(dtDatos, "Carrera");
            return dtDatos.Tables[0];
        }
        public DataTable Traeralumnosxmes()
        {
            conectar2();
            cc = Conexion.ccomputo;
            DataTable d1 = new DataTable();

            MySqlCommand cmdd = new MySqlCommand("select idusuarios, fechar from tblreservacionu where fechar BETWEEN'" + inicio + "' AND '" + fin +"' AND cc='" + cc + "';", con);
            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataSet dtDatos = new DataSet();
            traer.Fill(dtDatos, "Idusuarios");
            return dtDatos.Tables[0];
        }
        public DataTable cargarusuariosss()
        {
            conectar2();
            DataTable d1 = new DataTable();

            MySqlCommand cmdd = new MySqlCommand("Select idusuario, nombre from tblusuarios", con);
            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataSet dtDatos = new DataSet();
            traer.Fill(dtDatos, "usuarios");
            return dtDatos.Tables[0];
        }
        public DataTable cargaracademicos()
        {
            conectar2();
            DataTable d1 = new DataTable();

            MySqlCommand cmdd = new MySqlCommand("Select nempleado, nombre from tblusuacademicos", con);
            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataSet dtDatos = new DataSet();
            traer.Fill(dtDatos, "academicos");
            return dtDatos.Tables[0];
        }
        public DataTable cargarmaquinas()
        {
            conectar2();
            cc = Conexion.ccomputo;
            DataTable d1 = new DataTable();

            MySqlCommand cmdd = new MySqlCommand("Select (nmaquina * 1) AS MAQUINA, descripcion, cvestado from tblmaquina Where cc='" + cc + "'ORDER BY MAQUINA", con);
            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataSet dtDatos = new DataSet();
            traer.Fill(dtDatos, "maquina");
            return dtDatos.Tables[0];
        }

    }
}
