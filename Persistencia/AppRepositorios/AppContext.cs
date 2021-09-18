using Microsoft.EntityFrameworkCore;

namespace Persistencia.AppRepositorios
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Empleado> Empleados {get;set;}
    }
}