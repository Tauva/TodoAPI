using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAPI_ASP_CORE_Swagger.Models;

namespace ToDoAPI_ASP_CORE_Swagger.Services
{
    interface IUserService
    {
        Task<IEnumerable<User>> GetAllUser();
        Task<User> GetUserById(long Id);
        Task<User> CreateUser(User newArtist);
        Task UpdateUser(User UserToUpdate, User user);
        Task DeleteUser(User User);
    }
}
