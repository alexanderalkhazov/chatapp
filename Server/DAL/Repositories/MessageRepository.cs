namespace DAL.Repositories;

public interface IMessageRepository
{
    
}
public class MessageRepository : IMessageRepository
{
    public MessageRepository(AppDbContext context)
    {
        
    }
}