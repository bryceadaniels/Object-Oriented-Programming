using System;

class Program
{
    static void Main(string[] args)
    {
    Console.Write("What is your grade percentage? ");
    string grade = Console.ReadLine();
    int gradeNumber = int.Parse(grade);
    string gradeLetter = "";
    if (gradeNumber >= 90)
     {
        gradeLetter = "A";
     }
    else if (gradeNumber < 90 && gradeNumber >=80)
     {
        gradeLetter = "B";
     }
    else if (gradeNumber < 80 && gradeNumber >=70)
    {
        gradeLetter = "C";
    }
    else if (gradeNumber < 70 && gradeNumber >=60)
    {
       gradeLetter = "D";
    }
    else if (gradeNumber <60)
    {
        gradeLetter = "F";
    }
    string sign = "";
    int endingDigit = gradeNumber % 10;
    if (endingDigit >= 7 && gradeLetter != "A" && gradeLetter != "F")
    {
        sign = "+";
    }
    else if (endingDigit <3 && gradeLetter != "F")
    {
        sign = "-";
    }


    Console.WriteLine($"Your grade is {gradeLetter}{sign}");

    if (gradeNumber >= 70)
    {
        Console.WriteLine("Congrats! Your passed!");
    }
    else
    {
        Console.WriteLine("Try again!");
    }
    }
}