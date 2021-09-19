using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection.Metadata;
using System.ComponentModel;

namespace Dominio.Entidades
{
    public class Persona
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(30)]
        public string PrimerApellido { get; set; }
        [StringLength(30)]
        public string SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; } 
        [Required]
        [StringLength(30)]
        public string Documento { get; set; }  
    }
}