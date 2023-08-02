namespace Sistema
{
    partial class Balanza
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
            this.components = new System.ComponentModel.Container();
            this.BtnbuscarPuertos = new System.Windows.Forms.Button();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.LblBaudRate = new System.Windows.Forms.Label();
            this.CboPuertos = new System.Windows.Forms.ComboBox();
            this.CboBaudRate = new System.Windows.Forms.ComboBox();
            this.SpPuertos = new System.IO.Ports.SerialPort(this.components);
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtNombreBascula = new System.Windows.Forms.TextBox();
            this.TxtActivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGuardarBascula = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CboParidad = new System.Windows.Forms.ComboBox();
            this.CboBitsdatos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDatosRecibidos = new System.Windows.Forms.TextBox();
            this.CboBitsparada = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CboHandskate = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnbuscarPuertos
            // 
            this.BtnbuscarPuertos.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnbuscarPuertos.Location = new System.Drawing.Point(96, 2);
            this.BtnbuscarPuertos.Name = "BtnbuscarPuertos";
            this.BtnbuscarPuertos.Size = new System.Drawing.Size(121, 80);
            this.BtnbuscarPuertos.TabIndex = 0;
            this.BtnbuscarPuertos.Text = "BUSCAR PUERTOS";
            this.BtnbuscarPuertos.UseVisualStyleBackColor = true;
            this.BtnbuscarPuertos.Click += new System.EventHandler(this.BtnbuscarPuertos_Click);
            // 
            // BtnConectar
            // 
            this.BtnConectar.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConectar.Location = new System.Drawing.Point(612, 19);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(210, 98);
            this.BtnConectar.TabIndex = 2;
            this.BtnConectar.Text = "CONECTAR";
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // LblBaudRate
            // 
            this.LblBaudRate.AutoSize = true;
            this.LblBaudRate.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBaudRate.Location = new System.Drawing.Point(90, 90);
            this.LblBaudRate.Name = "LblBaudRate";
            this.LblBaudRate.Size = new System.Drawing.Size(139, 34);
            this.LblBaudRate.TabIndex = 3;
            this.LblBaudRate.Text = "BAUD RATE";
            // 
            // CboPuertos
            // 
            this.CboPuertos.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboPuertos.FormattingEnabled = true;
            this.CboPuertos.Location = new System.Drawing.Point(302, 12);
            this.CboPuertos.Name = "CboPuertos";
            this.CboPuertos.Size = new System.Drawing.Size(208, 44);
            this.CboPuertos.TabIndex = 5;
            // 
            // CboBaudRate
            // 
            this.CboBaudRate.Font = new System.Drawing.Font("Imprint MT Shadow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboBaudRate.FormattingEnabled = true;
            this.CboBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "6900",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "115200"});
            this.CboBaudRate.Location = new System.Drawing.Point(302, 84);
            this.CboBaudRate.Name = "CboBaudRate";
            this.CboBaudRate.Size = new System.Drawing.Size(208, 40);
            this.CboBaudRate.TabIndex = 6;
            this.CboBaudRate.Text = "9600";
            // 
            // SpPuertos
            // 
            
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(626, 297);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(208, 103);
            this.BtnGuardar.TabIndex = 9;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtNombreBascula
            // 
            this.TxtNombreBascula.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreBascula.Location = new System.Drawing.Point(302, 440);
            this.TxtNombreBascula.Name = "TxtNombreBascula";
            this.TxtNombreBascula.Size = new System.Drawing.Size(208, 40);
            this.TxtNombreBascula.TabIndex = 11;
            // 
            // TxtActivo
            // 
            this.TxtActivo.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtActivo.Location = new System.Drawing.Point(302, 514);
            this.TxtActivo.Name = "TxtActivo";
            this.TxtActivo.Size = new System.Drawing.Size(208, 40);
            this.TxtActivo.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 34);
            this.label2.TabIndex = 13;
            this.label2.Text = "ACTIVO";
            // 
            // BtnGuardarBascula
            // 
            this.BtnGuardarBascula.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarBascula.Location = new System.Drawing.Point(614, 488);
            this.BtnGuardarBascula.Name = "BtnGuardarBascula";
            this.BtnGuardarBascula.Size = new System.Drawing.Size(220, 111);
            this.BtnGuardarBascula.TabIndex = 14;
            this.BtnGuardarBascula.Text = "GUARDAR CONFIGURACION";
            this.BtnGuardarBascula.UseVisualStyleBackColor = true;
            this.BtnGuardarBascula.Click += new System.EventHandler(this.BtnGuardarBascula_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 34);
            this.label3.TabIndex = 15;
            this.label3.Text = "BITS DE DATOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 34);
            this.label4.TabIndex = 16;
            this.label4.Text = "PARIDAD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 34);
            this.label5.TabIndex = 17;
            this.label5.Text = "BITS DE PARADA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-1, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(287, 34);
            this.label6.TabIndex = 18;
            this.label6.Text = "NOMBRE DE LA BAZCULA";
            // 
            // CboParidad
            // 
            this.CboParidad.BackColor = System.Drawing.SystemColors.Window;
            this.CboParidad.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboParidad.FormattingEnabled = true;
            this.CboParidad.Items.AddRange(new object[] {
            "None",
            "SIN PARIDAD",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.CboParidad.Location = new System.Drawing.Point(302, 211);
            this.CboParidad.Name = "CboParidad";
            this.CboParidad.Size = new System.Drawing.Size(208, 42);
            this.CboParidad.TabIndex = 22;
            this.CboParidad.Text = "SIN PARIDAD";
            // 
            // CboBitsdatos
            // 
            this.CboBitsdatos.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboBitsdatos.FormattingEnabled = true;
            this.CboBitsdatos.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.CboBitsdatos.Location = new System.Drawing.Point(302, 143);
            this.CboBitsdatos.Name = "CboBitsdatos";
            this.CboBitsdatos.Size = new System.Drawing.Size(208, 42);
            this.CboBitsdatos.TabIndex = 23;
            this.CboBitsdatos.Text = "8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 593);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 34);
            this.label1.TabIndex = 24;
            this.label1.Text = "DATOS RECIBIDOS";
            // 
            // TxtDatosRecibidos
            // 
            this.TxtDatosRecibidos.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDatosRecibidos.Location = new System.Drawing.Point(302, 593);
            this.TxtDatosRecibidos.Name = "TxtDatosRecibidos";
            this.TxtDatosRecibidos.Size = new System.Drawing.Size(208, 40);
            this.TxtDatosRecibidos.TabIndex = 25;
            this.TxtDatosRecibidos.TextChanged += new System.EventHandler(this.TxtDatosRecibidos_TextChanged);
            // 
            // CboBitsparada
            // 
            this.CboBitsparada.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboBitsparada.FormattingEnabled = true;
            this.CboBitsparada.Items.AddRange(new object[] {
            "One",
            "Two",
            "None"});
            this.CboBitsparada.Location = new System.Drawing.Point(302, 288);
            this.CboBitsparada.Name = "CboBitsparada";
            this.CboBitsparada.Size = new System.Drawing.Size(208, 42);
            this.CboBitsparada.TabIndex = 26;
            this.CboBitsparada.Text = "One";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 34);
            this.label7.TabIndex = 27;
            this.label7.Text = "HANDSKATE";
            // 
            // CboHandskate
            // 
            this.CboHandskate.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboHandskate.FormattingEnabled = true;
            this.CboHandskate.Items.AddRange(new object[] {
            "None",
            "XOnXOff"});
            this.CboHandskate.Location = new System.Drawing.Point(302, 358);
            this.CboHandskate.Name = "CboHandskate";
            this.CboHandskate.Size = new System.Drawing.Size(208, 42);
            this.CboHandskate.TabIndex = 28;
            this.CboHandskate.Text = "None";
            // 
            // Balanza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(944, 641);
            this.Controls.Add(this.CboHandskate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CboBitsparada);
            this.Controls.Add(this.TxtDatosRecibidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboBitsdatos);
            this.Controls.Add(this.CboParidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnGuardarBascula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtActivo);
            this.Controls.Add(this.TxtNombreBascula);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.CboBaudRate);
            this.Controls.Add(this.CboPuertos);
            this.Controls.Add(this.LblBaudRate);
            this.Controls.Add(this.BtnConectar);
            this.Controls.Add(this.BtnbuscarPuertos);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Balanza";
            this.Text = "balanza";
            this.Load += new System.EventHandler(this.balanza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnbuscarPuertos;
        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.Label LblBaudRate;
        private System.Windows.Forms.ComboBox CboPuertos;
        private System.Windows.Forms.ComboBox CboBaudRate;
        private System.IO.Ports.SerialPort SpPuertos;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtNombreBascula;
        private System.Windows.Forms.TextBox TxtActivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGuardarBascula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CboParidad;
        private System.Windows.Forms.ComboBox CboBitsdatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDatosRecibidos;
        private System.Windows.Forms.ComboBox CboBitsparada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CboHandskate;
    }
}