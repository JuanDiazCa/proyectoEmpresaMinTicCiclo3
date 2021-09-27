using System;
using Dominio;
using System.Collections.Generic;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public interface IRepositorioEmpleado
    {
        IEnumerable<Empleado> ObtenerTodosLosEmpleados();
         Empleado AdicionarEmpleado(Empleado empleado);
         void EliminarEmpleado(string documentoEmpleado);
         Empleado ActualizarEmpleado(Empleado empleado);
         Empleado BuscarEmpleadoDocumento(string documentoEmpleado);
         Empleado BuscarEmpleadoNombre(string nombreEmpleado);
         Empleado BuscarEmpleadoApellido(string apellidoEmpleado);
    }
}