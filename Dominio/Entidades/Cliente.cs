using System;

namespace Dominio.Entidades
{
    public class Cliente : Persona
    {
        public Cliente(string id, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, string documento) : base(id, nombre, primerApellido, segundoApellido, fechaNacimiento, documento)
        {
        }

        public string Telefono {get; set;}
    }
}