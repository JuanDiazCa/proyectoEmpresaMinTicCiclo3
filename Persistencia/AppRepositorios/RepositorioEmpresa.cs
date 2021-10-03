using System;
using System.Linq;
using System.Collections.Generic;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public class RepositorioEmpresa : IRepositorioEmpresa
    {
        private readonly AppContext appContext;

        public RepositorioEmpresa(AppContext appContext)
        {
            this.appContext = appContext;
        }

        public Empresa ActualizarEmpresa(Empresa empresa)
        {
            var empresaEncontrada = appContext.Empresas.FirstOrDefault(
                e => e.Id == empresa.Id
            );
            if(empresaEncontrada != null)
            {
                empresaEncontrada.RazonSocial = empresa.RazonSocial;
                empresaEncontrada.Nit = empresa.Nit;
                empresaEncontrada.Direccion = empresa.Direccion;
                appContext.SaveChanges();
            }
            return empresaEncontrada;
        }

        public Empresa AgregarEmpresa(Empresa empresa)
        {
            var newEmpresa = appContext.Empresas.Add(empresa);
            appContext.SaveChanges();
            return newEmpresa.Entity;
        }

        public void EliminarEmpresa(int idEmpresa)
        {
            var empresaEncontrada = appContext.Empresas.FirstOrDefault(
                e => e.Id == idEmpresa
            );
            if (empresaEncontrada == null)
                return;
            appContext.Remove(empresaEncontrada);
            appContext.SaveChanges();
        }

        public Empresa ObtenerEmpresa(int idEmpresa)
        {
            return appContext.Empresas.FirstOrDefault(
                e => e.Id == idEmpresa
            );
        }

        public Empresa ObtenerEmpresaPorRazonSocial(string razon)
        {
            return appContext.Empresas.FirstOrDefault(
                e => e.RazonSocial == razon
            );
        }

        public IEnumerable<Empresa> ObtenerEmpresas()
        {
            return appContext.Empresas;
        }
    }
}
