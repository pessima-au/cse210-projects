using System.Transactions;

public class Video
{
    public string _title;
    public string  _author;
    public int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(string commenter, string comment)
    {
        _comments.Add(new Comment(commenter, comment));
    }

     public List<Comment> GetCommentList()
    {
        return _comments;
    }

    public int GetCommentCount()
    {
        {
            return _comments.Count;
        }
        //return;
    }
}