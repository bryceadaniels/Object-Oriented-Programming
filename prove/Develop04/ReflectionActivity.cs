public class ReflectionActivity: Activity
{
    List<string> _prompts = new List<string>();
    List<string> _questions = new List<string>();
    public ReflectionActivity(string name, string description, int duration): base(name, description, duration)
    {
        CompileQuestions();
        CompilePrompts();
    }
    public ReflectionActivity():base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 60)
    {
        CompileQuestions();
        CompilePrompts();
    }
    public ReflectionActivity(int duration): base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", duration)
    {
        CompileQuestions();
        CompilePrompts();
    }
    private void CompileQuestions()
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
        _questions.Add("Would you want to do this again? Why or why not?");
    }
    private void CompilePrompts()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
    }
    public string GetPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(0,_prompts.Count());
        string prompt = _prompts[index];
        _prompts.Remove(prompt);
        return prompt;
    }
    public void DisplayPrompt()
    {
        string prompt = GetPrompt();
        System.Console.WriteLine(prompt);
    }
    private string GetQuestion()
    {
        Random rand = new Random();
        int number = rand.Next(0,_questions.Count());
        string question = _questions[number];
        _questions.Remove(question);
        return question;
    }
    public void DisplayQuestion()
    {
        string question = GetQuestion();
        System.Console.WriteLine(question);
    }
    public void RunActivity()
    {
        DisplayBeginningMessage();
        DateTime startTime = DateTime.Now;
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        Console.Clear();
        DisplayPrompt();
        PauseWithSpinner(5);
        while (currentTime < futureTime)
        {
         DisplayQuestion();
         PauseWithSpinner(3);
         currentTime = DateTime.Now;
         if (_questions.Count() == 0)
         {
            CompileQuestions();
            if (_prompts.Count() == 0)
            {
                CompilePrompts();
            }
            Console.Clear();
            DisplayPrompt();
            PauseWithSpinner(5);
         }
        }
        Console.Clear();
        DisplayEndingMessage();
    }
}