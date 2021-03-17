using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAPI_ASP_CORE_Swagger.Models;

namespace ToDoAPI_ASP_CORE_Swagger.Repository
{
    interface IUserRepository : IRepository<User>
    {
        Task<IEnumerable<User>> GetAllWithItemAsync();
        Task<User> GetWithUserByIdAsync(long Id);
    }
}
