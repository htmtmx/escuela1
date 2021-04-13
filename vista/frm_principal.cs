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
    public partial class frm_principal : Form
    {
        Form _Form;
        List<class_alumno> _listAlumnos;
        List<class_profesor> _listProfesores;
        class_alumno _AlumnoSelect = new class_alumno();
        class_profesor _ProfesorSelect = new class_profesor();
        public static class_profesor _ProfesorLog = new class_profesor();


        public frm_principal(Form formAnterior, class_profesor profesor)
        {
            _ProfesorLog = profesor;
            this._Form = formAnterior;
            this._Form.Hide();
            InitializeComponent();
            lblNameUser.Text = ""+ profesor.Nombre + " "+ profesor.Apaterno + " " + profesor.Amaterno;
            btnEditarAlumno.Text = "Seleccione un registro para editar";
            btnEditarProfesor.Text = "Seleccione un registro para editar";
            genClaves g = new genClaves();
            if (g.encriptaMD5("0000").Equals(_ProfesorLog.Pwd))
            {
                MessageBox.Show("Su contraseña es la determinada por default \r\nPor favor, cambiela");

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            _Form.Show();
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            cargarAlumnos();
            cargarProfesores();
        }

        private void cargarAlumnos()
        {
            _listAlumnos = new List<class_alumno>();
            class_alumno tempAl = new class_alumno();
            _listAlumnos = tempAl.consultaAlumnos("");

            if (_listAlumnos != null)
            {
                cargaDatosGridAlumno(_listAlumnos);
            }
        }
        private void cargarProfesores()
        {
            _listProfesores = new List<class_profesor>();
            class_profesor tempProf = new class_profesor();
            _listProfesores = tempProf.consultaProfesores("");

            if (_listProfesores != null)
            {
                cargaDatosGridProfesor(_listProfesores);
            }
        }

        private void cargaDatosGridAlumno(List<class_alumno> _listAlumnos)
        {
            gridAlumnos1.Rows.Clear();
            int i = 0;
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();

            foreach (var alumno in _listAlumnos)
            {
                i++;
                int renglon = gridAlumnos1.Rows.Add();
                gridAlumnos1.Rows[renglon].Cells[0].Value = i;
                gridAlumnos1.Rows[renglon].Cells[1].Value = alumno.Matricula;
                gridAlumnos1.Rows[renglon].Cells[2].Value = alumno.Nombre + " " + alumno.Apaterno + " " + alumno.Amaterno;
                gridAlumnos1.Rows[renglon].Cells[3].Value = alumno.Correo;
                gridAlumnos1.Rows[renglon].Cells[4].Value = alumno.Edad + " años";
                gridAlumnos1.Rows[renglon].Cells[5].Value = alumno.Fecha_registro.ToLongDateString() + " " + alumno.Fecha_registro.ToLongTimeString();
                gridAlumnos1.Rows[renglon].Cells[6].Value = alumno.Estatus ? "ACTIVO" : "INACTIVO";
                gridAlumnos1.Rows[renglon].DefaultCellStyle.BackColor = alumno.Estatus ? Color.GreenYellow : Color.Red;
                data.Add(alumno.Matricula.ToString());

            }
           lblCountAlumnos.Text = "Se encontraron " + _listAlumnos.Count() + " alumnos";
           txtBuscar.AutoCompleteCustomSource = data;
           txtBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
           txtBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }
        private void cargaDatosGridProfesor(List<class_profesor> _listProfesores) 
        {
            gridProfesores1.Rows.Clear();
            int i = 0;

            foreach (var profesor in _listProfesores)
            {
                i++;
                int renglon = gridProfesores1.Rows.Add();
                gridProfesores1.Rows[renglon].Cells[0].Value = i;
                gridProfesores1.Rows[renglon].Cells[1].Value = profesor.No_empleado;
                gridProfesores1.Rows[renglon].Cells[2].Value = profesor.Nombre + " " + profesor.Apaterno + " " + profesor.Amaterno;
                gridProfesores1.Rows[renglon].Cells[3].Value = profesor.Salario;
                gridProfesores1.Rows[renglon].Cells[4].Value = profesor.Usuario;
                gridProfesores1.Rows[renglon].Cells[5].Value = profesor.Estatus ? "ACTIVO" : "INACTIVO";
                gridProfesores1.Rows[renglon].Cells[6].Value = profesor.Pwd;
                gridProfesores1.Rows[renglon].DefaultCellStyle.BackColor = profesor.Estatus ? Color.GreenYellow : Color.Red;
            }
            lblCountProfesores.Text = "Se encontraron " + _listProfesores.Count() + " profesores";
        }


        private int calculaEdad(DateTime fecha)
        {
            return DateTime.Now.Year - fecha.Year;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_crud_alumno formulario = new frm_crud_alumno(1);
            formulario.ShowDialog();
            cargarAlumnos();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_crud_alumno formAlumno = new frm_crud_alumno(0, _AlumnoSelect);
            formAlumno.ShowDialog();
            cargarAlumnos();
        }

        private void gridAlumnos1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                string matricula = gridAlumnos1.Rows[gridAlumnos1.CurrentRow.Index].Cells[1].Value.ToString();
                _AlumnoSelect = _listAlumnos.Find(x => x.Matricula.Equals(Convert.ToInt64(matricula)));
                btnEditarAlumno.Enabled = true;
                btnEditarAlumno.Text = "Editar a " + _AlumnoSelect.Nombre;
                
            }
            catch (Exception)
            {
                btnEditarAlumno.Enabled = false;
                btnEditarAlumno.Text = "Seleccione un registro para editar";
            }
        }

        private void gridAlumnos1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridProfesores1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                string noEmpleado = gridProfesores1.Rows[gridProfesores1.CurrentRow.Index].Cells[1].Value.ToString();
                _ProfesorSelect = _listProfesores.Find(x => x.No_empleado.Equals(Convert.ToInt64(noEmpleado)));
                btnEditarProfesor.Enabled = true;
                btnResetearPWD.Enabled = true;
                btnEditarProfesor.Text = "Editar a " + _ProfesorSelect.Nombre;

            }
            catch (Exception)
            {
                btnEditarProfesor.Enabled = false;
                btnResetearPWD.Enabled = false;
                btnEditarProfesor.Text = "Seleccione un registro para editar";
            }
        }

        private void btnEditarProfesor_Click(object sender, EventArgs e)
        {
            frm_crud_profesor formProfesor = new frm_crud_profesor(0, _ProfesorSelect);
            formProfesor.ShowDialog();
            cargarProfesores();
        }

        private void btnAgregarProfesor_Click(object sender, EventArgs e)
        {
            frm_crud_profesor formulario = new frm_crud_profesor(1);
            formulario.ShowDialog();
            cargarProfesores();
        }

        private void gridProfesores1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnResetearPWD_Click(object sender, EventArgs e)
        {
            if (_ProfesorSelect != null)
            {
                string message = "¿Esta seguro que deseas resetear la contraseña de " +_ProfesorSelect.NombreCompleto + "?";
                string caption = "Resetear contraseña de "+_ProfesorSelect.NombreCompleto+"?";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                // If the no button was pressed ...
                if (result == DialogResult.Yes)
                {
                    if (!_ProfesorSelect.reserPw(_ProfesorSelect, true))
                    {
                        MessageBox.Show("No pudimos resetear la contraseña, error interno");
                    }
                    cargarProfesores();
                }
            }

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            frm_modificaPWD changepwd = new frm_modificaPWD(_ProfesorLog);
            changepwd.ShowDialog();
            cargarProfesores();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarGrid(txtBuscar.Text, "matricula");
        }
        private void BuscarGrid(string TextoABuscar, string Columna)
        {
            var rows = (from item in gridAlumnos1.Rows.Cast<DataGridViewRow>() let clave = Convert.ToString(item.Cells[Columna].Value) where clave == TextoABuscar select item);
            gridAlumnos1.ClearSelection();
            foreach (DataGridViewRow row in rows)
            {
                row.Selected = true;
                gridAlumnos1.CurrentCell = gridAlumnos1.Rows[row.Index].Cells[1];
                break;
            }
        }

    }
}
