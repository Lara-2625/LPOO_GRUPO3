using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
namespace ClasesBase
{
    public class TrabajarUsuario
    {
        public static DataTable list_roles()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Roles";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la ocnsulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //LLena los datos de la consulta en un data Table
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable list_usuarios()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " Rol_Descripcion as 'Rol', ";
            cmd.CommandText += " Usu_ID as 'ID' ,";
            cmd.CommandText += " Usu_NombreUsuario as 'Usuario' ,";
            cmd.CommandText += " Usu_ApellidoNombre as 'Nombre y Apellido', ";
            cmd.CommandText += " Usu_Contraseña as 'Contraseña',U.Rol_Codigo ";
            cmd.CommandText += " FROM Usuario as U";
            cmd.CommandText += " LEFT JOIN Roles as R ON (R.Rol_Codigo=U.Rol_Codigo)";
            cmd.CommandType= CommandType.Text;
            cmd.Connection = cnn;

            //Ejecutar la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public static void insert_usuario(Usuario user)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuario(Usu_NombreUsuario,Usu_Contraseña,Usu_ApellidoNombre,Rol_Codigo) values (@nomusu,@pass,@nomyape,@rol)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            
            cmd.Parameters.AddWithValue("@nomusu",user.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@pass",user.Usu_Contraseña);
            cmd.Parameters.AddWithValue("@nomyape", user.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol", user.Rol_Codigo);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static void delete_usuario(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Usuario WHERE Usu_ID=" + id;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;


            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static void update_usuario(Usuario user)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Usuario SET Usu_NombreUsuario = @nomusu, Usu_Contraseña = @pass, Usu_ApellidoNombre = @nomyape, Rol_Codigo=@rol WHERE Usu_ID="+user.Usu_ID;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@nomusu", user.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@pass", user.Usu_Contraseña);
            cmd.Parameters.AddWithValue("@nomyape", user.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol", user.Rol_Codigo);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static DataTable seach_usuario(string sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " Rol_Descripcion as 'Rol', ";
            cmd.CommandText += " Usu_ID as 'ID' ,";
            cmd.CommandText += " Usu_NombreUsuario as 'Usuario' ,";
            cmd.CommandText += " Usu_ApellidoNombre as 'Nombre y Apellido', ";
            cmd.CommandText += " Usu_Contraseña as 'Contraseña',U.Rol_Codigo ";
            cmd.CommandText += " FROM Usuario as U";
            cmd.CommandText += " LEFT JOIN Roles as R ON (R.Rol_Codigo=U.Rol_Codigo)";

            cmd.CommandText += "WHERE Usu_NombreUsuario LIKE @pattern";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }



     }
}
