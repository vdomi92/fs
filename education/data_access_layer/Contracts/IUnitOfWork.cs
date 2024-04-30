using data_access_layer.Domain.Entites.Common;

namespace data_access_layer.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> GetRepository<T>() where T : Entity;

        int Commit();
    }
}
