using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoAPI_ASP_CORE_Swagger.Models;

namespace ToDoAPI_ASP_CORE_Swagger.Configuration
{
    public class TodoUserConfiguration
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id).UseSqlServerIdentityColumn();

            builder.Property(u => u.Name).IsRequired().HasMaxLength(50);

            builder.Property(u => u.Password).IsRequired();

            builder.Property(u => u.Mail).IsRequired();

            builder.Property(u => u.Items);

            builder.ToTable("Users");

        }
    }
}
