class Comment
{
    private string _person; //I know I don't have to do this for abstraction, but I prefer it
    private string _content;
    public Comment(string person, string content)
    {
        _content=content;
        _person = person;
    }
    public void Display()
    {
        System.Console.WriteLine($"{_person}- {_content}");
    }
}