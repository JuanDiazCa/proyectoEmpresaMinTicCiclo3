using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    public class Directivo
    {
        public int Id {set; get;}
        [Required]
        [StringLength(30)]
        public string Categoria{get;set;}
        public int EmpleadoId { get; set; }
        public virtual Empleado Empleado {get; set;}
    }
}