using Microsoft.EntityFrameworkCore;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}

        public DbSet<Rol> Roles {get;set;}
        public DbSet<Usuario> Usuarios {get;set;}
        public DbSet<Empleado> Empleados {get;set;}
        public DbSet<Cliente> Clientes {get;set;}
        public DbSet<Empresa> Empresas {get;set;}
        public DbSet<Directivo> Directivos {get;set;}
    }
}