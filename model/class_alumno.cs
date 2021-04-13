using escuela1.control;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace escuela1.model
{
    public class class_alumno : class_persona
    {
        MySqlCommand cmd;
        MySqlDataReader reader;
        long matricula;

        public long Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        long id_persona_fk;

        public long Id_persona_fk
        {
            get { return id_persona_fk; }
            set { id_persona_fk = value; }
        }
        string correo;

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        DateTime fecha_nacimiento;

        public DateTime Fecha_nacimiento
        {
            get { return fecha_nacimiento; }
            set { fecha_nacimiento = value; }
        }
        DateTime fecha_registro;

        public DateTime Fecha_registro
        {
            get { return fecha_registro; }
            set { fecha_registro = value; }
        }
        bool estatus;

        public bool Estatus
        {
            get { return estatus; }
            set { estatus = value; }
        }
        int edad;

        public int Edad
        {
            get { return DateTime.Now.Year-Fecha_nacimiento.Year; }
            set { edad = value; }
        }
        //-------------------------------------->M E T O D O S    DE    L A    C L A S E
        /// <summary>
        /// Ingresa a la DB un alumno
        /// </summary>
        /// <param name="alumno"> obj de la clase alumno</param>
        /// <param name="tipo">Opcion a realizar 1 es INSERT,  es update</param>
        /// <returns>si registro correctamente regresa verdadero sino falso</returns>
        public bool insertUpdateAlumno(class_alumno alumno, int tipo)
        {
            string s_insert = "INSERT INTO `alumno` (`matricula`, `id_persona_fk`, `correo`, `fecha_nacimiento`, `fecha_registro`, `estatus`) VALUES ('"+alumno.Matricula+"', '"+alumno.Id_persona_fk+"', '"+alumno.Correo+"', '"+alumno.Fecha_nacimiento.ToString("yyyy-MM-dd")+"', '"+DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+"', '"+(alumno.Estatus ? 1 : 0)+"')";

            string s_update = "UPDATE `alumno` SET `matricula` = '" + alumno.Matricula + "', `id_persona_fk` = '" + alumno.Id_persona_fk + "', `correo` = '" + alumno.Correo + "', `fecha_nacimiento` = '" + alumno.Fecha_nacimiento.ToString("yyyy-MM-dd") + "', `estatus` = '" + (alumno.Estatus ? 1 : 0) + "' WHERE `alumno`.`id_persona_fk` = " + alumno.Id_persona_fk + "";
            //Decision de que tipo de query se ejecutara
            string s_query = tipo != 0 ? s_insert : s_update;
            Console.WriteLine(s_query);
            //SINGLETON de conexion
            conexion CONN = conexion.getInstance;
            try
            {
                //Metodos de la conexion
                CONN.Cn.Open();
                cmd = new MySqlCommand(s_query, CONN.Cn);
                cmd.ExecuteReader();
                CONN.Cn.Close();
                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al insertar/actualizar alumno"+e);
                Console.WriteLine(s_query);
                return false;
            }       
        }
        /// <summary>
        /// Revisa el objeto alumno y verifica los campos obligatorios
        /// </summary>
        /// <param name="a">Obj alumno</param>
        /// <returns>Verdadero cuando todo OK o falso cuando los datos estan incompletos</returns>
        public bool revisaAlumno(class_alumno a)
        {
            if (String.IsNullOrEmpty(a.Nombre))
                return false;
            if (String.IsNullOrEmpty(a.Apaterno))
                return false;
            if (String.IsNullOrEmpty(a.Amaterno))
                return false;
            if (String.IsNullOrEmpty(a.Correo))
                return false;
            if (a.Matricula.Equals(""))
                return false;
            return true;
        }
        /// <summary>
        /// Regresa una lista de alumnos en funcion del filtro
        /// </summary>
        /// <param name="filtro"></param>
        /// <returns></returns>
        public List<class_alumno> consultaAlumnos(string filtro)
        {
            List<class_alumno> tempList = new List<class_alumno>();
            class_alumno objAlumno = null;
            string s_query ="SELECT "+
                "al.`matricula`,"+
                "al.`id_persona_fk`,"+
                "al.`correo`,"+
                "al.`fecha_nacimiento`,"+
                "al.`fecha_registro`,"+
                "al.`estatus`,"+
                "per.`id_persona`,"+
                "per.`nombre`,"+
                "per.`apaterno`,"+
                "per.`amaterno` "+
                "FROM `alumno` al, `personas` per "+
                "WHERE per.`id_persona` = al.`id_persona_fk`" + filtro + "";
            Console.WriteLine(s_query);
            //MessageBox.Show(s_query);

            conexion CONN = conexion.getInstance;
            try
            {
                //Metodos de la conexion
                CONN.Cn.Open();
                cmd = new MySqlCommand(s_query, CONN.Cn);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    //hay datos, que regreso SQL
                    while (reader.Read())
                    {
                        objAlumno = new class_alumno();
                        objAlumno.Matricula = Convert.ToInt64(reader.GetString("matricula"));
                        objAlumno.Id_persona_fk = Convert.ToInt64(reader.GetString("id_persona_fk"));
                        objAlumno.Correo = reader.GetString("correo");
                        objAlumno.Fecha_nacimiento = DateTime.Parse(reader.GetString("fecha_nacimiento"));
                        objAlumno.Fecha_registro = DateTime.Parse(reader.GetString("fecha_registro"));
                        //objAlumno.Estatus = reader.GetString("estatus") == "1" ? true : false;
                        objAlumno.Estatus = Convert.ToInt32(reader.GetString("estatus")) == 1 ? true : false;
                        objAlumno.Nombre = reader.GetString("nombre");
                        objAlumno.Apaterno = reader.GetString("apaterno");
                        objAlumno.Amaterno = reader.GetString("amaterno");
                        objAlumno.Id_persona = objAlumno.Id_persona_fk;
                        //Agregamos el objeto a la lista
                        tempList.Add(objAlumno);
                    }
                }
                CONN.Cn.Close();
                return tempList;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Query" + e);
                return null;
            }
        }
    }
}
