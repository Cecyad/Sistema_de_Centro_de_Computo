using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Forms;


namespace FCEATCC
{
    class Conexion
    {
        public static string ccomputo;
        public static string x;
        public static string y;
        public static string xa;
        public static string ya;
        public static string pantalla;
        public static string ancho;
        public static string alto;
        public string archivo = "c:/windows/help/Helpc.ini";
        public string IniGet(string sFileName, string sSection, string sKeyName, string sDefault)

        {
            //--------------------------------------------------------------------------
            // Devuelve el valor de una clave de un fichero INI
            // Los parámetros son:
            //   sFileName   El fichero INI
            //   sSection    La sección de la que se quiere leer
            //   sKeyName    Clave
            //   sDefault    Valor opcional que devolverá si no se encuentra la clave
            //--------------------------------------------------------------------------
            int ret;
            string sRetVal;
            //
            sRetVal = new string(' ', 255);
            //
            ret = GetPrivateProfileString(sSection, sKeyName, sDefault, sRetVal, sRetVal.Length, sFileName);
            if (ret == 0)
            {
                return sDefault;
            }
            else
            {
                return sRetVal.Substring(0, ret);
            }
        }




        // Leer una clave de un fichero INI
        [DllImport("Kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetPrivateProfileString(
            string lpAppName,        // points to section name
            string lpKeyName,        // points to key name
            string lpDefault,        // points to default string
            string lpReturnedString, // points to destination buffer
            int nSize,            // size of destination buffer
            string lpFileName        // points to initialization filename
        );
        [DllImport("Kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetPrivateProfileString(
            string lpAppName,        // points to section name
            int lpKeyName,        // points to key name
            string lpDefault,        // points to default string
            string lpReturnedString, // points to destination buffer
            int nSize,            // size of destination buffer
            string lpFileName        // points to initialization filename
            );



        public MySqlConnection con;
       
        public void conectar2()
        {
            try
            {
                string sv = IniGet(archivo, "conexion", "servidor", "");
                string bd = IniGet(archivo, "conexion", "bd", "");
                string us = IniGet(archivo, "conexion", "usuario", "");
                string psw2 = IniGet(archivo, "conexion", "psw", "");
                ccomputo = IniGet(archivo, "conexion", "cc", "");
                x = IniGet(archivo, "conexion", "x", "");
                y = IniGet(archivo, "conexion", "y", "");
                pantalla = IniGet(archivo, "conexion", "pantalla", "");
                ancho = IniGet(archivo, "conexion", "ancho", "");
                alto = IniGet(archivo, "conexion", "alto", "");
                xa = IniGet(archivo, "conexion", "xa", "");
                ya = IniGet(archivo, "conexion", "ya", "");
                //con = new MySqlConnection("server=127.0.0.1; database=bdccfceat; Uid=root; pwd=;");
                con = new MySqlConnection("server='" + sv + "'; database='" + bd + "'; Uid='" + us + "' ; pwd='"+ psw2 +"';");
                con.Open();
            }
            catch
            {
                MessageBox.Show("Error con la conexión con el servidor");
                con.Close();
            }

            


        }
        
        public string obtenercc()
        {
            string wcc = "";
            wcc = IniGet(archivo, "conexion", "cc", "");
            return wcc;
        }
        public int verificar()
        {
            int x = 0;
            if (File.Exists(archivo))
            {
                x = 1;
            }
            else
            {
                MessageBox.Show("Error, Favor de comunicarte con el Programador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                x = 0;
            }
            return x;




        }

    }
}
