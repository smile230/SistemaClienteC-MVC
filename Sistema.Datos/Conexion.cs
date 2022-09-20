using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql;

namespace Sistema.Datos
{
    class Conexion
    {
        private string Base;
        private string Host;
        private string Usuario;
        private string Clave;
        private string Port;
        private static Conexion con = null;

        private Conexion()
        {
            this.Base = "aries";
            this.Host = "192.168.0.27";
            this.Usuario = "developer";
            this.Clave = "D3veLopEr18";
            this.Port = "3306";
            //this.Host = "localhost";
            //this.Usuario = "root";
            //this.Clave = "";
        }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection cadena = new MySqlConnection();
            try
            {
                cadena.ConnectionString = "Server="+this.Host+";Port="+this.Port+";Uid="+this.Usuario+";Pwd="+this.Clave+";Database="+this.Base+";";
                
            }
            catch(Exception ex)
            {
                cadena = null;
                throw ex;
            }

            return cadena;
        }

        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}
