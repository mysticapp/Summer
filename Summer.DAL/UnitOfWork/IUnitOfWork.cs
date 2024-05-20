using Summer.DAL.Entities.User;
using Summer.DAL.Repositories;

namespace Summer.DAL.UnitOfWork;

public interface IUnitOfWork : IDisposable
{
    IRepository<User> Users { get; }
    Task<int> CompleteAsync();
}