using System.Data;
using MySql.Data.MySqlClient;
using MySql;
using Sistema.Entidades;
using System.Collections.Generic;

namespace Sistema.Datos
{
    public class DCliente
    {
        public List<Cliente> Listar()
        {
            MySqlDataReader Resultado;
            MySqlConnection SqlCn = new MySqlConnection();            
            List<Cliente> Lista = null;
            Cliente Obj = null;
            try
            {
                Lista = new List<Cliente>();
                SqlCn = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("SP_CLIENTELISTAR", SqlCn);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCn.Open();
                Resultado = Comando.ExecuteReader();
                
                while (Resultado.Read())
                {
                    int i = 0;
                    Obj = new Cliente();
                    Obj.IdCte = Resultado.GetInt32(i); i++;
                    Obj.IdMedio = Resultado.GetInt32(i); i++;
                    Obj.IdCto = Resultado.GetInt32(i); i++;
                    Obj.Nombre = Resultado.GetString(i); i++; 
                    Obj.Apellido_Paterno = Resultado.GetString(i); i++;
                    Obj.Apellido_Materno = Resultado.GetString(i); i++;
                    Obj.Sexo = Resultado.GetString(i); i++;
                    Obj.Edo_Civil = Resultado.GetString(i); i++;
                    Obj.Residencia = Resultado.GetChar(i); i++;
                    Obj.RetIsr = Resultado.GetChar(i); i++;
                    Obj.Rfc = Resultado.GetString(i); i++;
                    Obj.FechaNa = Resultado.GetString(i); i++;
                    Obj.Curp = Resultado.GetString(i); i++;
                    Obj.Nacionalidad = Resultado.GetString(i); i++;
                    Obj.TelCasa = Resultado.GetString(i); i++;
                    Obj.Celular = Resultado.GetString(i); i++;
                    Obj.TelOficina = Resultado.GetString(i); i++;
                    Obj.TelOtro = Resultado.GetString(i); i++;
                    Obj.Nextel = Resultado.GetString(i); i++;
                    Obj.Fax1 = Resultado.GetString(i); i++;
                    Obj.Email1 = Resultado.GetString(i); i++;
                    Obj.Email2 = Resultado.GetString(i); i++;
                    Obj.Email3 = Resultado.GetString(i); i++;
                    Obj.Web = Resultado.GetString(i); i++;
                    Obj.Tipo = Resultado.GetString(i); i++;
                    Obj.Fecha_Creacion = Resultado.GetDateTime(i); i++;
                    Obj.Creado_Por = Resultado.GetInt32(i); i++;
                    Obj.FechaAn = Resultado.GetString(i); i++;
                    Obj.IdZoho = Resultado.GetString(i); i++;
                    Obj.EntidadNacimiento = Resultado.GetString(i); i++;
                    Obj.CiudadNacimiento = Resultado.GetString(i); i++;
                    Obj.PaisNacimiento = Resultado.GetString(i); i++;
                    Lista.Add(Obj);
                }
                
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCn.State == ConnectionState.Open) SqlCn.Close();
            }

