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
    public partial class FormObraSocial : Form
    {
        public FormObraSocial()
        {
            InitializeComponent();
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea confirmar Registro?", "Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                ObraSocial obrSoc = new ObraSocial();
                obrSoc.Os_CUIT = txtBoxCuit.Text;
                obrSoc.Os_Direccion = txtBoxDireccion.Text;
                obrSoc.Os_RazonSocial = txtBoxRazonSocial.Text;
                obrSoc.Os_Telefono = txtBoxTelefono.Text;
                MessageBox.Show("Cuit: " + obrSoc.Os_CUIT + "\n" + "Direccion: " + obrSoc.Os_Direccion + "\n" + "Telefono: " + obrSoc.Os_Telefono, "Registro Exitoso");

            }
            else
            {
                MessageBox.Show("Registro Cancelado");
            }
        }

       
    }
}
