namespace DAL.Models;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string ProfilePictureUri { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime LastLogin { get; set; }
    public DateTime UpdatedAt { get; set; }
    public List<Conversation> Conversations { get; set; }
    public List<Message> SentMessages { get; set; }
    public List<Message> ReceivedMessages { get; set; }
    public List<Message> ReadMessages { get; set; }
}