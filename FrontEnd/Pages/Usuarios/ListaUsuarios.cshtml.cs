using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class ListaUsuariosModel : PageModel
    {
        private readonly RepositorioUsuario _repoUsuario;
        private readonly RepositorioPersona _repoPersona;
        private readonly RepositorioEmpresa _repoEmpresa;
        public IEnumerable<Empleado> Empleados {get; set;}
        public Persona Persona {get; set;}

        public ListaEmpleadosModel(RepositorioEmpleado _repoEmpleado, RepositorioPersona _repoPersona, RepositorioEmpresa _repoEmpresa)
        {
            this._repoEmpleado = _repoEmpleado;
            this._repoPersona = _repoPersona;
            this._repoEmpresa = _repoEmpresa;
        }
        public void OnGet()
        {
            Empleados = _repoEmpleado.ObtenerTodosLosEmpleados();
        }

        public void OnPost()
        {
            
        }

        public string GetNombreEmpresa(int id)
        {
            var empresa = _repoEmpresa.ObtenerEmpresa(id);
            return empresa.RazonSocial;
        }

        public Persona GetPersona(int id){
            return _repoPersona.ObtenerPersona(id);
        }

        public int CalcularEdad(DateTime fecha)
        {
            return DateTime.Today.AddTicks(-fecha.Ticks).Year - 1;
        }
    }
}
