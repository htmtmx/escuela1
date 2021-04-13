namespace escuela1.vista
{
    partial class frm_principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.lblNameUser = new System.Windows.Forms.Label();
            this.lblCountAlumnos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCountProfesores = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gridAlumnos1 = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridProfesores1 = new System.Windows.Forms.DataGridView();
            this.numeroprof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noempleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreprof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditarAlumno = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAgregarProfesor = new System.Windows.Forms.Button();
            this.btnEditarProfesor = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btnResetearPWD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlumnos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfesores1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bienvenido";
            // 
            // lblNameUser
            // 
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.Location = new System.Drawing.Point(129, 28);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(97, 17);
            this.lblNameUser.TabIndex = 1;
            this.lblNameUser.Text = "<Name_user>";
            // 
            // lblCountAlumnos
            // 
            this.lblCountAlumnos.AutoSize = true;
            this.lblCountAlumnos.Location = new System.Drawing.Point(27, 304);
            this.lblCountAlumnos.Name = "lblCountAlumnos";
            this.lblCountAlumnos.Size = new System.Drawing.Size(123, 17);
            this.lblCountAlumnos.TabIndex = 3;
            this.lblCountAlumnos.Text = "<Count_Alumnos>";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Alumnos";
            // 
            // lblCountProfesores
            // 
            this.lblCountProfesores.AutoSize = true;
            this.lblCountProfesores.Location = new System.Drawing.Point(28, 517);
            this.lblCountProfesores.Name = "lblCountProfesores";
            this.lblCountProfesores.Size = new System.Drawing.Size(138, 17);
            this.lblCountProfesores.TabIndex = 4;
            this.lblCountProfesores.Text = "<Count_Profesores>";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 29);
            this.label9.TabIndex = 5;
            this.label9.Text = "Profesores";
            // 
            // gridAlumnos1
            // 
            this.gridAlumnos1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlumnos1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.matricula,
            this.nombre,
            this.correo,
            this.edad,
            this.registro,
            this.estatus});
            this.gridAlumnos1.Location = new System.Drawing.Point(28, 151);
            this.gridAlumnos1.Name = "gridAlumnos1";
            this.gridAlumnos1.RowTemplate.Height = 24;
            this.gridAlumnos1.Size = new System.Drawing.Size(690, 150);
            this.gridAlumnos1.TabIndex = 6;
            this.gridAlumnos1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAlumnos1_CellContentClick);
            this.gridAlumnos1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridAlumnos1_MouseClick);
            // 
            // numero
            // 
            this.numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numero.HeaderText = "#";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 41;
            // 
            // matricula
            // 
            this.matricula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.matricula.HeaderText = "Matricula";
            this.matricula.Name = "matricula";
            this.matricula.ReadOnly = true;
            this.matricula.Width = 90;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // correo
            // 
            this.correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            this.correo.Width = 76;
            // 
            // edad
            // 
            this.edad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.edad.HeaderText = "Edad";
            this.edad.Name = "edad";
            this.edad.ReadOnly = true;
            this.edad.Width = 66;
            // 
            // registro
            // 
            this.registro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.registro.HeaderText = "Registro";
            this.registro.Name = "registro";
            this.registro.ReadOnly = true;
            this.registro.Width = 86;
            // 
            // estatus
            // 
            this.estatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.estatus.HeaderText = "Estado";
            this.estatus.Name = "estatus";
            this.estatus.ReadOnly = true;
            this.estatus.Width = 77;
            // 
            // gridProfesores1
            // 
            this.gridProfesores1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProfesores1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroprof,
            this.noempleado,
            this.nombreprof,
            this.salario,
            this.usuario,
            this.estado,
            this.pw});
            this.gridProfesores1.Location = new System.Drawing.Point(28, 373);
            this.gridProfesores1.Name = "gridProfesores1";
            this.gridProfesores1.RowTemplate.Height = 24;
            this.gridProfesores1.Size = new System.Drawing.Size(690, 141);
            this.gridProfesores1.TabIndex = 7;
            this.gridProfesores1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProfesores1_CellContentClick);
            this.gridProfesores1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridProfesores1_MouseClick);
            // 
            // numeroprof
            // 
            this.numeroprof.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numeroprof.HeaderText = "#";
            this.numeroprof.Name = "numeroprof";
            this.numeroprof.ReadOnly = true;
            this.numeroprof.Width = 41;
            // 
            // noempleado
            // 
            this.noempleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.noempleado.HeaderText = "# Empleado";
            this.noempleado.Name = "noempleado";
            this.noempleado.ReadOnly = true;
            this.noempleado.Width = 99;
            // 
            // nombreprof
            // 
            this.nombreprof.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreprof.HeaderText = "Nombre";
            this.nombreprof.Name = "nombreprof";
            this.nombreprof.ReadOnly = true;
            // 
            // salario
            // 
            this.salario.HeaderText = "Salario";
            this.salario.Name = "salario";
            this.salario.ReadOnly = true;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // pw
            // 
            this.pw.HeaderText = "pw";
            this.pw.Name = "pw";
            this.pw.ReadOnly = true;
            // 
            // btnEditarAlumno
            // 
            this.btnEditarAlumno.Enabled = false;
            this.btnEditarAlumno.Location = new System.Drawing.Point(485, 116);
            this.btnEditarAlumno.Name = "btnEditarAlumno";
            this.btnEditarAlumno.Size = new System.Drawing.Size(140, 29);
            this.btnEditarAlumno.TabIndex = 8;
            this.btnEditarAlumno.Text = "<Editar>";
            this.btnEditarAlumno.UseVisualStyleBackColor = true;
            this.btnEditarAlumno.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(643, 116);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 29);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnAgregarProfesor
            // 
            this.btnAgregarProfesor.Location = new System.Drawing.Point(643, 338);
            this.btnAgregarProfesor.Name = "btnAgregarProfesor";
            this.btnAgregarProfesor.Size = new System.Drawing.Size(75, 29);
            this.btnAgregarProfesor.TabIndex = 11;
            this.btnAgregarProfesor.Text = "Agregar";
            this.btnAgregarProfesor.UseVisualStyleBackColor = true;
            this.btnAgregarProfesor.Click += new System.EventHandler(this.btnAgregarProfesor_Click);
            // 
            // btnEditarProfesor
            // 
            this.btnEditarProfesor.Enabled = false;
            this.btnEditarProfesor.Location = new System.Drawing.Point(485, 338);
            this.btnEditarProfesor.Name = "btnEditarProfesor";
            this.btnEditarProfesor.Size = new System.Drawing.Size(140, 29);
            this.btnEditarProfesor.TabIndex = 10;
            this.btnEditarProfesor.Text = "Editar";
            this.btnEditarProfesor.UseVisualStyleBackColor = true;
            this.btnEditarProfesor.Click += new System.EventHandler(this.btnEditarProfesor_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(671, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 29);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button9_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(264, 28);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 22);
            this.txtBuscar.TabIndex = 13;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "<quees>";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(478, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(187, 29);
            this.button5.TabIndex = 15;
            this.button5.Text = "Modificar Contraseña";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // btnResetearPWD
            // 
            this.btnResetearPWD.Enabled = false;
            this.btnResetearPWD.Location = new System.Drawing.Point(292, 338);
            this.btnResetearPWD.Name = "btnResetearPWD";
            this.btnResetearPWD.Size = new System.Drawing.Size(187, 29);
            this.btnResetearPWD.TabIndex = 16;
            this.btnResetearPWD.Text = "Resetear Contraseña";
            this.btnResetearPWD.UseVisualStyleBackColor = true;
            this.btnResetearPWD.Click += new System.EventHandler(this.btnResetearPWD_Click);
            // 
            // frm_principal
            // 
            this.ClientSize = new System.Drawing.Size(740, 589);
            this.ControlBox = false;
            this.Controls.Add(this.btnResetearPWD);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAgregarProfesor);
            this.Controls.Add(this.btnEditarProfesor);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEditarAlumno);
            this.Controls.Add(this.gridProfesores1);
            this.Controls.Add(this.gridAlumnos1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblCountProfesores);
            this.Controls.Add(this.lblCountAlumnos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblNameUser);
            this.Controls.Add(this.label4);
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAlumnos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfesores1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gridAlumnos;
        private System.Windows.Forms.DataGridView gridProfesores;
        private System.Windows.Forms.Label lblContAlumnos;
        private System.Windows.Forms.Label lblContProfesores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNameUser;
        private System.Windows.Forms.Label lblCountAlumnos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCountProfesores;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView gridAlumnos1;
        private System.Windows.Forms.DataGridView gridProfesores1;
        private System.Windows.Forms.Button btnEditarAlumno;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAgregarProfesor;
        private System.Windows.Forms.Button btnEditarProfesor;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatus;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroprof;
        private System.Windows.Forms.DataGridViewTextBoxColumn noempleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreprof;
        private System.Windows.Forms.DataGridViewTextBoxColumn salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn pw;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnResetearPWD;
    }
}