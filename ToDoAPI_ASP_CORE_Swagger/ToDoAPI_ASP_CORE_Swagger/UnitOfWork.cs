using System.Threading.Tasks;
using MyTodoItem.Core;
using MyTodoItem.Core.Repositories;
using MyTodoItem.Data.Repositories;

namespace MyTodoItem.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyTodoItemDbContext _context;
        private TodoItemRepository _todoItemRepository;
        private UserRepository _userRepository;

        public UnitOfWork(MyTodoItemDbContext context)
        {
            this._context = context;
        }

        public ITodoItemRepository TodoItems => _todoItemRepository = _todoItemRepository ?? new TodoItemRepository(_context);

        public IUserRepository Users => _userRepository = _userRepository ?? new UsersRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}