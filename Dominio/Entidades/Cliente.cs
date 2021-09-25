using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required]
        [StringLength(15)]
        public string Telefono { get; set; }
        public Persona Persona {get; set;}
    }
}