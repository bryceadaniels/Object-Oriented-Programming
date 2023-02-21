public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    public Activity(string name,string description,int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public Activity(int duration)
    {
        _duration = duration;
    }
    public Activity(){}
    public void DisplayBeginningMessage()
    {
        System.Console.WriteLine($"Welcome to the {_name} Activity!");
        System.Console.WriteLine(_description);
        System.Console.Write("How many seconds would you like this activity to last? ");
        _duration = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Thank you. Your activity will begin shortly.");
        System.Console.WriteLine("Prepare yourself to begin.");
        Thread.Sleep(2000);
    }
    public void DisplayEndingMessage()
    {
        System.Console.WriteLine($"Great job! Yo completed the {_name} Activity for {_duration} seconds.");
        Thread.Sleep(3000);
    }
    public void PauseWithSpinner(int time)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);
        DateTime currentTime = DateTime.Now;   
        Console.Write("|");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(250);
        Console.Write("\b \b");
    }
    public void Countdown(int time)
    {
        while(time> 0)
        {
        System.Console.Write("");
        }
    }
}