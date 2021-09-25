using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public Empresa Empresa {get; set;}
    }
}