namespace DAL.Models;

public class Conversation
{
    public int Id { get; set; }
    public List<User> Participants { get; set; }
    public List<Message> Messages { get; set; }
    public string Name { get; set; }          // group chat name, null for DMs
    public string PictureUri { get; set; }    // group picture, null for DMs
    public bool IsGroup { get; set; }         // DM vs group flag
}