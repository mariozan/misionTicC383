﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoCiclo3.App.Persistencia;

namespace ProyectoCiclo3.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220823001216_MigraInicial1")]
    partial class MigraInicial1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ProyectoCiclo3.App.Dominio.Estaciones", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("coord_x")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("coord_y")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Estaciones");
                });

            modelBuilder.Entity("ProyectoCiclo3.App.Dominio.Rutas", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("destinoid")
                        .HasColumnType("int");

                    b.Property<int?>("origenid")
                        .HasColumnType("int");

                    b.Property<int>("tiempo_estimado")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("destinoid");

                    b.HasIndex("origenid");

                    b.ToTable("Rutas");
                });

            modelBuilder.Entity("ProyectoCiclo3.App.Dominio.Rutas", b =>
                {
                    b.HasOne("ProyectoCiclo3.App.Dominio.Estaciones", "destino")
                        .WithMany()
                        .HasForeignKey("destinoid");

                    b.HasOne("ProyectoCiclo3.App.Dominio.Estaciones", "origen")
                        .WithMany()
                        .HasForeignKey("origenid");

                    b.Navigation("destino");

                    b.Navigation("origen");
                });
#pragma warning restore 612, 618
        }
    }
}