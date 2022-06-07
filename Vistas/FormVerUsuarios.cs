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
    public partial class FormVerUsuarios : Form
    {
        public FormVerUsuarios()
        {
            InitializeComponent();
        }

        private void FormVerUsuarios_Load (object sender, EventArgs e)
        {
            
           dgvUsers.DataSource= TrabajarLogin.list_usuarios();
        }

        
    }
}
