using fullstack_quiz_app_elte.Server.DAL.Domain.Entities.Common;
using System.Linq.Expressions;

namespace fullstack_quiz_app_elte.Server.DAL.Contracts
{
    public interface IRepository<T> where T : Entity
    {
        public T? GetById(int id);

        public IEnumerable<T> GetAll();

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        public void Create(T entity);

        public void Update(T entity);

        public void Delete(int id);

    }
}
