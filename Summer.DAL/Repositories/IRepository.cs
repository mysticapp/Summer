using System.Linq.Expressions;
using Summer.DAL.Entities.Base;

namespace Summer.DAL.Repositories;

public interface IRepository<T> where T : BaseAuditableEntity
{
    Task<T> GetByIdAsync(int id);
    Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate);
    Task AddAsync(T entity);
    void Update(T entity);
    void Delete(T entity);
    Task<T> GetAsync(Expression<Func<T, bool>> predicate);
}