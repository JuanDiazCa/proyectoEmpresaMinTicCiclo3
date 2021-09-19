using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection.Metadata;
using System.ComponentModel;
namespace Dominio.Entidades
{
    public class Persona
    {
        public string IdPersona { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; } 
        public string Documento { get; set; }  

        public Persona(string idPersona, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, string documento) 
        {
            this.IdPersona = idPersona;
            this.Nombre = nombre;
            this.PrimerApellido = primerApellido;
            this.SegundoApellido = segundoApellido;
            this.FechaNacimiento = fechaNacimiento;
            this.Documento = documento;
               
        }
    }
}