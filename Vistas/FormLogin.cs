using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FormLogin : Form
    {
        
        public FormLogin()
        {
            InitializeComponent();
        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            string User_Name = inputUsername.Text;
            string User_Password = inputPassword.Text;

           /* Roles rol1 = new Roles(1, "Amdninistrador");
            Roles rol2 = new Roles(2,"Operador");
            Roles rol3 = new Roles(3, "Auditor");*/

            FormMain oFrmMain = new FormMain();
            
           /* if (oUser1.Usu_NombreUsuario == inputUsername.Text && oUser1.Usu_Contraseña == inputPassword.Text)
            {
                bUserFound = true;
            }
            else if (oUser2.Usu_NombreUsuario == txtUsername.Text && oUser2.Usu_Contraseña == txtPassword.Text)
            {
                bUserFound = true;
            }*/
            user = TrabajarLogin.login_check(User_Name,User_Password);

            if (user!=null)
            {
                oFrmMain.user = user;
                MessageBox.Show("Bienvenido/a: " + inputUsername.Text);
                oFrmMain.Show();
            }else{
                MessageBox.Show("Datos de Acceso Incorrecto");
            }

        }
        private void OnMouseEnterbtnEnviar(object sender, EventArgs e)
        {
            btnEnviar.BackColor = Color.NavajoWhite;
            btnEnviar.Font = new Font(btnEnviar.Font.FontFamily, 12);
           
        }
        private void OnMouseLeavebtnEnviear(object sender, EventArgs e) 
        {
            btnEnviar.BackColor = Color.OrangeRed;
            btnEnviar.Font = Button.DefaultFont;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormVerUsuarios formVerUsuarios = new FormVerUsuarios();
            formVerUsuarios.Show();
        }

        
       

        
    }
}
