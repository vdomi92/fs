using data_access_layer.Contracts;
using data_access_layer.Domain.Context;
using data_access_layer.Domain.Entites.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace data_access_layer.Repositories
{
    public class Repository<T>(ApplicationDbContext context) : IRepository<T> where T : Entity
    {
        private readonly ApplicationDbContext _context = context;

        private readonly DbSet<T> _dbSet = context.Set<T>();

        public T? GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate).ToList();
        }

        public void Create(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            T? entity = _dbSet.Find(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
            }
        }
    }
}
