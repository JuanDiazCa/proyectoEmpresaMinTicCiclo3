using System.Collections.Generic;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public interface IRepositorioRol
    {
        Rol AgregarRol(Rol rol);
        Rol ActualizarRol(Rol rol);
        void EliminarRol(int idRol);
        Rol ObtenerRol(int idRol);
        IEnumerable<Rol> ObtenerTodosLosRoles();
    }
}