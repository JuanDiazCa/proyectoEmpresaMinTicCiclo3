using Microsoft.EntityFrameworkCore;

namespace Persistencia.AppRepositorios
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}
<<<<<<< HEAD
        public DbSet<Rol> Roles {get;set;}
        public DbSet<Usuario> Usuarios {get;set;}
=======
        public DbSet<Empleado> Empleados {get;set;}
>>>>>>> 39a39ac7a98491e654b03776f05113247f209f11
    }
}