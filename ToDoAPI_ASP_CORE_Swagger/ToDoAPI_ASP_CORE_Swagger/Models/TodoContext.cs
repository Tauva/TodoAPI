using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAPI_ASP_CORE_Swagger.Configuration;


namespace ToDoAPI_ASP_CORE_Swagger.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }
        public DbSet<TodoItems> TodoItems { get; set; }
        public DbSet<User> Users { get; set; }

  protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new TodoUserConfiguration());

            builder.ApplyConfiguration(new TodoItemConfiguration());
        }
    }
}
