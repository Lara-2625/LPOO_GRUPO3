using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Data;
using System.Data.SqlClient;
namespace ClasesBase
{
    public class TrabajarLogin
    {
        public static DataTable list_usuarios()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " Rol_Descripcion as 'Rol', ";
            cmd.CommandText += " Usu_NombreUsuario as 'Usuario' ";
            cmd.CommandText += " FROM Usuario as U";
            cmd.CommandText += " LEFT JOIN Roles as R ON (R.Rol_Codigo=U.Rol_Codigo)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecutar la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public static Usuario login_check(string User_Name, string User_Password)
        {
            Usuario user= new Usuario();
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Usu_ID,Usu_NombreUsuario, Usu_Contraseña,Usu_ApellidoNombre,Rol_Codigo FROM Usuario WHERE Usu_NombreUsuario='" + User_Name+ "' AND Usu_Contraseña='"+User_Password+"'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;


            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
           
            
            if (dr.Read())
            {
                user.Usu_ID = Convert.ToInt32(dr["Usu_ID"].ToString());
                user.Usu_NombreUsuario = dr["Usu_NombreUsuario"].ToString();
                user.Usu_Contraseña = dr["Usu_Contraseña"].ToString();
                user.Usu_ApellidoNombre = dr["Usu_ApellidoNombre"].ToString();
                user.Rol_Codigo = Convert.ToInt32(dr["Rol_Codigo"].ToString());
            }
            else
            {
                user = null;
            }
            cnn.Close();
            return user;
            
        }

    }
}
