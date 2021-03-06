﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProAgil.Repositorio.Contexto;

namespace ProAgil.Repositorio.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210228171552_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProAgil.Dominio.Entidades.Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LocalId")
                        .HasColumnType("int")
                        .HasColumnName("Local_Id");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar");

                    b.Property<int>("QtdPessoas")
                        .HasColumnType("int");

                    b.Property<int?>("TemaId")
                        .HasColumnType("int")
                        .HasColumnName("Tema_Id");

                    b.HasKey("Id");

                    b.HasIndex("LocalId");

                    b.HasIndex("TemaId");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("ProAgil.Dominio.Entidades.Local", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("Locais");
                });

            modelBuilder.Entity("ProAgil.Dominio.Entidades.Tema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("Temas");
                });

            modelBuilder.Entity("ProAgil.Dominio.Entidades.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ProAgil.Dominio.Entidades.Evento", b =>
                {
                    b.HasOne("ProAgil.Dominio.Entidades.Local", "Local")
                        .WithMany()
                        .HasForeignKey("LocalId");

                    b.HasOne("ProAgil.Dominio.Entidades.Tema", "Tema")
                        .WithMany()
                        .HasForeignKey("TemaId");

                    b.Navigation("Local");

                    b.Navigation("Tema");
                });
#pragma warning restore 612, 618
        }
    }
}
