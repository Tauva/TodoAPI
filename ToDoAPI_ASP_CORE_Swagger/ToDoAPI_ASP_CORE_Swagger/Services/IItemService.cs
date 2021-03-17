using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAPI_ASP_CORE_Swagger.Models;

namespace ToDoAPI_ASP_CORE_Swagger.Services
{
    interface IItemService
    {
        Task<IEnumerable<TodoItems>> GetAllWithUser();
        Task<TodoItems> GetItemById(long Id);
        Task<IEnumerable<TodoItems>> GetItemByUserID(long UserID);
        Task<TodoItems> CreateTodoItem(TodoItems todoItems);
        Task UpdateTodoItem(TodoItems ItemToUpdate, TodoItems items);
        Task DeleteTodoItem(TodoItems Item);

    }
}