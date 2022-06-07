namespace Vistas
{
    partial class FormObraSocial
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
            this.txtCuit = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.Label();
            this.txtBoxCuit = new System.Windows.Forms.TextBox();
            this.txtBoxDireccion = new System.Windows.Forms.TextBox();
            this.txtBoxTelefono = new System.Windows.Forms.TextBox();
            this.txtBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCuit
            // 
            this.txtCuit.AutoSize = true;
            this.txtCuit.Location = new System.Drawing.Point(41, 47);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(25, 13);
            this.txtCuit.TabIndex = 0;
            this.txtCuit.Text = "Cuit";
            // 
            // txtDireccion
            // 
            this.txtDireccion.AutoSize = true;
            this.txtDireccion.Location = new System.Drawing.Point(41, 79);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(52, 13);
            this.txtDireccion.TabIndex = 1;
            this.txtDireccion.Text = "Direccion";
            // 
            // txtTelefono
            // 
            this.txtTelefono.AutoSize = true;
            this.txtTelefono.Location = new System.Drawing.Point(41, 115);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(49, 13);
            this.txtTelefono.TabIndex = 2;
            this.txtTelefono.Text = "Telefono";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.AutoSize = true;
            this.txtRazonSocial.Location = new System.Drawing.Point(41, 149);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(70, 13);
            this.txtRazonSocial.TabIndex = 3;
            this.txtRazonSocial.Text = "Razon Social";
            // 
            // txtBoxCuit
            // 
            this.txtBoxCuit.Location = new System.Drawing.Point(111, 44);
            this.txtBoxCuit.Name = "txtBoxCuit";
            this.txtBoxCuit.Size = new System.Drawing.Size(135, 20);
            this.txtBoxCuit.TabIndex = 4;
            // 
            // txtBoxDireccion
            // 
            this.txtBoxDireccion.Location = new System.Drawing.Point(111, 76);
            this.txtBoxDireccion.Name = "txtBoxDireccion";
            this.txtBoxDireccion.Size = new System.Drawing.Size(135, 20);
            this.txtBoxDireccion.TabIndex = 5;
            // 
            // txtBoxTelefono
            // 
            this.txtBoxTelefono.Location = new System.Drawing.Point(111, 108);
            this.txtBoxTelefono.Name = "txtBoxTelefono";
            this.txtBoxTelefono.Size = new System.Drawing.Size(135, 20);
            this.txtBoxTelefono.TabIndex = 6;
            // 
            // txtBoxRazonSocial
            // 
            this.txtBoxRazonSocial.Location = new System.Drawing.Point(111, 142);
            this.txtBoxRazonSocial.Name = "txtBoxRazonSocial";
            this.txtBoxRazonSocial.Size = new System.Drawing.Size(135, 20);
            this.txtBoxRazonSocial.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(99, 215);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // FormObraSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtBoxRazonSocial);
            this.Controls.Add(this.txtBoxTelefono);
            this.Controls.Add(this.txtBoxDireccion);
            this.Controls.Add(this.txtBoxCuit);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCuit);
            this.Name = "FormObraSocial";
            this.Text = "FormObraSocial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtCuit;
        private System.Windows.Forms.Label txtDireccion;
        private System.Windows.Forms.Label txtTelefono;
        private System.Windows.Forms.Label txtRazonSocial;
        private System.Windows.Forms.TextBox txtBoxCuit;
        private System.Windows.Forms.TextBox txtBoxDireccion;
        private System.Windows.Forms.TextBox txtBoxTelefono;
        private System.Windows.Forms.TextBox txtBoxRazonSocial;
        private System.Windows.Forms.Button btnRegistrar;
    }
}