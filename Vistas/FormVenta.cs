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
    public partial class FormVenta : Form
    {
        DataTable dt;
        Boolean band = false;
        public FormVenta()
        {
            InitializeComponent();
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            load_clientes();
            load_productos();
            MessageBox.Show("Para agregar mas productos solo presione el boton agregar mas productos una vez seleccionado el producto y la cantidad. Al finalizar solo presione guardar venta :)");

           
        }
        private void load_productos()
        {
            comboBoxProductos.DisplayMember = "Prod_Descripcion";
            comboBoxProductos.ValueMember = "Prod_Codigo";
            comboBoxProductos.DataSource = TrabajarVentas.list_Productos();
            dt = TrabajarVentas.list_Productos();
            
            
        }

        private void load_clientes()
        {
            comboBoxClientes.DisplayMember = "Cli_Nombre";
            comboBoxClientes.ValueMember = "Cli_DNI";
            comboBoxClientes.DataSource = TrabajarVentas.list_Cliente();

         
        }
        private void btnSave_Click(object sender, EventArgs e)
        {


            if (band == false)
            {
                TrabajarVentas.insert_venta_detalle(venta(), vDetalle());
            }
            else
            {
                TrabajarVentas.insert_vDetalle(vDetalle());
            }




            limpiar();
            comboBoxClientes.Enabled = true;
            dtpVenta.Enabled = true;
            band = false;
            MessageBox.Show("Registro Exitoso");
        }

        private void txtBoxCantidad_TextChanged(object sender, EventArgs e)
        {
            calculo();
        }
        private void txtBoxPrecio_TextChanged(object sender, EventArgs e)
        {
            calculo();
        }

        
        private void calculo()
        {
            if (txtBoxCantidad.Text != "" && txtBoxPrecio.Text != "")
            {
                txtBoxTotal.Text = (Convert.ToString((Convert.ToDecimal(txtBoxPrecio.Text)) * (Convert.ToDecimal(txtBoxCantidad.Text))));
            }
        }

        private void comboBoxProductos_SelectionChangeCommitted(object sender, EventArgs e)
        {
      
            for (var i = 0; i < dt.Rows.Count; i++)
            {

                             if (dt.Rows[i]["Prod_Codigo"].ToString() ==comboBoxProductos.SelectedValue.ToString()  )
                                {
                    
                                    txtBoxPrecio.Text = dt.Rows[i]["Prod_Precio"].ToString();
                                }
            }
        }
        private Venta venta()
        {
            Venta venta = new Venta();
            venta.Cli_DNI = comboBoxClientes.SelectedValue.ToString();
            venta.Ven_Fecha = Convert.ToDateTime(dtpVenta.Text);
            return venta;
        }
        private VentaDetalle vDetalle()
        {
            VentaDetalle vDetalle = new VentaDetalle();

            vDetalle.Prod_Codigo = comboBoxProductos.SelectedValue.ToString();
            vDetalle.Det_Cantidad = Convert.ToDecimal(txtBoxCantidad.Text);
            vDetalle.Det_Precio = Convert.ToDecimal(txtBoxPrecio.Text);
            vDetalle.Det_Total = vDetalle.Det_Cantidad * vDetalle.Det_Precio;

            return vDetalle;
        }


        private void btnMasProducto_Click(object sender, EventArgs e)
        {
            ListViewItem lista = new ListViewItem(comboBoxProductos.Text);
            lista.SubItems.Add(txtBoxPrecio.Text);
            lista.SubItems.Add(txtBoxCantidad.Text);
            lVProductos.Items.Add(lista);

            comboBoxClientes.Enabled = false;
            dtpVenta.Enabled = false;


            if (band == false)
            {
                TrabajarVentas.insert_venta(venta());
                TrabajarVentas.insert_vDetalle(vDetalle());
                band = true;
            }
            else
            {
                TrabajarVentas.insert_vDetalle(vDetalle());

            }

        }
        private void limpiar()
        {
            txtBoxCantidad.Clear();
            txtBoxPrecio.Clear();
            txtBoxTotal.Clear();
            lVProductos.Clear();
        }

        


       
        

       

      

        
    }
}
