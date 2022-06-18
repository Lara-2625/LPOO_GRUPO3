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
    public partial class FormMain : Form
    {
        public Usuario user = new Usuario();
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
           if (user.Rol_Codigo == 1)
            {
                tsmUsuarios.Enabled = false;
                tsmProductos.Enabled = false;
                BtnAltaProducto.Enabled = false;
            }
            else if (user.Rol_Codigo == 2)
            {
                tsmVentas.Enabled = false;
                tsmClientes.Enabled = false;
                BtnAltaCliente.Enabled = false;
            }



        }
        

        private void BtnAltaObraSocial_Click(object sender, EventArgs e)
        {
            FormObraSocial frmObraSocial = new FormObraSocial();
            frmObraSocial.Show();
        }

        private void BtnAltaCliente_Click(object sender, EventArgs e)
        {
            FormCliente frmCliente = new FormCliente();
            frmCliente.Show();
        }

        private void BtnAltaProducto_Click(object sender, EventArgs e)
        {
            FormProducto frmProducto = new FormProducto();
            frmProducto.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

      

        private void aBMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuario frmUsuario = new FormUsuario();
            frmUsuario.Show();
        }

        private void altaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVenta frmVenta = new FormVenta();
            frmVenta.Show();
        }

        private void listadoVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVentas frmVentas = new FormVentas();
            frmVentas.Show();
        }

     
      

        private void aBMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCliente frmCliente = new FormCliente();
            frmCliente.Show();
        }

        private void altaProuctoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProducto frmProducto = new FormProducto();
            frmProducto.Show();
        }

        private void listadoProductosVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVentasDetalles frmVentaDetalle = new FormVentasDetalles();
            frmVentaDetalle.Show();
        }

        private void lIstadoDetalleDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVentasDetalles frmVentaDetalle = new FormVentasDetalles();
            frmVentaDetalle.Show();
        }

        private void listadoBusquedaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClienteBusqueda frmClienteBusqueda = new FormClienteBusqueda();
            frmClienteBusqueda.Show();
        }

        private void clientesAfiliadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientesObra frmCliObra = new FormClientesObra();
            frmCliObra.Show();
        }

      
      
       

        

      

        




    }
}
