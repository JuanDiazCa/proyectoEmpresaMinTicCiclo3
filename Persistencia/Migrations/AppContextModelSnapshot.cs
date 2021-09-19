﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia.AppRepositorios;

namespace Persistencia.Migrations
{
    [DbContext(typeof(Persistencia.AppRepositorios.AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Dominio.Entidades.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nit")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("RazonSocial")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("Dominio.Entidades.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PrimerApellido")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("SegundoApellido")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Dominio.Entidades.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Consultar")
                        .HasColumnType("bit");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminar")
                        .HasColumnType("bit");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<bool>("Ingresar")
                        .HasColumnType("bit");

                    b.Property<bool>("Modificar")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Rol");
                });

            modelBuilder.Entity("Dominio.Entidades.Cliente", b =>
                {
                    b.HasBaseType("Dominio.Entidades.Persona");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasDiscriminator().HasValue("Cliente");
                });

            modelBuilder.Entity("Dominio.Entidades.Empleado", b =>
                {
                    b.HasBaseType("Dominio.Entidades.Persona");

                    b.Property<int>("IdEmpleado")
                        .HasColumnType("int");

                    b.Property<decimal>("SueldoBruto")
                        .HasColumnType("decimal(18,2)");

                    b.HasDiscriminator().HasValue("Empleado");
                });

            modelBuilder.Entity("Dominio.Entidades.Usuario", b =>
                {
                    b.HasBaseType("Dominio.Entidades.Rol");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("clave")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("usuario")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasDiscriminator().HasValue("Usuario");
                });

            modelBuilder.Entity("Dominio.Entidades.Directivo", b =>
                {
                    b.HasBaseType("Dominio.Entidades.Empleado");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("IdDirectivo")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Directivo");
                });
#pragma warning restore 612, 618
        }
    }
}
