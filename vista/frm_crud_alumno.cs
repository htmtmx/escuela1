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
    public partial class frm_crud_alumno : Form
    {
        int _Accion;
        class_alumno _Alumno;
        public frm_crud_alumno(int accion)
        {
            this._Accion = accion;
            InitializeComponent();
        }
        public frm_crud_alumno(int accion, class_alumno alu)
        {
            this._Accion = accion;
            this._Alumno = alu;
            InitializeComponent();
        }

        private void frm_crud_alumno_Load(object sender, EventArgs e)
        {
            pickNacimiento.MaxDate = DateTime.Now;
            rellenaCampos();
        }

        private void rellenaCampos()
        {
            //1 es agregar          0 es editar
            if (_Accion == 1)
            {
                lblTitulo.Text = "Llene los campos para agregar un nuevo alumno";
                btnAction.Text = "Guardar";
            }
            else
            {
                this.Text = "Actualizar a " + _Alumno.Id_persona;
                lblRegistro.Visible = true;
                txtFechaRegistro.Visible = true;
                lblTitulo.Text = "Editar datos de " + _Alumno.Nombre + " " + _Alumno.Apaterno + " " + _Alumno.Amaterno;
                btnAction.Text = "Actualizar";
                txtMatricula.Text = _Alumno.Matricula.ToString();
                txtNombre.Text = _Alumno.Nombre;
                txtApaterno.Text = _Alumno.Apaterno;
                txtAmaterno.Text = _Alumno.Amaterno;
                txtCorreo.Text = _Alumno.Correo;
                txtFechaRegistro.Text = _Alumno.Fecha_registro.ToLongDateString() + " " + _Alumno.Fecha_registro.ToLongTimeString();
                pickNacimiento.Value = _Alumno.Fecha_nacimiento;
                cboEstatus.Checked = _Alumno.Estatus;
                btnAction.Text = "Actualizar";
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            class_alumno tempAlumno = new class_alumno();
            genClaves clave = new genClaves();
            try{tempAlumno.Matricula = Convert.ToInt64(txtMatricula.Text);
            }catch (Exception){MessageBox.Show("El formato de la matricula es incorrecto o esta vacío");}
            tempAlumno.Id_persona = _Accion == 1 ? clave.generaCodigoEstudiante() : _Alumno.Id_persona;
            tempAlumno.Id_persona_fk = tempAlumno.Id_persona;
            tempAlumno.Nombre = txtNombre.Text;
            tempAlumno.Apaterno = txtApaterno.Text;
            tempAlumno.Amaterno = txtAmaterno.Text;
            tempAlumno.Correo = txtCorreo.Text;
            tempAlumno.Fecha_nacimiento = pickNacimiento.Value;
            tempAlumno.Estatus = cboEstatus.Checked;
            
            if (tempAlumno.revisaAlumno(tempAlumno))
            {
                if (tempAlumno.insertUpdatePersona(tempAlumno, _Accion))
                {
                    if (!tempAlumno.insertUpdateAlumno(tempAlumno, _Accion))
                        MessageBox.Show("Ocurrrio un error al " + (_Accion == 1 ? "registrar" : "aztualizar") + "");
                    else
                        this.Close();
                }

                else
                {
                    MessageBox.Show("Errrorr");
                }
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            
        }
    }
}
