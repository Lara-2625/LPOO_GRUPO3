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
    public partial class FormClienteBusqueda : Form
    {
        public FormClienteBusqueda()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvCliente.DataSource=TrabajarClienteBusqueda.listar_clientes_patron(txtBoxPatron.Text);
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            dgvCliente.DataSource=TrabajarClienteBusqueda.listar_clientes_ordernar(comboBoxOrdenar.Text);
            
        }

        private void FormClienteBusqueda_FormClosing(object sender, FormClosingEventArgs e)
        {
            string valuemember;
            string dispalymember;
            if (dgvCliente.Rows.Count != 0)
            {
                if (dgvCliente.Rows.Count!= 1 )
                {

                    valuemember = dgvCliente.Rows[0].Cells[0].Value.ToString();
                    dispalymember = dgvCliente.Rows[0].Cells[1].Value.ToString();
                    FormVenta frmVenta = new FormVenta();
                    frmVenta.valuemember = valuemember;
                    frmVenta.Show();
                }
            }
            
           
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {

            if (dgvCliente.Rows.Count != 0 && dgvCliente.Rows.Count != 1)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("No seleccionaste ningun cliente Actual");
            }
        }


    }
}
