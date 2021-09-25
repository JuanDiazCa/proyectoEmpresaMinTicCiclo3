using System;
using System.Linq;
using System.Collections.Generic;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public class RepositorioRol : IRepositorioRol
    {
        private readonly AppContext appContext;
        public RepositorioRol(AppContext appContext)
        {
            this.appContext = appContext;
        }

        public Rol AgregarRol(Rol rol)
        {
            var rolAdicionado = appContext.Roles.Add(rol);
            appContext.SaveChanges();
            return rolAdicionado.Entity;
        }
        public Rol ActualizarRol(Rol rol)
        {
            var rolEncontrado = appContext.Roles.FirstOrDefault(r => r.Id == rol.Id);
            if(rolEncontrado != null){
                rolEncontrado.Nombre = rol.Nombre;
                rolEncontrado.Ingresar = rol.Ingresar;
                rolEncontrado.Modificar = rol.Modificar;
                rolEncontrado.Consultar = rol.Consultar;
                rolEncontrado.Eliminar = rol.Eliminar;
                rolEncontrado.Estado = rol.Estado;
                appContext.SaveChanges();
            }
            return rolEncontrado;
        }
        public void EliminarRol(int idRol)
        {
            var rolEncontrado = appContext.Roles.FirstOrDefault(r => r.Id == idRol);
            if(rolEncontrado == null)
                return;
            appContext.Roles.Remove(rolEncontrado);
            appContext.SaveChanges();
        }
        public Rol ObtenerRol(int idRol)
        {
            return appContext.Roles.FirstOrDefault(r => r.Id == idRol);
        }
        public IEnumerable<Rol> ObtenerTodosLosRoles()
        {
            return appContext.Roles;
        }

    }
}