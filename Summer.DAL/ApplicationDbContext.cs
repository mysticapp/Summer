using Microsoft.EntityFrameworkCore;
using Summer.DAL.Entities.Base;
using Summer.DAL.Entities.User;

namespace Summer.DAL;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
}