using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace escuela1.control
{
    class conexion
    {
        private static conexion instance = null;
        MySqlConnection cn; //PATH (LINK) PARA CONECTAR CON LA DB (A QUIEN)

        public MySqlConnection Cn
        {
            get { return cn; }
            set { cn = value; }
        }
        static string ip = "localhost";
        static string puerto = "3306";
        //static string ip = "localhost";
        static string userDB = "root";
        static string pwd = "";
        static string dataBaseName = "escuela1";

        public conexion() 
        {
            try
            {
                //Link del enlace con MySQL
                string link = "datasource=" + ip + ";port=" + puerto + ";username=" + userDB + ";Password=" + pwd + ";database=" + dataBaseName + ";";
                //Prepara la conexion
                Cn = new MySqlConnection(link);

            }
            catch (Exception ex)
            {
                MessageBox.Show("La conexion fallo: " + ex.ToString());
            }
        }
        //S I N G L E T O N
        //Metodo utilizado para regresar la instancia del objeto que esta creao, sino existe, la crea
        public static conexion getInstance
        {
            get
            {
                if (instance == null)
                    instance = new conexion();
                return instance;
            }
        }
    }
}
