namespace TP_FINAL
{
    partial class FrmPantallaPrincipal
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
            this.lblNombreUser = new System.Windows.Forms.Label();
            this.tbNivelUsuarioBienvenida = new System.Windows.Forms.TextBox();
            this.lblNivelUsuarioUser = new System.Windows.Forms.Label();
            this.tbUsuarioBienvenida = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreUser
            // 
            this.lblNombreUser.AutoSize = true;
            this.lblNombreUser.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUser.Location = new System.Drawing.Point(12, 199);
            this.lblNombreUser.Name = "lblNombreUser";
            this.lblNombreUser.Size = new System.Drawing.Size(83, 22);
            this.lblNombreUser.TabIndex = 2;
            this.lblNombreUser.Text = "Nombre:";
            this.lblNombreUser.Click += new System.EventHandler(this.lblNombreUser_Click);
            // 
            // tbNivelUsuarioBienvenida
            // 
            this.tbNivelUsuarioBienvenida.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNivelUsuarioBienvenida.Location = new System.Drawing.Point(370, 228);
            this.tbNivelUsuarioBienvenida.Multiline = true;
            this.tbNivelUsuarioBienvenida.Name = "tbNivelUsuarioBienvenida";
            this.tbNivelUsuarioBienvenida.Size = new System.Drawing.Size(181, 29);
            this.tbNivelUsuarioBienvenida.TabIndex = 3;
            this.tbNivelUsuarioBienvenida.TextChanged += new System.EventHandler(this.tbNivelUsuarioBienvenida_TextChanged);
            // 
            // lblNivelUsuarioUser
            // 
            this.lblNivelUsuarioUser.AutoSize = true;
            this.lblNivelUsuarioUser.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelUsuarioUser.Location = new System.Drawing.Point(366, 199);
            this.lblNivelUsuarioUser.Name = "lblNivelUsuarioUser";
            this.lblNivelUsuarioUser.Size = new System.Drawing.Size(152, 22);
            this.lblNivelUsuarioUser.TabIndex = 4;
            this.lblNivelUsuarioUser.Text = "Nivel de Usuario:";
            this.lblNivelUsuarioUser.Click += new System.EventHandler(this.lblNivelUsuarioUser_Click);
            // 
            // tbUsuarioBienvenida
            // 
            this.tbUsuarioBienvenida.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuarioBienvenida.Location = new System.Drawing.Point(15, 228);
            this.tbUsuarioBienvenida.Name = "tbUsuarioBienvenida";
            this.tbUsuarioBienvenida.Size = new System.Drawing.Size(156, 29);
            this.tbUsuarioBienvenida.TabIndex = 5;
            this.tbUsuarioBienvenida.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP_FINAL.Properties.Resources.Sin_títuasdlo;
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(588, 151);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(664, 439);
            this.Controls.Add(this.tbUsuarioBienvenida);
            this.Controls.Add(this.lblNivelUsuarioUser);
            this.Controls.Add(this.tbNivelUsuarioBienvenida);
            this.Controls.Add(this.lblNombreUser);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmPantallaPrincipal";
            this.Text = "FrmPantallaPrincipal";
            this.Load += new System.EventHandler(this.FrmPantallaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNombreUser;
        private System.Windows.Forms.TextBox tbNivelUsuarioBienvenida;
        private System.Windows.Forms.Label lblNivelUsuarioUser;
        private System.Windows.Forms.TextBox tbUsuarioBienvenida;
    }
}