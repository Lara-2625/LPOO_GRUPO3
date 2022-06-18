namespace Vistas
{
    partial class FormLogin
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.Label();
            this.inputUsername = new System.Windows.Forms.TextBox();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEnviar.Location = new System.Drawing.Point(113, 303);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(255, 34);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Aceptar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            this.btnEnviar.MouseLeave += new System.EventHandler(this.OnMouseLeavebtnEnviear);
            this.btnEnviar.MouseHover += new System.EventHandler(this.OnMouseEnterbtnEnviar);
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Location = new System.Drawing.Point(194, 116);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(46, 13);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Usuario:";
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.Location = new System.Drawing.Point(194, 186);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(67, 13);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Contraseña: ";
            // 
            // inputUsername
            // 
            this.inputUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputUsername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.inputUsername.Location = new System.Drawing.Point(194, 132);
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.Size = new System.Drawing.Size(174, 38);
            this.inputUsername.TabIndex = 3;
            // 
            // inputPassword
            // 
            this.inputPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPassword.Location = new System.Drawing.Point(194, 202);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.PasswordChar = '*';
            this.inputPassword.Size = new System.Drawing.Size(174, 38);
            this.inputPassword.TabIndex = 4;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.ForeColor = System.Drawing.Color.DarkRed;
            this.btnUsuarios.Location = new System.Drawing.Point(188, 343);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(105, 23);
            this.btnUsuarios.TabIndex = 7;
            this.btnUsuarios.Text = "Ver Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Vistas.Properties.Resources.img2;
            this.pictureBox2.Location = new System.Drawing.Point(113, 201);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vistas.Properties.Resources.img1;
            this.pictureBox1.Location = new System.Drawing.Point(113, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(140, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Iniciar Sesion";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(461, 394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.inputUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnEnviar);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLogin";
            this.Text = "Bienvenido al Sistema";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.TextBox inputUsername;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Label label1;
    }
}

