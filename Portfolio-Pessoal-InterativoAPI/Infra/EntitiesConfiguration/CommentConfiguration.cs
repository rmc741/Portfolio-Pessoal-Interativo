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

            builder
                .HasOne(c => c.Project) 
                .WithMany(p => p.CommentsList)
                .HasForeignKey(c => c.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<User>() 
           .WithMany(u => u.Comments)
           .HasForeignKey(c => c.UserId)
           .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
