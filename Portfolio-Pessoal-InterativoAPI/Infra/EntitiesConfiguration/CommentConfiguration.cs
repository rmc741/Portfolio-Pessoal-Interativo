using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntitiesConfiguration
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Content)
                .IsRequired();

            builder.Property(e => e.CreatedAt);
            builder.Property(e => e.UpdatedAt);

            // Configuração da chave estrangeira
            builder
                .HasOne(c => c.Project) // Relacionamento com Project
                .WithMany(p => p.CommentsList) // Um Project pode ter muitos comentários
                .HasForeignKey(c => c.ProjectId) // Especifica a chave estrangeira
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
