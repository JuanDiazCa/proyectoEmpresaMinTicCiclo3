using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia.AppRepositorios;

namespace MyApp.Namespace
{
    public class ListaUsuariosModel : PageModel
    {
        private readonly RepositorioUsuario _repoUsuario;
        private readonly RepositorioRol _repoRol;
        public IEnumerable<Usuario> Usuarios {get; set;}

        public ListaUsuariosModel(RepositorioUsuario _repoUsuario, RepositorioRol _repoRol)
        {
            this._repoUsuario = _repoUsuario;
            this._repoRol = _repoRol;
        }
        public void OnGet()
        {
            Usuarios = _repoUsuario.ObtenerTodosLosUsuarios();
        }

        public void OnPost()
        {
            
        }

        public Rol GetRol(int id){
            return _repoRol.ObtenerRol(id);
        }

    }
}
