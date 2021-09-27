using System.Collections.Generic;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public interface IRepositorioUsuario
    {
        Usuario AgregarUsuario(Usuario usuario);
        Usuario ActualizarUsuario(Usuario usuario);
        void EliminarUsuario(int idUsuario);
        Usuario ObtenerUsuario(int idUsuario);
        IEnumerable<Usuario> ObtenerTodosLosUsuarios();
    }
}