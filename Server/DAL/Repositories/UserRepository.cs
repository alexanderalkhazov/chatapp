using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories;

public interface IUserRepository : IRepository<User>
{
    Task<User?> GetByEmailAsync(string email);
    Task<IEnumerable<User>> GetWithConversationsAsync();
}

public class UserRepository : Repository<User>, IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<User?> GetByEmailAsync(string email)
    {
         return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
    }

    public async Task<IEnumerable<User>> GetWithConversationsAsync()
    {
        return await _context.Users.Include(u => u.Conversations).ToListAsync();
    }
}