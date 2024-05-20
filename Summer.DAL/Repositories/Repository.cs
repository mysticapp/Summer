using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Summer.DAL.Entities.Base;

namespace Summer.DAL.Repositories;

public class Repository<T> : IRepository<T> where T : BaseAuditableEntity
{
    private readonly ApplicationDbContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(ApplicationDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public async Task<T> GetByIdAsync(int id) => await GetBaseQuery().FirstOrDefaultAsync(x => x.Id == id && x.DateDeleted == null);
    public async Task<T> GetAsync(Expression<Func<T, bool>> predicate) => await GetBaseQuery().FirstOrDefaultAsync(predicate);

    public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null)
    {
        return await GetBaseQuery().Where(predicate).ToListAsync();
    }

    public async Task AddAsync(T entity)
    {
        entity.DateCreated = DateTime.Now;
        await _dbSet.AddAsync(entity);
    }

    public void Update(T entity)
    {
        entity.DateModified = DateTime.Now;
        _dbSet.Update(entity);
    }

    public void Delete(T entity)
    {
        entity.DateDeleted = DateTime.Now;
        _dbSet.Update(entity);
    }
    
    public IQueryable<T> GetBaseQuery() => _dbSet.AsNoTracking().Where(x => x.DateDeleted == null);
}