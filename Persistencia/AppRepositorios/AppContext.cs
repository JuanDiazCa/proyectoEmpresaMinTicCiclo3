using Microsoft.EntityFrameworkCore;

namespace Persistencia.AppRepositorios
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Rol> Roles {get;set;}
        public DbSet<Usuario> Usuarios {get;set;}
    }
}