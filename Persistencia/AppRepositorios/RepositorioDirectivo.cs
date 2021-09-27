using System;
using System.Linq;
using System.Collections.Generic;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public class RepositorioDirectivo : IRepositorioDirectivo
    {
        private readonly AppContext appContext;

        public RepositorioDirectivo(AppContext appContext)
        {
            this.appContext = appContext;
        }

        public Directivo AgregarDirectivo(Directivo directivo)
        {
            var directivoAdicionado = appContext.Directivos.Add(directivo);
            appContext.SaveChanges();
            return directivoAdicionado.Entity;
        }
        public Directivo ActualizarDirectivo(Directivo directivo)
        {
            var directivoEncontrado = appContext.Directivos.FirstOrDefault(d => d.Id == directivo.Id);
            if(directivoEncontrado != null){
                directivoEncontrado.Categoria= directivo.Categoria;
                directivoEncontrado.Persona = directivo.Persona;
                appContext.SaveChanges();
            }
            return directivoEncontrado;
        }
        public void EliminarDirectivo(int idDirectivo)
        {
            var directivoEncontrado = appContext.Directivos.FirstOrDefault(d => d.Id == idDirectivo);
            if(directivoEncontrado == null)
                return;
            appContext.Directivos.Remove(directivoEncontrado);
            appContext.SaveChanges();
        }
        public Directivo ObtenerDirectivo(int idDirectivo)
        {
            return appContext.Directivos.FirstOrDefault(d => d.Id == idDirectivos);
        }
        public IEnumerable<Directivo> ObtenerTodosLosDirectivos()
        {
            return appContext.Directivos;
        }
    }
}