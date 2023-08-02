namespace Sistema
{
    partial class Reporte
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
            this.button1 = new System.Windows.Forms.Button();
            this.CboReportes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(49, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 94);
            this.button1.TabIndex = 0;
            this.button1.Text = "GENERAR REPORTE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CboReportes
            // 
            this.CboReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboReportes.FormattingEnabled = true;
            this.CboReportes.Location = new System.Drawing.Point(295, 102);
            this.CboReportes.Name = "CboReportes";
            this.CboReportes.Size = new System.Drawing.Size(390, 50);
            this.CboReportes.TabIndex = 1;
            this.CboReportes.SelectedIndexChanged += new System.EventHandler(this.CboReportes_SelectedIndexChanged);
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 503);
            this.Controls.Add(this.CboReportes);
            this.Controls.Add(this.button1);
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CboReportes;
    }
}