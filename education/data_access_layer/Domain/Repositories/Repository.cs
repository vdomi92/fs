using data_access_layer.Domain.Context;
using data_access_layer.Domain.Entites.Common;
using Microsoft.EntityFrameworkCore;

namespace data_access_layer.Domain.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly ApplicationDbContext _context;

        private readonly DbSet<T> _dbSet;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public Task<T> GetById(int id)
        {
            //TODO: Implement GetById method
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAll()
        {
            //TODO: Implement GetAll method
            throw new NotImplementedException();
        }

        public Task Create(T entity)
        {
            //TODO: Implement Create method
            throw new NotImplementedException();
        }

        public Task Update(T entity)
        {
            //TODO: Implement Update method
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            //TODO: Implement Delete method
            throw new NotImplementedException();
        }

        public Task SaveChanges()
        {
            //TODO: Implement SaveChanges method
            throw new NotImplementedException();
        }
    }
}
