class Video
{
    string _title;
    string _author;
    int _length;
    List<Comment> _comments;
    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }
    public int GetNumOfComments()
    {
        return _comments.Count();
    }
    public void Display()
    {
        System.Console.WriteLine($"{_title} by {_author} ({_length} sec) {GetNumOfComments()} comments");
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }
}