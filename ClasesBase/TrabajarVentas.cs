using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
namespace ClasesBase
{
    public class TrabajarVentas
    {
        public static DataTable list_Cliente()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Cliente";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la ocnsulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //LLena los datos de la consulta en un data Table
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns.Add("Cli_NombreCompleto", typeof(string), "Cli_Apellido +', ' +Cli_Nombre");
            return dt;
        }
        public static DataTable list_Productos()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Producto";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la ocnsulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //LLena los datos de la consulta en un data Table
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            
        }

        public static void insert_venta_detalle(Venta venta, VentaDetalle vDetalle)
        {
            int ven_nro;

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Venta(Ven_Fecha,Cli_Dni) values (@fecha,@dni)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;


            cmd.Parameters.AddWithValue("@fecha",  venta.Ven_Fecha);
            cmd.Parameters.AddWithValue("@dni", venta.Cli_DNI);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            
            cmd.CommandText = "SELECT MAX(Ven_Nro) AS 'Ven_Nro' FROM Venta";
            cmd.CommandType = CommandType.Text;

            cnn.Open();
            cmd.ExecuteNonQuery();
           
            ven_nro = Convert.ToInt32(cmd.ExecuteScalar());
            cnn.Close();
            
           

            cmd.CommandText = "INSERT INTO VentaDetalle(Ven_Nro,Prod_Codigo,Det_Precio,Det_Cantidad,Det_Total) values (@vennro,@prodcod,@precio,@cantidad,@total)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@vennro", ven_nro);
            cmd.Parameters.AddWithValue("@prodcod", vDetalle.Prod_Codigo);
            cmd.Parameters.AddWithValue("@precio", vDetalle.Det_Precio);
            cmd.Parameters.AddWithValue("@cantidad", vDetalle.Det_Cantidad);
            cmd.Parameters.AddWithValue("@total", vDetalle.Det_Total);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
        public static void insert_venta(Venta venta)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Venta(Ven_Fecha,Cli_Dni) values (@fecha,@dni)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@fecha", venta.Ven_Fecha);
            cmd.Parameters.AddWithValue("@dni", venta.Cli_DNI);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static void insert_vDetalle(VentaDetalle vDetalle)
        {
            int ven_nro;

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT MAX(Ven_Nro) AS 'Ven_Nro' FROM Venta";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cnn.Open();
            cmd.ExecuteNonQuery();

            ven_nro = Convert.ToInt32(cmd.ExecuteScalar());
            cnn.Close();



            cmd.CommandText = "INSERT INTO VentaDetalle(Ven_Nro,Prod_Codigo,Det_Precio,Det_Cantidad,Det_Total) values (@vennro,@prodcod,@precio,@cantidad,@total)";
            
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@vennro", ven_nro);
            cmd.Parameters.AddWithValue("@prodcod", vDetalle.Prod_Codigo);
            cmd.Parameters.AddWithValue("@precio", vDetalle.Det_Precio);
            cmd.Parameters.AddWithValue("@cantidad", vDetalle.Det_Cantidad);
            cmd.Parameters.AddWithValue("@total", vDetalle.Det_Total);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


        public static DataTable listar_Ventas()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT V.Ven_Nro as 'Venta_Numero', V.Ven_Fecha as 'Venta_Fecha', V.Cli_DNI as 'DNI Cliente', C.Cli_Nombre as 'Nombre Cliente' FROM Venta as V";
            cmd.CommandText += " LEFT JOIN Cliente as C ON(C.Cli_DNI=V.Cli_DNI)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la ocnsulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //LLena los datos de la consulta en un data Table
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable listar_Ventas_Cliente(String cli_dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_venta_cliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", cli_dni);


            //Ejecuta la ocnsulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //LLena los datos de la consulta en un data Table
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public static DataTable listar_Ventas_Fecha(DateTime dInicio, DateTime dFin)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_venta_fecha";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dInicio", dInicio);
            cmd.Parameters.AddWithValue("@dFin", dFin);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable listar_Producto_Cliente(string dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_productos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", dni);
           

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable listar_Producto_Fecha(DateTime dInicio, DateTime dFin)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_productos_fecha";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dInicio", dInicio);
            cmd.Parameters.AddWithValue("@dFin", dFin);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static int contar_clientes_ventas(string dni)
        {
            int cant_cliente=0;
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "contar_clientes_ventas";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", dni);
            cmd.Parameters.AddWithValue("@count", SqlDbType.Int);
            cmd.Parameters["@count"].Direction = ParameterDirection.Output;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            if (cmd.Parameters["@count"].Value.GetType() == Type.GetType("System.Int32"))
            {
                cant_cliente = (int)cmd.Parameters["@count"].Value;
            }
            return cant_cliente;
        }
        public static int contar_ventas_fecha(DateTime dInicio,DateTime dFin)
        {
            int cant_ventas_fecha=0;
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "contar_ventas_fecha";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dInicio", dInicio);
            cmd.Parameters.AddWithValue("@dFin", dFin);
            cmd.Parameters.AddWithValue("@count", SqlDbType.Int);
            cmd.Parameters["@count"].Direction = ParameterDirection.Output;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            if (cmd.Parameters["@count"].Value.GetType() == Type.GetType("System.Int32"))
            {
                cant_ventas_fecha = (int)cmd.Parameters["@count"].Value;
            }
            return cant_ventas_fecha;
        }
        public static int contar_productos_cliente(string dni)
        {
            int total_cliente=0;
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "contar_productos_cliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", dni);

            cnn.Open();
            if (cmd.ExecuteScalar().GetType() == Type.GetType("System.Decimal"))
            {
                total_cliente = Convert.ToInt32(cmd.ExecuteScalar());
            }
            cnn.Dispose();
            cmd.Dispose();
            cnn.Close();
            
            

            return total_cliente;
        }
        public static decimal contar_productos_fecha(DateTime dInicio, DateTime dFin)
        {
            decimal cant_productos_fecha = 0;
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "contar_productos_fecha";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dInicio", dInicio);
            cmd.Parameters.AddWithValue("@dFin", dFin);



            cnn.Open();
            if (cmd.ExecuteScalar().GetType() == Type.GetType("System.Decimal"))
            {
                cant_productos_fecha = Convert.ToInt32(cmd.ExecuteScalar());
            }
  
            cnn.Dispose();
            cmd.Dispose();
            cnn.Close();

            return cant_productos_fecha;
        }

        public static void borrar_venta(String codigo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ventasBorrar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@codigo", codigo);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

    }
}
