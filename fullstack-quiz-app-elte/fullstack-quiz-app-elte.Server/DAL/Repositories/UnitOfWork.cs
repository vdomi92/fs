using fullstack_quiz_app_elte.Server.DAL.Contracts;
using fullstack_quiz_app_elte.Server.DAL.Domain.Context;
using fullstack_quiz_app_elte.Server.DAL.Domain.Entities.Common;

namespace fullstack_quiz_app_elte.Server.DAL.Repositories
{
    public class UnitOfWork(AppDbContext context) : IUnitOfWork
    {
        private AppDbContext _context = context;

        private Dictionary<Type, object> _repositories = [];

        private bool disposed = false;

        public IRepository<T> GetRepository<T>() where T : Entity
        {
            Type entityType = typeof(T);
            if (!_repositories.ContainsKey(entityType))
            {
                _repositories[entityType] = new Repository<T>(_context);
            }

            return (IRepository<T>)_repositories[entityType];
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
