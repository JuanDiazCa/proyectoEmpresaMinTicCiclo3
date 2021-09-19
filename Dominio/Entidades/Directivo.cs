using System;

namespace Dominio.Entidades
{
    public class Directivo : Empleado
    {
        public Directivo(int idDirectivo, string categoria, int idEmpleado, int sueldoBruto, string idPersona, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, string documento)  : base(idEmpleado, sueldoBruto, idPersona, nombre, primerApellido, segundoApellido, fechaNacimiento, documento)
        {
            IdDirectivo = idDirectivo;
            Categoria = categoria;
        }
        public int IdDirectivo {set; get;}
        public string Categoria{get;set;}
    }
}