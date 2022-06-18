namespace Vistas
{
    partial class FormClientesObra
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxObras = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxObra = new System.Windows.Forms.TextBox();
            this.txtBoxTotalClientes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 95);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(534, 194);
            this.dgvClientes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione Obra Social";
            // 
            // comboBoxObras
            // 
            this.comboBoxObras.FormattingEnabled = true;
            this.comboBoxObras.Location = new System.Drawing.Point(136, 41);
            this.comboBoxObras.Name = "comboBoxObras";
            this.comboBoxObras.Size = new System.Drawing.Size(121, 21);
            this.comboBoxObras.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(285, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Clientes Afiliados a: ";
            // 
            // txtBoxObra
            // 
            this.txtBoxObra.Enabled = false;
            this.txtBoxObra.Location = new System.Drawing.Point(199, 310);
            this.txtBoxObra.Name = "txtBoxObra";
            this.txtBoxObra.Size = new System.Drawing.Size(110, 20);
            this.txtBoxObra.TabIndex = 5;
            // 
            // txtBoxTotalClientes
            // 
            this.txtBoxTotalClientes.Enabled = false;
            this.txtBoxTotalClientes.Location = new System.Drawing.Point(199, 341);
            this.txtBoxTotalClientes.Name = "txtBoxTotalClientes";
            this.txtBoxTotalClientes.Size = new System.Drawing.Size(110, 20);
            this.txtBoxTotalClientes.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total:";
            // 
            // FormClientesObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 373);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxTotalClientes);
            this.Controls.Add(this.txtBoxObra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.comboBoxObras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClientes);
            this.Name = "FormClientesObra";
            this.Text = "Clientes Afiliados a Obra Social";
            this.Load += new System.EventHandler(this.FormClientesObra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxObras;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxObra;
        private System.Windows.Forms.TextBox txtBoxTotalClientes;
        private System.Windows.Forms.Label label3;
    }
}