class Word{
    private string _text;
    private bool _cleared;
    public Word(){}
    public Word(string text){
        _text = text;
        _cleared = false;
    }
    public void Display(){
        if (_cleared == true){
            foreach(char letter in _text){
                System.Console.Write("_");
            }
        }
        else{
        System.Console.Write(_text);
        }
    }
    public void Clear(){
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
