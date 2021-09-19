using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    public class Directivo : Empleado
    {
        public int IdDirectivo {set; get;}
        [Required]
        [StringLength(30)]
        public string Categoria{get;set;}
    }
}