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
        private const string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog = EmpresaTeamDDesarroladores;Integrated Security = True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder
                .UseSqlServer(connectionString);
            }
        }
    }
}
//dotnet ef migrations add Entidades --startup-project ..\HospiEnCasa.App.Consola\