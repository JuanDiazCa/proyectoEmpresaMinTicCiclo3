using System;
using Dominio;
using Persistencia;
using Dominio.Entidades;

namespace Aplicacion
{
    class Program
    {
        private static IRepositorioEmpresa _repoEmpresa =  new RepositorioEmpresa(new Persistencia.AppRepositorios.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Team D Desarroladores!");
            Console.WriteLine("PRUEBAS DE CRUD");
            pruebaCrud();
        }
        
        private static pruebaCrud()
        {
            var empresa = new Empresa{
                RazonSocial = "Empresa XYZ",
                Nit = "123456-89",
                Direccion = "CL 123 85 96"
            };
            Console.WriteLine("Agregar empresa");
            _repoEmpresa.AgregarEmpresa(empresa);
        }
    }
}
