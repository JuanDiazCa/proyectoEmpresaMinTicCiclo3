namespace Dominio.Entidades
{
    public class Empleado : Persona
    {
        public Empleado(string id, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, string documento) : base(id, nombre, primerApellido, segundoApellido, fechaNacimiento, documento){   
        }
        public int SueldoBruto { get; set; }
    }
}