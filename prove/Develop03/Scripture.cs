public class Scripture{
    private string _reference;
    private List<Verse> _content = new List<Verse>();
    private bool _hidden = false;
    public Scripture(){}
    public Scripture(string reference, List<string> content)
    {
        _reference = reference;
        foreach(string part in content)
        {
            Verse verse = new Verse(part);
            _content.Add(verse);
        }
        _hidden = false;
    }
    public void Display()
    {
        System.Console.WriteLine(_reference);
        foreach(Verse verse in _content)
        {
            verse.Display();
        }
    }
    public bool IsAllHidden()
    {
        foreach(Verse verse in _content)
        {
            if (verse.GetIfCleared() == false)
            {
                return false;
            }
        }
        return true;
    }
    public bool HideWords(int number)
    {
        int counter = 0;
        int failCounter = 0;
        while (counter < number)
        {
            Random rand = new Random();
            int index = rand.Next(_content.Count());
            Verse verse = new Verse();
            verse = _content[index];
            if(verse.HideWord()==true)
            {
                counter = counter +1;
            }
            failCounter = failCounter + 1;
            if(failCounter > 100)
            {
                _hidden = true;
                return false;
            }
        }
        return true;
    }
    public void ClearAll()
    {
        foreach(Verse verse in _content)
        {
            verse.ClearAll();
            _hidden = true;
        }
    }
}