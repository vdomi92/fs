using data_access_layer.Domain.Entites.Common;

namespace data_access_layer.Domain.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        public Task<T> GetById(int id);

        public Task<IEnumerable<T>> GetAll();

        public Task Create(T entity);

        public Task Update(T entity);

        public Task Delete(int id);

        public Task SaveChanges();
    }
}
