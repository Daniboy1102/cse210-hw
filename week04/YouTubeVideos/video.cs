public class Video
{
    public string Title;
    public string Author;
    public int LengthSeconds;

    public List<Comment> Comments = new List<Comment>();

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}
