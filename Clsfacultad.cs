using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace FCEATCC
{
    
    
    class Clsfacultad : Conexion
    {
        

        string cvegrado, cveusu, tusu, contrau, horas, cvestado, fechareg, horae, usuariosis, pasword, nempleado, cc, grado, estado, idusuariosis, grupo, fechares, idmaestro, cvema, cveus, nombreu, nbloque, tiempo, cvecarrera, descripcionca, semestre, cveestado, descripcionest, nmaquina, descripcionmaq, idusuario, cveturno, descripcionturno, cvegen, generacion;

        public string _cvegrado
        {
            get { return cvegrado; }
            set { cvegrado = value; }
        }
        public string _cveusu
        {
            get { return cveusu; }
            set { cveusu = value; }
        }
        public string _tusu
        {
            get { return tusu; }
            set { tusu = value; }
        }
        public string _contrau
        {
            get { return contrau; }
            set { contrau = value; }
        }
        public string _horas
        {
            get { return horas; }
            set { horas = value; }
        }
        public string _cvestado
        {
            get { return cvestado; }
            set { cvestado = value; }
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
        public string _usuariosis
        {
            get { return usuariosis; }
            set { usuariosis = value; }
        }
        public string _pasword
        {
            get { return pasword; }
            set { pasword = value; }
        }
        public string _nempleado
        {
            get { return nempleado; }
            set { nempleado = value; }
        }
        public string _grado
        {
            get { return grado; }
            set { grado = value; }
        }
        
        public string _estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public string _idusuariosis
        {
            get { return idusuariosis; }
            set { idusuariosis = value; }
        }
        public string _grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }
        public string _fechares
        {
            get { return fechares; }
            set { fechares = value; }
        }
        public string _idmaestro
        {
            get { return idmaestro; }
            set { idmaestro = value; }
        }
        public string _cvema
        {
            get { return cvema; }
            set { cvema = value; }
        }
        public string _cveus
        {
            get { return cveus; }
            set { cveus = value; }
        }
        public string _nombreu
        {
            get { return nombreu; }
            set { nombreu = value; }
        }
        public string _cvegen
        {
            get { return cvegen; }
            set { cvegen = value; }
        }
        public string _generacion
        {
            get { return generacion; }
            set { generacion = value; }
        }
        public string _nbloque
        {
            get { return nbloque; }
            set { nbloque = value; }
        }
        public string _tiempo
        {
            get { return tiempo; }
            set { tiempo = value; }
        }
        public string _cvecarrera
        {
            get { return cvecarrera; }
            set { cvecarrera = value; }
        }
        public string _descripcionca
        {
            get { return descripcionca; }
            set { descripcionca = value; }
        }
        public string _semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }
        public string _cveestado
        {
            get { return cveestado; }
            set { cveestado = value; }
        }
        public string _descripcionest
        {
            get { return descripcionest; }
            set { descripcionest = value; }
        }
        public string _nmaquina
        {
            get { return nmaquina; }
            set { nmaquina = value; }
        }
        public string _descripcionmaq
        {
            get { return descripcionmaq; }
            set { descripcionmaq = value; }
        }
        public string _idusuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }
        public string _cveturno
        {
            get { return cveturno; }
            set { cveturno = value; }
        }
        public string _descripcionturno
        {
            get { return descripcionturno; }
            set { descripcionturno = value; }
        }

        public void grabarbloque()
        {

            try
            {
                conectar2();
                MySqlCommand cm = new MySqlCommand("INSERT INTO tblbloque VALUES ('" + nbloque + "','" + tiempo + "');", con);
                cm.ExecuteNonQuery();
                
            }
            catch (Exception)
            {
                MessageBox.Show("EL BLOQUE YA SE ENCUENTRA O NO ES VALIDO");
            }
            finally
            { con.Close(); }
        }
        public void grabartusu()
        {

            try
            {
                conectar2();
                MySqlCommand cm = new MySqlCommand("INSERT INTO tbltusuario VALUES ('" + cveusu + "','" + tusu + "');", con);
                cm.ExecuteNonQuery();

            }
            catch (Exception)
            {
                MessageBox.Show("EL TIPO DE USUARIO YA SE ENCUENTRA O NO ES VALIDO");
            }
            finally
            { con.Close(); }
        }
        public void eliminarbloque()
        {
            conectar2();
            MySqlCommand cm = new MySqlCommand("DELETE FROM tblbloque WHERE nbloque=" + nbloque, con);
            cm.ExecuteNonQuery();
            con.Close();
        }
        public void eliminartusu()
        {
            conectar2();
            MySqlCommand cm = new MySqlCommand("DELETE FROM tbltusuario WHERE cveus=" + cveusu, con);
            cm.ExecuteNonQuery();
            con.Close();
        }
        public void actualizarbloque()
        {
            conectar2();
            MySqlCommand cm = new MySqlCommand("UPDATE tblbloque SET nbloque='" + nbloque + "',tiempo='" + tiempo + "'WHERE nbloque='" + nbloque + "'", con);


            cm.ExecuteNonQuery();
            con.Close();
        }
        public void actualizartusu()
        {
            conectar2();
            MySqlCommand cm = new MySqlCommand("UPDATE tbltusuario SET nombreu='" + tusu + "'WHERE cveus='" + cveusu + "'", con);


            cm.ExecuteNonQuery();
            con.Close();
        }
        public void llenargridbloque(DataGridView d1)
        {
            conectar2();

            MySqlCommand cmdd = new MySqlCommand("SELECT * FROM tblbloque", con);

            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataTable dt = new DataTable();
            traer.Fill(dt);
            d1.DataSource = dt;
        }
        public void llenargridtusu(DataGridView d1)
        {
            conectar2();

            MySqlCommand cmdd = new MySqlCommand("SELECT * FROM tbltusuario", con);

            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataTable dt = new DataTable();
            traer.Fill(dt);
            d1.DataSource = dt;
        }
        public void buscarbloque(TextBox c1, TextBox c2)
        {

            conectar2();

            MySqlCommand cmdd = new MySqlCommand("Select * from tblbloque WHERE nbloque ='" + nbloque + "';", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                c1.Text = leer["nbloque"].ToString();
                c2.Text = leer["tiempo"].ToString();
            }


        }
        public void buscartusu(TextBox c1, TextBox c2)
        {

            conectar2();

            MySqlCommand cmdd = new MySqlCommand("Select * from tbltusuario WHERE cveus ='" + cveusu + "';", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                c1.Text = leer["cveus"].ToString();
                c2.Text = leer["nombreu"].ToString();
            }


        }


        public void grabarcarrera()
        {

            try
            {
                conectar2();
                MySqlCommand cm = new MySqlCommand("INSERT INTO tblcarrera VALUES ('" + cvecarrera + "','" + descripcionca + "');", con);
                cm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("LA CARRERA YA SE ENCUENTRA O NO ES VALIDA");
            }
        }
        public void eliminacarrera()
        {
            conectar2();
            MySqlCommand cm = new MySqlCommand("DELETE FROM tblcarrera WHERE cvecarrera=" + cvecarrera, con);
            cm.ExecuteNonQuery();
            con.Close();
        }
        public void actualizarcarrera()
        {
            conectar2();
            MySqlCommand cm = new MySqlCommand("UPDATE tblcarrera SET descripcion='" + descripcionca + "'WHERE cvecarrera='" + cvecarrera + "'", con);


            cm.ExecuteNonQuery();
            con.Close();
        }
        public void llenargridcarrera(DataGridView d1)
        {
            conectar2();

            MySqlCommand cmdd = new MySqlCommand("SELECT * FROM tblcarrera", con);

            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataTable dt = new DataTable();
            traer.Fill(dt);
            d1.DataSource = dt;
        }
        public void buscarcarrera(TextBox c1, TextBox c2)
        {

            conectar2();

            MySqlCommand cmdd = new MySqlCommand("Select * from tblcarrera WHERE cvecarrera ='" + cvecarrera + "';", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                c1.Text = leer["cvecarrera"].ToString();
                c2.Text = leer["descripcion"].ToString();
                
            }


        }


        public void grabarestado()
        {

            try
            {
                conectar2();
                MySqlCommand cm = new MySqlCommand("INSERT INTO tblestado VALUES ('" + cveestado + "','" + descripcionest + "');", con);
                cm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("EL ESTADO YA SE ENCUENTRA O NO ES VALIDO");
            }
        }
        public void eliminarESTADO()
        {
            conectar2();
            MySqlCommand cm = new MySqlCommand("DELETE FROM tblestado WHERE cveestado=" + cveestado, con);
            cm.ExecuteNonQuery();
            con.Close();
        }
        public void actualizarestado()
        {
            conectar2();
            MySqlCommand cm = new MySqlCommand("UPDATE tblestado SET descripcion='" + descripcionest + "'WHERE cveestado='" + cveestado + "'", con);


            cm.ExecuteNonQuery();
            con.Close();
        }
        public void llenargridestado(DataGridView d1)
        {
            conectar2();

            MySqlCommand cmdd = new MySqlCommand("SELECT * FROM tblestado", con);

            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataTable dt = new DataTable();
            traer.Fill(dt);
            d1.DataSource = dt;
        }
        public void buscarestado(TextBox c1, TextBox c2)
        {

            conectar2();

            MySqlCommand cmdd = new MySqlCommand("Select * from tblestado WHERE cveestado ='" + cveestado + "';", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                c1.Text = leer["cveestado"].ToString();
                c2.Text = leer["descripcion"].ToString();
            }


        }


        public void grabarmaquina()
        {

            try
            {
                conectar2();
                cc = Conexion.ccomputo;
                MySqlCommand cm = new MySqlCommand("INSERT INTO tblmaquina VALUES ('" + nmaquina + "','"  + idusuario + "','" + cc + "','" + descripcionmaq + "','" + cveestado + "');", con);
                cm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("LA MAQUINA YA SE ENCUENTRA O NO ES VALIDA");
            }
        }
        public void eliminarmaquina()
        {
            conectar2();
            cc = Conexion.ccomputo;
            MySqlCommand cm = new MySqlCommand("DELETE FROM tblmaquina WHERE nmaquina='" + nmaquina + "' AND cc='" + cc + "'", con);
            cm.ExecuteNonQuery();
            con.Close();
        }
        public void actualizarmaquina()
        {
            conectar2();
            cc = Conexion.ccomputo;
            MySqlCommand cm = new MySqlCommand("UPDATE tblmaquina SET idusuario='" + idusuario + "',descripcion='" + descripcionmaq + "',cvestado='" + cveestado + "'WHERE nmaquina='" + nmaquina + "' AND cc='" + cc + "'", con);


            cm.ExecuteNonQuery();
            con.Close();
        }
        public void actualizarmaquinaID()
        {
            try
            {
                conectar2();
                cc = Conexion.ccomputo;
                MySqlCommand cm = new MySqlCommand("UPDATE tblmaquina SET idusuario='" + idusuario + "',cvestado='" + cveestado + "'WHERE nmaquina='" + nmaquina + "' AND cc='" + cc + "'", con);


                cm.ExecuteNonQuery();
            }
            catch
            { MessageBox.Show("Error con el Servidor"); }

            finally
            {
                con.Close();
            }
        }
        public string buscanummaquinaconusuario()
        {
            string o = "";

            conectar2();
            cc = Conexion.ccomputo;
            
            MySqlCommand cmdd = new MySqlCommand("Select nmaquina from tblmaquina WHERE idusuario ='" + idusuario + "' AND cc='" + cc + "';", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                o = leer["nmaquina"].ToString();
                con.Close();

            }
            else
            {
                o = "";
                con.Close();
            }

            return o;
        }
        public void llenargridmaquina(DataGridView d1)
        {
            conectar2();

            MySqlCommand cmdd = new MySqlCommand("SELECT * FROM tblmaquina", con);

            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataTable dt = new DataTable();
            traer.Fill(dt);
            d1.DataSource = dt;
        }
        public void cargarestmaquina(ComboBox c1)
        {

            conectar2();

            MySqlCommand cmdd = new MySqlCommand("Select * from tblestado where descripcion='DISPONIBLE' OR descripcion='OCUPADA' OR descripcion='NO DISPONIBLE' OR descripcion='RESERVADA';", con);
            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataTable dt = new DataTable();
            traer.Fill(dt);
            c1.DisplayMember = "descripcion";
            c1.ValueMember = "cveestado";
            c1.DataSource = dt;
        }

        public void buscarmaquina(TextBox c1, TextBox c2, ComboBox c3, TextBox c4)
        {

            conectar2();
            cc = Conexion.ccomputo;
            MySqlCommand cmdd = new MySqlCommand("Select * from tblmaquina WHERE nmaquina ='" + nmaquina + "' AND cc='" + cc + "'", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                c1.Text = leer["nmaquina"].ToString();
                c2.Text = leer["descripcion"].ToString();
                c3.Text = leer["cvestado"].ToString();
                c4.Text = leer["idusuario"].ToString();
            }


        }

        public void grabarturno()
        {

            try
            {
                conectar2();
                MySqlCommand cm = new MySqlCommand("INSERT INTO tblturno VALUES ('" + cveturno + "','" + descripcionturno + "');", con);
                cm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("EL TURNO YA SE ENCUENTRA O NO ES VALIDO");
            }
        }
        public void eliminarturno()
        {
            conectar2();
            MySqlCommand cm = new MySqlCommand("DELETE FROM tblturno WHERE CVETURNO=" + cveturno, con);
            cm.ExecuteNonQuery();
            con.Close();
        }
        public void actualizarturno()
        {
            conectar2();
            MySqlCommand cm = new MySqlCommand("UPDATE tblturno SET descripcion='" + descripcionturno + "'WHERE cveturno='" + cveturno + "'", con);


            cm.ExecuteNonQuery();
            con.Close();
        }
        public void llenargridturno(DataGridView d1)
        {
            conectar2();

            MySqlCommand cmdd = new MySqlCommand("SELECT * FROM tblturno", con);

            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataTable dt = new DataTable();
            traer.Fill(dt);
            d1.DataSource = dt;
        }
        public void buscarturno(TextBox c1, TextBox c2)
        {

            conectar2();

            MySqlCommand cmdd = new MySqlCommand("Select * from tblturno WHERE cveturno ='" + cveturno + "';", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                c1.Text = leer["cveturno"].ToString();
                c2.Text = leer["descripcion"].ToString();
            }


        }
        public void grabargeneracion()
        {

            try
            {
                conectar2();
                MySqlCommand cm = new MySqlCommand("INSERT INTO tblgeneracion VALUES ( null,'" + generacion + "');", con);
                cm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("LA GENERACIÓN YA SE ENCUENTRA O NO ES VALIDA");
            }
        }
        public void eliminargeneracion()
        {
            conectar2();
            MySqlCommand cm = new MySqlCommand("DELETE FROM tblgeneracion WHERE cvegen=" + cvegen, con);
            cm.ExecuteNonQuery();
            con.Close();
        }
        public void actualizargeneracion()
        {
            conectar2();
            MySqlCommand cm = new MySqlCommand("UPDATE tblgeneracion SET generacion='" + generacion + "'WHERE cvegen='" + cvegen + "'", con);


            cm.ExecuteNonQuery();
            con.Close();
        }
        public void llenargridgeneracion(DataGridView d1)
        {
            conectar2();

            MySqlCommand cmdd = new MySqlCommand("SELECT * FROM tblgeneracion", con);

            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataTable dt = new DataTable();
            traer.Fill(dt);
            d1.DataSource = dt;
        }
        public void buscargeneracion(TextBox c1, TextBox c2)
        {

            conectar2();

            MySqlCommand cmdd = new MySqlCommand("Select * from tblgeneracion WHERE cvegen ='" + cvegen + "';", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                c1.Text = leer["cvegen"].ToString();
                c2.Text = leer["generacion"].ToString();
            }

        }
        public void grabartusuario()
        {

            try
            {
                conectar2();
                MySqlCommand cm = new MySqlCommand("INSERT INTO tblussis VALUES ('" + cveus + "','" + nombreu + "',sha1('" + contrau + "'));", con);
                cm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("EL USUARIO YA SE ENCUENTRA O NO ES VALID0");
            }
        }
        public void eliminartusuario()
        {
            conectar2();
            MySqlCommand cm = new MySqlCommand("DELETE FROM tblussis WHERE id=" + cveus, con);
            cm.ExecuteNonQuery();
            con.Close();
        }
        public void actualizartusuario()
        {
            conectar2();
            MySqlCommand cm = new MySqlCommand("UPDATE tblussis SET nombre='" + nombreu + "',password=sha1('" + contrau + "') WHERE id='" + cveus + "'", con);


            cm.ExecuteNonQuery();
            con.Close();
        }
        public void actualizartusuariosolo()
        {
            conectar2();
            MySqlCommand cm = new MySqlCommand("UPDATE tblussis SET password=sha1('" + contrau + "') WHERE id='" + cveus + "'", con);


            cm.ExecuteNonQuery();
            con.Close();
        }
        public void llenargridtusuario(DataGridView d1)
        {
            conectar2();

            MySqlCommand cmdd = new MySqlCommand("SELECT * FROM tblussis", con);

            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataTable dt = new DataTable();
            traer.Fill(dt);
            d1.DataSource = dt;
        }
        public void buscartusuario(TextBox c1, TextBox c2, TextBox c3)
        {

            conectar2();

            MySqlCommand cmdd = new MySqlCommand("Select * from tblussis WHERE id='" + cveus + "';", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                c1.Text = leer["id"].ToString();
                c2.Text = leer["nombre"].ToString();
                c3.Text = leer["password"].ToString();
            }

        }

        public string buscarusuriores()
        {
            string p = "";
            conectar2();

            MySqlCommand cmdd = new MySqlCommand("Select idusuario from tblusuarios WHERE idusuario ='" + idusuario + "';", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                p = leer["idusuario"].ToString();
                /*Frmreservacionus xy = new Frmreservacionus();
                xy.y = p;
                xy.ShowDialog();*/
            }
            else
            {
                MessageBox.Show("PASAR LA CREDENCIAL POR EL CHECADOR");
            }
            return p;

        }
        public string buscaridusuario()
        {
            string o = "";

            conectar2();

            MySqlCommand cmdd = new MySqlCommand("Select idusuario from tblusuarios WHERE idusuario ='" + idusuario + "';", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                o = leer["idusuario"].ToString();
                con.Close();

            }
            else
            {
                o = "";
                MessageBox.Show("PASAR LA CREDENCIAL POR EL CHECADOR");
                con.Close();
            }
            return o;
        }
        
        public string buscausuarioreservacion()
        {
            string o = "";

            conectar2();

            cc = Conexion.ccomputo;

            MySqlCommand cmdd = new MySqlCommand("Select idusuario from tblmaquina WHERE idusuario ='" + idusuario + "' AND cc='" + cc + "';", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                o = leer["idusuario"].ToString();
                con.Close();

            }
            else
            {
                o = "";
                con.Close();
            }
            
            return o;

        }
       
        public DataTable traerestmaquina()
        {
            conectar2();
            cc = Conexion.ccomputo;
            DataTable d1 = new DataTable();

            MySqlCommand cmdd = new MySqlCommand("SELECT cvestado FROM tblmaquina Where cc='" + cc + "' order by cast(nmaquina as unsigned)", con);
            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataSet dtDatos = new DataSet();
            traer.Fill(dtDatos, "PRODUCO");
            return dtDatos.Tables[0];
        }
        public String contarmaquina()
        {
            conectar2();
            cc = Conexion.ccomputo;
            MySqlCommand contar = new MySqlCommand("SELECT COUNT(*) FROM tblmaquina WHERE cc='"+cc+"'", con);
            string cant = contar.ExecuteScalar().ToString();
            return cant;


        }

        public void buscarnomestado(TextBox a)
        {
            try
            {
                
                    conectar2();

                    MySqlCommand cmdd = new MySqlCommand("Select descripcion from tblestado WHERE cveestado ='" + cveestado + "';", con);
                    MySqlDataReader leer = cmdd.ExecuteReader();
                    if (leer.Read())
                    {
                        a.Text = leer["descripcion"].ToString();
                    }
                con.Close();

            }
            catch (MySqlException e)
            {
                con.Close();
            }
            

        }
        public void actualizarestmaquina()
        {
            conectar2();
            cc = Conexion.ccomputo;
            MySqlCommand cm = new MySqlCommand("UPDATE tblmaquina SET cvestado='" + cveestado + "',idusuario='" + idusuario + "'WHERE nmaquina='" + nmaquina + "' AND cc='" + cc + "';", con);


            cm.ExecuteNonQuery();
            con.Close();
        }
        public void actualizarestmaq()
        {
            conectar2();
            cc = Conexion.ccomputo;
            MySqlCommand cm = new MySqlCommand("UPDATE tblmaquina SET cvestado='" + cveestado + "'WHERE nmaquina='" + nmaquina + "'AND cc='" + cc + "'", con);


            cm.ExecuteNonQuery();
            con.Close();
        }
        public string buscarestadomaq()
        {
            string o = "";

            conectar2();

            MySqlCommand cmdd = new MySqlCommand("Select cvestado from tblmaquina WHERE nmaquina ='" + nmaquina + "';", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                o = leer["cvestado"].ToString();
               
            }
            else
            {
               
            }
            return o;
        }
        public string buscarestado()
        {
            string z = "";

            conectar2();

            MySqlCommand cmdd = new MySqlCommand("Select descripcion from tblestado WHERE cveestado ='" + cveestado + "';", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                z = leer["descripcion"].ToString();
           
            }
            else
            {

            }
            return z;
        }
        public DataTable cargausuacar()
        {
            conectar2();
            DataTable d1 = new DataTable();

            MySqlCommand cmdd = new MySqlCommand("Select idusuario, nombre from tblusuarios where cvecarrera='" + cvecarrera + "'", con);
            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataSet dtDatos = new DataSet();
            traer.Fill(dtDatos, "usuarios");
            return dtDatos.Tables[0];
        }
        public DataTable cargausua()
        {
            conectar2();
            DataTable d1 = new DataTable();

            MySqlCommand cmdd = new MySqlCommand("Select idusuario, nombre from tblusuarios where cvecarrera='" + cvecarrera + "'and grado='" + cvegrado + "'", con);
            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataSet dtDatos = new DataSet();
            traer.Fill(dtDatos, "usuarios");
            return dtDatos.Tables[0];
        }
        public DataTable cargarusuariosss()
        {
            conectar2();
            DataTable d1 = new DataTable();

            MySqlCommand cmdd = new MySqlCommand("Select idusuario, nombre from tblusuarios where cvecarrera='" + cvecarrera + "'and grado='" + cvegrado + "' and grupo='" + grupo + "'", con);
            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataSet dtDatos = new DataSet();
            traer.Fill(dtDatos, "usuarios");
            return dtDatos.Tables[0];
        }

        public void cargarcarrera(ComboBox c1)
        {

            conectar2();

            MySqlCommand cmdd = new MySqlCommand("Select * from tblcarrera", con);
            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataTable dt = new DataTable();
            traer.Fill(dt);
            c1.DisplayMember = "descripcion";
            c1.ValueMember = "cvecarrera";
            c1.DataSource = dt;
        }
        public void cargargrupo(ComboBox c1)
        {

            conectar2();

            MySqlCommand cmdd = new MySqlCommand("Select grupo, concat_ws('-',grado,grupo) As ce from tblgrupo where cvecarrera='" + cvecarrera + "'", con);
            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataTable dt = new DataTable();
            traer.Fill(dt);
            c1.DisplayMember = "ce";
            c1.ValueMember = "grupo";
            c1.DataSource = dt;
        }
        public void cargargrado(ComboBox c1)
        {
            conectar2();

            MySqlCommand cmdd = new MySqlCommand("Select DISTINCT grado from tblgrupo where cvecarrera='" + cvecarrera + "'", con);
            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataTable dt = new DataTable();
            traer.Fill(dt);
            c1.DisplayMember = "grado";
            c1.ValueMember = "grado";
            c1.DataSource = dt;
        }
        public void cargargrupoo(ComboBox c1)
        {
            conectar2();

            MySqlCommand cmdd = new MySqlCommand("Select grupo from tblgrupo where cvecarrera='" + cvecarrera + "'and grado='" + cvegrado + "'", con);
            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataTable dt = new DataTable();
            traer.Fill(dt);
            c1.DisplayMember = "grupo";
            c1.ValueMember = "grupo";
            c1.DataSource = dt;
        }
        public void cargargruporgrid(ComboBox c1)
        {

            conectar2();

            MySqlCommand cmdd = new MySqlCommand("Select grupo from tblgrupo where grupo='" + grupo + "'", con);
            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataTable dt = new DataTable();
            traer.Fill(dt);
            c1.DisplayMember = "grupo";
            c1.ValueMember = "grupo";
            c1.DataSource = dt;
        }
        public void cargarbloque(ComboBox c1)
        {

            conectar2();

            MySqlCommand cmdd = new MySqlCommand("Select * from tblbloque", con);
            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataTable dt = new DataTable();
            traer.Fill(dt);
            c1.DisplayMember = "tiempo";
            c1.ValueMember = "nbloque";
            c1.DataSource = dt;
        }
        public void llenargridreservarm(DataGridView d1)
        {
            conectar2();
            cc = Conexion.ccomputo;

            MySqlCommand cmdd = new MySqlCommand("SELECT * FROM tblreservacionm where cc='" + cc + "'ORDER BY fecha desc", con);

            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataTable dt = new DataTable();
            traer.Fill(dt);
            d1.DataSource = dt;
        }
        public void llenargridreservarm2(DataGridView d1)
        {
            conectar2();
            cc = Conexion.ccomputo;

            MySqlCommand cmdd = new MySqlCommand("SELECT * FROM tblreservacionm where cc='" + cc + "' AND idmaestro = '" + idmaestro + "'ORDER BY fecha desc LIMIT 6", con);

            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataTable dt = new DataTable();
            traer.Fill(dt);
            d1.DataSource = dt;
        }
        public void eliminaresmaestro()
        {
            conectar2();
            cc = Conexion.ccomputo;
            MySqlCommand cm = new MySqlCommand("DELETE FROM tblreservacionm WHERE idmaestro = '" + idmaestro + "' AND fecha = '" + fechares + "' AND nbloque = '" + nbloque + "' AND cc = '" + cc + "'; ", con);
            cm.ExecuteNonQuery();
            con.Close();
        }
        public string buscarcvestadoconombre()
        {
            string p = "";
            conectar2();

            MySqlCommand cmdd = new MySqlCommand("Select cveestado from tblestado WHERE descripcion='" + estado + "';", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                p = leer["cveestado"].ToString();
            }
            else
            {
                
            }
            return p;

        }
        public void grabarreservacionmaestro()
        {

            try
            {
                conectar2();
                cc = Conexion.ccomputo;
                MySqlCommand cm = new MySqlCommand("INSERT INTO tblreservacionm VALUES ('" + idmaestro + "','" + fechares + "','" + grupo + "','" + nbloque + "','" + cc + "','" + cveestado + "','" + Program.Idsis + "');", con);
                cm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("LA RESERVACIÓN YA SE ENCUENTRA O NO ES VALIDA");
            }
        }
        public void grabarreservacionmaestro2()
        {

            try
            {
                conectar2();
                cc = Conexion.ccomputo;
                MySqlCommand cm = new MySqlCommand("INSERT INTO tblreservacionm VALUES ('" + idmaestro + "','" + fechares + "','" + grupo + "','" + nbloque + "','" + cc + "','" + cveestado + "','" + idmaestro + "');", con);
                cm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("LA RESERVACIÓN YA SE ENCUENTRA O NO ES VALIDA");
            }
        }
        public string buscaduplicadosr()
        {
            string o = "";

            conectar2();
            cc = Conexion.ccomputo;


            MySqlCommand cmdd = new MySqlCommand("Select idmaestro from tblreservacionm WHERE fecha ='" + fechares + "' AND nbloque='" + nbloque + "' AND cc='" + cc + "';", con);
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
        public void actualizarreservacionmaestro()
        {
            conectar2();
            cc = Conexion.ccomputo;
            MySqlCommand cm = new MySqlCommand("UPDATE tblreservacionm SET fecha='" + fechares + "', nbloque='" + nbloque + "'WHERE idmaestro = '" + idmaestro + "' AND grupo = '" + grupo + "' AND cc = '" + cc + "';", con);


            cm.ExecuteNonQuery();
            con.Close();
        }
        public void llenargridgrupo(DataGridView d1)
        {
            conectar2();

            MySqlCommand cmdd = new MySqlCommand("SELECT * FROM tblgrupo", con);

            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataTable dt = new DataTable();
            traer.Fill(dt);
            d1.DataSource = dt;
        }
        public void eliminargrupo()
        {
            conectar2();
            MySqlCommand cm = new MySqlCommand("DELETE FROM tblgrupo WHERE grupo = '" + grupo + "' AND cvecarrera = '" + cvecarrera + "' AND grado = '" + grado + "'; ", con);
            cm.ExecuteNonQuery();
            con.Close();
        }
        public void grabargrupo()
        {

            try
            {
                conectar2();
                MySqlCommand cm = new MySqlCommand("INSERT INTO tblgrupo VALUES ('" + grupo + "','" + cvecarrera + "','" + cveturno + "','" + grado + "');", con);
                cm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("EL GRUPO YA SE ENCUENTRA O NO ES VALIDO");
            }
        }
        public void actualizargrupo()
        {
            conectar2();
            MySqlCommand cm = new MySqlCommand("UPDATE tblgrupo SET  cveturno='" + cveturno + "'WHERE grupo = '" + grupo + "' AND cvecarrera= '" + cvecarrera + "' AND grado= '" + grado + "'; ", con);


            cm.ExecuteNonQuery();
            con.Close();
        }
        public void cargarturno(ComboBox c1)
        {

            conectar2();

            MySqlCommand cmdd = new MySqlCommand("Select * from tblturno", con);
            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataTable dt = new DataTable();
            traer.Fill(dt);
            c1.DisplayMember = "descripcion";
            c1.ValueMember = "cveturno";
            c1.DataSource = dt;
        }
        
        public string contarmaquinareser()
        {
            conectar2();
            cc = Conexion.ccomputo;
            MySqlCommand contar = new MySqlCommand("SELECT COUNT(*) FROM tblmaquina WHERE cc='" + cc + "' AND cvestado='" + cveestado + "';", con);
            string cant = contar.ExecuteScalar().ToString();
            return cant;


        }
        public string buscaridacademico()
        {
            string o = "";

            conectar2();

            MySqlCommand cmdd = new MySqlCommand("Select nempleado from tblusuacademicos WHERE nempleado ='" + nempleado + "';", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                o = leer["nempleado"].ToString();
                con.Close();
            }
            else
            {
                o = "";
                MessageBox.Show("EL NUMERO NO ESTA REGISTRADO, FAVOR DE PASAR CON EL ENCARGADO");
                con.Close();
            }
            return o;
        }
        public DataTable traerestadoo()
        {
            conectar2();
            cc = Conexion.ccomputo;
            DataTable d1 = new DataTable();

            MySqlCommand cmdd = new MySqlCommand("SELECT * FROM tblestado", con);
            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataSet dtDatos = new DataSet();
            traer.Fill(dtDatos, "estado");
            return dtDatos.Tables[0];
        }
        public string buscaususis()
        {
            string o = "";

            conectar2();

            MySqlCommand cmdd = new MySqlCommand("Select id from tblussis WHERE id ='" + usuariosis + "' AND password=sha1('" + pasword + "');", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                o = leer["id"].ToString();

            }
            else
            {
                o = "";
            }
            return o;
        }
        public void grabarresusuario()
        {

            try
            {
                conectar2();
                cc = Conexion.ccomputo;
                MySqlCommand cm = new MySqlCommand("INSERT INTO tblreservacionu VALUES ('" + Program.Idsis + "','" + nmaquina + "','" + "','" + horae + "','" + "','" + fechareg + "','" + cc + "');", con);
                cm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("LA RESERVACIÓN YA SE ENCUENTRA O NO ES VALIDA");
            }
        }
        public void actualizarreservaciohoras()
        {
            try
            {
                conectar2();
                cc = Conexion.ccomputo;
                MySqlCommand cm = new MySqlCommand("UPDATE tblreservacionu SET horas='" + horas + "',cvestado='" + cvestado + "' WHERE idusuarios='" + Program.Idsis + "' AND horae = '" + horae + "' AND fechar = '" + fechareg + "' AND cc = '" + cc + "';", con);


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

            MySqlCommand cmdd = new MySqlCommand("Select horae from tblreservacionu WHERE idusuarios ='" + Program.Idsis + "' AND nmaquina = '" + nmaquina + "' AND fechar = '" + fechareg + "' AND horas = '" + " " + "';", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                o = leer["horae"].ToString();

            }
            else
            {
                o = "";
            }
            return o;
        }
        public void eliminarporgeneracion()
        {
            conectar2();
            MySqlCommand cm = new MySqlCommand("DELETE FROM tblusuarios WHERE cvegeneracion = '" + generacion + "'; ", con);
            cm.ExecuteNonQuery();
            con.Close();
        }
        public void eliminargen()
        {
            conectar2();
            MySqlCommand cm = new MySqlCommand("DELETE FROM tblgeneracion WHERE cvegen = '" + generacion + "'; ", con);
            cm.ExecuteNonQuery();
            con.Close();
        }
        public string buscanombreusu()
        {
            string o = "";

            conectar2();

            MySqlCommand cmdd = new MySqlCommand("Select nombre from tblussis WHERE id ='" + Program.Idsis + "';", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                o = leer["nombre"].ToString();

            }
            else
            {
                o = "";
            }
            return o;
        }
    }
}
