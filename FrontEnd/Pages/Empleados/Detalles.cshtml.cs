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
    public class DetallesModel : PageModel
    {
        private readonly RepositorioEmpleado _repoEmpleado;
        private readonly RepositorioPersona _repoPersona;
        private readonly RepositorioEmpresa _repoEmpresa;
        public Persona Persona {get; set;}
        public Empleado Empleado {get; set;}
        public Empresa Empresa {get; set;}

        public DetallesModel(RepositorioEmpleado _repoEmpleado, RepositorioPersona _repoPersona, RepositorioEmpresa _repoEmpresa)
        {
            this._repoEmpleado = _repoEmpleado;
            this._repoPersona = _repoPersona;
            this._repoEmpresa = _repoEmpresa;
        }
        public IActionResult OnGet(int idEmpleado)
        {
            Empleado = _repoEmpleado.ObtenerEmpleado(idEmpleado);
            if(Empleado==null){
                Console.WriteLine("Empleado no encontrado");
                return RedirectToPage("../Admin");
            }
            Persona = _repoPersona.ObtenerPersona(Empleado.PersonaId);
            if(Persona==null){
                Console.WriteLine("Persona no encontrada");
                return RedirectToPage("../Admin");
            }
            Empresa = _repoEmpresa.ObtenerEmpresa(Persona.EmpresaId);
            if(Empresa==null){
                Console.WriteLine("Persona no encontrada");
                return RedirectToPage("../Admin");
            }
            return Page();
        }

        public int CalcularEdad(DateTime fecha)
        {
            return DateTime.Today.AddTicks(-fecha.Ticks).Year - 1;
        }
    }
}
