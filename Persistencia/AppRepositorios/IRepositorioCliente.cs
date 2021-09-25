using System.Security.AccessControl;
using System.Collections.Generic;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public interface IRepositorioCliente
    {
        Cliente AgregarCliente(Cliente cliente);
        Cliente ActualizarCliente(Cliente cliente);
        void EliminarCliente(int idPaciente);
        Cliente ObtenerCliente(int idPaciente);
        IEnumerable<Cliente> ObtenerTodosLosClientes();
    }
}