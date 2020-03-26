using Microsoft.EntityFrameworkCore;
using Switch.Domain.Entities;
using Switch.Infra.Data.Config;

namespace Switch.Infra.Data.Context
{
    public class SwitchContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<StatusRelacionamento> StatusRelacionamento { get; set; }
        public DbSet<Identificacao> Identificacao { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<UsuarioGrupo> UsuarioGrupos { get; set; }
        public DbSet<Amigo> Amigos { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<InstituicaoDeEnsino> InstituicoesEnsino { get; set; }
        public DbSet<LocalDeTrabalho> LocaisTrabalho { get; set; }
        public DbSet<ProcurandoPor> ProcurandoPor { get; set; }

        public SwitchContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new GrupoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioGrupoConfiguration());
            modelBuilder.ApplyConfiguration(new AmigoConfiguration());

            modelBuilder.Entity<ProcurandoPor>().HasData(
                new ProcurandoPor() { Id = 1, Descricao = "NaoIdentificado" },
                new ProcurandoPor() { Id = 2, Descricao = "Namoro" },
                new ProcurandoPor() { Id = 3, Descricao = "Amizade" },
                new ProcurandoPor() { Id = 4, Descricao = "RelacionamentoSerio" }
                );

            modelBuilder.Entity<StatusRelacionamento>().HasData(
                new StatusRelacionamento() { Id = 1, Status = "NaoEspecificado" },
                new StatusRelacionamento() { Id = 2, Status = "Solteiro" },
                new StatusRelacionamento() { Id = 3, Status = "Casado" },
                new StatusRelacionamento() { Id = 4, Status = "EmRelacionamentoSerio" }
                );

            base.OnModelCreating(modelBuilder);
        }
    }

}
