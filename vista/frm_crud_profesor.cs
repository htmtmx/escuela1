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
    public partial class frm_crud_profesor : Form
    {
        int _Accion;
        class_profesor _Profesor;
        public frm_crud_profesor(int accion)
        {
            this._Accion = accion;
            InitializeComponent();
        }
        public frm_crud_profesor(int accion, class_profesor prof)
        {
            this._Accion = accion;
            this._Profesor = prof;
            InitializeComponent();
        }

        private void frm_crud_profesor_Load(object sender, EventArgs e)
        {
            rellenaCampos();
        }
        private void rellenaCampos()
        {
            //      1 es AGREGAR            0 es ACTUALIZAR
            if (_Accion == 1)
            {
                lblTitulo.Text = "Llene los campos para registrar un nuevo profesor";
                btnAccionProf.Text = "Guardar";
            }
            else
            {
                this.Text = "Actualizar a " + _Profesor.Nombre;
                lblNoEmpleado.Visible = true;
                txtNoEmpleado.Visible = true;
                lblTitulo.Text = "Editar datos de " + _Profesor.Nombre + " " + _Profesor.Apaterno + " " + _Profesor.Amaterno;
                btnAccionProf.Text = "Actualizar";
                txtNoEmpleado.Text = _Profesor.No_empleado.ToString();
                txtNombre.Text = _Profesor.Nombre;
                txtApaterno.Text = _Profesor.Apaterno;
                txtAmaterno.Text = _Profesor.Amaterno;
                txtSalario.Text = _Profesor.Salario.ToString();
                txtUsuario.Text = _Profesor.Usuario;
                cboEstatus.Checked = _Profesor.Estatus;
            }
        }
        private void btnAccionProf_Click(object sender, EventArgs e)
        {
            class_profesor tempProfesor = new class_profesor();
            genClaves claseClave = new genClaves();

            tempProfesor.Id_persona = _Accion == 1 ? claseClave.generaIdPersona() : _Profesor.Id_persona;
            tempProfesor.Id_persona_fk = tempProfesor.Id_persona;
            tempProfesor.Nombre = txtNombre.Text;
            tempProfesor.Apaterno = txtApaterno.Text;
            tempProfesor.Amaterno = txtAmaterno.Text;
            tempProfesor.No_empleado = claseClave.generaNoEmpleadoProfesor();
            tempProfesor.Salario = Convert.ToDecimal(txtSalario.Text);
            tempProfesor.Usuario =txtUsuario.Text;
            tempProfesor.Pwd = _Accion == 1 ? claseClave.encriptaMD5("0000") : "";
            tempProfesor.Estatus = cboEstatus.Checked;

            if (tempProfesor.revisaProfesor(tempProfesor))
            {
                if (tempProfesor.insertUpdatePersona(tempProfesor, _Accion))
                {
                    if (!tempProfesor.insertUpdateProfesor(tempProfesor, _Accion))
                        MessageBox.Show("Ocurrio un error al " + (_Accion == 1 ? "registrar" : "actualizar") + "");
                    else
                        this.Close();
                }
                else
                {
                    MessageBox.Show("Errrorrr");
                }
            }
            else
            {
                MessageBox.Show("Por favor, llene todos los campos");
            }
        }

        
    }
}
