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
    class Clsusuario : Conexion
    {
        string cvegeneracion, carrera, Turno, nempleado, cvetusu, cvegen, gen, dia, numero, mes, fech, idusuario, nombre, grado, grupo, cvecarrera, tusuario, generacion;

        public string _cvegeneracion
        {
            get { return cvegeneracion; }
            set { cvegeneracion = value; }
        }
        public string _carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public string _Turno
        {
            get { return Turno; }
            set { Turno = value; }
        }
        public string _nempleado
        {
            get { return nempleado; }
            set { nempleado = value; }
        }
        public string _cvetusu
        {
            get { return cvetusu; }
            set { cvetusu = value; }
        }
        public string _cvegen
        {
            get { return cvegen; }
            set { cvegen = value; }
        }
        public string _gen
        {
            get { return gen; }
            set { gen = value; }
        }
        public string _dia
        {
            get { return dia; }
            set { dia = value; }
        }
        public string _numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string _mes

        {
            get { return mes; }
            set { mes = value; }
        }
        public string _fech
        {
            get { return fech; }
            set { fech = value; }
        }
        public string _idusuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }
        public string _nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string _grado
        {
            get { return grado; }
            set { grado = value; }
        }
        public string _grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }
        
        public string _cvecarrera
        {
            get { return cvecarrera; }
            set { cvecarrera = value; }
        }
        
        
        public string _tusuario
        {
            get { return tusuario; }
            set { tusuario = value; }
        }
        public string _generacion
        {
            get { return generacion; }
            set { generacion = value; }
        }

        public void grabar()
        {

            try
            {
                conectar2();
                MySqlCommand cm = new MySqlCommand("INSERT INTO tblusuarios VALUES ('" + idusuario + "','" + nombre + "','" + grado + "','" + grupo + "','" + cvecarrera + "','" + tusuario + "','" + cvegeneracion + "');", con);
                cm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("EL USUARIO YA SE ENCUENTRA O NO ES VALIDO");
            }
        }
        public void eliminar()
        {
            conectar2();
            MySqlCommand cm = new MySqlCommand("DELETE FROM tblusuarios WHERE idusuario=" + idusuario, con);
            cm.ExecuteNonQuery();
            con.Close();
        }
        public void actualizar()
        {
            try
            {
                conectar2();
                MySqlCommand cm = new MySqlCommand("UPDATE tblusuarios SET nombre='" + nombre + "',grado='" + grado + "',grupo='" + grupo + "',cvecarrera='" + cvecarrera + "',cvetusuario='" + tusuario + "',cvegeneracion='" + generacion + "'WHERE idusuario='" + idusuario + "'", con);


                cm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("LOS CAMPOS DEL USUARIO NO SON VALIDOS");
            }
        }
        public void actualizargrado()
        {
            try
            {
                conectar2();
                MySqlCommand cm = new MySqlCommand("UPDATE tblusuarios SET grado=grado+1", con);


                cm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al actualizar grado");
            }
        }
        public void actualizargradogrupo()
        {
            try
            {
                conectar2();
                MySqlCommand cm = new MySqlCommand("UPDATE tblgrupo SET grado=grado+1", con);


                cm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al actualizar grado del grupo");
            }
        }
        public void eliminargradogrupo()
        {
            try
            {
                conectar2();
                MySqlCommand cm = new MySqlCommand("Delete from tblgrupo where grado=6", con);


                cm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar grado del grupo");
            }
        }

        public void llenargrid(DataGridView d1)
        {
            conectar2();

            MySqlCommand cmdd = new MySqlCommand("SELECT * FROM tblusuarios", con);

            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataTable dt = new DataTable();
            traer.Fill(dt);
            d1.DataSource = dt;
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
        
        public void buscarusuario(TextBox c1, TextBox c2, TextBox c3, TextBox c4, ComboBox c5, ComboBox c6, ComboBox c7)
        {

            conectar2();

            MySqlCommand cmdd = new MySqlCommand("Select * from tblusuarios WHERE idusuario ='" + idusuario + "';", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                c1.Text = leer["idusuario"].ToString();
                c2.Text = leer["nombre"].ToString();
                c3.Text = leer["grado"].ToString();
                c4.Text = leer["grupo"].ToString();
                c5.Text = leer["cvecarrera"].ToString();
                c6.Text = leer["cvetusuario"].ToString();
                c7.Text = leer["cvegeneracion"].ToString();
            }


        }
        public void cargarcarrerausuario(ComboBox c1)
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
        public void cargargeneracion(ComboBox c1)
        {

            conectar2();

            MySqlCommand cmdd = new MySqlCommand("Select * from tblgeneracion", con);
            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataTable dt = new DataTable();
            traer.Fill(dt);
            c1.DisplayMember = "generacion";
            c1.ValueMember = "cvegen";
            c1.DataSource = dt;

        }
        public void cargartusuario(ComboBox c1)
        {

            conectar2();

            MySqlCommand cmdd = new MySqlCommand("Select * from tbltusuario", con);
            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataTable dt = new DataTable();
            traer.Fill(dt);
            c1.DisplayMember = "nombreu";
            c1.ValueMember = "cveus";
            c1.DataSource = dt;

        }
        public void grabarprueba()
        {

            try
            {
                conectar2();
                MySqlCommand cm = new MySqlCommand("INSERT INTO tblprueba VALUES ('" + dia + "','" + numero + "','" + mes + "','" + fech + "');", con);
                cm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("EL USUARIO YA SE ENCUENTRA O NO ES VALIDO");
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
                
            }
        }
        public string traergeneracion()
        {
            string o = "";
            conectar2();

            MySqlCommand cmdd = new MySqlCommand("Select cvegen from tblgeneracion WHERE generacion ='" + gen + "';", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                o = leer["cvegen"].ToString();

            }
            else
            {
                o = "";
            }
            return o;
        }
        
        public string traergen()
        {
            string o = "";
            conectar2();

            MySqlCommand cmdd = new MySqlCommand("SELECT cvegen FROM tblgeneracion WHERE generacion LIKE '" + generacion + "';", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                o = leer["cvegen"].ToString();

            }
            else
            {
                o = "";
            }
            return o;
        }
        public DataTable traerporgeneracion()
        {
            conectar2();

            MySqlCommand cmdd = new MySqlCommand("select idusuario, nombre, cvecarrera, cvegeneracion from tblusuarios where cvegeneracion='" + cvegen + "'; ", con);
            MySqlDataAdapter traer = new MySqlDataAdapter(cmdd);

            DataSet dtDatos = new DataSet();
            traer.Fill(dtDatos, "generacion");
            return dtDatos.Tables[0];
        }
        public void grabarhistorialal()
        {

            try
            {
                conectar2();
                MySqlCommand cm = new MySqlCommand("INSERT INTO tblhistalumn VALUES ('" + idusuario + "','" + nombre + "','" + cvecarrera + "','" + cvegen + "');", con);
                cm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("EL HISTORIAL NO SE HA PODIDO COMPLETAR");
            }
        }
        public void eliminarusuarios()
        {
            conectar2();
            MySqlCommand cm = new MySqlCommand("DELETE FROM tblusuarios WHERE cvegeneracion=" + cvegen, con);
            cm.ExecuteNonQuery();
            con.Close();
        }
        public void grabaracademicos()
        {

            try
            {
                conectar2();
                MySqlCommand cm = new MySqlCommand("INSERT INTO tblusuacademicos VALUES ('" + nempleado + "','" + nombre + "','" + cvetusu + "');", con);
                cm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("EL ARCHIVO NO SE HA PODIDO COMPLETAR");
            }
        }
        public void grabaracad()
        {

            try
            {
                conectar2();
                MySqlCommand cm = new MySqlCommand("INSERT INTO tblusuacademicos VALUES ('" + idusuario + "','" + nombre + "','" + tusuario + "');", con);
                cm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("EL USUARIO NO ES VALIDO");
            }
        }
        public void grabargrupo()
        {

            try
            {
                conectar2();
                MySqlCommand cm = new MySqlCommand("INSERT INTO tblgrupo VALUES ('" + grupo + "','" + cvecarrera + "','" + Turno + "','" + grado + "');", con);
                cm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("EL GRUPO YA SE ENCUENTRA O NO ES VALIDO");
            }
        }
        public string buscaduplicadosgrupo()
        {
            string o = "";

            conectar2();
            MySqlCommand cmdd = new MySqlCommand("Select grupo from tblgrupo WHERE grupo ='" + grupo + "' AND cvecarrera='" + cvecarrera + "' AND grado='" + grado + "';", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                o = leer["grupo"].ToString();

            }
            else
            {
                o = "";
            }
            con.Close();
            return o;
        }
        public void grabarcarrera()
        {

            try
            {
                conectar2();
                MySqlCommand cm = new MySqlCommand("INSERT INTO tblcarrera VALUES ('" + cvecarrera + "','" + carrera + "');", con);
                cm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
               
            }
        }
        public string buscaduplicadoscarrera()
        {
            string o = "";

            conectar2();
            MySqlCommand cmdd = new MySqlCommand("Select cvecarrera from tblcarrera WHERE cvecarrera ='" + cvecarrera + "' AND descripcion='" + carrera + "';", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                o = leer["cvecarrera"].ToString();

            }
            else
            {
                o = "";
            }
            con.Close();
            return o;
        }
        public string buscaduplicadosgen()
        {
            string o = "";

            conectar2();
            MySqlCommand cmdd = new MySqlCommand("Select cvegen from tblgeneracion WHERE generacion='" + generacion + "';", con);
            MySqlDataReader leer = cmdd.ExecuteReader();
            if (leer.Read())
            {
                o = leer["cvegen"].ToString();

            }
            else
            {
                o = "";
            }
            con.Close();
            return o;
        }

    }
}
