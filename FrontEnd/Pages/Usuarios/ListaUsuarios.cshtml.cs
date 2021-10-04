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
        private readonly RepositorioPersona _repoPersona;
        private readonly RepositorioEmpresa _repoEmpresa;
        public IEnumerable<Usuario> Usuarios {get; set;}
        public Persona Persona {get; set;}

        public ListaUsuariosModel(RepositorioUsuario _repoUsuario, RepositorioPersona _repoPersona, RepositorioEmpresa _repoEmpresa)
        {
            this._repoUsuario = _repoUsuario;
            this._repoPersona = _repoPersona;
            this._repoEmpresa = _repoEmpresa;
        }
        public void OnGet()
        {
            Usuarios = _repoUsuario.ObtenerTodosLosUsuarios();
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
