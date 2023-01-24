public class Entry{

    public Entry(){}
    public string _date = "";
    public string _prompt = "";
    public PromptGenerator _promptGenerator = new PromptGenerator();
    public string _response = "";
    public string _location = "";

    public void GetResponse(){
        System.Console.WriteLine("Welcome to creating an entry!");
        System.Console.WriteLine("Where are you writing this entry? ");
        _location = Console.ReadLine();
        System.Console.WriteLine("Thank you, today's prompt is:");
        _prompt = _promptGenerator.GetPrompt();
        System.Console.WriteLine(_prompt);
        _response = Console.ReadLine();
    }
    public void Display(){
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
        System.Console.Write($"Entry on {_date} at {_location}: ");
        System.Console.WriteLine(_prompt);
        System.Console.WriteLine(_response);
    }


}