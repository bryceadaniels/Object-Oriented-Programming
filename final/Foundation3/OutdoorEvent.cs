class OutdoorEvent : Event
{
    private string _weatherForecast;
    public OutdoorEvent(string weather, string title, string desc, string date, string time, Address addy): base(title,desc,date,time,addy,"Outdoor Event")
    {
        _weatherForecast = weather;
    }
    public void FullMessage()
    {
        System.Console.WriteLine(GetTitle());
        System.Console.WriteLine(GetDescription());
        System.Console.WriteLine(GetDate() + " " + GetTime());
        System.Console.WriteLine(GetAddress().FullAddress());
        System.Console.WriteLine("Weather: "+_weatherForecast);
    }
}