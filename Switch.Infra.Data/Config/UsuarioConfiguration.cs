using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Nome).HasMaxLength(255).IsRequired();
            builder.Property(u => u.Sobrenome).HasMaxLength(255).IsRequired();
            builder.Property(u => u.Email).HasMaxLength(255).IsRequired();
            builder.Property(u => u.Senha).HasMaxLength(255).IsRequired();
        }
    }
}
