using System.Data;
using System;

namespace Sistema.Entidades
{
    public class Cliente
    {
        public int IdCte { get; set; }
        public int IdMedio { get; set; }
        public int IdCto { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Sexo { get; set; }
        public string Edo_Civil { get; set; }
        public char Residencia { get; set; }
        public char RetIsr { get; set; }
        public string Rfc { get; set; }
        public string FechaNa { get; set; }
        public string Curp { get; set; }
        public string Nacionalidad { get; set; }
        public string TelCasa { get; set; }
        public string Celular { get; set; }
        public string TelOficina { get; set; }
        public string TelOtro { get; set; }
        public string Nextel { get; set; }
        public string Fax1 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public string Web { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha_Creacion { get; set; }
        public int Creado_Por { get; set; }
        public string FechaAn { get; set; }
        public string IdZoho { get; set; }
        public string EntidadNacimiento { get; set; }
        public string CiudadNacimiento { get; set; }
        public string PaisNacimiento { get; set; }
        

    }
}
