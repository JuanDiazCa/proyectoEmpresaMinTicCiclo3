using System;
using Dominio;
using Persistencia;
using Persistencia.AppRepositorios;
using Dominio.Entidades;

namespace Aplicacion
{
    class Program
    {
        private static IRepositorioEmpresa _repoEmpresa =  new RepositorioEmpresa(new Persistencia.AppRepositorios.AppContext());
        private static IRepositorioPersona _repoPersona =  new RepositorioPersona(new Persistencia.AppRepositorios.AppContext());
        private static IRepositorioCliente _repoCliente =  new RepositorioCliente(new Persistencia.AppRepositorios.AppContext());
        private static IRepositorioEmpleado _repoEmpleado =  new RepositorioEmpleado(new Persistencia.AppRepositorios.AppContext());
        private static IRepositorioDirectivo _repoDirectivo =  new RepositorioDirectivo(new Persistencia.AppRepositorios.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Team D Desarroladores!");
            Console.WriteLine("PRUEBAS DE CRUD");
            //pruebaCrudAgregar();
            //pruebaCrudConsultar();
            //pruebaCrudActualizar();
            pruebaCrudEliminar();
        }

        public static void pruebaCrudEliminar(){
            Console.WriteLine("eliminar cliente id 2");
            _repoCliente.EliminarCliente(2);
            Console.WriteLine("eliminar persona id 2");
            _repoPersona.EliminarPersona(2);

        }

        private static void pruebaCrudActualizar(){
            Console.WriteLine("Actualizando empresa");
            var empresaActualizada = new Empresa{
                Id = 2,
                RazonSocial = "Empresa XYZ ACTUALIZADA",
                Nit = "123456-89",
                Direccion = "CL 123 85 96"
            };
            _repoEmpresa.ActualizarEmpresa(empresaActualizada);
        }

        private static void pruebaCrudConsultar(){
            Console.WriteLine("Consultar Empresa, datos:");
            var empresa = _repoEmpresa.ObtenerEmpresa(2);
            Console.WriteLine(empresa.RazonSocial);
            Console.WriteLine(empresa.Nit);
            Console.WriteLine(empresa.Direccion);
        }
        
        private static void pruebaCrudAgregar()
        {
            // crear la empresa
            var empresa = new Empresa{
                Id = 1,
                RazonSocial = "Empresa XYZ",
                Nit = "123456-89",
                Direccion = "CL 123 85 96"
            };
            Console.WriteLine("Agregar empresa");
            _repoEmpresa.AgregarEmpresa(empresa);

            var persona1 = new Persona{
                Id = 1,
                Nombre = "Angela",
                PrimerApellido = "Mayorga",
                SegundoApellido = "Escobar",
                FechaNacimiento = new DateTime(2001, 01, 01), 
                Documento = "123456",
                Empresa = empresa
            };
            Console.WriteLine("Agregar persona1 para cliente");
            _repoPersona.AgregarPersona(persona1);

            var cliente = new Cliente{
                Id = 1,
                Telefono = "555-89999",
                Persona = persona1
            };
            Console.WriteLine("Agregar cliente");
            _repoCliente.AgregarCliente(cliente);

            var persona2 = new Persona{
                Id = 2,
                Nombre = "Carlos",
                PrimerApellido = "Castaño",
                SegundoApellido = "Hernandez",
                FechaNacimiento = new DateTime(2005, 05, 05), 
                Documento = "987654",
                Empresa = empresa
            };
            Console.WriteLine("Agregar persona 2 para empleado directivo");
            _repoPersona.AgregarPersona(persona2);

            var empleado1 = new Empleado{
                Id = 1,
                SueldoBruto = 1500000,
                Persona = persona2
            };
            Console.WriteLine("Agregar empleado para directivo");
            _repoEmpleado.AdicionarEmpleado(empleado1);

            var directivo = new Directivo{
                Id = 1,
                Categoria = "Jefe",
                Empleado = empleado1
            };
            Console.WriteLine("Agregar directivo");
            _repoDirectivo.AgregarDirectivo(directivo);

            var persona3 = new Persona{
                Id = 3,
                Nombre = "Leidy",
                PrimerApellido = "Rodas",
                SegundoApellido = "Alcaraz",
                FechaNacimiento = new DateTime(2004, 04, 04), 
                Documento = "258147",
                Empresa = empresa
            };
            Console.WriteLine("Agregar persona 3 para empleado");
            _repoPersona.AgregarPersona(persona3);

            var empleado2 = new Empleado{
                Id = 2,
                SueldoBruto = 2000000,
                Persona = persona3
            };
            Console.WriteLine("Agregar empleado");
            _repoEmpleado.AdicionarEmpleado(empleado2);
        }
    }
}
