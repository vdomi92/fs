using data_access_layer.Domain.Entites.Common;
using System.Linq.Expressions;

namespace data_access_layer.Contracts
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
