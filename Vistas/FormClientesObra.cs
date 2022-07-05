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
    public partial class FormClientesObra : Form
    {
        public FormClientesObra()
        {
            InitializeComponent();
        }

        private void FormClientesObra_Load(object sender, EventArgs e)
        {
            load_obras();
        }
        private void load_obras()
        {
            comboBoxObras.DisplayMember = "OS_RazonSocial";
            comboBoxObras.ValueMember = "OS_CUIT";
            comboBoxObras.DataSource = TrabajarCliente.list_obras();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (comboBoxObras.SelectedValue != null)
            {
                dgvClientes.DataSource = TrabajarCliente.listar_clientes_obra(comboBoxObras.SelectedValue.ToString());
                txtBoxObra.Text = comboBoxObras.Text;
                txtBoxTotalClientes.Text = TrabajarCliente.contar_clientes_obra(comboBoxObras.SelectedValue.ToString()).ToString();
            }

        }
    }
}
