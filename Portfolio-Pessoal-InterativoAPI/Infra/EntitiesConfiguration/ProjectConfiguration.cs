using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;

namespace Infra.EntitiesConfiguration
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.Description).IsRequired();
            builder.Property(e => e.UrlGit).IsRequired();
            builder.Property(e => e.Tags)
                .IsRequired()
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null), // Para JSON
                    v => JsonSerializer.Deserialize<HashSet<string>>(v, (JsonSerializerOptions)null) // De JSON
                );
            builder.Property(e => e.CreatedAt);
            builder.Property(e => e.UpdatedAt);

            builder
            .HasMany(e => e.CommentsList)
            .WithOne(c => c.Project) // Cada comentário pertence a um projeto
            .HasForeignKey(c => c.ProjectId) // Chave estrangeira
            .OnDelete(DeleteBehavior.Cascade);

            // Configuração de eager loading automático
            //Será mesmo necessario?
            //Se o projeto tiver muitos comentarios?
            builder.Navigation(e => e.CommentsList)
                .AutoInclude();


        }
    }
}

