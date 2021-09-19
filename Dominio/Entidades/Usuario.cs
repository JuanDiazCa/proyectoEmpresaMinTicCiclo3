using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection.Metadata;
using System.ComponentModel;

namespace Dominio.Entidades
{
    public class Usuario : Rol
    {
        public Usuario(int idUsuario, string usuario, string clave, int idRol, string nombre, bool ingresar, bool modificar, bool consultar, bool eliminar, bool estado) : base(idRol, nombre, ingresar, modificar, consultar, eliminar, estado)
        {
            this.IdUsuario = idUsuario;
            this.usuario = usuario;
            this.clave = clave;

        }
        public int IdUsuario { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
    }
}