namespace Vistas
{
    partial class FormProducto
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
            this.txtCategoria = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.Label();
            this.txtBoxCategoria = new System.Windows.Forms.TextBox();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.txtBoxPrecio = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxCodig = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rBtnCategoria = new System.Windows.Forms.RadioButton();
            this.rBtnDescripcion = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCategoria
            // 
            this.txtCategoria.AutoSize = true;
            this.txtCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtCategoria.Location = new System.Drawing.Point(42, 74);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(52, 13);
            this.txtCategoria.TabIndex = 0;
            this.txtCategoria.Text = "Categoria";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AutoSize = true;
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtDescripcion.Location = new System.Drawing.Point(42, 125);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(63, 13);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.Text = "Descripcion";
            // 
            // txtPrecio
            // 
            this.txtPrecio.AutoSize = true;
            this.txtPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtPrecio.Location = new System.Drawing.Point(42, 175);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(37, 13);
            this.txtPrecio.TabIndex = 2;
            this.txtPrecio.Text = "Precio";
            // 
            // txtBoxCategoria
            // 
            this.txtBoxCategoria.Location = new System.Drawing.Point(139, 71);
            this.txtBoxCategoria.Name = "txtBoxCategoria";
            this.txtBoxCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCategoria.TabIndex = 3;
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Location = new System.Drawing.Point(139, 122);
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDescripcion.TabIndex = 4;
            // 
            // txtBoxPrecio
            // 
            this.txtBoxPrecio.Location = new System.Drawing.Point(139, 168);
            this.txtBoxPrecio.Name = "txtBoxPrecio";
            this.txtBoxPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPrecio.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRegistrar.Location = new System.Drawing.Point(11, 219);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(82, 24);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.Location = new System.Drawing.Point(349, 112);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(666, 249);
            this.dgvProductos.TabIndex = 9;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxCodig);
            this.groupBox1.Controls.Add(this.labelCodigo);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 308);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta Producto";
            // 
            // txtBoxCodig
            // 
            this.txtBoxCodig.Enabled = false;
            this.txtBoxCodig.Location = new System.Drawing.Point(127, 23);
            this.txtBoxCodig.Name = "txtBoxCodig";
            this.txtBoxCodig.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCodig.TabIndex = 10;
            this.txtBoxCodig.Visible = false;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(30, 26);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 9;
            this.labelCodigo.Text = "Codigo";
            this.labelCodigo.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDelete.Location = new System.Drawing.Point(189, 258);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkRed;
            this.btnUpdate.Location = new System.Drawing.Point(189, 219);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLimpiar.Location = new System.Drawing.Point(11, 258);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(82, 23);
            this.btnLimpiar.TabIndex = 0;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.rBtnCategoria);
            this.groupBox2.Controls.Add(this.rBtnDescripcion);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(349, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 94);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordenar por Desscripcion o Categoria";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBuscar.Location = new System.Drawing.Point(125, 29);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Ordenar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rBtnCategoria
            // 
            this.rBtnCategoria.AutoSize = true;
            this.rBtnCategoria.Location = new System.Drawing.Point(28, 46);
            this.rBtnCategoria.Name = "rBtnCategoria";
            this.rBtnCategoria.Size = new System.Drawing.Size(70, 17);
            this.rBtnCategoria.TabIndex = 1;
            this.rBtnCategoria.Text = "Categoria";
            this.rBtnCategoria.UseVisualStyleBackColor = true;
            // 
            // rBtnDescripcion
            // 
            this.rBtnDescripcion.AutoSize = true;
            this.rBtnDescripcion.Location = new System.Drawing.Point(28, 23);
            this.rBtnDescripcion.Name = "rBtnDescripcion";
            this.rBtnDescripcion.Size = new System.Drawing.Size(81, 17);
            this.rBtnDescripcion.TabIndex = 0;
            this.rBtnDescripcion.Text = "Descripcion";
            this.rBtnDescripcion.UseVisualStyleBackColor = true;
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1027, 373);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.txtBoxPrecio);
            this.Controls.Add(this.txtBoxDescripcion);
            this.Controls.Add(this.txtBoxCategoria);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormProducto";
            this.Text = "FormProducto";
            this.Load += new System.EventHandler(this.FormProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtCategoria;
        private System.Windows.Forms.Label txtDescripcion;
        private System.Windows.Forms.Label txtPrecio;
        private System.Windows.Forms.TextBox txtBoxCategoria;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.TextBox txtBoxPrecio;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton rBtnCategoria;
        private System.Windows.Forms.RadioButton rBtnDescripcion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtBoxCodig;
        private System.Windows.Forms.Label labelCodigo;
    }
}