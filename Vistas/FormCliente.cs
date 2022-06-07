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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea confirmar Registro?", "Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Cliente cliente = new Cliente();
                cliente.Cli_Nombre = txtBoxNombre.Text;
                cliente.Cli_Apellido = txtBoxApellido.Text;
                cliente.Cli_DNI = txtBoxDni.Text;
                cliente.Cli_Direccion = txtBoxDireccion.Text;
                cliente.Cli_NroCarnet = txtBoxNroCarnet.Text;
                cliente.Os_CUIT = comboBoxObras.SelectedValue.ToString();

                TrabajarCliente.insert_cliente(cliente);
                load_clientes();
                limpiar();
            }
            else
            {
                MessageBox.Show("Registro Cancelado");
            }
          


        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            load_obras();
            load_clientes();

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            
        }
        private void load_obras()
        {
            comboBoxObras.DisplayMember = "OS_RazonSocial";
            comboBoxObras.ValueMember = "OS_CUIT";
            comboBoxObras.DataSource = TrabajarCliente.list_obras();
        }
        private void load_clientes()
        {
            dgvClientes.DataSource = TrabajarCliente.list_clientes();

            
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.CurrentCell != null || dgvClientes.CurrentCell.Value != null)
            {

                comboBoxObras.SelectedValue = dgvClientes.CurrentRow.Cells["OS_CUIT"].Value.ToString();
                txtBoxDni.Text = dgvClientes.CurrentRow.Cells["Cli_DNI"].Value.ToString();
                txtBoxApellido.Text = dgvClientes.CurrentRow.Cells["Cli_Apellido"].Value.ToString();
                txtBoxNombre.Text = dgvClientes.CurrentRow.Cells["Cli_Nombre"].Value.ToString();
                txtBoxDireccion.Text = dgvClientes.CurrentRow.Cells["Cli_Direccion"].Value.ToString();
                txtBoxNroCarnet.Text = dgvClientes.CurrentRow.Cells["Cli_NroCarnet"].Value.ToString();
                

                
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnRegistrar.Enabled = false;

            }
        }

        private void limpiar()
        {
            txtBoxDni.Clear();
            txtBoxApellido.Clear();
            txtBoxNombre.Clear();
            txtBoxDireccion.Clear();
            txtBoxNroCarnet.Clear();

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnRegistrar.Enabled = true;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Cli_Nombre = txtBoxNombre.Text;
            cliente.Cli_Apellido = txtBoxApellido.Text;
            cliente.Cli_DNI = txtBoxDni.Text;
            cliente.Cli_Direccion = txtBoxDireccion.Text;
            cliente.Cli_NroCarnet = txtBoxNroCarnet.Text;
            cliente.Os_CUIT = comboBoxObras.SelectedValue.ToString();

            TrabajarCliente.update_cliente(cliente);
            limpiar();
            load_clientes();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TrabajarCliente.delete_cliente(txtBoxDni.Text);
            limpiar();
            load_clientes();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtBoxS.Text != "" )
            {
                dgvClientes.DataSource = TrabajarCliente.search_cliente(txtBoxS.Text);
            }
            else
            {
                load_clientes();
            }

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {

            dgvClientes.DataSource = TrabajarCliente.list_clientes_apellido();
        }

     




       

     
       
    }
}
