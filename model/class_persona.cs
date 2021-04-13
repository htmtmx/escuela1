using escuela1.control;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escuela1.model
{
    public class class_persona
    {
        MySqlCommand cmd;
        MySqlDataReader reader;
        long id_persona;

        public long Id_persona
        {
            get { return id_persona; }
            set { id_persona = value; }
        }
        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        string apaterno;

        public string Apaterno
        {
            get { return apaterno; }
            set { apaterno = value; }
        }
        string amaterno;

        public string Amaterno
        {
            get { return amaterno; }
            set { amaterno = value; }
        }
        //
        //Metodo que inserta o actualiza a la persona ---> 0 es una actualizacion      1 es un insert
        public bool insertUpdatePersona(class_persona persona, int tipo)
        {
            //Ya debe traer un ID creado
            string s_insert = "INSERT INTO `personas` (`id_persona`, `nombre`, `apaterno`, `amaterno`)" +
     " VALUES ('" + persona.Id_persona + "', '" + persona.Nombre + "', '" + persona.Apaterno + "', '" + persona.Amaterno + "')";
            //Ya tiene ID
            string s_update = "UPDATE `personas` SET `id_persona` = '"+persona.Id_persona+"', `nombre` = '"+persona.Nombre+"', `apaterno` = '"+persona.Apaterno+"', `amaterno` = '"+persona.Amaterno+"' WHERE `personas`.`id_persona` = "+persona.Id_persona+"";

            //Decision de que tipo de query se ejecutara
            string s_query = tipo != 0 ? s_insert : s_update;

            //SINGLETON de conexion
            conexion CONN = conexion.getInstance;

            //if (tipo == 1)
            //{
            //    s_query = s_insert;
            //}
            //else
            //{
            //    s_query = s_update;
            //}
            try
            {
                //Metodos de la conexion
                CONN.Cn.Open();
                cmd = new MySqlCommand(s_query, CONN.Cn);
                cmd.ExecuteReader();
                CONN.Cn.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
        
    }
}
