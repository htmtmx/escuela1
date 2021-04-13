using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escuela1.control
{
    class genClaves
    {
        public long generaCodigoEstudiante()
        {
            DateTime hoy = DateTime.Now;
            DateTime inicio = new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0);
            //los dos ultimos dijotos del año, mas los segundos pasados desde el inico del año en curso hasta hoy
            TimeSpan interval = hoy - inicio;
            int value = DateTime.Now.Year - 2000;
            long seconds = Convert.ToInt64(interval.TotalMinutes);
            int seconsNow = DateTime.Now.Second + 10;
            return Convert.ToInt64(value + "" + seconds + "" + seconsNow);
        }
        public long generaIdPersona()
        { 
            long id;
            Random idProf = new Random();
            id = idProf.Next(0,999999999);
            return id;
        }
        public long generaNoEmpleadoProfesor()
        {
            long id;
            Random idProf = new Random();
            id = idProf.Next(0, 999999999);
            return id;
        }
        public string encriptaMD5(string valor)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(valor);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
                        
        }

    }
}
