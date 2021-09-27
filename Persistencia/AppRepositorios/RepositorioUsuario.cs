using System;
using System.Linq;
using System.Collections.Generic;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private readonly AppContext appContext;
        public RepositorioUsuario(AppContext appContext)
        {
            this.appContext = appContext;
        }

        public Usuario ActualizarUsuario(Usuario usuario)
        {
            var usuario_agregar = appContext.Usuarios.Add(usuario);
            appContext.SaveChanges();

            return usuario_agregar.Entity;
        }

        public Usuario AgregarUsuario(Usuario usuario)
        {
            var usuario_encontrado = appContext.Usuarios.FirstOrDefault(u => u.Id == usuario.Id);
            if (usuario_encontrado != null)
            {   
                usuario_encontrado.usuario = usuario.usuario;
                usuario_encontrado.clave = usuario.clave;
                usuario_encontrado.Rol = usuario.Rol;
                usuario_encontrado.Persona = usuario.Persona;

                appContext.SaveChanges();
            }

            return usuario_encontrado;
        }

        public void EliminarUsuario(int idUsuario)
        {
            var usuario_encontrado = appContext.Usuarios.FirstOrDefault(u => u.Id == idUsuario);
            if(usuario_encontrado == null)
                return;
            appContext.Usuarios.Remove(usuario_encontrado);

            appContext.SaveChanges();
        }

        public Usuario ObtenerUsuario(int idUsuario)
        {
            return appContext.Usuarios.FirstOrDefault(u => u.Id == idUsuario);
        }

        public IEnumerable<Usuario> ObtenerTodosLosUsuarios()
        {
            return appContext.Usuarios;
        }
    }
}