using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        journal.GetUserName();
        int choice = 0;
        while (choice != 5){
            System.Console.WriteLine();
            System.Console.WriteLine("1. Write");
            System.Console.WriteLine("2. Display");
            System.Console.WriteLine("3. Load");
            System.Console.WriteLine("4. Save");
            System.Console.WriteLine("5. Quit");
            System.Console.WriteLine("What would you like to do? ");
            string input = Console.ReadLine();
            choice = int.Parse(input);

            if (choice == 1){
                journal.AddEntry();
            }
            else if (choice == 2){
                journal.Display();
            }
            else if (choice == 3){
                journal.LoadFile();
            }
            else if (choice == 4){
                journal.SaveFile();
            }
            else if (choice == 5){
                System.Console.WriteLine("See you tomorrow!");
            }
            else {
                System.Console.WriteLine("Please enter 1-5 ");
            }

        }
    }
}