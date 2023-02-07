class Verse{
    private List<Word> _contents;
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
        }
    }
    private int ChooseRandomIndex(){
        Random rand = new Random();
        int index = rand.Next(_contents.Count());
        return index;
    }
    public bool HideWord(){
        bool hidden = true;
        while (hidden == true){
        Word word = new Word();
        int index = ChooseRandomIndex();
        word = _contents[index];
        if (word.GetIfCleared() == false){
            word.Clear();
            return true;
        }
        }
        return true;
    }
    }
