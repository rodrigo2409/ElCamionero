namespace Sistema
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesarEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesoEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesoSalidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.basculaToolStripMenuItem,
            this.catalogosToolStripMenuItem,
            this.configuracionToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.pesoEntradaToolStripMenuItem,
            this.pesoSalidaToolStripMenuItem,
            this.herramientasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1138, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(95, 30);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(129, 30);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // basculaToolStripMenuItem
            // 
            this.basculaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesarEntradaToolStripMenuItem});
            this.basculaToolStripMenuItem.Name = "basculaToolStripMenuItem";
            this.basculaToolStripMenuItem.Size = new System.Drawing.Size(101, 30);
            this.basculaToolStripMenuItem.Text = "Bascula";
            // 
            // pesarEntradaToolStripMenuItem
            // 
            this.pesarEntradaToolStripMenuItem.Name = "pesarEntradaToolStripMenuItem";
            this.pesarEntradaToolStripMenuItem.Size = new System.Drawing.Size(284, 30);
            this.pesarEntradaToolStripMenuItem.Text = "CONFIGURAR BASCULA";
            this.pesarEntradaToolStripMenuItem.Click += new System.EventHandler(this.pesarEntradaToolStripMenuItem_Click);
            // 
            // catalogosToolStripMenuItem
            // 
            this.catalogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarUsuarioToolStripMenuItem,
            this.consultarUsuarioToolStripMenuItem});
            this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(121, 30);
            this.catalogosToolStripMenuItem.Text = "Catalogos";
            // 
            // registrarUsuarioToolStripMenuItem
            // 
            this.registrarUsuarioToolStripMenuItem.Name = "registrarUsuarioToolStripMenuItem";
            this.registrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.registrarUsuarioToolStripMenuItem.Text = "Registrar usuario";
            this.registrarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registrarUsuarioToolStripMenuItem_Click);
            // 
            // consultarUsuarioToolStripMenuItem
            // 
            this.consultarUsuarioToolStripMenuItem.Name = "consultarUsuarioToolStripMenuItem";
            this.consultarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.consultarUsuarioToolStripMenuItem.Text = "Consultar usuario";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tarasToolStripMenuItem,
            this.cajasToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.provedorToolStripMenuItem});
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // tarasToolStripMenuItem
            // 
            this.tarasToolStripMenuItem.Name = "tarasToolStripMenuItem";
            this.tarasToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.tarasToolStripMenuItem.Text = "taras";
            this.tarasToolStripMenuItem.Click += new System.EventHandler(this.tarasToolStripMenuItem_Click);
            // 
            // cajasToolStripMenuItem
            // 
            this.cajasToolStripMenuItem.Name = "cajasToolStripMenuItem";
            this.cajasToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.cajasToolStripMenuItem.Text = "cajas";
            this.cajasToolStripMenuItem.Click += new System.EventHandler(this.cajasToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.clienteToolStripMenuItem.Text = "cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // provedorToolStripMenuItem
            // 
            this.provedorToolStripMenuItem.Name = "provedorToolStripMenuItem";
            this.provedorToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.provedorToolStripMenuItem.Text = "provedor";
            this.provedorToolStripMenuItem.Click += new System.EventHandler(this.provedorToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarProductoToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(122, 30);
            this.productosToolStripMenuItem.Text = "productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.prodructosToolStripMenuItem_Click);
            // 
            // insertarProductoToolStripMenuItem
            // 
            this.insertarProductoToolStripMenuItem.Name = "insertarProductoToolStripMenuItem";
            this.insertarProductoToolStripMenuItem.Size = new System.Drawing.Size(254, 30);
            this.insertarProductoToolStripMenuItem.Text = "insertar producto";
            this.insertarProductoToolStripMenuItem.Click += new System.EventHandler(this.insertarProductoToolStripMenuItem_Click);
            // 
            // pesoEntradaToolStripMenuItem
            // 
            this.pesoEntradaToolStripMenuItem.Name = "pesoEntradaToolStripMenuItem";
            this.pesoEntradaToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.pesoEntradaToolStripMenuItem.Text = "peso entrada";
            this.pesoEntradaToolStripMenuItem.Click += new System.EventHandler(this.pesoEntradaToolStripMenuItem_Click);
            // 
            // pesoSalidaToolStripMenuItem
            // 
            this.pesoSalidaToolStripMenuItem.Name = "pesoSalidaToolStripMenuItem";
            this.pesoSalidaToolStripMenuItem.Size = new System.Drawing.Size(135, 30);
            this.pesoSalidaToolStripMenuItem.Text = "peso salida";
            this.pesoSalidaToolStripMenuItem.Click += new System.EventHandler(this.pesoSalidaToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalizarToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(127, 30);
            this.herramientasToolStripMenuItem.Text = "Reporteria";
            this.herramientasToolStripMenuItem.Click += new System.EventHandler(this.herramientasToolStripMenuItem_Click);
            // 
            // personalizarToolStripMenuItem
            // 
            this.personalizarToolStripMenuItem.Name = "personalizarToolStripMenuItem";
            this.personalizarToolStripMenuItem.Size = new System.Drawing.Size(342, 30);
            this.personalizarToolStripMenuItem.Text = "reportes de peso de salida";
            this.personalizarToolStripMenuItem.Click += new System.EventHandler(this.personalizarToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(342, 30);
            this.opcionesToolStripMenuItem.Text = "reportes de peso entrada ";
            this.opcionesToolStripMenuItem.Click += new System.EventHandler(this.opcionesToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1138, 729);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesarEntradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesoEntradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesoSalidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provedorToolStripMenuItem;
    }
}