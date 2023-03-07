public abstract class Goal
{
    private string _name;
    private string _description;
    private int _numberOfPoints;
    private bool _completed;
    protected string _strRep;
    public Goal(){}
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _numberOfPoints = points;
        _completed = false;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public void SetDesc(string desc)
    {
        _description = desc;
    }
    public void SetPoints(int points)
    {
        _numberOfPoints=points;
    }
    public void SetComp(bool comp)
    {
        _completed = comp;
    }
    public int GetPoints()
    {
        return _numberOfPoints;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDesc()
    {
        return _description;
    }
    public string GetStrRep()
    {
        return _strRep;
    }
    public bool IsComplete()
    {
        return _completed;
    }
    public abstract void Display();
    //public abstract void GetGoal();
    public abstract void RecordEvent();
    public abstract void SetStrRep();
    public abstract int ReportTotal();
}