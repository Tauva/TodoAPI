using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAPI_ASP_CORE_Swagger.Models;
using ToDoAPI_ASP_CORE_Swagger.Repositories;
using Microsoft.EntityFrameworkCore;
using ToDoAPI_ASP_CORE_Swagger.Repository;

namespace ToDoAPI_ASP_CORE_Swagger.Repository
{
    public class TodoItemRepository : Repository<TodoItems>, IItemRepository
    {
        public TodoItemRepository(TodoContext context) : base(context) { }
    }
}
