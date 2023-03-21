class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;
    public LectureEvent(string speaker, int capacity, string title, string desc, string date, string time, Address addy): base(title,desc,date,time,addy,"Lecture Event")
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public void FullMessage()
    {
        System.Console.WriteLine(GetTitle());
        System.Console.WriteLine(GetDescription());
        System.Console.WriteLine(GetDate() + " " + GetTime());
        System.Console.WriteLine(GetAddress().FullAddress());
        System.Console.WriteLine("Speaker: "+_speaker);
        System.Console.WriteLine("Capacity: "+_capacity);
    }
}