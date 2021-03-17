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
        public TodoItemRepository(MyTodoItemDbContext context) : base(context) { }

        public async Task<IEnumerable<TodoItems>> GetAllWithUserAsyc() {
            return await MyTodoItemDbContext.TodoItems
                .Include(m => m.User)
                .ToListAsync();
        }

        public async Task<TodoItems> GetWithUserByIdAsync(int id) {
            return await MyTodoItemDbContext.TodoItems
                .Include(m => m.User)
                .SingleOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IEnumerable<TodoItems>> GetAllWithUserByUserIdAsync(int userId) {
            return await MyTodoItemDbContext.TodoItems
                .Include(m => m.User)
                .Where(m => m.UserId == userId)
                .ToListAsync();
        }

        private MyTodoItemDbContext MyTodoItemDbContext {
            get { return Context as MyTodoItemDbContext; }
        }
    }
}
