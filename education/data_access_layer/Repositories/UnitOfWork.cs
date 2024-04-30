using data_access_layer.Contracts;
using data_access_layer.Domain.Context;
using data_access_layer.Domain.Entites.Common;
using System.Data.Common;

namespace data_access_layer.Repositories
{
    public class UnitOfWork(ApplicationDbContext context) : IUnitOfWork
    {
        private ApplicationDbContext _context = context;

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
