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
    public class class_profesor : class_persona
    {
        MySqlCommand cmd;
        MySqlDataReader reader;
        long no_empleado;

        public long No_empleado
        {
            get { return no_empleado; }
            set { no_empleado = value; }
        }
        long id_persona_fk;

        public long Id_persona_fk
        {
            get { return id_persona_fk; }
            set { id_persona_fk = value; }
        }
        decimal salario;

        public decimal Salario
        {
            get { return salario; }
            set { salario = value; }
        }        
        string usuario;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        string pwd;

        public string Pwd
        {
            get { return pwd; }
            set { pwd = value; }
        }
        bool estatus;

        public bool Estatus
        {
            get { return estatus; }
            set { estatus = value; }
        }
        public bool insertUpdateProfesor(class_profesor profesor, int tipo)
        {
            string s_insert = "INSERT INTO `profesor` (`no_empleado`, `id_persona_fk`, `salario`, `usuario`, `pwd`, `estatus`) VALUES ('" + profesor.No_empleado + "', '" + profesor.Id_persona_fk + "', '" + profesor.Salario + "', '" + profesor.Usuario + "', '" + profesor.Pwd + "', '" + (profesor.Estatus ? 1 : 0) + "')";

            string s_update = "UPDATE `profesor` SET `no_empleado` = '" + profesor.No_empleado + "', `id_persona_fk` = '" + profesor.Id_persona_fk + "', `salario` = '" + profesor.Salario + "', `usuario` = '" + profesor.Usuario + "',  `estatus` = '" + (profesor.Estatus ? 1 : 0) + "' WHERE `profesor`.`id_persona_fk` = " + profesor.Id_persona_fk + "";

            string s_query = tipo != 0 ? s_insert : s_update;
            conexion CONN = conexion.getInstance;
            Console.WriteLine(s_query);
            try
            {
                CONN.Cn.Open();
                cmd = new MySqlCommand(s_query, CONN.Cn);
                cmd.ExecuteReader();
                CONN.Cn.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al registrar/actualizar profesor" + e);
                return false;
                Console.WriteLine(s_query);
            }
        }

        public bool reserPw(class_profesor profesor)
        {
            //Resetear contraseña y cambiar
            //Resetear, lo pone en 0000
            //Cambiar, poner cualquier contraseña
            genClaves g = new genClaves();
            string pwreset = g.encriptaMD5("0000");
            string s_query = "UPDATE pw = " + pwreset;// C O M P L E T A R               Q U E R Y
            conexion CONN = conexion.getInstance;
            Console.WriteLine(s_query);
            try
            {
                CONN.Cn.Open();
                cmd = new MySqlCommand(s_query, CONN.Cn);
                cmd.ExecuteReader();
                CONN.Cn.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al registrar/actualizar profesor" + e);
                return false;
                Console.WriteLine(s_query);
            }
        }

        public bool revisaProfesor(class_profesor p)
        {
            if (p.No_empleado.Equals(""))
                return false;
            if (String.IsNullOrEmpty(p.Nombre))
                return false;
            if (String.IsNullOrEmpty(p.Apaterno))
                return false;
            if (String.IsNullOrEmpty(p.Amaterno))
                return false;
            if (p.Salario.Equals(""))
                return false;
            if (String.IsNullOrEmpty(p.Usuario))
                return false;
            if (String.IsNullOrEmpty(p.Pwd))
                return false;
            return true;
            
        }
        public List<class_profesor> consultaProfesores(string filtro)
        {
            List<class_profesor> tempList = new List<class_profesor>();
            class_profesor objProfesor = null;
            string s_query = "SELECT " +
                "pr.`no_empleado`," +
                "pr.`id_persona_fk`," +
                "pr.`salario`," +
                "pr.`usuario`," +
                "pr.`pwd`," +
                "pr.`estatus`," +
                "per.`id_persona`," +
                "per.`nombre`," +
                "per.`apaterno`," +
                "per.`amaterno` " +
                "FROM `profesor` pr, `personas` per " +
                "WHERE per.`id_persona` = pr.`id_persona_fk`" + filtro + "";
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
                        objProfesor = new class_profesor();
                        objProfesor.No_empleado = Convert.ToInt64(reader.GetString("no_empleado"));
                        objProfesor.Id_persona_fk = Convert.ToInt64(reader.GetString("id_persona_fk"));
                        objProfesor.Salario = Convert.ToDecimal(reader.GetString("salario"));
                        objProfesor.Usuario = reader.GetString("usuario");
                        objProfesor.Pwd = reader.GetString("pwd");
                        //objAlumno.Estatus = reader.GetString("estatus") == "1" ? true : false;
                        objProfesor.Estatus = Convert.ToInt32(reader.GetString("estatus")) == 1 ? true : false;
                        objProfesor.Nombre = reader.GetString("nombre");
                        objProfesor.Apaterno = reader.GetString("apaterno");
                        objProfesor.Amaterno = reader.GetString("amaterno");
                        objProfesor.Id_persona = objProfesor.Id_persona_fk;
                        //Agregamos el objeto a la lista
                        tempList.Add(objProfesor);
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

        //SQL INSERT profesor
        //INSERT INTO `profesor` (`no_empleado`, `id_persona_fk`, `salario`, `usuario`, `pwd`, `estatus`) VALUES ('159753', '123456789', '16000', 'profeprueba', '123456', '1');
    }
}
