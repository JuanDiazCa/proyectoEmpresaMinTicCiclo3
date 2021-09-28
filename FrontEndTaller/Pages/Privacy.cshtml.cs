using System.Collections;
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
    public class ListModel : PageModel
    {
        private static IRepositorioCliente _repoCliente;
        //private static IRepositorioCliente _repoCliente =  new RepositorioCliente(new Persistencia.AppRepositorios.AppContext());
        //private IEnumerable<Cliente> Clientes {get; set;}
        private string[] nombres = {"cliente 1", "cliente 2", "cliente 3"};
        public List<String> Clientes {get; set;}

        public ListModel()
        {
            //this._repoCliente = _repoCliente;
            
        }

        public void OnGet()
        {
            //Clientes = _repoCliente.ObtenerTodosLosClientes();
            Clientes = new List<string>  {"prueba","prueba2"};
        }
    }
}