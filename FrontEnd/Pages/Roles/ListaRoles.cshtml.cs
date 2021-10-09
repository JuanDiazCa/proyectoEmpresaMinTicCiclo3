using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia.AppRepositorios;

namespace FrontEnd.Pages.Roles
{
    public class ListaRolesModel : PageModel
    {
        private readonly RepositorioRol _repoRol;
        public IEnumerable<Rol> Roles {get; set;}

        public ListaRolesModel(RepositorioRol _repoRol)
        {
            this._repoRol = _repoRol;
        }
        public void OnGet()
        {
            Roles = _repoRol.ObtenerTodosLosRoles();
        }

        public void OnPost()
        {
        }
    }
}
