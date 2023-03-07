public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string desc, int points): base(name,desc,points){}
    public SimpleGoal():base(){}
    public SimpleGoal(string loadString)
    {
        string[] parts = loadString.Split("|");
        SetName(parts[0]);
        SetDesc(parts[1]);
        SetPoints(int.Parse(parts[2]));
        if (int.Parse(parts[3])==1)
        {
            SetComp(true);
        }
        else if (int.Parse(parts[3])==0)
        {
            SetComp(false);
        }
    }
    public override void RecordEvent()
    {
        SetComp(true);
    }
    public override void Display()
    {
        string name = GetName();
        string desc = GetDesc();

        if (IsComplete()==true)
        {
            System.Console.WriteLine($"[X] {name} ({desc})");
        }
        else if (IsComplete()==false)
        {
            System.Console.WriteLine($"[ ] {name} ({desc})");
        }
    }
    public override void SetStrRep()
    {
        string name = GetName();
        string desc = GetDesc();
        int points = GetPoints();
        int comp;
        if (IsComplete()==true)
        {
            comp = 1;
        }
        else
        {
            comp = 0;
        }
        string strRep = $"{name}|{desc}|{points}|{comp}";
        _strRep= strRep;
    }
    public override int ReportTotal()
    {
        return GetPoints();
    }
}