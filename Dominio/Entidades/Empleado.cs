using System;

namespace Dominio.Entidades
{
    public class Empleado : Persona
    {
        public int IdEmpleado {get; set;}
        public decimal SueldoBruto { get; set; }
    }
}