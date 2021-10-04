using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    public class Empresa
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe ingresar un valor válido.")]
        [StringLength(50)]
        public string RazonSocial { get; set; }
        [Required(ErrorMessage = "Debe ingresar un valor válido.")]
        [StringLength(30)]
        public string Nit { get; set; }
        [Required(ErrorMessage = "Debe ingresar un valor válido.")]
        [StringLength(50)]
        public string Direccion { get; set; }       
    }
}