namespace TP_FINAL
{
    partial class FrmPantallaPrincipalAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpPersonaSeleccionada = new System.Windows.Forms.GroupBox();
            this.txtNivelUsuario = new System.Windows.Forms.TextBox();
            this.lblNivelUsuario = new System.Windows.Forms.Label();
            this.cmbNivelUsuario = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.lblListaUsuarios = new System.Windows.Forms.Label();
            this.grpPersonaSeleccionada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPersonaSeleccionada
            // 
            this.grpPersonaSeleccionada.Controls.Add(this.txtNivelUsuario);
            this.grpPersonaSeleccionada.Controls.Add(this.lblNivelUsuario);
            this.grpPersonaSeleccionada.Controls.Add(this.cmbNivelUsuario);
            this.grpPersonaSeleccionada.Controls.Add(this.txtEmail);
            this.grpPersonaSeleccionada.Controls.Add(this.txtNombre);
            this.grpPersonaSeleccionada.Controls.Add(this.txtApellido);
            this.grpPersonaSeleccionada.Controls.Add(this.lblEmail);
            this.grpPersonaSeleccionada.Controls.Add(this.lblNombre);
            this.grpPersonaSeleccionada.Controls.Add(this.lblApellido);
            this.grpPersonaSeleccionada.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPersonaSeleccionada.Location = new System.Drawing.Point(29, 12);
            this.grpPersonaSeleccionada.Name = "grpPersonaSeleccionada";
            this.grpPersonaSeleccionada.Size = new System.Drawing.Size(738, 225);
            this.grpPersonaSeleccionada.TabIndex = 2;
            this.grpPersonaSeleccionada.TabStop = false;
            this.grpPersonaSeleccionada.Text = "Datos del usuario:";
            this.grpPersonaSeleccionada.Enter += new System.EventHandler(this.grpPersonaSeleccionada_Enter);
            // 
            // txtNivelUsuario
            // 
            this.txtNivelUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNivelUsuario.Location = new System.Drawing.Point(437, 177);
            this.txtNivelUsuario.Multiline = true;
            this.txtNivelUsuario.Name = "txtNivelUsuario";
            this.txtNivelUsuario.Size = new System.Drawing.Size(292, 32);
            this.txtNivelUsuario.TabIndex = 12;
            // 
            // lblNivelUsuario
            // 
            this.lblNivelUsuario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelUsuario.Location = new System.Drawing.Point(433, 149);
            this.lblNivelUsuario.Name = "lblNivelUsuario";
            this.lblNivelUsuario.Size = new System.Drawing.Size(225, 22);
            this.lblNivelUsuario.TabIndex = 11;
            this.lblNivelUsuario.Text = "Nivel Usuario:";
            this.lblNivelUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbNivelUsuario
            // 
            this.cmbNivelUsuario.FormattingEnabled = true;
            this.cmbNivelUsuario.Location = new System.Drawing.Point(437, 107);
            this.cmbNivelUsuario.Name = "cmbNivelUsuario";
            this.cmbNivelUsuario.Size = new System.Drawing.Size(292, 30);
            this.cmbNivelUsuario.TabIndex = 10;
            this.cmbNivelUsuario.Text = "Seleccione el Nivel del Usuario";
            this.cmbNivelUsuario.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbNivelUsuario.Click += new System.EventHandler(this.cmbNivelUsuario_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(437, 51);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(292, 32);
            this.txtEmail.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(28, 62);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(204, 32);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(28, 160);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(204, 32);
            this.txtApellido.TabIndex = 4;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(433, 25);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(226, 22);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(24, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(192, 22);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(24, 135);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(187, 22);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(560, 243);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(141, 36);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.Location = new System.Drawing.Point(29, 283);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(738, 253);
            this.dgvUsuarios.TabIndex = 6;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonalizado_CellContentClick);
            this.dgvUsuarios.SelectionChanged += new System.EventHandler(this.dgvUsuarios_SelectionChanged);
            // 
            // lblListaUsuarios
            // 
            this.lblListaUsuarios.AutoSize = true;
            this.lblListaUsuarios.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaUsuarios.Location = new System.Drawing.Point(25, 254);
            this.lblListaUsuarios.Name = "lblListaUsuarios";
            this.lblListaUsuarios.Size = new System.Drawing.Size(158, 22);
            this.lblListaUsuarios.TabIndex = 7;
            this.lblListaUsuarios.Text = "Lista de usuarios:";
            this.lblListaUsuarios.Click += new System.EventHandler(this.lblListaUsuarios_Click);
            // 
            // FrmPantallaPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(780, 548);
            this.Controls.Add(this.lblListaUsuarios);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.grpPersonaSeleccionada);
            this.Controls.Add(this.btnEliminar);
            this.Name = "FrmPantallaPrincipalAdmin";
            this.Text = "FrmPantallaPrincipalAdmin";
            this.Load += new System.EventHandler(this.FrmPantallaPrincipalAdmin_Load);
            this.grpPersonaSeleccionada.ResumeLayout(false);
            this.grpPersonaSeleccionada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpPersonaSeleccionada;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.ComboBox cmbNivelUsuario;
        private System.Windows.Forms.TextBox txtNivelUsuario;
        private System.Windows.Forms.Label lblNivelUsuario;
        private System.Windows.Forms.Label lblListaUsuarios;
    }
}