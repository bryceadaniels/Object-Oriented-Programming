class Word{
    private string _text;
    private bool _cleared;
    public Word(){}
    public Word(string text){
        _text = text;
        _cleared = false;
    }
    public void Display(){
        System.Console.Write(_text);
    }
    public void Clear(){
        _text = _text.Replace(_text,"_____");
        _cleared = true;
    }
    public bool GetIfCleared(){
        if (_cleared == true){
            return true;
        }
        else{
            return false;
        }
    }

    }
