using escuela1.control;
using escuela1.model;
using escuela1.vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace escuela1
{
    public partial class Form1 : Form
    {
        class_profesor _Profesor;
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (verificaUsuario(txtUser.Text, txtPwd.Text))
            {
                frm_principal ventana = new frm_principal(this, _Profesor);
                ventana.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                txtPwd.Focus();
            }
            
        }
        public bool verificaUsuario(string user, string pwd)
        {
            if (!(string.IsNullOrEmpty(user)) && !(string.IsNullOrEmpty(pwd)))
            {
                _Profesor = new class_profesor();
                genClaves g = new genClaves();
                string temppwd = g.encriptaMD5(pwd);
                string filtro = " AND pr.usuario = '"+user+"' AND pr.pwd = '"+ temppwd +"'";
                List<class_profesor> listProf = new List<class_profesor>();
                listProf = _Profesor.consultaProfesores(filtro);
                if (listProf.Count == 1) //Si es = 1 tiene una fila, un profesor
                {
                    _Profesor = listProf[0];
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
