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

namespace FrontEnd.Pages.Clientes
{
    public class ListaClientesModel : PageModel
    {
        private readonly RepositorioCliente _repoCliente;
        private readonly RepositorioPersona _repoPersona;
        private readonly RepositorioEmpresa _repoEmpresa;
        public IEnumerable<Cliente> Clientes {get; set;}
        public Persona Persona {get; set;}

        public ListaClientesModel(RepositorioCliente _repoCliente, RepositorioPersona _repoPersona, RepositorioEmpresa _repoEmpresa)
        {
            this._repoCliente = _repoCliente;
            this._repoPersona = _repoPersona;
            this._repoEmpresa = _repoEmpresa;
        }
        public void OnGet()
        {
            Clientes = _repoCliente.ObtenerTodosLosClientes();
        }

        public void OnPost(){
            
        }

        public string GetNombreEmpresa(int id){
            var empresa = _repoEmpresa.ObtenerEmpresa(id);
            return empresa.RazonSocial;
        }

        public Persona GetPersona(int id){
            return _repoPersona.ObtenerPersona(id);
        }

        public int CalcularEdad(DateTime fecha){
            return DateTime.Today.AddTicks(-fecha.Ticks).Year - 1;
        }
    }
}