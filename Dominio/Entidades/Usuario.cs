using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection.Metadata;
using System.ComponentModel;

namespace Dominio.Entidades
{
    public class Usuario : Rol
    {
        public String Usuario {get; set;}
        public String clave {get; set;}
        public Rol rol {get; set;}

        public Usuario(String usuario, String clave, Rol rol) 
        {
            this.Usuario = usuario;
            this.clave = clave;
            this.rol = rol;
        }
    }
}