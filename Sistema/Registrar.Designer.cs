namespace Sistema
{
    partial class Registrar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtapellidoPaterno = new System.Windows.Forms.TextBox();
            this.TxtapellidoMaterno = new System.Windows.Forms.TextBox();
            this.TxtUsusario = new System.Windows.Forms.TextBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.TxtActivo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CboTipoUsuario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESE NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESE APELLIDO PATERNO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "INGRESE APEDILLO MATERNO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "INGRESE USUARIO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(301, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "INGRESE CONTRASEÑA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(316, 529);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 34);
            this.label6.TabIndex = 5;
            this.label6.Text = "ACTIVO/ INACTIVO";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(665, 353);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(215, 197);
            this.BtnGuardar.TabIndex = 12;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombre.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(338, 40);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(204, 40);
            this.TxtNombre.TabIndex = 13;
            // 
            // TxtapellidoPaterno
            // 
            this.TxtapellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtapellidoPaterno.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtapellidoPaterno.Location = new System.Drawing.Point(338, 135);
            this.TxtapellidoPaterno.Name = "TxtapellidoPaterno";
            this.TxtapellidoPaterno.Size = new System.Drawing.Size(204, 40);
            this.TxtapellidoPaterno.TabIndex = 14;
            // 
            // TxtapellidoMaterno
            // 
            this.TxtapellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtapellidoMaterno.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtapellidoMaterno.Location = new System.Drawing.Point(338, 230);
            this.TxtapellidoMaterno.Name = "TxtapellidoMaterno";
            this.TxtapellidoMaterno.Size = new System.Drawing.Size(204, 40);
            this.TxtapellidoMaterno.TabIndex = 15;
            // 
            // TxtUsusario
            // 
            this.TxtUsusario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtUsusario.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsusario.Location = new System.Drawing.Point(338, 310);
            this.TxtUsusario.Name = "TxtUsusario";
            this.TxtUsusario.Size = new System.Drawing.Size(204, 40);
            this.TxtUsusario.TabIndex = 16;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtContraseña.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraseña.Location = new System.Drawing.Point(338, 390);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(204, 40);
            this.TxtContraseña.TabIndex = 20;
            this.TxtContraseña.UseSystemPasswordChar = true;
            this.TxtContraseña.TextChanged += new System.EventHandler(this.TxtContraseña_TextChanged);
            // 
            // TxtActivo
            // 
            this.TxtActivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtActivo.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtActivo.Location = new System.Drawing.Point(338, 577);
            this.TxtActivo.Name = "TxtActivo";
            this.TxtActivo.Size = new System.Drawing.Size(204, 40);
            this.TxtActivo.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(322, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 34);
            this.label7.TabIndex = 21;
            this.label7.Text = "TIPO DE USUARIO";
            // 
            // CboTipoUsuario
            // 
            this.CboTipoUsuario.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTipoUsuario.FormattingEnabled = true;
            this.CboTipoUsuario.Items.AddRange(new object[] {
            "1",
            "2"});
            this.CboTipoUsuario.Location = new System.Drawing.Point(338, 476);
            this.CboTipoUsuario.Name = "CboTipoUsuario";
            this.CboTipoUsuario.Size = new System.Drawing.Size(195, 42);
            this.CboTipoUsuario.TabIndex = 22;
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(944, 641);
            this.Controls.Add(this.CboTipoUsuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtActivo);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtUsusario);
            this.Controls.Add(this.TxtapellidoMaterno);
            this.Controls.Add(this.TxtapellidoPaterno);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.Registrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtapellidoPaterno;
        private System.Windows.Forms.TextBox TxtapellidoMaterno;
        private System.Windows.Forms.TextBox TxtUsusario;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.TextBox TxtActivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CboTipoUsuario;
    }
}