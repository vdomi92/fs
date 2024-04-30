using fullstack_quiz_app_elte.Server.DAL.Domain.Entities.Common;

namespace fullstack_quiz_app_elte.Server.DAL.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> GetRepository<T>() where T : Entity;

        int Commit();
    }
}
