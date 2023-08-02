namespace Sistema
{
    partial class PesoSalida
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
            this.TxtDatosRecibidos = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.SpPuertos = new System.IO.Ports.SerialPort(this.components);
            this.CboProdructos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CboCajas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CboTaras = new System.Windows.Forms.ComboBox();
            this.TxtTaras = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpesotara = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtPesoneto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CboCliente = new System.Windows.Forms.ComboBox();
            this.txtNocajas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtDatosRecibidos
            // 
            this.TxtDatosRecibidos.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDatosRecibidos.Location = new System.Drawing.Point(347, 328);
            this.TxtDatosRecibidos.Name = "TxtDatosRecibidos";
            this.TxtDatosRecibidos.Size = new System.Drawing.Size(297, 40);
            this.TxtDatosRecibidos.TabIndex = 27;
            this.TxtDatosRecibidos.TextChanged += new System.EventHandler(this.TxtDatosRecibidos_TextChanged);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(675, 394);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(286, 181);
            this.BtnGuardar.TabIndex = 28;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // SpPuertos
            // 
            this.SpPuertos.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DatoRecivido);
            // 
            // CboProdructos
            // 
            this.CboProdructos.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboProdructos.FormattingEnabled = true;
            this.CboProdructos.Location = new System.Drawing.Point(675, 46);
            this.CboProdructos.Name = "CboProdructos";
            this.CboProdructos.Size = new System.Drawing.Size(297, 42);
            this.CboProdructos.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(799, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 34);
            this.label1.TabIndex = 35;
            this.label1.Text = "PRODUCTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 34);
            this.label2.TabIndex = 36;
            this.label2.Text = "PESO DE LACAJAS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CboCajas
            // 
            this.CboCajas.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCajas.FormattingEnabled = true;
            this.CboCajas.Location = new System.Drawing.Point(357, 57);
            this.CboCajas.Name = "CboCajas";
            this.CboCajas.Size = new System.Drawing.Size(297, 42);
            this.CboCajas.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 34);
            this.label3.TabIndex = 38;
            this.label3.Text = "TARAS";
            // 
            // CboTaras
            // 
            this.CboTaras.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTaras.FormattingEnabled = true;
            this.CboTaras.Location = new System.Drawing.Point(23, 184);
            this.CboTaras.Name = "CboTaras";
            this.CboTaras.Size = new System.Drawing.Size(297, 42);
            this.CboTaras.TabIndex = 39;
            // 
            // TxtTaras
            // 
            this.TxtTaras.Font = new System.Drawing.Font("Impact", 20.25F);
            this.TxtTaras.Location = new System.Drawing.Point(12, 59);
            this.TxtTaras.Name = "TxtTaras";
            this.TxtTaras.Size = new System.Drawing.Size(297, 40);
            this.TxtTaras.TabIndex = 40;
            this.TxtTaras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeroTara_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 34);
            this.label4.TabIndex = 41;
            this.label4.Text = "INICIAR PESAJE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(414, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 34);
            this.label5.TabIndex = 42;
            this.label5.Text = "PESO BRUTO";
            // 
            // txtpesotara
            // 
            this.txtpesotara.Font = new System.Drawing.Font("Impact", 20.25F);
            this.txtpesotara.Location = new System.Drawing.Point(687, 169);
            this.txtpesotara.Name = "txtpesotara";
            this.txtpesotara.Size = new System.Drawing.Size(297, 40);
            this.txtpesotara.TabIndex = 43;
            this.txtpesotara.TextChanged += new System.EventHandler(this.txtpesotara_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(763, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 34);
            this.label6.TabIndex = 44;
            this.label6.Text = "Pesotara";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(774, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 34);
            this.label7.TabIndex = 45;
            this.label7.Text = "peso neto";
            // 
            // TxtPesoneto
            // 
            this.TxtPesoneto.Font = new System.Drawing.Font("Impact", 20.25F);
            this.TxtPesoneto.Location = new System.Drawing.Point(675, 328);
            this.TxtPesoneto.Name = "TxtPesoneto";
            this.TxtPesoneto.Size = new System.Drawing.Size(297, 40);
            this.TxtPesoneto.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(103, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 34);
            this.label8.TabIndex = 47;
            this.label8.Text = "CLIENTE";
            // 
            // CboCliente
            // 
            this.CboCliente.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCliente.FormattingEnabled = true;
            this.CboCliente.Location = new System.Drawing.Point(23, 326);
            this.CboCliente.Name = "CboCliente";
            this.CboCliente.Size = new System.Drawing.Size(297, 42);
            this.CboCliente.TabIndex = 48;
            // 
            // txtNocajas
            // 
            this.txtNocajas.Font = new System.Drawing.Font("Impact", 20.25F);
            this.txtNocajas.Location = new System.Drawing.Point(355, 186);
            this.txtNocajas.Name = "txtNocajas";
            this.txtNocajas.Size = new System.Drawing.Size(297, 40);
            this.txtNocajas.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(397, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(229, 34);
            this.label9.TabIndex = 49;
            this.label9.Text = "NUMERO DE  CAJAS";
            // 
            // PesoSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 749);
            this.Controls.Add(this.txtNocajas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CboCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtPesoneto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtpesotara);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtTaras);
            this.Controls.Add(this.CboTaras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CboCajas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboProdructos);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtDatosRecibidos);
            this.Name = "PesoSalida";
            this.Text = "PesoSalida";
            this.Load += new System.EventHandler(this.PesoSalida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDatosRecibidos;
        private System.Windows.Forms.Button BtnGuardar;
        private System.IO.Ports.SerialPort SpPuertos;
        private System.Windows.Forms.ComboBox CboProdructos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboCajas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboTaras;
        private System.Windows.Forms.TextBox TxtTaras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpesotara;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtPesoneto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CboCliente;
        private System.Windows.Forms.TextBox txtNocajas;
        private System.Windows.Forms.Label label9;
    }
}