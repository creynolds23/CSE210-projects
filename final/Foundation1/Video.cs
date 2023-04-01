public class Video
{
    public string _title { get; set; }
    public string _author { get; set; }
    public int _length { get; set; }
    public List<Comment> _comments { get; set; }
    public string _genre{get; set;}

    public int NumberOfComments()
    {
        return _comments.Count;
    }
}