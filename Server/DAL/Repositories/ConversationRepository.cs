namespace DAL.Repositories;

public interface IConversationRepository
{
    
}
public class ConversationRepository : IConversationRepository
{
    public ConversationRepository(AppDbContext context)
    {
        
    }
}