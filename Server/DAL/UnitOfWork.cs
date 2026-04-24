using DAL.Repositories;

namespace DAL;

public interface IUnitOfWork : IDisposable
{
    IUserRepository Users { get; }
    IConversationRepository Conversations { get; }
    IMessageRepository Messages { get; }
    Task<int> SaveChangesAsync();
    Task<bool> IsConnected();
}

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    public IUserRepository Users { get; }
    public IConversationRepository Conversations { get; }
    public IMessageRepository Messages { get; }

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
        Users = new UserRepository(_context);
        Conversations = new ConversationRepository(_context);
        Messages = new MessageRepository(_context);
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public async Task<bool> IsConnected()
    {
        return await _context.Database.CanConnectAsync();
    }

    public void Dispose() => _context.Dispose();
}
