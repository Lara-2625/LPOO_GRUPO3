using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
namespace ClasesBase
{
    public class TrabajarCliente
    {

        public static DataTable list_obras()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM ObraSocial";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la ocnsulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //LLena los datos de la consulta en un data Table
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable list_clientes()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " OS_RazonSocial , ";
            cmd.CommandText += " Cli_DNI , ";
            cmd.CommandText += " Cli_Apellido , ";
            cmd.CommandText += " Cli_Nombre , ";
            cmd.CommandText += " Cli_Direccion , ";
            cmd.CommandText += " Cli_NroCarnet , ";
            cmd.CommandText += " OS.OS_CUIT ";
            cmd.CommandText += " FROM Cliente as C";
            cmd.CommandText += " LEFT JOIN ObraSocial as OS ON (OS.OS_CUIT=C.OS_CUIT)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecutar la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public static void insert_cliente(Cliente cli)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Cliente(Cli_DNI,Cli_Apellido,Cli_Nombre,Cli_Direccion,OS_CUIT,Cli_NroCarnet) values (@dni,@apellido,@nombre,@dire,@OS_CUIT,@NroCarnet)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;


            cmd.Parameters.AddWithValue("@dni", cli.Cli_DNI);
            cmd.Parameters.AddWithValue("@apellido", cli.Cli_Apellido);
            cmd.Parameters.AddWithValue("@nombre", cli.Cli_Nombre);
            cmd.Parameters.AddWithValue("@dire", cli.Cli_Direccion);
            cmd.Parameters.AddWithValue("@OS_CUIT", cli.Os_CUIT);
            cmd.Parameters.AddWithValue("@NroCarnet", cli.Cli_NroCarnet);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static void delete_cliente(string dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Cliente WHERE Cli_DNI=" + "'"+dni+"'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;


            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static void update_cliente(Cliente cliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Cliente SET Cli_DNI = @dni, Cli_Apellido = @apellido, Cli_Nombre = @nombre, Cli_Direccion = @dire, OS_CUIT = @OS_CUIT, Cli_NroCarnet = @NroCarnet WHERE Cli_DNI=" + cliente.Cli_DNI;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", cliente.Cli_DNI);
            cmd.Parameters.AddWithValue("@apellido", cliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@nombre", cliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@dire", cliente.Cli_Direccion);
            cmd.Parameters.AddWithValue("@OS_CUIT", cliente.Os_CUIT);
            cmd.Parameters.AddWithValue("@NroCarnet", cliente.Cli_NroCarnet);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static DataTable search_cliente(string sPattern1)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " OS_RazonSocial , ";
            cmd.CommandText += " Cli_DNI ," ;
            cmd.CommandText += " Cli_Apellido , ";
            cmd.CommandText += " Cli_Nombre , ";
            cmd.CommandText += " Cli_Direccion , ";
            cmd.CommandText += " Cli_NroCarnet , ";
            cmd.CommandText += " OS.OS_CUIT ";
            cmd.CommandText += " FROM Cliente as C";
            cmd.CommandText += " LEFT JOIN ObraSocial as OS ON (OS.OS_CUIT=C.OS_CUIT)";

            cmd.CommandText += "WHERE (Cli_Nombre  LIKE @pattern1 OR Cli_NroCarnet LIKE @pattern1) ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern1", "%" + sPattern1 + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public static DataTable list_clientes_apellido()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_clientes_apellido";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
