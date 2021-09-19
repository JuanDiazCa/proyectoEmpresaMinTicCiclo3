using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection.Metadata;
using System.ComponentModel;

namespace Dominio.Entidades
{
    public class Usuario : Rol
    {
        public int IdUsuario { get; set; }
        [Required]
        [StringLength(15)]
        public string usuario { get; set; }
        [Required]
        [StringLength(30)]
        public string clave { get; set; }
    }
}