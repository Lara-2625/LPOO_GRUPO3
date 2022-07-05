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
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            load_ventas();
        }
        private void load_ventas()
        {
            dgvVentas.DataSource = TrabajarVentas.listar_Ventas();
            comboBoxCliente.DisplayMember = "Cli_NombreCompleto";
            comboBoxCliente.ValueMember = "Cli_DNI";
            comboBoxCliente.DataSource = TrabajarVentas.list_Cliente();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvVentas.DataSource=TrabajarVentas.listar_Ventas_Cliente(comboBoxCliente.SelectedValue.ToString());
            txtBoxNomCliente.Text = comboBoxCliente.Text;
            txtBoxCantClientes.Text= (TrabajarVentas.contar_clientes_ventas(comboBoxCliente.SelectedValue.ToString())).ToString();
            txtBoxFechaF.Clear();
            txtBoxFechaI.Clear();
            txtBoxTotalFecha.Clear();
        }

        private void btnListarD_Click(object sender, EventArgs e)
        {
            dgvVentas.DataSource = TrabajarVentas.listar_Ventas_Fecha(Convert.ToDateTime(dtpInicio.Text), Convert.ToDateTime(dtpFin.Text));
            txtBoxFechaI.Text = dtpInicio.Text;
            txtBoxFechaF.Text= dtpFin.Text;
            txtBoxTotalFecha.Text = (TrabajarVentas.contar_ventas_fecha(Convert.ToDateTime(dtpInicio.Text), Convert.ToDateTime(dtpFin.Text))).ToString();
            txtBoxNomCliente.Clear();
            txtBoxCantClientes.Clear();
        }
      
        private void dgvVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVentas.Rows.Count != 0)
            {
                if (dgvVentas.Rows.Count != 1)
                {
                    string valuemember = dgvVentas.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string name = dgvVentas.Rows[e.RowIndex].Cells[3].Value.ToString();
                    DialogResult d = MessageBox.Show("Esta seguro que desea eliminar el registro de ventas N°"+valuemember+" del cliente "+name,"ADVERTENCIA!!!",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
                    if (d == DialogResult.Yes)
                    {
                        TrabajarVentas.borrar_venta(valuemember);                        
                        dgvVentas.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Venta Eliminada con exito");
                    }
                    
                    
                }
            }
            
        }

    }
}
