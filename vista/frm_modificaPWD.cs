using escuela1.control;
using escuela1.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace escuela1.vista
{
    public partial class frm_modificaPWD : Form
    {
        class_profesor _Profe;
        public frm_modificaPWD(class_profesor profesor)
        {
            this._Profe = profesor;
            InitializeComponent();
        }

        private void btnCambiarPWD_Click(object sender, EventArgs e)
        {
            string pwdActual = txtPwdActual.Text;
            string pwdNueva = txtPwdNueva.Text;
            string pwdConfirm = txtPwdConfirm.Text;
            if (string.IsNullOrEmpty(pwdActual)||string.IsNullOrEmpty(pwdNueva)||string.IsNullOrEmpty(pwdConfirm))
            {
                MessageBox.Show("Llene todos los campos");
            }
            else
            {
                if (pwdNueva.Equals(pwdConfirm) )
                {
                    genClaves g = new genClaves();
                    if (g.encriptaMD5(pwdActual).Equals(_Profe.Pwd))
                    {
                        _Profe.Pwd = pwdNueva;
                        //Modificar contraseña
                        if (!_Profe.reserPw(_Profe, false))
                        {
                            MessageBox.Show("Ocurrio un error");
                        }
                        else
                        {
                            frm_principal._ProfesorLog.Pwd = g.encriptaMD5(pwdNueva);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("La contraseña actual es incorrecta, intentelo de nuevo");
                        txtPwdActual.Focus();
                        txtPwdActual.SelectAll();
                    }
                }
                else
                {
                    
                    MessageBox.Show("Las contraseñas no coinciden");
                    txtPwdNueva.Focus();
                    txtPwdNueva.SelectAll();
                    txtPwdConfirm.Clear();
                }
            }
        }

        private void frm_modificaPWD_Load(object sender, EventArgs e)
        {
            lbltitulo.Text = "Actualizar contraseña de: "+_Profe.NombreCompleto;
        }
    }
}
