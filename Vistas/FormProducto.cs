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
    public partial class FormProducto : Form
    {
        public FormProducto()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea confirmar Registro?", "Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Producto product = new Producto();
                product.Prod_Descripcion = txtBoxDescripcion.Text;
                product.Prod_Categoria = txtBoxCategoria.Text;
                product.Prod_Precio = Convert.ToDecimal( txtBoxPrecio.Text);
                MessageBox.Show( "Codigo: "+product.Prod_Codigo + "\n" +"Descripcion: " + product.Prod_Descripcion + "\n" + "Precio: " + product.Prod_Precio , "Registro Exitoso");
                TrabajarProducto.alta_producto(product);
                dgvProductos.DataSource=TrabajarProducto.listar_producto(0);
                limpiar();
            }
            else
            {
                MessageBox.Show("Registro Cancelado");
            }
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rBtnCategoria.Checked == true)
            {
             
              dgvProductos.DataSource = TrabajarProducto.listar_producto(2);
              
            }
            else if(rBtnDescripcion.Checked== true)
            {
             
                dgvProductos.DataSource = TrabajarProducto.listar_producto(1);
            }
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = TrabajarProducto.listar_producto(0);
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
        private void limpiar()
        {
            txtBoxCategoria.Clear();
            txtBoxCodig.Clear();
            txtBoxDescripcion.Clear();
            txtBoxPrecio.Clear();
            btnRegistrar.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            labelCodigo.Visible = false;
            txtBoxCodig.Visible = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Producto product = new Producto();
            product.Prod_Codigo = Convert.ToInt32(txtBoxCodig.Text);
            product.Prod_Descripcion = txtBoxDescripcion.Text;
            product.Prod_Categoria = txtBoxCategoria.Text;
            product.Prod_Precio = Convert.ToDecimal(txtBoxPrecio.Text);
            TrabajarProducto.actualizar_producto(product);
            MessageBox.Show("Datos actualizados");
            dgvProductos.DataSource = TrabajarProducto.listar_producto(0);
            limpiar();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.CurrentCell.Value.ToString() != "" )
            {
                labelCodigo.Visible = true;
                txtBoxCodig.Visible = true;
                btnRegistrar.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                txtBoxCodig.Text = dgvProductos.CurrentRow.Cells["Prod_Codigo"].Value.ToString();
                txtBoxDescripcion.Text = dgvProductos.CurrentRow.Cells["Prod_Descripcion"].Value.ToString();
                txtBoxCategoria.Text = dgvProductos.CurrentRow.Cells["Prod_Categoria"].Value.ToString();
                txtBoxPrecio.Text = dgvProductos.CurrentRow.Cells["Prod_Precio"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TrabajarProducto.borrar_producto(dgvProductos.Text);
            MessageBox.Show("Producto Borrado con exito");
            limpiar();
            dgvProductos.DataSource = TrabajarProducto.listar_producto(0);
        }

      
        

       

       
    }
}
