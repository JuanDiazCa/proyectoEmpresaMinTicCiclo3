using System;
using Dominio;
using Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Persistencia.AppRepositorios
{
    public class RepositorioEmpleado:IRepositorioEmpleado
    {
        private readonly AppContext _appContext;

        public RepositorioEmpleado(AppContext appContext){
            this._appContext = appContext;
        }
        public Empleado AdicionarEmpleado(Empleado empleado){
            var nuevoEmpleado = _appContext.Add(empleado);
            _appContext.SaveChanges();
            return nuevoEmpleado.Entity;
        }
        public void EliminarEmpleado(string documentoEmpleado){
            var empleadoEncontrado = _appContext.Empleados.FirstOrDefault(
                e => e.Persona.Documento == documentoEmpleado);
            if(empleadoEncontrado == null)    
            return;
            _appContext.Remove(empleadoEncontrado);
            _appContext.SaveChanges();
        }
        public Empleado ActualizarEmpleado(Empleado empleado){
            var empleadoEncontrado = _appContext.Empleados.FirstOrDefault(
                e=>e.Persona.Documento == empleado.Persona.Documento);
            if(empleadoEncontrado != null){
                empleadoEncontrado.Persona = empleado.Persona;
                empleadoEncontrado.SueldoBruto = empleado.SueldoBruto;
                _appContext.SaveChanges();
            }
            return empleadoEncontrado;
            
         }
        public Empleado BuscarEmpleadoDocumento(string documentoEmpleado){
            return _appContext.Empleados.FirstOrDefault(
                e=>e.Persona.Documento == documentoEmpleado);
        }
        public Empleado BuscarEmpleadoNombre(string nombreEmpleado){
            return _appContext.Empleados.FirstOrDefault(
                e=>e.Persona.Nombre == nombreEmpleado);
        }
        public Empleado BuscarEmpleadoApellido(string apellidoEmpleado){
            return _appContext.Empleados.FirstOrDefault(
                e=>e.Persona.PrimerApellido == apellidoEmpleado);
        }
        public Empleado ObtenerEmpleado(int idEmpleado)
        {
            return _appContext.Empleados.FirstOrDefault(e => e.Id == idEmpleado);
        }
        public IEnumerable<Empleado> ObtenerTodosLosEmpleados(){
            return _appContext.Empleados;
        }        
  }
}