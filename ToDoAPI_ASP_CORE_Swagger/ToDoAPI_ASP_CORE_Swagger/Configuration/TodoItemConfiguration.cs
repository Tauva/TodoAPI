using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoAPI_ASP_CORE_Swagger.Models;


namespace ToDoAPI_ASP_CORE_Swagger.Configuration
{
    public class TodoItemConfiguration
    {
        public void Configure(EntityTypeBuilder<TodoItems> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Id).UseSqlServerIdentityColumn();

            builder.Property(i => i.Name).IsRequired().HasMaxLength(50);

            builder.Property(i => i.IsComplete);

            builder.ToTable("Items");
        }
    }
}
