using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    public class Empleado
    {
        public int Id {get; set;}
        [Required]
        public decimal SueldoBruto { get; set; }
        public Persona Persona {get; set;}
    }
}