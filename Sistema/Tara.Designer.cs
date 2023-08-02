namespace Sistema
{
    partial class Tara
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtNumeroTara = new System.Windows.Forms.TextBox();
            this.TxtDatosRecibidos = new System.Windows.Forms.TextBox();
            this.SpPuertos = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESE EL NUMERO DE TARA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESE PESO DE LA TARA ";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(271, 324);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(273, 147);
            this.BtnGuardar.TabIndex = 2;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtNumeroTara
            // 
            this.TxtNumeroTara.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumeroTara.Location = new System.Drawing.Point(247, 100);
            this.TxtNumeroTara.Name = "TxtNumeroTara";
            this.TxtNumeroTara.Size = new System.Drawing.Size(297, 40);
            this.TxtNumeroTara.TabIndex = 14;
            this.TxtNumeroTara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeroTara_KeyPress);
            // 
            // TxtDatosRecibidos
            // 
            this.TxtDatosRecibidos.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDatosRecibidos.Location = new System.Drawing.Point(247, 246);
            this.TxtDatosRecibidos.Name = "TxtDatosRecibidos";
            this.TxtDatosRecibidos.Size = new System.Drawing.Size(297, 40);
            this.TxtDatosRecibidos.TabIndex = 26;
            this.TxtDatosRecibidos.TextChanged += new System.EventHandler(this.TxtDatosRecibidos_TextChanged);
            // 
            // SpPuertos
            // 
            this.SpPuertos.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DatoRecivido);
            // 
            // Tara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(944, 641);
            this.Controls.Add(this.TxtDatosRecibidos);
            this.Controls.Add(this.TxtNumeroTara);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Tara";
            this.Text = "Tara";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtNumeroTara;
        private System.Windows.Forms.TextBox TxtDatosRecibidos;
        private System.IO.Ports.SerialPort SpPuertos;
    }
}