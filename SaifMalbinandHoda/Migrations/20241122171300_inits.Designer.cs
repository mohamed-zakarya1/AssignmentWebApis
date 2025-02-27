﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SaifMalbinandHoda.Data;

#nullable disable

namespace SaifMalbinandHoda.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241122171300_inits")]
    partial class inits
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DirectosMovies", b =>
                {
                    b.Property<int>("DirectosId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesId")
                        .HasColumnType("int");

                    b.HasKey("DirectosId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("DirectosMovies");
                });

            modelBuilder.Entity("SaifMalbinandHoda.Models.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("SaifMalbinandHoda.Models.Directos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NationalityId")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NationalityId")
                        .IsUnique()
                        .HasFilter("[NationalityId] IS NOT NULL");

                    b.ToTable("Directos");
                });

            modelBuilder.Entity("SaifMalbinandHoda.Models.Movies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Published_year")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoriesId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("SaifMalbinandHoda.Models.Nationalities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Nationalities");
                });

            modelBuilder.Entity("DirectosMovies", b =>
                {
                    b.HasOne("SaifMalbinandHoda.Models.Directos", null)
                        .WithMany()
                        .HasForeignKey("DirectosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SaifMalbinandHoda.Models.Movies", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SaifMalbinandHoda.Models.Directos", b =>
                {
                    b.HasOne("SaifMalbinandHoda.Models.Nationalities", "Nationalities")
                        .WithOne("Directos")
                        .HasForeignKey("SaifMalbinandHoda.Models.Directos", "NationalityId");

                    b.Navigation("Nationalities");
                });

            modelBuilder.Entity("SaifMalbinandHoda.Models.Movies", b =>
                {
                    b.HasOne("SaifMalbinandHoda.Models.Categories", "Categories")
                        .WithMany("Movies")
                        .HasForeignKey("CategoriesId");

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("SaifMalbinandHoda.Models.Categories", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("SaifMalbinandHoda.Models.Nationalities", b =>
                {
                    b.Navigation("Directos");
                });
#pragma warning restore 612, 618
        }
    }
}
