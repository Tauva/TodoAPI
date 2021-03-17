using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAPI_ASP_CORE_Swagger.Repository
{
    interface IUnitOfWork : IDisposable
    {
        IItemRepository TodoItem { get;  }
        IUserRepository User { get; }
        Task<int> CommitAsync();
    }
}
