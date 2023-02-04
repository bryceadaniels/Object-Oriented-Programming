class Verse{
    private List<Word> _contents;
    public Verse(){}
    public Verse(string contents){
        foreach(string part in contents.Split(' ')){
            Word word new Word(part);
            _contents.Add(word);
        }
    }
}