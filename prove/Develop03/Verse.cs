class Verse{
    private List<Word> _contents = new List<Word>();
    private bool _hidden;

    public Verse(){}
    public Verse(string contents){
        foreach(string part in contents.Split(' ')){
            Word word = new Word(part);
            _contents.Add(word);
        }
    }
    public void Display(){
        foreach(Word word in _contents){
            word.Display();
            System.Console.Write(" ");
        }
        System.Console.WriteLine("");
    }
    private int ChooseRandomIndex(){
        Random rand = new Random();
        int index = rand.Next(_contents.Count());
        return index;
    }
    public bool HideWord(){
        bool hidden = true;
        int counter = 0;
        while (hidden == true){
            Word word = new Word();
            int index = ChooseRandomIndex();
            word = _contents[index];
            counter = counter + 1;
            if (word.GetIfCleared() == false){
                word.Clear();
                return true;
            }
            if (counter > _contents.Count() * 3){
                return false;
            }
            }
        return false;
    }
    public bool GetIfCleared(){
        if (_hidden == true){
            return true;
        }
        else{
            foreach(Word word in _contents){
                if (word.GetIfCleared() == false){
                    return false;
                }
            }
            _hidden = true;
            return true;

        }
    }
    
    
    }
