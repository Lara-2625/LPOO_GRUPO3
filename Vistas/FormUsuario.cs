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
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }


        private void FormUsuario_Load(object sender, EventArgs e)
        {
            load_combo_roles();
            load_usuarios();
           
           // dgvUsuarios.ClearSelection();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
        private void load_combo_roles()
        {
            comboBoxRoles.DisplayMember = "Rol_Descripcion";
            comboBoxRoles.ValueMember = "Rol_Codigo";
            comboBoxRoles.DataSource = TrabajarUsuario.list_roles();
        }

        private void load_usuarios()
        {
            dgvUsuarios.DataSource = TrabajarUsuario.list_usuarios();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Rol_Codigo = (int)comboBoxRoles.SelectedValue;
            user.Usu_ApellidoNombre = txtBoxApellido.Text;
            user.Usu_NombreUsuario = txtBoxNombreUser.Text;
            user.Usu_Contraseña = txtBoxContraseña.Text;

            TrabajarUsuario.insert_usuario(user);
            load_usuarios();
            Limpiar();
        }

      

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            if (dgvUsuarios.CurrentCell!=null || dgvUsuarios.CurrentCell.Value!=null)
            {
              
                comboBoxRoles.SelectedValue = dgvUsuarios.CurrentRow.Cells["Rol_Codigo"].Value.ToString();
                txtBoxApellido.Text = dgvUsuarios.CurrentRow.Cells["Nombre y Apellido"].Value.ToString();
                txtBoxNombreUser.Text = dgvUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                txtBoxContraseña.Text = dgvUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
                txtBoxId.Text = dgvUsuarios.CurrentRow.Cells["ID"].Value.ToString();
               
                labelID.Visible = true;
                txtBoxId.Visible = true;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnSave.Enabled = false;

            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtBoxApellido.Clear();
            txtBoxContraseña.Clear();
            txtBoxNombreUser.Clear();
            labelID.Visible = false;
            txtBoxId.Visible = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            TrabajarUsuario.delete_usuario(Convert.ToInt32(txtBoxId.Text));
            Limpiar();
            load_usuarios();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Usu_ID = Convert.ToInt32(txtBoxId.Text);
            user.Rol_Codigo = (int)comboBoxRoles.SelectedValue;
            user.Usu_ApellidoNombre = txtBoxApellido.Text;
            user.Usu_NombreUsuario = txtBoxNombreUser.Text;
            user.Usu_Contraseña = txtBoxContraseña.Text;

            TrabajarUsuario.update_usuario(user);
            Limpiar();
            load_usuarios();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtBoxSearch.Text != "")
            {
                dgvUsuarios.DataSource = TrabajarUsuario.seach_usuario(txtBoxSearch.Text);
            }
            else
            {
                load_usuarios();
            }


        }

       

      

       
       
      
      
        
    }
}