            return Lista;
        }
        public string Insertar(Cliente Obj)
        {            
            MySqlConnection SqlCn = new MySqlConnection();            
            string Respuesta = string.Empty;

            try
            {
                SqlCn = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando  = new MySqlCommand("SP_CLIENTEINSERTAR", SqlCn);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@_IdMedio", MySqlDbType.Int32).Value = Obj.IdMedio;
                Comando.Parameters.Add("@_IdCto", MySqlDbType.Int32).Value = Obj.IdCto;
                Comando.Parameters.Add("@_Nombre", MySqlDbType.VarChar).Value = Obj.Nombre;
                Comando.Parameters.Add("@_Apellido_Paterno", MySqlDbType.VarChar).Value = Obj.Apellido_Paterno;
                Comando.Parameters.Add("@_Apellido_Materno", MySqlDbType.VarChar).Value = Obj.Apellido_Materno;
                Comando.Parameters.Add("@_Sexo", MySqlDbType.VarChar).Value = Obj.Sexo;
                Comando.Parameters.Add("@_Edo_Civil", MySqlDbType.VarChar).Value = Obj.Edo_Civil;
                Comando.Parameters.Add("@_Residencia", MySqlDbType.String).Value = Obj.Residencia;
                Comando.Parameters.Add("@_RetIsr", MySqlDbType.String).Value = Obj.RetIsr;
                Comando.Parameters.Add("@_Rfc", MySqlDbType.VarChar).Value = Obj.Rfc;
                Comando.Parameters.Add("@_FechaNa", MySqlDbType.VarChar).Value = Obj.FechaNa;
                Comando.Parameters.Add("@_Curp", MySqlDbType.VarChar).Value = Obj.Curp;
                Comando.Parameters.Add("@_Nacionalidad", MySqlDbType.VarChar).Value = Obj.Nacionalidad;
                Comando.Parameters.Add("@_TelCasa", MySqlDbType.VarChar).Value = Obj.TelCasa;
                Comando.Parameters.Add("@_Celular", MySqlDbType.VarChar).Value = Obj.Celular;
                Comando.Parameters.Add("@_TelOficina", MySqlDbType.VarChar).Value = Obj.TelOficina;
                Comando.Parameters.Add("@_TelOtro", MySqlDbType.VarChar).Value = Obj.TelOtro;
                Comando.Parameters.Add("@_Nextel", MySqlDbType.VarChar).Value = Obj.Nextel;
                Comando.Parameters.Add("@_Fax1", MySqlDbType.VarChar).Value = Obj.Fax1;
                Comando.Parameters.Add("@_Email1", MySqlDbType.VarChar).Value = Obj.Email1;
                Comando.Parameters.Add("@_Email2", MySqlDbType.VarChar).Value = Obj.Email2;
                Comando.Parameters.Add("@_Email3", MySqlDbType.VarChar).Value = Obj.Email3;
                Comando.Parameters.Add("@_Web", MySqlDbType.VarChar).Value = Obj.Web;
                Comando.Parameters.Add("@_Tipo", MySqlDbType.VarChar).Value = Obj.Tipo;
                Comando.Parameters.Add("@_Fecha_Creacion", MySqlDbType.DateTime).Value = Obj.Fecha_Creacion;
                Comando.Parameters.Add("@_Creado_Por", MySqlDbType.Int32).Value = Obj.Creado_Por;
                Comando.Parameters.Add("@_FechaAn", MySqlDbType.VarChar).Value = Obj.FechaAn;
                Comando.Parameters.Add("@_IdZoho", MySqlDbType.VarChar).Value = Obj.IdZoho;
                Comando.Parameters.Add("@_EntidadNacimiento", MySqlDbType.VarChar).Value = Obj.EntidadNacimiento;
                Comando.Parameters.Add("@_CiudadNacimiento", MySqlDbType.VarChar).Value = Obj.CiudadNacimiento;
                Comando.Parameters.Add("@_PaisNacimiento", MySqlDbType.VarChar).Value = Obj.PaisNacimiento;

                SqlCn.Open();
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro correctamente";
                
            }
            catch (System.Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCn.State == ConnectionState.Open) SqlCn.Close();
            }

