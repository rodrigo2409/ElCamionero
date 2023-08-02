namespace Sistema
{
    partial class PesoEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesoEntrada));
            this.TxtDatosRecibidos = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.SpPuertos = new System.IO.Ports.SerialPort(this.components);
            this.CboProdructos = new System.Windows.Forms.ComboBox();
            this.TxtTaras = new System.Windows.Forms.TextBox();
            this.CboTaras = new System.Windows.Forms.ComboBox();
            this.CboCajas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpesotara = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPesoneto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CboProvedor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNocajas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtDatosRecibidos
            // 
            resources.ApplyResources(this.TxtDatosRecibidos, "TxtDatosRecibidos");
            this.TxtDatosRecibidos.Name = "TxtDatosRecibidos";
            this.TxtDatosRecibidos.TextChanged += new System.EventHandler(this.TxtDatosRecibidos_TextChanged);
            // 
            // BtnGuardar
            // 
            resources.ApplyResources(this.BtnGuardar, "BtnGuardar");
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // SpPuertos
            // 
            this.SpPuertos.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DatoRecivido);
            // 
            // CboProdructos
            // 
            resources.ApplyResources(this.CboProdructos, "CboProdructos");
            this.CboProdructos.FormattingEnabled = true;
            this.CboProdructos.Name = "CboProdructos";
            this.CboProdructos.SelectedIndexChanged += new System.EventHandler(this.CboProdructos_SelectedIndexChanged);
            // 
            // TxtTaras
            // 
            resources.ApplyResources(this.TxtTaras, "TxtTaras");
            this.TxtTaras.Name = "TxtTaras";
            this.TxtTaras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTaras_KeyPress);
            // 
            // CboTaras
            // 
            resources.ApplyResources(this.CboTaras, "CboTaras");
            this.CboTaras.FormattingEnabled = true;
            this.CboTaras.Name = "CboTaras";
            this.CboTaras.SelectedIndexChanged += new System.EventHandler(this.CboTaras_SelectedIndexChanged);
            // 
            // CboCajas
            // 
            resources.ApplyResources(this.CboCajas, "CboCajas");
            this.CboCajas.FormattingEnabled = true;
            this.CboCajas.Name = "CboCajas";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtpesotara
            // 
            resources.ApplyResources(this.txtpesotara, "txtpesotara");
            this.txtpesotara.Name = "txtpesotara";
            this.txtpesotara.TextChanged += new System.EventHandler(this.txtpesotara_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // TxtPesoneto
            // 
            resources.ApplyResources(this.TxtPesoneto, "TxtPesoneto");
            this.TxtPesoneto.Name = "TxtPesoneto";
            this.TxtPesoneto.TextChanged += new System.EventHandler(this.txtpesotara_TextChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // CboProvedor
            // 
            resources.ApplyResources(this.CboProvedor, "CboProvedor");
            this.CboProvedor.FormattingEnabled = true;
            this.CboProvedor.Name = "CboProvedor";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // txtNocajas
            // 
            resources.ApplyResources(this.txtNocajas, "txtNocajas");
            this.txtNocajas.Name = "txtNocajas";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // PesoEntrada
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNocajas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CboProvedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtPesoneto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpesotara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboCajas);
            this.Controls.Add(this.CboTaras);
            this.Controls.Add(this.TxtTaras);
            this.Controls.Add(this.CboProdructos);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtDatosRecibidos);
            this.Name = "PesoEntrada";
            this.Load += new System.EventHandler(this.PesoEntrada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDatosRecibidos;
        private System.Windows.Forms.Button BtnGuardar;
        private System.IO.Ports.SerialPort SpPuertos;
        private System.Windows.Forms.ComboBox CboProdructos;
        private System.Windows.Forms.TextBox TxtTaras;
        private System.Windows.Forms.ComboBox CboTaras;
        private System.Windows.Forms.ComboBox CboCajas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpesotara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPesoneto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CboProvedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNocajas;
        private System.Windows.Forms.Label label9;
    }
}