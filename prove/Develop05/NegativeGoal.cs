class NegativeGoal : Goal
{
    private int _numCompleted;
    public NegativeGoal(string name, string desc,int points):base(name,desc,points)
    {
        _numCompleted = 0;
    }
    public NegativeGoal():base(){}
    public NegativeGoal(string loadString)
    {
        string[] parts = loadString.Split("|");
        SetName(parts[0]);
        SetDesc(parts[1]);
        SetPoints(int.Parse(parts[2]));
        SetComp(false);
        _numCompleted = int.Parse(parts[3]);
    }
    public NegativeGoal(string name, string desc,int points, int comp):base(name,desc,points)
    {
        _numCompleted = comp;
    }
    public override void Display()
    {
        string name = GetName();
        string desc = GetDesc();
        System.Console.WriteLine($"[ ] {name} ({desc})");
    }
    public override void RecordEvent()
    {
        _numCompleted ++;
    }
    public override void SetStrRep()
    {
        string name = GetName();
        string desc = GetDesc();
        int points = GetPoints();
        string strRep = $"NegativeGoal=={name}|{desc}|{points}|{_numCompleted}";
        _strRep = strRep;
    }
    public override int ReportTotal()
    {
        return -_numCompleted * GetPoints();
    }
}
