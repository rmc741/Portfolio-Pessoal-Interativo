using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.EntitiesConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            // Configurações de propriedades
            builder.Property(u => u.Name)
                .IsRequired() 
                .HasMaxLength(250); 

            builder.Property(u => u.Email)
                .IsRequired() 
                .HasMaxLength(200);
            builder.HasIndex(u => u.Email).IsUnique();

            builder.Property(u => u.Password)
                .IsRequired() 
                .HasMaxLength(50); 

            builder.Property(u => u.UserName)
                .IsRequired() 
                .HasMaxLength(50); 
            builder.HasIndex(u => u.UserName).IsUnique(); 

            builder.Property(u => u.CreateAt)
                .IsRequired();

            builder.Property(u => u.UpdateAt)
                .IsRequired();

            builder.Property(u => u.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            
        }
    }
}
