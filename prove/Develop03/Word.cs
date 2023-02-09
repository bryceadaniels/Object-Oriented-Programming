class Word{
    private string _text;
    private bool _cleared = false;
    public Word(){}
    public Word(string text)
    {
        _text = text;
        _cleared = false;
    }
    public void Display()
    {
        if (_cleared == true)
        {
            foreach(char letter in _text)
            {
                System.Console.Write("_");
            }
        }
        else
        {
        System.Console.Write(_text);
        }
    }
    public void Clear()
    {
        _cleared = true;
    }
    public bool GetIfCleared()
    {
        return _cleared;
    }

    }
