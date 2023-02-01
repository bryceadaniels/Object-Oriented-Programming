using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();
        Fraction frac2 = new Fraction(6);
        Fraction frac3 = new Fraction(6,7);

        System.Console.WriteLine(frac1.GetFractionString());
        System.Console.WriteLine(frac1.GetDecimalValue());
        System.Console.WriteLine(frac2.GetFractionString());
        System.Console.WriteLine(frac2.GetDecimalValue());
        System.Console.WriteLine(frac3.GetFractionString());
        System.Console.WriteLine(frac3.GetDecimalValue());
    }
}