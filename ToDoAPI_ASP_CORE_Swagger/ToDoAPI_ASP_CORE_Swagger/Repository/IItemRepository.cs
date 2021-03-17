using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAPI_ASP_CORE_Swagger.Models;

namespace ToDoAPI_ASP_CORE_Swagger.Repository
{
    public interface IItemRepository : IRepository<TodoItems>
    {
        Task<IEnumerable<TodoItems>> GetAllWithUserAsync();
        Task<TodoItems> GetWithUserIdAsync(long id);
        Task<IEnumerable<TodoItems>> GetAllWithUserByUserIdAsync(long UserId);

    }
}
