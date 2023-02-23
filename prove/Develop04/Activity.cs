public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
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
        PauseWithSpinner(3);
    }
    public void DisplayEndingMessage()
    {
        System.Console.WriteLine($"Great job! You completed the {_name} Activity! See you soon :)");
        PauseWithSpinner(2);
    }
    public void PauseWithSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {   
            Console.Write("|");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(100);
            Console.Write("\b \b");
            currentTime = DateTime.Now;
        }
    }
    public void Countdown(int seconds)
    {
        while(seconds> 0)
        {
        System.Console.Write($"{seconds}");
        Thread.Sleep(1000);
        System.Console.Write("\b \b");
        seconds--;
        }
    }
}