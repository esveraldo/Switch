﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Switch.Infra.Data.Context;

namespace Switch.Infra.Data.Migrations
{
    [DbContext(typeof(SwitchContext))]
    [Migration("20200324020639_BugUser")]
    partial class BugUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Switch.Domain.Entities.Amigo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Amigos");
                });

            modelBuilder.Entity("Switch.Domain.Entities.Comentario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataPublicacao");

                    b.Property<string>("Texto");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Comentarios");
                });

            modelBuilder.Entity("Switch.Domain.Entities.Grupo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("UrlFoto")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Grupos");
                });

            modelBuilder.Entity("Switch.Domain.Entities.Identificacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdentificacaoEnum");

                    b.Property<string>("Numero");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId")
                        .IsUnique();

                    b.ToTable("Identificacao");
                });

            modelBuilder.Entity("Switch.Domain.Entities.InstituicaoDeEnsino", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("AnoFormacao");

                    b.Property<bool>("EstudandoAtualmente");

                    b.Property<string>("Nome");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("InstituicoesEnsino");
                });

            modelBuilder.Entity("Switch.Domain.Entities.LocalDeTrabalho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataAdmissao");

                    b.Property<DateTime?>("DataSaida");

                    b.Property<bool>("EmpresaAtual");

                    b.Property<string>("Nome");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("LocaisTrabalho");
                });

            modelBuilder.Entity("Switch.Domain.Entities.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataDoPost")
                        .HasMaxLength(255);

                    b.Property<int>("GrupoId");

                    b.Property<string>("Postagem")
                        .IsRequired();

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("GrupoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Switch.Domain.Entities.ProcurandoPor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.HasKey("Id");

                    b.ToTable("ProcurandoPor");

                    b.HasData(
                        new { Id = 1, Descricao = "NaoIdentificado" },
                        new { Id = 2, Descricao = "Namoro" },
                        new { Id = 3, Descricao = "Amizade" },
                        new { Id = 4, Descricao = "RelacionamentoSerio" }
                    );
                });

            modelBuilder.Entity("Switch.Domain.Entities.StatusRelacionamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.ToTable("StatusRelacionamento");

                    b.HasData(
                        new { Id = 1, Status = "NaoEspecificado" },
                        new { Id = 2, Status = "Solteiro" },
                        new { Id = 3, Status = "Casado" },
                        new { Id = 4, Status = "EmRelacionamentoSerio" }
                    );
                });

            modelBuilder.Entity("Switch.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataDeNascimento");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Foto");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int?>("ProcurandoPorId");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("Sexo");

                    b.Property<string>("SexoEnum");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int?>("StatusRelacionamentoId");

                    b.HasKey("Id");

                    b.HasIndex("ProcurandoPorId");

                    b.HasIndex("StatusRelacionamentoId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Switch.Domain.Entities.UsuarioGrupo", b =>
                {
                    b.Property<int>("UsuarioId");

                    b.Property<int>("GrupoId");

                    b.Property<bool>("Administrador");

                    b.Property<DateTime>("DataCriacao");

                    b.HasKey("UsuarioId", "GrupoId");

                    b.HasIndex("GrupoId")
                        .IsUnique();

                    b.ToTable("UsuarioGrupos");
                });

            modelBuilder.Entity("Switch.Domain.Entities.Amigo", b =>
                {
                    b.HasOne("Switch.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Amigos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Switch.Domain.Entities.Comentario", b =>
                {
                    b.HasOne("Switch.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Comentarios")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Switch.Domain.Entities.Identificacao", b =>
                {
                    b.HasOne("Switch.Domain.Entities.Usuario", "Usuario")
                        .WithOne("Identificacao")
                        .HasForeignKey("Switch.Domain.Entities.Identificacao", "UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Switch.Domain.Entities.InstituicaoDeEnsino", b =>
                {
                    b.HasOne("Switch.Domain.Entities.Usuario", "Usuario")
                        .WithMany("InstituicoesDeEnsino")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Switch.Domain.Entities.LocalDeTrabalho", b =>
                {
                    b.HasOne("Switch.Domain.Entities.Usuario", "Usuario")
                        .WithMany("LocaisDeTrabalho")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Switch.Domain.Entities.Post", b =>
                {
                    b.HasOne("Switch.Domain.Entities.Grupo", "Grupo")
                        .WithMany("Posts")
                        .HasForeignKey("GrupoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Switch.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Posts")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Switch.Domain.Entities.Usuario", b =>
                {
                    b.HasOne("Switch.Domain.Entities.ProcurandoPor", "ProcurandoPor")
                        .WithMany()
                        .HasForeignKey("ProcurandoPorId");

                    b.HasOne("Switch.Domain.Entities.StatusRelacionamento", "StatusRelacionamento")
                        .WithMany()
                        .HasForeignKey("StatusRelacionamentoId");
                });

            modelBuilder.Entity("Switch.Domain.Entities.UsuarioGrupo", b =>
                {
                    b.HasOne("Switch.Domain.Entities.Grupo", "grupo")
                        .WithOne("UsuarioGrupo")
                        .HasForeignKey("Switch.Domain.Entities.UsuarioGrupo", "GrupoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Switch.Domain.Entities.Usuario", "Usuario")
                        .WithMany("UsuarioGrupos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
