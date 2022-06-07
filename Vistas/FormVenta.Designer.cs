namespace Vistas
{
    partial class FormVenta
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
            this.comboBoxClientes = new System.Windows.Forms.ComboBox();
            this.dtpVenta = new System.Windows.Forms.DateTimePicker();
            this.txtBoxPrecio = new System.Windows.Forms.TextBox();
            this.txtBoxCantidad = new System.Windows.Forms.TextBox();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxProductos = new System.Windows.Forms.ComboBox();
            this.btnMasProducto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lVProductos = new System.Windows.Forms.ListView();
            this.Producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Venta Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total";
            // 
            // comboBoxClientes
            // 
            this.comboBoxClientes.FormattingEnabled = true;
            this.comboBoxClientes.Location = new System.Drawing.Point(146, 32);
            this.comboBoxClientes.Name = "comboBoxClientes";
            this.comboBoxClientes.Size = new System.Drawing.Size(200, 21);
            this.comboBoxClientes.TabIndex = 5;
            // 
            // dtpVenta
            // 
            this.dtpVenta.Location = new System.Drawing.Point(146, 71);
            this.dtpVenta.Name = "dtpVenta";
            this.dtpVenta.Size = new System.Drawing.Size(200, 20);
            this.dtpVenta.TabIndex = 6;
            // 
            // txtBoxPrecio
            // 
            this.txtBoxPrecio.Enabled = false;
            this.txtBoxPrecio.Location = new System.Drawing.Point(146, 163);
            this.txtBoxPrecio.Name = "txtBoxPrecio";
            this.txtBoxPrecio.Size = new System.Drawing.Size(200, 20);
            this.txtBoxPrecio.TabIndex = 7;
            this.txtBoxPrecio.TextChanged += new System.EventHandler(this.txtBoxPrecio_TextChanged);
            // 
            // txtBoxCantidad
            // 
            this.txtBoxCantidad.Location = new System.Drawing.Point(146, 213);
            this.txtBoxCantidad.Name = "txtBoxCantidad";
            this.txtBoxCantidad.Size = new System.Drawing.Size(200, 20);
            this.txtBoxCantidad.TabIndex = 8;
            this.txtBoxCantidad.TextChanged += new System.EventHandler(this.txtBoxCantidad_TextChanged);
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.Enabled = false;
            this.txtBoxTotal.Location = new System.Drawing.Point(146, 255);
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.Size = new System.Drawing.Size(200, 20);
            this.txtBoxTotal.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(191, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 35);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Guardar Venta";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxProductos);
            this.groupBox1.Controls.Add(this.btnMasProducto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxClientes);
            this.groupBox1.Controls.Add(this.dtpVenta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBoxPrecio);
            this.groupBox1.Controls.Add(this.txtBoxCantidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxTotal);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 331);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venta";
            // 
            // comboBoxProductos
            // 
            this.comboBoxProductos.FormattingEnabled = true;
            this.comboBoxProductos.Location = new System.Drawing.Point(146, 120);
            this.comboBoxProductos.Name = "comboBoxProductos";
            this.comboBoxProductos.Size = new System.Drawing.Size(200, 21);
            this.comboBoxProductos.TabIndex = 15;
            this.comboBoxProductos.SelectionChangeCommitted += new System.EventHandler(this.comboBoxProductos_SelectionChangeCommitted);
            // 
            // btnMasProducto
            // 
            this.btnMasProducto.Location = new System.Drawing.Point(52, 290);
            this.btnMasProducto.Name = "btnMasProducto";
            this.btnMasProducto.Size = new System.Drawing.Size(93, 35);
            this.btnMasProducto.TabIndex = 14;
            this.btnMasProducto.Text = "Agregar mas productos";
            this.btnMasProducto.UseVisualStyleBackColor = true;
            this.btnMasProducto.Click += new System.EventHandler(this.btnMasProducto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(424, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Productos Escogidos";
            // 
            // lVProductos
            // 
            this.lVProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Producto,
            this.Precio,
            this.Cantidad});
            this.lVProductos.Location = new System.Drawing.Point(406, 121);
            this.lVProductos.Name = "lVProductos";
            this.lVProductos.Size = new System.Drawing.Size(184, 152);
            this.lVProductos.TabIndex = 15;
            this.lVProductos.UseCompatibleStateImageBehavior = false;
            this.lVProductos.View = System.Windows.Forms.View.Details;
            // 
            // Producto
            // 
            this.Producto.Text = "Producto";
            // 
            // Precio
            // 
            this.Precio.Text = "Precio";
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 363);
            this.Controls.Add(this.lVProductos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormVenta";
            this.Text = "FormVenta";
            this.Load += new System.EventHandler(this.FormVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxClientes;
        private System.Windows.Forms.DateTimePicker dtpVenta;
        private System.Windows.Forms.TextBox txtBoxPrecio;
        private System.Windows.Forms.TextBox txtBoxCantidad;
        private System.Windows.Forms.TextBox txtBoxTotal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxProductos;
        private System.Windows.Forms.Button btnMasProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lVProductos;
        private System.Windows.Forms.ColumnHeader Producto;
        private System.Windows.Forms.ColumnHeader Precio;
        private System.Windows.Forms.ColumnHeader Cantidad;
    }
}