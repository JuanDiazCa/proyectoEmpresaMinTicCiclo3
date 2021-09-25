using System;
using System.Linq;
using System.Collections.Generic;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public class RepositorioCliente : IRepositorioCliente
    {
        private readonly AppContext appContext;

        public RepositorioCliente(AppContext appContext)
        {
            this.appContext = appContext;
        }

        public Cliente AgregarCliente(Cliente cliente)
        {
            var clienteAdicionado = appContext.Clientes.Add(cliente);
            appContext.SaveChanges();
            return clienteAdicionado.Entity;
        }
        public Cliente ActualizarCliente(Cliente cliente)
        {
            var clienteEncontrado = appContext.Clientes.FirstOrDefault(c => c.Id == cliente.Id);
            if(clienteEncontrado != null){
                clienteEncontrado.Telefono = cliente.Telefono;
                clienteEncontrado.Persona = cliente.Persona;
                appContext.SaveChanges();
            }
            return clienteEncontrado;
        }
        public void EliminarCliente(int idPaciente)
        {
            var clienteEncontrado = appContext.Clientes.FirstOrDefault(c => c.Id == idPaciente);
            if(clienteEncontrado == null)
                return;
            appContext.Clientes.Remove(clienteEncontrado);
            appContext.SaveChanges();
        }
        public Cliente ObtenerCliente(int idPaciente)
        {
            return appContext.Clientes.FirstOrDefault(c => c.Id == idPaciente);
        }
        public IEnumerable<Cliente> ObtenerTodosLosClientes()
        {
            return appContext.Clientes;
        }
    }
}