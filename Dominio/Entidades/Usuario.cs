using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        [StringLength(15)]
        public string usuario { get; set; }
        [Required]
        [StringLength(30)]
        public string clave { get; set; }
        public Rol Rol {get; set;}
        public Persona Persona {get; set;}
    }
}