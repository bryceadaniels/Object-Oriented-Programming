public class Admin
{
    public Admin(){}
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
            file.WriteLine(CalcTotalPoints(goals));
            foreach (Goal goal in goals)
            {
                goal.SetStrRep();
                file.WriteLine(goal.GetStrRep());
            }
        }
    }
    public void LoadFile(string filename)
    {
        string[] goals = System.IO.File.ReadAllLines(filename);
        for (int i = 0; i< goals.Length; i++)
        {
            if(goals[i].Split("==")[0]=="SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(goals[i].Split("==")[1]);
            }
            else if(goals[i].Split("==")[0]=="EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(goals[i].Split("==")[1]);
            }
            else if(goals[i].Split("==")[0]=="ChecklistGoal")
            {
                ChecklistGoal checklistGoal = new ChecklistGoal(goals[i].Split("==")[1]);
            }
            else
            {
                System.Console.WriteLine("There is an error somewhere.");
            }
        }
    }
    public void ListGoals(List<Goal> goals)
    {
        foreach(Goal goal in goals)
        {
            goal.Display();
        }
    }
}