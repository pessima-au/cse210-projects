public class Comment{
     public string _commenter;
    public string _comment;

    public Comment(string commenter, string comment)
    {
        _commenter = commenter;
        _comment = comment;
    }

    public void MakeComment(string comment)
    {
        _comment = comment;
    }

    public override string ToString()
    {
        return $"{_commenter}: {_comment}";
    }
}