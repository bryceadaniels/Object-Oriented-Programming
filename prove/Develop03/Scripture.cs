public class Scripture{
    private string _reference;
    private List<Verse> _content;
    private bool _hidden;
    public Scripture(){}
    public Scripture(string reference, List<string> content){
        _reference = reference;
        foreach(string part in content){
            Verse verse = new Verse(part);
            _content.Add(verse);
        }
    }
    public void Display(){
        foreach(Verse verse in _content){
            verse.Display();
        }
    }
    public bool IsAllHidden(){
        foreach(Verse verse in _content){
            if (verse.GetIfCleared() == false){
                return false;
            }
        }
        return true;
    }
    public void HideWords(int number){
        int counter = 0;
        while (counter < number){
            Random rand = new Random();
            int index = rand.Next(_content.Count());
            Verse verse = new Verse();
            verse = _content[index];
            if(verse.HideWord()==true){
                counter = counter +1;
            }
        }
    }
}