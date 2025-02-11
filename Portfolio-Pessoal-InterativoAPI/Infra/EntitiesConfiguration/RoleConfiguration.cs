using Domain;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntitiesConfiguration
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Type)
                .HasConversion(
                    v => v.ToString(), // Enum para string
                    v => (RoleTypeEnum)Enum.Parse(typeof(RoleTypeEnum), v)
                )
                .IsRequired();

            builder.HasData(
                new Role { Id = Guid.NewGuid(), Type = RoleTypeEnum.ADMIN },
                new Role { Id = Guid.NewGuid(), Type = RoleTypeEnum.USER },
                new Role { Id = Guid.NewGuid(), Type = RoleTypeEnum.MANAGER }
            );
        }
    }
}
