using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LPOO_GRUPO3
{
    public class Usuario
    {
        private int usu_ID;
        private string usu_NobreUsuario;
        private string usu_Contraseña;
        private string usu_ApellidoNombre;
        private int rol_Codigo;

        public string Usu_Contraseña
        {
            get { return usu_Contraseña; }
            set { usu_Contraseña = value; }
        }
        public int Usu_ID
        {
            get { return usu_ID; }
            set { usu_ID = value; }
        }
        public string Usu_NombreUsuario
        {
            get { return usu_NobreUsuario; }
            set { usu_NobreUsuario = value; }
        }
        public string UsuApellidoNombre
        {
            get { return usu_ApellidoNombre; }
            set { usu_ApellidoNombre = value; }
        }
        public int Rol_Codigo
        {
            get { return Rol_Codigo; }
            set { Rol_Codigo = value; }
        }

        public Usuario(string username, string password)
        {
            usu_NobreUsuario = username;
            usu_Contraseña = password;
        }
    
    }
}