            return Respuesta;
        }

        public string Actualizar(Cliente Obj)
        {
            MySqlConnection SqlCn = new MySqlConnection();
            string Respuesta = string.Empty;

            try
            {
                SqlCn = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("SP_CLIENTEACTUALIZAR", SqlCn);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@_IdCte", MySqlDbType.Int32).Value = Obj.IdCte;
                Comando.Parameters.Add("@_IdMedio", MySqlDbType.Int32).Value = Obj.IdMedio;
                Comando.Parameters.Add("@_IdCto", MySqlDbType.Int32).Value = Obj.IdCto;
                Comando.Parameters.Add("@_Nombre", MySqlDbType.VarChar).Value = Obj.Nombre;
                Comando.Parameters.Add("@_Apellido_Paterno", MySqlDbType.VarChar).Value = Obj.Apellido_Paterno;
                Comando.Parameters.Add("@_Apellido_Materno", MySqlDbType.VarChar).Value = Obj.Apellido_Materno;
                Comando.Parameters.Add("@_Sexo", MySqlDbType.VarChar).Value = Obj.Sexo;
                Comando.Parameters.Add("@_Edo_Civil", MySqlDbType.VarChar).Value = Obj.Edo_Civil;
                Comando.Parameters.Add("@_Residencia", MySqlDbType.String).Value = Obj.Residencia;
                Comando.Parameters.Add("@_RetIsr", MySqlDbType.String).Value = Obj.RetIsr;
                Comando.Parameters.Add("@_Rfc", MySqlDbType.VarChar).Value = Obj.Rfc;
                Comando.Parameters.Add("@_FechaNa", MySqlDbType.VarChar).Value = Obj.FechaNa;
                Comando.Parameters.Add("@_Curp", MySqlDbType.VarChar).Value = Obj.Curp;
                Comando.Parameters.Add("@_Nacionalidad", MySqlDbType.VarChar).Value = Obj.Nacionalidad;
                Comando.Parameters.Add("@_TelCasa", MySqlDbType.VarChar).Value = Obj.TelCasa;
                Comando.Parameters.Add("@_Celular", MySqlDbType.VarChar).Value = Obj.Celular;
                Comando.Parameters.Add("@_TelOficina", MySqlDbType.VarChar).Value = Obj.TelOficina;
                Comando.Parameters.Add("@_TelOtro", MySqlDbType.VarChar).Value = Obj.TelOtro;
                Comando.Parameters.Add("@_Nextel", MySqlDbType.VarChar).Value = Obj.Nextel;
                Comando.Parameters.Add("@_Fax1", MySqlDbType.VarChar).Value = Obj.Fax1;
                Comando.Parameters.Add("@_Email1", MySqlDbType.VarChar).Value = Obj.Email1;
                Comando.Parameters.Add("@_Email2", MySqlDbType.VarChar).Value = Obj.Email2;
                Comando.Parameters.Add("@_Email3", MySqlDbType.VarChar).Value = Obj.Email3;
                Comando.Parameters.Add("@_Web", MySqlDbType.VarChar).Value = Obj.Web;
                Comando.Parameters.Add("@_Tipo", MySqlDbType.VarChar).Value = Obj.Tipo;
                Comando.Parameters.Add("@_Fecha_Creacion", MySqlDbType.DateTime).Value = Obj.Fecha_Creacion;
                Comando.Parameters.Add("@_Creado_Por", MySqlDbType.Int32).Value = Obj.Creado_Por;
                Comando.Parameters.Add("@_FechaAn", MySqlDbType.VarChar).Value = Obj.FechaAn;
                Comando.Parameters.Add("@_IdZoho", MySqlDbType.VarChar).Value = Obj.IdZoho;
                Comando.Parameters.Add("@_EntidadNacimiento", MySqlDbType.VarChar).Value = Obj.EntidadNacimiento;
                Comando.Parameters.Add("@_CiudadNacimiento", MySqlDbType.VarChar).Value = Obj.CiudadNacimiento;
                Comando.Parameters.Add("@_PaisNacimiento", MySqlDbType.VarChar).Value = Obj.PaisNacimiento;

                SqlCn.Open();
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro correctamente";

            }
            catch (System.Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCn.State == ConnectionState.Open) SqlCn.Close();
            }

            return Respuesta;
        }

        public string Eliminar(int Id)
        {
            MySqlConnection SqlCn = new MySqlConnection();
            string Respuesta = string.Empty;

            try
            {
                SqlCn = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("SP_CLIENTEELIMINAR", SqlCn);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@IdCte", MySqlDbType.Int32).Value = Id;
                

                SqlCn.Open();
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro correctamente";

            }
            catch (System.Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCn.State == ConnectionState.Open) SqlCn.Close();
            }

            return Respuesta;
        }

        
    }
}
