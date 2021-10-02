using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio.Entidades;
using Persistencia.AppRepositorios;

namespace MyApp.Namespace
{
    public class ListaEmpleadosModel : PageModel
    {
        private readonly RepositorioEmpleado _repoEmpleado;
        private readonly RepositorioPersona _repoPersona;
        public IEnumerable<Empleado> Empleados {get; set;}

        public Boolean agregar {get; set;}
        public Persona Persona {get; set;}

        public ListaEmpleadosModel(RepositorioEmpleado _repoEmpleado, RepositorioPersona _repoPersona)
        {
            this._repoEmpleado = _repoEmpleado;
            this._repoPersona = _repoPersona;
            agregar = false;
        }
        public void OnGet()
        {
            Empleados = _repoEmpleado.ObtenerTodosLosEmpleados();
        }

        public string GetNombreEmpresa(int id)
        {
            return "Prueba";
        }

        public Persona GetPersona(int id){
            return _repoPersona.ObtenerPersona(id);
        }
    }
}
