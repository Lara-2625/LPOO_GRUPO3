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
    public partial class FormVentasDetalles : Form
    {
        public FormVentasDetalles()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (comboBoxClientes.SelectedValue != null)
            {
                dgvProductos.DataSource = TrabajarVentas.listar_Producto_Cliente(comboBoxClientes.SelectedValue.ToString());

                txtBoxNomCliente.Text = comboBoxClientes.Text;
                txtBoxCantClientes.Text = TrabajarVentas.contar_productos_cliente(comboBoxClientes.SelectedValue.ToString()).ToString();
            }
            txtBoxFechaF.Clear();
            txtBoxFechaI.Clear();
            txtBoxTotalFecha.Clear();
        }

        private void FormVentasDetalles_Load(object sender, EventArgs e)
        {
            comboBoxClientes.DisplayMember = "Cli_NombreCompleto";
            comboBoxClientes.ValueMember = "Cli_DNI";
            comboBoxClientes.DataSource = TrabajarVentas.list_Cliente();

        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = TrabajarVentas.listar_Producto_Fecha(Convert.ToDateTime(dtpInicio.Text), Convert.ToDateTime(dtpFin.Text));
            txtBoxFechaI.Text = dtpInicio.Text;
            txtBoxFechaF.Text = dtpFin.Text;
 
            txtBoxTotalFecha.Text = TrabajarVentas.contar_productos_fecha(Convert.ToDateTime(dtpInicio.Text), Convert.ToDateTime(dtpFin.Text)).ToString();
            txtBoxNomCliente.Clear();
            txtBoxCantClientes.Clear();
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
