class ReceptionEvent : Event
{
    private string _RSVPemail;
    public ReceptionEvent(string email, string title, string desc, string date, string time, Address addy): base(title,desc,date,time,addy,"Reception Event")
    {
        _RSVPemail = email;
    }
    public void FullMessage()
    {
        System.Console.WriteLine(GetTitle());
        System.Console.WriteLine(GetDescription());
        System.Console.WriteLine(GetDate() + " " + GetTime());
        System.Console.WriteLine(GetAddress().FullAddress());
        System.Console.WriteLine("RSVP: "+_RSVPemail);
    }
    
}