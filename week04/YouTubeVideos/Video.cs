using System;

public class Video
{
    private string _title = "";
    private string _author = "";
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int NumberOfComments()
    {
        return _comments.Count;
    }

    public string GetVideoTitle()
    {
        return _title;
    }

    public string DisplayVideo()
    {
        return $"Title: {_title}\nAuthor: {_author}\nLength: {_length} seconds";
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}