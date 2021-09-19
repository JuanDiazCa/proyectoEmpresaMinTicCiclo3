using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection.Metadata;
using System.ComponentModel;

namespace Dominio.Entidades
{
    public class Rol
    {
        public int Id {get; set;}
        [Required]
        [StringLength(30)]
        public string Nombre {get; set;}
        public bool Ingresar {get; set;}
        public bool Modificar {get; set;}
        public bool Consultar {get; set;}
        public bool Eliminar {get; set;}
        public bool Estado {get; set;}
    }
}