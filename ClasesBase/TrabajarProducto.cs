using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
namespace ClasesBase
{
    public class TrabajarProducto
    {
        public static DataTable listar_producto(int opcion){

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_productos_descripcion";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@parameter1", opcion);
            //Ejecuta la ocnsulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //LLena los datos de la consulta en un data Table
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void alta_producto(Producto producto)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "producto_alta";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@categoria", producto.Prod_Categoria);
            cmd.Parameters.AddWithValue("@descripcion", producto.Prod_Descripcion);
            cmd.Parameters.AddWithValue("@precio", producto.Prod_Precio);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        
        }
        public static void actualizar_producto(Producto prod)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "producto_actualizar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@codigo", prod.Prod_Codigo);
            cmd.Parameters.AddWithValue("@categoria", prod.Prod_Categoria);
            cmd.Parameters.AddWithValue("@descripcion", prod.Prod_Descripcion);
            cmd.Parameters.AddWithValue("@precio", prod.Prod_Precio);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static void borrar_producto(String codigo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "producto_borrar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@codigo" , codigo);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

    }
}
