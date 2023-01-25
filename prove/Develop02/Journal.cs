using System.IO;

public class Journal
{
    public Journal(){}
    public List<Entry> _entries = new List<Entry>();
    public string _fileName = "";
    public void Display()
    {
        foreach(Entry entry in _entries){
            entry.Display();
        }
    }
    public void LoadFile()
    {
        try 
        {
            Console.WriteLine("What file would you like to load? ");
            string _fileName = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(_fileName);
            foreach (string line in lines)
            {
                Entry entry = new Entry();
                string[] parts = line.Split("|");
                entry._date = parts[0];
                entry._location = parts[1];
                entry._prompt = parts[2];
                entry._response = parts[3];
                _entries.Add(entry);
            }
        }
        catch(FileNotFoundException)
        {
            System.Console.WriteLine("File is not found. Try again");
        }
        }
        
    
    public void SaveFile()
    {
    System.Console.WriteLine("What would you like to save the file as? ");
    string _fileName = Console.ReadLine();
    using (StreamWriter outputFile = new StreamWriter(_fileName)){
        foreach (Entry entry in _entries)
        {
            outputFile.WriteLine($"{entry._date}|{entry._location}|{entry._prompt}|{entry._response}");
        }
    }   

    }
    public void AddEntry()
    {
        Entry entry = new Entry();
        entry.GetResponse();
        _entries.Add(entry);
    }
}