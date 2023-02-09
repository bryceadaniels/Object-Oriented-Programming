using System;

class Program
{
    static void Main(string[] args)
    {
        string diffVerse = "yes";
        while(diffVerse == "yes")
        {
            List<string> verses = new List<string>();
            System.Console.Write("Please enter the scripture reference: ");
            string reference = Console.ReadLine();
            string verse = "";

            while(verse.ToLower() != "quit")
            {
                System.Console.WriteLine("Please enter one verse of the scripture (if done type quit): ");
                verse = Console.ReadLine();
                if(verse.ToLower() != "quit")
                {
                    verses.Add(verse);
                }
            }

            string repeat = "yes";
            while (repeat == "yes")
            {
                Scripture scripture = new Scripture(reference, verses);
                Console.Clear();
                scripture.Display();
                System.Console.WriteLine("Press ENTER to continue or type QUIT to end. ");
                string input = Console.ReadLine();
                while (scripture.IsAllHidden()==false)
                {
                    Random rand = new Random();
                    int number = rand.Next(1,4);
                    if (scripture.HideWords(number) == true)
                    {
                    scripture.HideWords(number);
                    }
                    Console.Clear();
                    scripture.Display();
                    System.Console.WriteLine("Press ENTER to continue or type QUIT to end. ");
                    input = Console.ReadLine();
                    if(input == "quit")
                    {
                        break;
                    }
                }
                Console.Clear();
                scripture.Display();
                System.Console.Write("All done, would you like to repeat the verse? (Yes/No) ");
                repeat = Console.ReadLine().ToLower();
            }
            System.Console.Write("Would you like to input a new verse? (Yes/No) ");
            diffVerse = Console.ReadLine().ToLower();
        }   

    }
}