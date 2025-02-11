using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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

            var comparer = new ValueComparer<HashSet<string>>(
            (c1, c2) => c1.SetEquals(c2),  // Compara os elementos da coleção
            c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())), // Gera hash para a coleção
            c => new HashSet<string>(c) // Garante que a cópia seja independente
            );

            builder.Property(e => e.Tags)
                .IsRequired()
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null), // Para JSON
                    v => JsonSerializer.Deserialize<HashSet<string>>(v, (JsonSerializerOptions)null) // De JSON
                )
                .Metadata.SetValueComparer(comparer); // Adiciona o Value Comparer

            builder.Property(e => e.CreatedAt);
            builder.Property(e => e.UpdatedAt);

            builder
            .HasMany(e => e.CommentsList)
            .WithOne(c => c.Project) // Cada comentário pertence a um projeto
            .HasForeignKey(c => c.ProjectId) // Chave estrangeira
            .OnDelete(DeleteBehavior.Cascade);

        }
    }
}

