using System;

namespace Dominio.Entidades
{
    public class Empleado : Persona
    {
        public Empleado(int idEmpleado, int sueldoBruto, string idPersona, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, string documento)  : base(idPersona, nombre, primerApellido, segundoApellido, fechaNacimiento, documento)
        {
            IdEmpleado = idEmpleado;
            SueldoBruto = sueldoBruto;
        }
        public int IdEmpleado {get; set;}
        public int SueldoBruto { get; set; }
    }
}