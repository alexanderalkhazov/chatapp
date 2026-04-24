namespace DAL.Models;

public class ConversationParticipant
{
    public int ConversationId { get; set; }
    public Conversation Conversation { get; set; }
    public bool IsAdmin { get; set; }  
    public int UserId { get; set; }
    public User User { get; set; }
    public DateTime JoinedAt { get; set; }
    public bool IsMuted { get; set; }
}