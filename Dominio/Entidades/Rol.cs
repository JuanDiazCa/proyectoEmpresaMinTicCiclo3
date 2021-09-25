using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    public class Rol
    {
        public int Id {get; set;}
        [Required]
        [StringLength(30)]
        public string Nombre {get; set;}
        [Required]
        public bool Ingresar {get; set;}
        [Required]
        public bool Modificar {get; set;}
        [Required]
        public bool Consultar {get; set;}
        [Required]
        public bool Eliminar {get; set;}
        [Required]
        public bool Estado {get; set;}
    }
}