using Microsoft.EntityFrameworkCore;
using Switch.Domain.Entities;
using Switch.Infra.Data.Config;

namespace Switch.Infra.Data.Context
{
    public class SwitchContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Post> Posts { get; set; }

        public SwitchContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());

            /*modelBuilder.Entity<Usuario>(entity => {
                entity.HasKey(u => u.Id);
                entity.Property(u => u.Nome).HasMaxLength(255).IsRequired();
                entity.Property(u => u.Sobrenome).HasMaxLength(255).IsRequired();
                entity.Property(u => u.Email).HasMaxLength(255).IsRequired();
                entity.Property(u => u.Senha).HasMaxLength(255).IsRequired();
            });*/

            base.OnModelCreating(modelBuilder);
        }
    }

}
