﻿// <auto-generated />
using System;
using MiApp.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MiApp.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MiApp.Eventos.Evento", b =>
                {
                    b.Property<int>("EventoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("EquipoLocal")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("EquipoVisitante")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.HasKey("EventoId");

                    b.ToTable("Eventos");

                    b.HasData(
                        new
                        {
                            EventoId = 1,
                            EquipoLocal = "Valencia",
                            EquipoVisitante = "Espanyol",
                            Fecha = new DateTime(2020, 2, 17, 11, 44, 6, 473, DateTimeKind.Local).AddTicks(9825)
                        },
                        new
                        {
                            EventoId = 2,
                            EquipoLocal = "Barcelona",
                            EquipoVisitante = "Madrid",
                            Fecha = new DateTime(2020, 2, 17, 11, 44, 6, 475, DateTimeKind.Local).AddTicks(9728)
                        });
                });

            modelBuilder.Entity("MiApp.Mercados.Mercado", b =>
                {
                    b.Property<int>("MercadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("ApostadoOver")
                        .HasColumnType("double");

                    b.Property<double>("ApostadoUnder")
                        .HasColumnType("double");

                    b.Property<double>("CuotaOver")
                        .HasColumnType("double");

                    b.Property<double>("CuotaUnder")
                        .HasColumnType("double");

                    b.Property<int>("EventoId")
                        .HasColumnType("int");

                    b.Property<double>("Tipo")
                        .HasColumnType("double");

                    b.HasKey("MercadoId");

                    b.HasIndex("EventoId");

                    b.ToTable("Mercados");

                    b.HasData(
                        new
                        {
                            MercadoId = 1,
                            ApostadoOver = 100.0,
                            ApostadoUnder = 100.0,
                            CuotaOver = 1.8999999999999999,
                            CuotaUnder = 2.5,
                            EventoId = 1,
                            Tipo = 1.5
                        },
                        new
                        {
                            MercadoId = 2,
                            ApostadoOver = 100.0,
                            ApostadoUnder = 100.0,
                            CuotaOver = 2.5,
                            CuotaUnder = 1.8999999999999999,
                            EventoId = 1,
                            Tipo = 2.5
                        },
                        new
                        {
                            MercadoId = 3,
                            ApostadoOver = 100.0,
                            ApostadoUnder = 100.0,
                            CuotaOver = 3.0,
                            CuotaUnder = 1.8999999999999999,
                            EventoId = 1,
                            Tipo = 3.3999999999999999
                        },
                        new
                        {
                            MercadoId = 4,
                            ApostadoOver = 100.0,
                            ApostadoUnder = 100.0,
                            CuotaOver = 1.8999999999999999,
                            CuotaUnder = 2.5,
                            EventoId = 2,
                            Tipo = 1.5
                        },
                        new
                        {
                            MercadoId = 5,
                            ApostadoOver = 100.0,
                            ApostadoUnder = 100.0,
                            CuotaOver = 2.5,
                            CuotaUnder = 1.8999999999999999,
                            EventoId = 2,
                            Tipo = 2.5
                        },
                        new
                        {
                            MercadoId = 6,
                            ApostadoOver = 100.0,
                            ApostadoUnder = 100.0,
                            CuotaOver = 3.0,
                            CuotaUnder = 1.8999999999999999,
                            EventoId = 2,
                            Tipo = 3.3999999999999999
                        });
                });

            modelBuilder.Entity("MiApp.Mercados.Mercado", b =>
                {
                    b.HasOne("MiApp.Eventos.Evento", "Evento")
                        .WithMany()
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
