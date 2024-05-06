using fullstack_quiz_app_elte.Server.DAL.Contracts;
using fullstack_quiz_app_elte.Server.DAL.Domain.Context;
using fullstack_quiz_app_elte.Server.DAL.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace fullstack_quiz_app_elte.Server.DAL.Repositories
{
    public class Repository<T>(AppDbContext context) : IRepository<T> where T : Entity
    {
        private readonly AppDbContext _context = context;

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

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
