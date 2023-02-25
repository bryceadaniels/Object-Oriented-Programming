public class ListingActivity:Activity
{
    List<string> _prompts = new List<string>();
    List<string> _responses = new List<string>();
    string _prompt;
    public ListingActivity():base("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",60)
    {
        CompilePrompts();
    }
    public ListingActivity(int duration) : base("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",duration)
    {
        CompilePrompts();
    }
    public ListingActivity(string name, string description, int duration): base(name, description, duration)
    {
        CompilePrompts();
    }
    private void CompilePrompts()
    {
        _prompts.Add("Who are people that you appreciate? ");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week? ");
        _prompts.Add("When have you felt the Holy Ghost this month? ");
        _prompts.Add("Who are some of your personal heroes?");
    }
    private void GetPrompt()
    {
        Random rand = new Random();
        int number = rand.Next(0,_prompts.Count);
        _prompt= _prompts[number];
    }
    private void DisplayPrompt()
    {
        System.Console.WriteLine(_prompt);
    }
    private void DisplayCount()
    {
        System.Console.WriteLine($"You answered {_responses.Count} times.");
    }
    public void RunActivity()
    {
        DisplayBeginningMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        GetPrompt();
        while(currentTime < endTime)
        {
            Console.Clear();
            DisplayPrompt();
            string respone = Console.ReadLine();
            _responses.Add(respone);
            currentTime = DateTime.Now;
        }
        DisplayCount();
        DisplayEndingMessage();
    }
}
