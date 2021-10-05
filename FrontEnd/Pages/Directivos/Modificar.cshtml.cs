using System.Threading;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio.Entidades;
using Persistencia.AppRepositorios;
using System.ComponentModel.DataAnnotations;

namespace FrontEnd.Pages
{
    public class EditModel : PageModel
    {
        private readonly RepositorioEmpleado _repoEmpleado;
        private readonly RepositorioPersona _repoPersona;
        private readonly RepositorioEmpresa _repoEmpresa;
        private readonly RepositorioDirectivo _repoDirectivo;
        [BindProperty]
        public Persona Persona {get; set;}
        [BindProperty]
        public Directivo Directivo {get;set;}
        public Empleado Empleado {get; set;}
        public IEnumerable<Empresa> Empresas {get; set;}
        public Empresa Empresa {get; set;}
        public bool DirectivoEncontrado {get; set;}
        [BindProperty]
        public string RazonSocial {get; set;}
        
        public EditModel(RepositorioEmpleado _repoEmpleado, RepositorioPersona _repoPersona, RepositorioEmpresa _repoEmpresa, RepositorioDirectivo _repoDirectivo)
        {
            this._repoEmpleado = _repoEmpleado;
            this._repoPersona = _repoPersona;
            this._repoEmpresa = _repoEmpresa;
            this ._repoDirectivo= _repoDirectivo;
            DirectivoEncontrado = true;
        }
        public IActionResult OnGet(int idDirectivo)
        {
              Directivo= _repoDirectivo.ObtenerDirectivo(Directivo.EmpleadoId);
            if(Directivo==null){
                DirectivoEncontrado = false;
                //Console.WriteLine("Empleado no encontrado");
                return Page();
            }
            Empleado = _repoEmpleado.ObtenerEmpleado(Empleado.PersonaId);
            if(Empleado==null){
                DirectivoEncontrado = false;
                //Console.WriteLine("Empleado no encontrado");
                return Page();
            }
            Persona = _repoPersona.ObtenerPersona(Empleado.PersonaId);
            if(Persona==null){
                DirectivoEncontrado  = false;
                //Console.WriteLine("Persona no encontrado");
                return Page();
            }
            Empresa = _repoEmpresa.ObtenerEmpresa(Persona.EmpresaId);
            if(Empresa==null){
                DirectivoEncontrado  = false;
                //Console.WriteLine("Empresa no encontrado");
                return Page();
            }
            Empresas = _repoEmpresa.ObtenerEmpresas();
            DirectivoEncontrado = true;
            return Page();
        }

        public IActionResult OnPost(int idDirectivo)
        {
            if(ModelState.IsValid)
            {
                
                Empresa = _repoEmpresa.ObtenerEmpresaPorRazonSocial(RazonSocial);
                Persona.EmpresaId = Empresa.Id;
                Persona = _repoPersona.AgregarPersona(Persona);
                Empleado.PersonaId = Persona.Id;
                Empleado = _repoEmpleado.AdicionarEmpleado(Empleado);
                Directivo.EmpleadoId = Empleado.Id;
                Directivo = _repoDirectivo.AgregarDirectivo(Directivo);
                return RedirectToPage("./ListaDirectivos");
            }
            return OnGet(idDirectivo);
        }
    }
}
