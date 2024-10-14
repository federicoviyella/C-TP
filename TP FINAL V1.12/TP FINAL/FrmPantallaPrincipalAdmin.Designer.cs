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
            this.chkDarDeBaja = new System.Windows.Forms.CheckBox();
            this.chkPermitirEdicion = new System.Windows.Forms.CheckBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.btnCargar2daGrilla = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.grpPersonaSeleccionada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPersonaSeleccionada
            // 
            this.grpPersonaSeleccionada.Controls.Add(this.chkDarDeBaja);
            this.grpPersonaSeleccionada.Controls.Add(this.chkPermitirEdicion);
            this.grpPersonaSeleccionada.Controls.Add(this.txtDni);
            this.grpPersonaSeleccionada.Controls.Add(this.txtNombres);
            this.grpPersonaSeleccionada.Controls.Add(this.txtApellido);
            this.grpPersonaSeleccionada.Controls.Add(this.lblDni);
            this.grpPersonaSeleccionada.Controls.Add(this.lblNombres);
            this.grpPersonaSeleccionada.Controls.Add(this.lblApellido);
            this.grpPersonaSeleccionada.Location = new System.Drawing.Point(28, 48);
            this.grpPersonaSeleccionada.Name = "grpPersonaSeleccionada";
            this.grpPersonaSeleccionada.Size = new System.Drawing.Size(661, 178);
            this.grpPersonaSeleccionada.TabIndex = 2;
            this.grpPersonaSeleccionada.TabStop = false;
            this.grpPersonaSeleccionada.Text = "Persona Seleccionada";
            this.grpPersonaSeleccionada.Enter += new System.EventHandler(this.grpPersonaSeleccionada_Enter);
            // 
            // chkDarDeBaja
            // 
            this.chkDarDeBaja.AutoSize = true;
            this.chkDarDeBaja.Location = new System.Drawing.Point(447, 79);
            this.chkDarDeBaja.Name = "chkDarDeBaja";
            this.chkDarDeBaja.Size = new System.Drawing.Size(91, 17);
            this.chkDarDeBaja.TabIndex = 7;
            this.chkDarDeBaja.Text = "Dado de Baja";
            this.chkDarDeBaja.UseVisualStyleBackColor = true;
            // 
            // chkPermitirEdicion
            // 
            this.chkPermitirEdicion.AutoSize = true;
            this.chkPermitirEdicion.Location = new System.Drawing.Point(447, 102);
            this.chkPermitirEdicion.Name = "chkPermitirEdicion";
            this.chkPermitirEdicion.Size = new System.Drawing.Size(98, 17);
            this.chkPermitirEdicion.TabIndex = 8;
            this.chkPermitirEdicion.Text = "Permitir Edicion";
            this.chkPermitirEdicion.UseVisualStyleBackColor = true;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(31, 99);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 6;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(447, 32);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(100, 20);
            this.txtNombres.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(31, 41);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 4;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(28, 83);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "DNI";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(444, 16);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(49, 13);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombres";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(28, 24);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido";
            // 
            // btnCargar2daGrilla
            // 
            this.btnCargar2daGrilla.Location = new System.Drawing.Point(569, 395);
            this.btnCargar2daGrilla.Name = "btnCargar2daGrilla";
            this.btnCargar2daGrilla.Size = new System.Drawing.Size(103, 43);
            this.btnCargar2daGrilla.TabIndex = 7;
            this.btnCargar2daGrilla.Text = "Cargar 2da Grilla";
            this.btnCargar2daGrilla.UseVisualStyleBackColor = true;
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
            this.dgvUsuarios.Location = new System.Drawing.Point(47, 232);
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
            this.dgvUsuarios.Size = new System.Drawing.Size(642, 150);
            this.dgvUsuarios.TabIndex = 6;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonalizado_CellContentClick);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(25, 18);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(35, 13);
            this.lblAdmin.TabIndex = 9;
            this.lblAdmin.Text = "label1";
            // 
            // FrmPantallaPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.btnCargar2daGrilla);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.grpPersonaSeleccionada);
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
        private System.Windows.Forms.CheckBox chkDarDeBaja;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.CheckBox chkPermitirEdicion;
        private System.Windows.Forms.Button btnCargar2daGrilla;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lblAdmin;
    }
}