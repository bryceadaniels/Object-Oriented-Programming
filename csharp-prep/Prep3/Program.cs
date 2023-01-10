using System;

class Program
{
    static void Main(string[] args)
    {
        string play = "yes";
        while (play.ToLower() == "yes")
        {
            Console.Write("What is the magic number? ");
            string magicNumberString = Console.ReadLine();
            int magicNumber = int.Parse(magicNumberString);
            int guessNumber = 0;
            if (magicNumber >= 0)
            {
                guessNumber = -1;
            }
            else
            {
                guessNumber = 1;
            }
            int numOfGuesses = 0;
            while (guessNumber != magicNumber)
            {
                Console.Write("What is your guess? ");
                string guessString = Console.ReadLine();
                guessNumber = int.Parse(guessString);
                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessNumber == magicNumber)
                {
                    Console.WriteLine("Correct!");
                }
                numOfGuesses += 1;
            }
            
            Console.WriteLine($"Good job with the game. It took you {numOfGuesses} tries");
            Console.Write("Would you like to play again? ");
            play = Console.ReadLine();
        }
        Console.WriteLine("Thanks for playing!");
    }   
}