using System.Net.Cache;
using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio.Entidades;
using Persistencia.AppRepositorios;

namespace FrontEnd.Pages.Empleados
{
    public class ListaEmpleadosModel : PageModel
    {
        private readonly RepositorioEmpleado _repoEmpleado;
        private readonly RepositorioPersona _repoPersona;
        private readonly RepositorioEmpresa _repoEmpresa;
        private readonly RepositorioDirectivo _repoDirectivo;
        public IEnumerable<Empleado> Empleados {get; set;}
        public IEnumerable<Directivo> Directivos {get; set;}
        public Persona Persona {get; set;}
        public int cantidad {get; set;}

        public ListaEmpleadosModel(RepositorioEmpleado _repoEmpleado, RepositorioPersona _repoPersona, RepositorioEmpresa _repoEmpresa, RepositorioDirectivo _repoDirectivo)
        {
            this._repoEmpleado = _repoEmpleado;
            this._repoPersona = _repoPersona;
            this._repoEmpresa = _repoEmpresa;
            this._repoDirectivo = _repoDirectivo;
        }
        public void OnGet()
        {
            Empleados = _repoEmpleado.ObtenerTodosLosEmpleados();
            Directivos = _repoDirectivo.ObtenerTodosLosDirectivos();
            cantidad = Math.Abs(Empleados.Count()-Directivos.Count());
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

        public bool esDirectivo(int idEmpleado)
        {
            foreach(var dir in Directivos)
            {
                if(dir.EmpleadoId==idEmpleado)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
