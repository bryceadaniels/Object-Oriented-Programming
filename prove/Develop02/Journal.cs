using System.IO;

public class Journal{
    public Journal(){}
    public string _userName = "";
    public List<Entry> _entries = new List<Entry>();
    public string _fileName = "";
    public string GetUserName(){
        System.Console.WriteLine("Hello! Welcome to your journal! What is your name? ");
        _userName = Console.ReadLine();
        return _userName;
    }
    public void Display(){
        System.Console.WriteLine($"{_userName}'s Journal");
        foreach(Entry entry in _entries){
            entry.Display();
        }
    }
    public void LoadFile(){
        Console.WriteLine("What file would you like to load? ");
        string _fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        foreach (string line in lines){
            
        }
        
    }
    public void SaveFile(){
    System.Console.WriteLine("What would you like to save the file as? ");
    string _fileName = Console.ReadLine();
    using (StreamWriter outputFile = new StreamWriter(_fileName)){
        foreach (Entry entry in _entries){
            outputFile.WriteLine(entry);
        }
    }   

    }
    public void AddEntry(){
        Entry entry = new Entry();
        entry.GetResponse();
        _entries.Add(entry);
    }
}