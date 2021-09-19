using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    public class Cliente : Persona
    {
        public int IdCliente { get; set; }
        [Required]
        [StringLength(15)]
        public string Telefono { get; set; }
    }
}