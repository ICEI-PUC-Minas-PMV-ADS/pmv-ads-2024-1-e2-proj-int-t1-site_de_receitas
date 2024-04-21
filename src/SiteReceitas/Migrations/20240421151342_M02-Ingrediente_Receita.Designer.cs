﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SiteReceitas.Models;

#nullable disable

namespace SiteReceitas.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20240421151342_M02-Ingrediente_Receita")]
    partial class M02Ingrediente_Receita
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SiteReceitas.Models.Ingrediente_Receita", b =>
                {
                    b.Property<int>("IdIngredienteReceita")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdIngredienteReceita"));

                    b.Property<int>("IdReceita")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeIngrediente")
                        .HasColumnType("int");

                    b.Property<int?>("ReceitaIdReceita")
                        .HasColumnType("int");

                    b.HasKey("IdIngredienteReceita");

                    b.HasIndex("ReceitaIdReceita");

                    b.ToTable("Ingredientes_Receita");
                });

            modelBuilder.Entity("SiteReceitas.Models.Receita", b =>
                {
                    b.Property<int>("IdReceita")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdReceita"));

                    b.Property<string>("ModoPreparo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeReceita")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdReceita");

                    b.ToTable("Receitas");
                });

            modelBuilder.Entity("SiteReceitas.Models.Ingrediente_Receita", b =>
                {
                    b.HasOne("SiteReceitas.Models.Receita", "Receita")
                        .WithMany("Ingredientes_Receita")
                        .HasForeignKey("ReceitaIdReceita");

                    b.Navigation("Receita");
                });

            modelBuilder.Entity("SiteReceitas.Models.Receita", b =>
                {
                    b.Navigation("Ingredientes_Receita");
                });
#pragma warning restore 612, 618
        }
    }
}
