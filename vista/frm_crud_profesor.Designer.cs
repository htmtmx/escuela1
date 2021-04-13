namespace escuela1.vista
{
    partial class frm_crud_profesor
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNoEmpleado = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNoEmpleado = new System.Windows.Forms.TextBox();
            this.txtAmaterno = new System.Windows.Forms.TextBox();
            this.txtApaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAccionProf = new System.Windows.Forms.Button();
            this.cboEstatus = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(64, 45);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(129, 17);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "<Accion a realizar>";
            // 
            // lblNoEmpleado
            // 
            this.lblNoEmpleado.AutoSize = true;
            this.lblNoEmpleado.Location = new System.Drawing.Point(67, 116);
            this.lblNoEmpleado.Name = "lblNoEmpleado";
            this.lblNoEmpleado.Size = new System.Drawing.Size(145, 17);
            this.lblNoEmpleado.TabIndex = 9;
            this.lblNoEmpleado.Text = "Numero de Empleado";
            this.lblNoEmpleado.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Primer Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Segundo Apellido";
            // 
            // txtNoEmpleado
            // 
            this.txtNoEmpleado.Enabled = false;
            this.txtNoEmpleado.Location = new System.Drawing.Point(237, 113);
            this.txtNoEmpleado.Name = "txtNoEmpleado";
            this.txtNoEmpleado.Size = new System.Drawing.Size(194, 22);
            this.txtNoEmpleado.TabIndex = 1;
            this.txtNoEmpleado.Visible = false;
            // 
            // txtAmaterno
            // 
            this.txtAmaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAmaterno.Location = new System.Drawing.Point(237, 207);
            this.txtAmaterno.Name = "txtAmaterno";
            this.txtAmaterno.Size = new System.Drawing.Size(194, 22);
            this.txtAmaterno.TabIndex = 4;
            // 
            // txtApaterno
            // 
            this.txtApaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApaterno.Location = new System.Drawing.Point(237, 176);
            this.txtApaterno.Name = "txtApaterno";
            this.txtApaterno.Size = new System.Drawing.Size(194, 22);
            this.txtApaterno.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(237, 143);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(194, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Salario";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(237, 240);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(194, 22);
            this.txtSalario.TabIndex = 5;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(237, 273);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(194, 22);
            this.txtUsuario.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Usuario";
            // 
            // btnAccionProf
            // 
            this.btnAccionProf.Location = new System.Drawing.Point(356, 405);
            this.btnAccionProf.Name = "btnAccionProf";
            this.btnAccionProf.Size = new System.Drawing.Size(90, 31);
            this.btnAccionProf.TabIndex = 8;
            this.btnAccionProf.Text = "<Action>";
            this.btnAccionProf.UseVisualStyleBackColor = true;
            this.btnAccionProf.Click += new System.EventHandler(this.btnAccionProf_Click);
            // 
            // cboEstatus
            // 
            this.cboEstatus.AutoSize = true;
            this.cboEstatus.Checked = true;
            this.cboEstatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboEstatus.Location = new System.Drawing.Point(237, 313);
            this.cboEstatus.Name = "cboEstatus";
            this.cboEstatus.Size = new System.Drawing.Size(68, 21);
            this.cboEstatus.TabIndex = 7;
            this.cboEstatus.Text = "Activo";
            this.cboEstatus.UseVisualStyleBackColor = true;
            // 
            // frm_crud_profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 571);
            this.Controls.Add(this.cboEstatus);
            this.Controls.Add(this.btnAccionProf);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApaterno);
            this.Controls.Add(this.txtAmaterno);
            this.Controls.Add(this.txtNoEmpleado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNoEmpleado);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frm_crud_profesor";
            this.Text = "frm_crud_profesor";
            this.Load += new System.EventHandler(this.frm_crud_profesor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNoEmpleado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNoEmpleado;
        private System.Windows.Forms.TextBox txtAmaterno;
        private System.Windows.Forms.TextBox txtApaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAccionProf;
        private System.Windows.Forms.CheckBox cboEstatus;
    }
}