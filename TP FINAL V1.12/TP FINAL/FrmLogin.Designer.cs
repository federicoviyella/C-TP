namespace TP_FINAL
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsuarioEmail = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.tbEmailUsuarioLogin = new System.Windows.Forms.TextBox();
            this.tbContraseñaLogin = new System.Windows.Forms.TextBox();
            this.btnRecuperarContraseña = new System.Windows.Forms.Button();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsuarioEmail
            // 
            this.lblUsuarioEmail.AutoSize = true;
            this.lblUsuarioEmail.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioEmail.Location = new System.Drawing.Point(93, 33);
            this.lblUsuarioEmail.Name = "lblUsuarioEmail";
            this.lblUsuarioEmail.Size = new System.Drawing.Size(233, 24);
            this.lblUsuarioEmail.TabIndex = 0;
            this.lblUsuarioEmail.Text = "Ingrese Usuario o Email";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(150, 119);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(119, 24);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña";
            this.lblContraseña.Click += new System.EventHandler(this.lblContraseña_Click);
            // 
            // tbEmailUsuarioLogin
            // 
            this.tbEmailUsuarioLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbEmailUsuarioLogin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailUsuarioLogin.Location = new System.Drawing.Point(95, 69);
            this.tbEmailUsuarioLogin.Multiline = true;
            this.tbEmailUsuarioLogin.Name = "tbEmailUsuarioLogin";
            this.tbEmailUsuarioLogin.Size = new System.Drawing.Size(229, 35);
            this.tbEmailUsuarioLogin.TabIndex = 2;
            this.tbEmailUsuarioLogin.TextChanged += new System.EventHandler(this.tbEmailUsuarioLogin_TextChanged);
            // 
            // tbContraseñaLogin
            // 
            this.tbContraseñaLogin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContraseñaLogin.Location = new System.Drawing.Point(92, 146);
            this.tbContraseñaLogin.Multiline = true;
            this.tbContraseñaLogin.Name = "tbContraseñaLogin";
            this.tbContraseñaLogin.Size = new System.Drawing.Size(235, 38);
            this.tbContraseñaLogin.TabIndex = 3;
            this.tbContraseñaLogin.TextChanged += new System.EventHandler(this.tbContraseñaLogin_TextChanged);
            // 
            // btnRecuperarContraseña
            // 
            this.btnRecuperarContraseña.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperarContraseña.Location = new System.Drawing.Point(92, 205);
            this.btnRecuperarContraseña.Name = "btnRecuperarContraseña";
            this.btnRecuperarContraseña.Size = new System.Drawing.Size(232, 34);
            this.btnRecuperarContraseña.TabIndex = 4;
            this.btnRecuperarContraseña.Text = "Recuperar contraseña";
            this.btnRecuperarContraseña.UseVisualStyleBackColor = true;
            this.btnRecuperarContraseña.Click += new System.EventHandler(this.btnRecuperarContraseña_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Location = new System.Drawing.Point(92, 257);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(232, 65);
            this.btnIniciarSesion.TabIndex = 5;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.Location = new System.Drawing.Point(92, 351);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(235, 52);
            this.btnRegistrarse.TabIndex = 6;
            this.btnRegistrarse.Text = "¿Aun no te registraste?";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(437, 440);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.btnRecuperarContraseña);
            this.Controls.Add(this.tbContraseñaLogin);
            this.Controls.Add(this.tbEmailUsuarioLogin);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuarioEmail);
            this.Name = "FrmLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuarioEmail;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox tbEmailUsuarioLogin;
        private System.Windows.Forms.TextBox tbContraseñaLogin;
        private System.Windows.Forms.Button btnRecuperarContraseña;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Button btnRegistrarse;
    }
}

