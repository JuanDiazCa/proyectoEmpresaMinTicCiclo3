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

namespace FrontEnd.Pages.Directivos
{
    public class ListaDirectivosModel : PageModel
    {
        private readonly RepositorioEmpleado _repoEmpleado;
        private readonly RepositorioPersona _repoPersona;
        private readonly RepositorioEmpresa _repoEmpresa;
        private readonly RepositorioDirectivo _repoDirectivo;

        public IEnumerable<Directivo> Directivos {get; set;}
        public Persona Persona {get; set;}
          [BindProperty]
        public string CriterioFiltro { get; set; }
        [BindProperty]
        public string TextoFiltro { get; set; }

        public ListaDirectivosModel(RepositorioEmpleado _repoEmpleado, RepositorioPersona _repoPersona, RepositorioEmpresa _repoEmpresa, RepositorioDirectivo _repoDirectivo)
        {
            this._repoEmpleado = _repoEmpleado;
            this._repoPersona = _repoPersona;
            this._repoEmpresa = _repoEmpresa;
            this._repoDirectivo = _repoDirectivo;
        }
         public void OnGet(string CriterioFiltro, string TextoFiltro)
        {
            if(String.IsNullOrEmpty(CriterioFiltro)||String.IsNullOrEmpty(TextoFiltro))
            {
                Directivos = _repoDirectivo.ObtenerTodosLosDirectivos();
                return;
            }
            else
            {
                switch (CriterioFiltro)
                {
                    case "Todos los registros":
                        Directivos= _repoDirectivo.ObtenerTodosLosDirectivos();
                        break;
                    case "Por categoria":
                        Directivos = _repoDirectivo.ObtenerDirectivoPorCategoria(TextoFiltro);
                        break;
                    
                }
            }
        }
      
        public string GetNombreEmpresa(int id)
        {
            var empresa = _repoEmpresa.ObtenerEmpresa(id);
            return empresa.RazonSocial;
        }

        public Persona GetPersona(int id){
            return _repoPersona.ObtenerPersona(id);
        }

        public Empleado GetEmpleado(int id){
            return _repoEmpleado.ObtenerEmpleado(id);
        }

        public Directivo GetDirectivo(int id){
            return _repoDirectivo.ObtenerDirectivo(id);
        }

        public int CalcularEdad(DateTime fecha)
        {
            return DateTime.Today.AddTicks(-fecha.Ticks).Year - 1;
        }
    }
}
