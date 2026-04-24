using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models;

public class Message
{
    public int Id { get; set; }
    public int ConversationId { get; set; }
    public Conversation Conversation { get; set; }
    public int SenderId { get; set; }
    [InverseProperty("SentMessages")]
    public User Sender { get; set; }
    public string Content { get; set; }
    public DateTime Timestamp { get; set; }
    [InverseProperty("ReceivedMessages")]
    public List<User> Receivers { get; set; }
    [InverseProperty("ReadMessages")]
    public List<User> ReadBy { get; set; }
}