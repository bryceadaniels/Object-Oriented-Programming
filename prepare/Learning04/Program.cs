using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Bryce Daniels","Coding with Classes");
        System.Console.WriteLine(assignment1.GetSummary());
        
        MathAssignment assignmentMath = new MathAssignment("TK","Statistics", "12", "1-29");
        System.Console.WriteLine(assignmentMath.GetSummary());
        System.Console.WriteLine(assignmentMath.GetHomeworkList());

        WritingAssignment assignmentWriting = new WritingAssignment("Kallie", "Child Dev", "Be Good Parents");
        System.Console.WriteLine(assignmentWriting.GetSummary());
        System.Console.WriteLine(assignmentWriting.GetWritingInfo());
    }
}