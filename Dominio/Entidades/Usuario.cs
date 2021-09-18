using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection.Metadata;
using System.ComponentModel;

namespace Dominio.Entidades
{
    public class Usuario : Rol
    {
        public Usuario(string nombre, bool ingresar, bool modificar, bool consultar, bool eliminar, bool estado) : base(nombre, ingresar, modificar, consultar, eliminar, estado)
        {
        }

        public string usuario {get; set;}
        public string clave {get; set;}
        public Rol rol {get; set;}

    }
}