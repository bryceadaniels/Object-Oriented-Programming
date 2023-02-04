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
    
    
}