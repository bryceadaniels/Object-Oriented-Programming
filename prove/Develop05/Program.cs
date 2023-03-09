using System;

class Program
{
    static void Main(string[] args)
    {
        Admin admin = new Admin();
        List<Goal> goalList = new List<Goal>();
        int choice=0;
        while (choice != 6)
        {
            System.Console.WriteLine($"You have {admin.CalcTotalPoints(goalList)} points. ");
            System.Console.WriteLine();
            System.Console.WriteLine("Menu Options:");
            System.Console.WriteLine("  1. Create New Goal");
            System.Console.WriteLine("  2. List Goals");
            System.Console.WriteLine("  3. Save Goals");
            System.Console.WriteLine("  4. Load Goals");
            System.Console.WriteLine("  5. Record Event");
            System.Console.WriteLine("  6. Quit");
            System.Console.Write("Select a choice from the menu: ");
            choice = int.Parse(System.Console.ReadLine());
            Console.Clear();
            switch (choice)
            {
                case 1:
                    System.Console.WriteLine("The types of goals are: ");
                    System.Console.WriteLine("1. Simple");
                    System.Console.WriteLine("2. Eternal");
                    System.Console.WriteLine("3. Checklist");
                    System.Console.WriteLine("4. Negative");
                    System.Console.Write("What type of goal would you like to create? ");
                    int goalType = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (goalType)
                    {
                        case 1:
                            System.Console.Write("What is the name of your goal? ");
                            string simpName = Console.ReadLine();
                            System.Console.Write("What is a short description of it? ");
                            string simpDesc = Console.ReadLine();
                            System.Console.Write("How many points do you associate with this goal? ");
                            int simpPoints = int.Parse(Console.ReadLine());
                            SimpleGoal simpleGoal = new SimpleGoal(simpName,simpDesc,simpPoints);
                            goalList.Add(simpleGoal);
                            Console.Clear();
                            break;
                        case 2:
                            System.Console.Write("What is the name of your goal? ");
                            string eterName = Console.ReadLine();
                            System.Console.Write("What is a short description of it? ");
                            string eterDesc = Console.ReadLine();
                            System.Console.Write("How many points do you associate with this goal? ");
                            int eterPoints = int.Parse(Console.ReadLine());
                            EternalGoal eternalGoal = new EternalGoal(eterName,eterDesc,eterPoints);
                            goalList.Add(eternalGoal);
                            Console.Clear();
                            break;
                        case 3:
                            System.Console.Write("What is the name of your goal? ");
                            string chName = Console.ReadLine();
                            System.Console.Write("What is a short description of it? ");
                            string chDesc = Console.ReadLine();
                            System.Console.Write("How many points do you associate with this goal? ");
                            int chPoints = int.Parse(Console.ReadLine());
                            System.Console.Write("How many times must you perform this goal to complete it? ");
                            int chNumTotal = int.Parse(Console.ReadLine());
                            System.Console.Write("How many points will you be awarded upon completion of the goal? ");
                            int chBonus = int.Parse(Console.ReadLine());
                            ChecklistGoal checklistGoal = new ChecklistGoal(chName,chDesc,chPoints,chBonus,chNumTotal);
                            goalList.Add(checklistGoal);
                            Console.Clear();
                            break;
                        case 4:
                            System.Console.Write("What is the name of your goal? ");
                            string negName = Console.ReadLine();
                            System.Console.Write("What is a short description of it? ");
                            string negDesc = Console.ReadLine();
                            System.Console.Write("How many points do you associate with this goal? ");
                            int negPoints = int.Parse(Console.ReadLine());
                            NegativeGoal negGoal = new NegativeGoal(negName,negDesc,negPoints);
                            goalList.Add(negGoal);
                            Console.Clear();
                            break;
                    }
                    break;

                case 2:
                    System.Console.WriteLine("The goals are: ");
                    admin.ListGoals(goalList);

                    System.Console.WriteLine("\n \n");
                    break;
                
                case 3:
                    System.Console.Write("What file would you like to save this as? ");
                    string filename = Console.ReadLine();
                    admin.SaveToFile(filename,goalList);
                    Console.Clear();
                    break;
                
                case 4:
                    System.Console.Write("What file would you like to load? ");
                    string fileName = Console.ReadLine();
                    admin.LoadFile(fileName,goalList);
                    Console.Clear();
                    break;
                
                case 5:
                    System.Console.WriteLine("The goals are: ");
                    int i = 1;
                    List<Goal> uncompleted = new List<Goal>();
                    foreach(Goal goal in goalList)
                    {
                        if (goal.IsComplete()==false)
                        {
                            uncompleted.Add(goal);
                            System.Console.WriteLine($" {i}. {goal.GetName()} ({goal.GetDesc()})");
                            i++;
                        }
                    }
                    int recChoice;
                    System.Console.Write("Which goal did you accomplish? ");
                    recChoice = int.Parse(Console.ReadLine())-1;
                    uncompleted[recChoice].RecordEvent();
                    System.Console.WriteLine($"Congrats, you earned {uncompleted[recChoice].GetPoints()} points. ");
                    System.Console.WriteLine("\n \n");
                    break;

                case 6:
                    System.Console.WriteLine("Have a good day!");
                    break;
            }
        } 
    }
       
}