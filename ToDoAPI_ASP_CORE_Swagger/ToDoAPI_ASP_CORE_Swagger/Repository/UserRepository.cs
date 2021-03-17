using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyTodoItem.Core.Models;
using MyTodoItem.Core.Repositories;

namespace ToDoAPI_ASP_CORE_Swagger.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(MyTodoItemDbContext context)
            : base(context)
        { }

        public async Task<IEnumerable<User>> GetAllWithTodoItemAsync() {
            return await MyTodoItemContext.Users
                .Include(async => a.TodoItems)
                .ToListAsync();
        }

        public Task<Users> GetWithTodoItemsByIdAsync(int id) {
            return MyTodoItemDbContext.Users
                .Include(async => async.TodoItems)
                .SingleOrDefaultAsync(a => a.Id == id);
        }

        private MyTodoItemDbContext MyTodoItemDbContext {
            get { return Context as MyTodoItemDbContext; }
        }
    }
}