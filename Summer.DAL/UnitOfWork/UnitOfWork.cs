using Summer.DAL.Entities.User;
using Summer.DAL.Repositories;

namespace Summer.DAL.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;
    private readonly IRepository<User> _userRepository;

    public UnitOfWork(ApplicationDbContext context, IRepository<User> userRepository)
    {
        _context = context;
        _userRepository = userRepository;
    }

    public IRepository<User> Users => _userRepository;

    public async Task<int> CompleteAsync() => await _context.SaveChangesAsync();

    public void Dispose() => _context.Dispose();
}