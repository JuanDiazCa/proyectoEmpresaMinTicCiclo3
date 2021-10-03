using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio.Entidades;
using Persistencia.AppRepositorios;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;

namespace FrontEnd.Pages
{
    public class ModificarModel : PageModel
    {
        private readonly ILogger<ModificarModel> _logger;
        private readonly RepositorioEmpleado _repoEmpleado;
        private readonly RepositorioPersona _repoPersona;
        private readonly RepositorioEmpresa _repoEmpresa;
        [BindProperty]
        public Persona Persona {get; set;}
        [BindProperty]
        public Empleado Empleado {get; set;}
        public IEnumerable<Empresa> Empresas {get; set;}
        [BindProperty]
        public Empresa Empresa {get; set;}
        public bool EmpleadoEncontrado {get; set;}
        [Required]
        [BindProperty]
        public bool ConfirmarModificacion {get; set;}
        public ModificarModel(RepositorioEmpleado _repoEmpleado, RepositorioPersona _repoPersona, RepositorioEmpresa _repoEmpresa, ILogger<ModificarModel> logger)
        {
            _logger = logger;
            this._repoEmpleado = _repoEmpleado;
            this._repoPersona = _repoPersona;
            this._repoEmpresa = _repoEmpresa;
            EmpleadoEncontrado = false;
        }
        public IActionResult OnGet(int idEmpleado)
        {
            Empleado = _repoEmpleado.ObtenerEmpleado(idEmpleado);
            if(Empleado==null){
                EmpleadoEncontrado = false;
                Console.WriteLine("Empleado no encontrado");
                return Page();
            }
            Persona = _repoPersona.ObtenerPersona(Empleado.PersonaId);
            if(Persona==null){
                EmpleadoEncontrado = false;
                Console.WriteLine("Persona no encontrado");
                return Page();
            }
            Empresa = _repoEmpresa.ObtenerEmpresa(Persona.EmpresaId);
            if(Empresa==null){
                EmpleadoEncontrado = false;
                Console.WriteLine("Empresa no encontrado");
                return Page();
            }
            Empresas = _repoEmpresa.ObtenerEmpresas();
            EmpleadoEncontrado = true;
            return Page();
        }

        public void OnPost()
        {

        }

        public string FormatearFecha(DateTime fecha)
        {
            //DateTime dt = DateTime.ParseExact(fecha.ToString(), )
            return fecha.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            //return fecha.ToShortDateString();
        }

        public string FormatearSueldo()
        {
            return Empleado.SueldoBruto.ToString().Replace(',', '.');
        }
    }
}
