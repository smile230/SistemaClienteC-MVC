using System.Data;
using Sistema.Datos;
using Sistema.Entidades;
using System;
using System.Collections.Generic;

namespace Sistema.Negocio
{
    public class NCliente
    {
        public static List<Cliente> Listar()
        {
            DCliente Datos = new DCliente();
            return Datos.Listar();
        }

        public static string Insertar(int IdMedio, int IdCto, string Nombre, string Apellido_Paterno, string Apellido_Materno, string Sexo, string Edo_Civil, char Residencia, char RetIsr, string Rfc,
        string FechaNa, string Curp, string Nacionalidad, string TelCasa, string Celular, string TelOficina, string TelOtro, string Nextel, string Fax1, string Email1, string Email2, string Email3, string Web, string Tipo, 
        DateTime Fecha_Creacion, int Creado_Por, string FechaAn, string IdZoho, string EntidadNacimiento, string CiudadNacimiento, string PaisNacimiento)
        {
            DCliente Datos = new DCliente();
            Cliente Obj = new Cliente();            
            Obj.IdMedio = IdMedio;
            Obj.IdCto = IdCto;
            Obj.Nombre = Nombre;
            Obj.Apellido_Paterno = Apellido_Paterno;
            Obj.Apellido_Materno = Apellido_Materno;
            Obj.Sexo = Sexo;
            Obj.Edo_Civil = Edo_Civil;
            Obj.Residencia = Residencia;
            Obj.RetIsr = RetIsr;
            Obj.Rfc = Rfc;
            Obj.FechaNa = FechaNa;
            Obj.Curp = Curp;
            Obj.Nacionalidad = Nacionalidad;
            Obj.TelCasa = TelCasa;
            Obj.Celular = Celular;
            Obj.TelOficina = TelOficina;
            Obj.TelOtro = TelOtro;
            Obj.Nextel = Nextel;
            Obj.Fax1 = Fax1;
            Obj.Email1 = Email1;
            Obj.Email2 = Email2;
            Obj.Email3 = Email3;
            Obj.Web = Web;
            Obj.Tipo = Tipo;
            Obj.Fecha_Creacion = Fecha_Creacion;
            Obj.Creado_Por = Creado_Por;
            Obj.FechaAn = FechaAn;
            Obj.IdZoho = IdZoho;
            Obj.EntidadNacimiento = EntidadNacimiento;
            Obj.CiudadNacimiento = CiudadNacimiento;
            Obj.PaisNacimiento = PaisNacimiento;
            return Datos.Insertar(Obj);
        }

        public static string Actualizar(int IdCte, int IdMedio, int IdCto, string Nombre, string Apellido_Paterno, string Apellido_Materno, string Sexo, string Edo_Civil, char Residencia, char RetIsr, string Rfc,
        string FechaNa, string Curp, string Nacionalidad, string TelCasa, string Celular, string TelOficina, string TelOtro, string Nextel, string Fax1, string Email1, string Email2, string Email3, string Web, string Tipo,
        DateTime Fecha_Creacion, int Creado_Por, string FechaAn, string IdZoho, string EntidadNacimiento, string CiudadNacimiento, string PaisNacimiento)
        {
            DCliente Datos = new DCliente();
            Cliente Obj = new Cliente();
            Obj.IdCte = IdCte;
            Obj.IdMedio = IdMedio;
            Obj.IdCto = IdCto;
            Obj.Nombre = Nombre;
            Obj.Apellido_Paterno = Apellido_Paterno;
            Obj.Apellido_Materno = Apellido_Materno;
            Obj.Sexo = Sexo;
            Obj.Edo_Civil = Edo_Civil;
            Obj.Residencia = Residencia;
            Obj.RetIsr = RetIsr;
            Obj.Rfc = Rfc;
            Obj.FechaNa = FechaNa;
            Obj.Curp = Curp;
            Obj.Nacionalidad = Nacionalidad;
            Obj.TelCasa = TelCasa;
            Obj.Celular = Celular;
            Obj.TelOficina = TelOficina;
            Obj.TelOtro = TelOtro;
            Obj.Nextel = Nextel;
            Obj.Fax1 = Fax1;
            Obj.Email1 = Email1;
            Obj.Email2 = Email2;
            Obj.Email3 = Email3;
            Obj.Web = Web;
            Obj.Tipo = Tipo;
            Obj.Fecha_Creacion = Fecha_Creacion;
            Obj.Creado_Por = Creado_Por;
            Obj.FechaAn = FechaAn;
            Obj.IdZoho = IdZoho;
            Obj.EntidadNacimiento = EntidadNacimiento;
            Obj.CiudadNacimiento = CiudadNacimiento;
            Obj.PaisNacimiento = PaisNacimiento;
            return Datos.Actualizar(Obj);
        }

        public static string Eliminar(int IdCte)
        {
            DCliente Datos = new DCliente();            
            return Datos.Eliminar(IdCte);
        }

    }
}
