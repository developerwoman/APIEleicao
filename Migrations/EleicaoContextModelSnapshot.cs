﻿// <auto-generated />
using System;
using APIEleicao.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APIEleicao.Migrations
{
    [DbContext(typeof(EleicaoContext))]
    partial class EleicaoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Eleicoes")
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("APIEleicao.Model.Candidato", b =>
                {
                    b.Property<string>("Codigo")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)")
                        .HasColumnName("CODIGO");

                    b.Property<DateTime>("Data_registro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("DATA_REGISTRO");

                    b.Property<Guid>("Id_candidato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID_CANDIDATO");

                    b.Property<string>("Legenda")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("LEGENDA");

                    b.Property<string>("Nome")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("NOME");

                    b.Property<string>("Vice")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("VICE");

                    b.ToTable("Candidato");
                });

            modelBuilder.Entity("APIEleicao.Model.Voto", b =>
                {
                    b.Property<DateTime>("Data_registro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("DATA_REGISTRO");

                    b.Property<int>("Id_candidato")
                        .HasMaxLength(200)
                        .HasColumnType("int")
                        .HasColumnName("ID_CANDIDATO");

                    b.Property<Guid>("Id_voto")
                        .HasColumnType("uniqueidentifier");

                    b.ToTable("Voto");
                });
#pragma warning restore 612, 618
        }
    }
}
