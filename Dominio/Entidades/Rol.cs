using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection.Metadata;
using System.ComponentModel;

namespace Dominio.Entidades
{
    public class Rol
    {
        public int IdRol {get; set;}
        public string Nombre {get; set;}
        public bool Ingresar {get; set;}
        public bool Modificar {get; set;}
        public bool Consultar {get; set;}
        public bool Eliminar {get; set;}
        public bool Estado {get; set;}

        public Rol(int idRol, string nombre, bool ingresar, bool modificar, bool consultar, bool eliminar, bool estado) 
        {
            this.IdRol = idRol;
            this.Nombre = nombre;
            this.Ingresar = ingresar;
            this.Modificar = modificar;
            this.Consultar = consultar;
            this.Eliminar = eliminar;
            this.Estado = estado;
        }
    }
}