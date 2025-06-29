﻿// <auto-generated />
using System;
using ComisionesVentas.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ComisionesVentas.Migrations
{
    [DbContext(typeof(SalesDbContext))]
    [Migration("20250625005549_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.6");

            modelBuilder.Entity("ComisionesVentas.Models.Regla", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("MontoMaximo")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("MontoMinimo")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("PorcentajeComision")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("Id");

                    b.ToTable("Reglas");
                });

            modelBuilder.Entity("ComisionesVentas.Models.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Vendedores");
                });

            modelBuilder.Entity("ComisionesVentas.Models.Venta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Monto")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("ReglaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VendedorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ReglaId");

                    b.HasIndex("VendedorId");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("ComisionesVentas.Models.Venta", b =>
                {
                    b.HasOne("ComisionesVentas.Models.Regla", "Regla")
                        .WithMany("Ventas")
                        .HasForeignKey("ReglaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ComisionesVentas.Models.Vendedor", "Vendedor")
                        .WithMany("Ventas")
                        .HasForeignKey("VendedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Regla");

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("ComisionesVentas.Models.Regla", b =>
                {
                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("ComisionesVentas.Models.Vendedor", b =>
                {
                    b.Navigation("Ventas");
                });
#pragma warning restore 612, 618
        }
    }
}
