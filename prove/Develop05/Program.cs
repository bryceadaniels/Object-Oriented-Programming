using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
    }
    public int CalcTotalPoints(List<Goal> goals)
    {
        int totalPoints = 0;
        foreach(Goal goal in goals)
        {
            totalPoints+=goal.ReportTotal();
        }
        return totalPoints;
    }
    public void SaveToFile(string filename, List<Goal> goals)
    {
        using (StreamWriter file = new StreamWriter(filename))
        {
            foreach (Goal goal in goals)
            {
                goal.SetStrRep();
                System.Console.WriteLine(goal.GetStrRep());
            }
        }
    }
}