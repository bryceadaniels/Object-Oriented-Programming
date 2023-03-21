abstract class  Activity
{
    private string _date;
    private int _length;
    private string _type;
    public Activity(string date, int length, string type)
    {
        _date = date;
        _length = length;
        _type = type;
    }
    public string GetSummary()
    {
        return $"{_date} {_type} ({_length})- Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace {GetPace()} min per km";
    }
    public int GetLength()
    {
        return _length;
    }
    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();

}