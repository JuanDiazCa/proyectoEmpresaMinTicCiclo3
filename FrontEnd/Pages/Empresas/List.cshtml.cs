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

namespace proyectoEmpresaMinTicCiclo3.FrontEnd.Pages
{
    public class ListModel : PageModel
    {
        private readonly RepositorioEmpresa _repoEmpresa;
        public IEnumerable<Empresa> Empresas {get; set;}

        public ListModel(RepositorioEmpresa _repoEmpresa)
        {
            this._repoEmpresa = _repoEmpresa;
        }
        public void OnGet()
        {
            Empresas = _repoEmpresa.ObtenerEmpresas();
        }
    }
}