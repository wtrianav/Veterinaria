﻿// <auto-generated />
using System;
using MascotaFeliz.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MascotaFeliz.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211022202105_Azure")]
    partial class Azure
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MascotaFeliz.App.Dominio.Mascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Afiliado")
                        .HasColumnType("bit");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("PropietarioId")
                        .HasColumnType("int");

                    b.Property<string>("Raza")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoMascota")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PropietarioId");

                    b.ToTable("Mascotas");
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.MascotaVeterinario", b =>
                {
                    b.Property<int>("VeterinarioId")
                        .HasColumnType("int");

                    b.Property<int>("MascotaId")
                        .HasColumnType("int");

                    b.HasKey("VeterinarioId", "MascotaId");

                    b.HasIndex("MascotaId");

                    b.ToTable("MascotasVeterinarios");
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.Propietario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("NumeroTelefono")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Propietarios");
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.RegistroVisita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("EstadoAnimo")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<string>("FrecuenciaCardiaca")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("FrecuenciaRespiratoria")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<int>("MascotaId")
                        .HasColumnType("int");

                    b.Property<string>("Medicamentos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Peso")
                        .HasColumnType("real");

                    b.Property<string>("Recomendaciones")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TarjetaProfesionalVeterinario")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Temperatura")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.HasKey("Id");

                    b.HasIndex("MascotaId");

                    b.ToTable("RegistrosVisitas");
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.Veterinario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("NumeroTelefono")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TarjetaProfesionalVeterinario")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("Id");

                    b.ToTable("Veterinarios");
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.Mascota", b =>
                {
                    b.HasOne("MascotaFeliz.App.Dominio.Propietario", null)
                        .WithMany("Mascotas")
                        .HasForeignKey("PropietarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.MascotaVeterinario", b =>
                {
                    b.HasOne("MascotaFeliz.App.Dominio.Mascota", "Mascota")
                        .WithMany("MascotaVeterinario")
                        .HasForeignKey("MascotaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MascotaFeliz.App.Dominio.Veterinario", "Veterinario")
                        .WithMany("MascotaVeterinario")
                        .HasForeignKey("VeterinarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mascota");

                    b.Navigation("Veterinario");
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.RegistroVisita", b =>
                {
                    b.HasOne("MascotaFeliz.App.Dominio.Mascota", null)
                        .WithMany("Visitas")
                        .HasForeignKey("MascotaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.Mascota", b =>
                {
                    b.Navigation("MascotaVeterinario");

                    b.Navigation("Visitas");
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.Propietario", b =>
                {
                    b.Navigation("Mascotas");
                });

            modelBuilder.Entity("MascotaFeliz.App.Dominio.Veterinario", b =>
                {
                    b.Navigation("MascotaVeterinario");
                });
#pragma warning restore 612, 618
        }
    }
}
