using System;

namespace Dominio.Entidades
{
    public class Cliente : Persona
    {
        public Cliente(int idCliente, string telefono, string idPersona, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, string documento) : base(idPersona, nombre, primerApellido, segundoApellido, fechaNacimiento, documento)
        {
            this.IdCliente = idCliente;
            this.Telefono = telefono;

        }

        public int IdCliente { get; set; }
        public string Telefono { get; set; }
    }
}