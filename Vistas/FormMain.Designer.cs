namespace Vistas
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.altaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lIstadoDetalleDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.altaProuctoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoProductosVendidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnAltaCliente = new System.Windows.Forms.Button();
            this.BtnAltaProducto = new System.Windows.Forms.Button();
            this.BtnAltaObraSocial = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.tsmVentas,
            this.tsmProductos,
            this.tsmClientes,
            this.tsmUsuarios});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(396, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // tsmVentas
            // 
            this.tsmVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaVentaToolStripMenuItem,
            this.listadoVentasToolStripMenuItem,
            this.lIstadoDetalleDeVentasToolStripMenuItem});
            this.tsmVentas.Name = "tsmVentas";
            this.tsmVentas.Size = new System.Drawing.Size(53, 20);
            this.tsmVentas.Text = "Ventas";
            // 
            // altaVentaToolStripMenuItem
            // 
            this.altaVentaToolStripMenuItem.Name = "altaVentaToolStripMenuItem";
            this.altaVentaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.altaVentaToolStripMenuItem.Text = "Alta Venta";
            this.altaVentaToolStripMenuItem.Click += new System.EventHandler(this.altaVentaToolStripMenuItem_Click);
            // 
            // listadoVentasToolStripMenuItem
            // 
            this.listadoVentasToolStripMenuItem.Name = "listadoVentasToolStripMenuItem";
            this.listadoVentasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.listadoVentasToolStripMenuItem.Text = "Listado Ventas";
            this.listadoVentasToolStripMenuItem.Click += new System.EventHandler(this.listadoVentasToolStripMenuItem_Click);
            // 
            // lIstadoDetalleDeVentasToolStripMenuItem
            // 
            this.lIstadoDetalleDeVentasToolStripMenuItem.Name = "lIstadoDetalleDeVentasToolStripMenuItem";
            this.lIstadoDetalleDeVentasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.lIstadoDetalleDeVentasToolStripMenuItem.Text = "LIstado DetalleVentas";
            this.lIstadoDetalleDeVentasToolStripMenuItem.Click += new System.EventHandler(this.lIstadoDetalleDeVentasToolStripMenuItem_Click);
            // 
            // tsmProductos
            // 
            this.tsmProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaProuctoToolStripMenuItem,
            this.listadoProductosVendidosToolStripMenuItem});
            this.tsmProductos.Name = "tsmProductos";
            this.tsmProductos.Size = new System.Drawing.Size(73, 20);
            this.tsmProductos.Text = "Productos";
            // 
            // altaProuctoToolStripMenuItem
            // 
            this.altaProuctoToolStripMenuItem.Name = "altaProuctoToolStripMenuItem";
            this.altaProuctoToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.altaProuctoToolStripMenuItem.Text = "ABM Producto";
            this.altaProuctoToolStripMenuItem.Click += new System.EventHandler(this.altaProuctoToolStripMenuItem_Click);
            // 
            // listadoProductosVendidosToolStripMenuItem
            // 
            this.listadoProductosVendidosToolStripMenuItem.Name = "listadoProductosVendidosToolStripMenuItem";
            this.listadoProductosVendidosToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.listadoProductosVendidosToolStripMenuItem.Text = "Listado Productos Vendidos";
            this.listadoProductosVendidosToolStripMenuItem.Click += new System.EventHandler(this.listadoProductosVendidosToolStripMenuItem_Click);
            // 
            // tsmClientes
            // 
            this.tsmClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMToolStripMenuItem1});
            this.tsmClientes.Name = "tsmClientes";
            this.tsmClientes.Size = new System.Drawing.Size(61, 20);
            this.tsmClientes.Text = "Clientes";
            // 
            // aBMToolStripMenuItem1
            // 
            this.aBMToolStripMenuItem1.Name = "aBMToolStripMenuItem1";
            this.aBMToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.aBMToolStripMenuItem1.Text = "ABM Cliente";
            this.aBMToolStripMenuItem1.Click += new System.EventHandler(this.aBMToolStripMenuItem1_Click);
            // 
            // tsmUsuarios
            // 
            this.tsmUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMToolStripMenuItem});
            this.tsmUsuarios.Name = "tsmUsuarios";
            this.tsmUsuarios.Size = new System.Drawing.Size(64, 20);
            this.tsmUsuarios.Text = "Usuarios";
            // 
            // aBMToolStripMenuItem
            // 
            this.aBMToolStripMenuItem.Name = "aBMToolStripMenuItem";
            this.aBMToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.aBMToolStripMenuItem.Text = "ABM Usuario";
            this.aBMToolStripMenuItem.Click += new System.EventHandler(this.aBMToolStripMenuItem_Click);
            // 
            // BtnAltaCliente
            // 
            this.BtnAltaCliente.Location = new System.Drawing.Point(127, 84);
            this.BtnAltaCliente.Name = "BtnAltaCliente";
            this.BtnAltaCliente.Size = new System.Drawing.Size(111, 23);
            this.BtnAltaCliente.TabIndex = 1;
            this.BtnAltaCliente.Text = "Alta Cliente";
            this.BtnAltaCliente.UseVisualStyleBackColor = true;
            this.BtnAltaCliente.Click += new System.EventHandler(this.BtnAltaCliente_Click);
            // 
            // BtnAltaProducto
            // 
            this.BtnAltaProducto.Location = new System.Drawing.Point(127, 123);
            this.BtnAltaProducto.Name = "BtnAltaProducto";
            this.BtnAltaProducto.Size = new System.Drawing.Size(111, 23);
            this.BtnAltaProducto.TabIndex = 2;
            this.BtnAltaProducto.Text = "Alta Producto";
            this.BtnAltaProducto.UseVisualStyleBackColor = true;
            this.BtnAltaProducto.Click += new System.EventHandler(this.BtnAltaProducto_Click);
            // 
            // BtnAltaObraSocial
            // 
            this.BtnAltaObraSocial.Location = new System.Drawing.Point(127, 41);
            this.BtnAltaObraSocial.Name = "BtnAltaObraSocial";
            this.BtnAltaObraSocial.Size = new System.Drawing.Size(111, 23);
            this.BtnAltaObraSocial.TabIndex = 3;
            this.BtnAltaObraSocial.Text = "Alta ObraSocial";
            this.BtnAltaObraSocial.UseVisualStyleBackColor = true;
            this.BtnAltaObraSocial.Click += new System.EventHandler(this.BtnAltaObraSocial_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(149, 226);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 261);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.BtnAltaObraSocial);
            this.Controls.Add(this.BtnAltaProducto);
            this.Controls.Add(this.BtnAltaCliente);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmVentas;
        private System.Windows.Forms.ToolStripMenuItem tsmProductos;
        private System.Windows.Forms.ToolStripMenuItem tsmClientes;
        private System.Windows.Forms.Button BtnAltaCliente;
        private System.Windows.Forms.Button BtnAltaProducto;
        private System.Windows.Forms.Button BtnAltaObraSocial;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmUsuarios;
        private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem altaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lIstadoDetalleDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaProuctoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoProductosVendidosToolStripMenuItem;
    }
}