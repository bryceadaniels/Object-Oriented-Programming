public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _numberToComplete;
    private int _numberCompleted;
    public ChecklistGoal(string name,string desc,int points, int bonus,int numToComp, int numDone=0): base(name,desc,points)
    {
        _bonusPoints = bonus;
        _numberCompleted = numDone;
        _numberToComplete = numToComp;
    }
    public ChecklistGoal():base(){}
    public ChecklistGoal(string loadString):base()
    {
        string[] parts = loadString.Split("|");
        SetName(parts[0]);
        SetDesc(parts[1]);
        SetPoints(int.Parse(parts[2]));
        _bonusPoints = int.Parse(parts[3]);
        _numberToComplete = int.Parse(parts[4]);
        _numberCompleted = int.Parse(parts[5]);
        if (_numberCompleted == _numberToComplete)
        {
            SetComp(true);
        }
        else
        {
            SetComp(false);
        }
    }
    public override void Display()
    {
        string name = GetName();
        string desc = GetDesc();
        if (IsComplete()==true)
        {
            System.Console.WriteLine($"[X] {name} ({desc}) {_numberCompleted}/{_numberToComplete}");
        }
        else
        {
            System.Console.WriteLine($"[ ] {name} ({desc}) Completed: {_numberCompleted}/{_numberToComplete}");
        }
    }
    public override void RecordEvent()
    {
        _numberCompleted++;
        if (_numberCompleted==_numberToComplete)
        {
            SetComp(true);
        }
        else
        {
            SetComp(false);
        }
    }
    public override void SetStrRep()
    {
        string name = GetName();
        string desc = GetDesc();
        int points = GetPoints();
        string strRep = $"ChecklistGoal=={name}|{desc}|{points}|{_bonusPoints}|{_numberToComplete}|{_numberCompleted}";
        _strRep = strRep;        
    }
    public override int ReportTotal()
    {
        int total = GetPoints() * _numberCompleted;
        if (_numberCompleted==_numberToComplete)
        {
            total += _bonusPoints;
        }
        else{}
        return total; 
    }
}