namespace escuela1.vista
{
    partial class frm_modificaPWD
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
            this.btnCambiarPWD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPwdActual = new System.Windows.Forms.TextBox();
            this.txtPwdNueva = new System.Windows.Forms.TextBox();
            this.txtPwdConfirm = new System.Windows.Forms.TextBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCambiarPWD
            // 
            this.btnCambiarPWD.Location = new System.Drawing.Point(206, 169);
            this.btnCambiarPWD.Name = "btnCambiarPWD";
            this.btnCambiarPWD.Size = new System.Drawing.Size(102, 36);
            this.btnCambiarPWD.TabIndex = 0;
            this.btnCambiarPWD.Text = "Actualizar";
            this.btnCambiarPWD.UseVisualStyleBackColor = true;
            this.btnCambiarPWD.Click += new System.EventHandler(this.btnCambiarPWD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contraseña actual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nueva Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirmar Contraseña:";
            // 
            // txtPwdActual
            // 
            this.txtPwdActual.Location = new System.Drawing.Point(267, 44);
            this.txtPwdActual.Name = "txtPwdActual";
            this.txtPwdActual.PasswordChar = '●';
            this.txtPwdActual.Size = new System.Drawing.Size(100, 22);
            this.txtPwdActual.TabIndex = 4;
            // 
            // txtPwdNueva
            // 
            this.txtPwdNueva.Location = new System.Drawing.Point(267, 85);
            this.txtPwdNueva.Name = "txtPwdNueva";
            this.txtPwdNueva.PasswordChar = '●';
            this.txtPwdNueva.Size = new System.Drawing.Size(100, 22);
            this.txtPwdNueva.TabIndex = 5;
            // 
            // txtPwdConfirm
            // 
            this.txtPwdConfirm.Location = new System.Drawing.Point(267, 125);
            this.txtPwdConfirm.Name = "txtPwdConfirm";
            this.txtPwdConfirm.PasswordChar = '●';
            this.txtPwdConfirm.Size = new System.Drawing.Size(100, 22);
            this.txtPwdConfirm.TabIndex = 6;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(168, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(54, 17);
            this.lbltitulo.TabIndex = 7;
            this.lbltitulo.Text = "<titulo>";
            // 
            // frm_modificaPWD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 227);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.txtPwdConfirm);
            this.Controls.Add(this.txtPwdNueva);
            this.Controls.Add(this.txtPwdActual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCambiarPWD);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_modificaPWD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cambiar contraseña";
            this.Load += new System.EventHandler(this.frm_modificaPWD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCambiarPWD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPwdActual;
        private System.Windows.Forms.TextBox txtPwdNueva;
        private System.Windows.Forms.TextBox txtPwdConfirm;
        private System.Windows.Forms.Label lbltitulo;
    }
}