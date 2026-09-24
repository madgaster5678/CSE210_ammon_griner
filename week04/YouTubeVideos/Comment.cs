using System;

public class Comment
{
    private string _comment = "";
    private string _commenterName = "";

    public Comment(string textOfComment, string nameOfCommenter)
    {
        _comment = textOfComment;
        _commenterName = nameOfCommenter;
    }

    public string DisplayComment()
    {
        return $"{_commenterName}: {_comment}";
    }
}