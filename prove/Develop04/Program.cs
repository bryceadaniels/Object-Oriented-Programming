using System;

class Program
{
    static void Main(string[] args)
    {
        int input=0;
        while(input != 5)
        {
            Console.Clear();
            System.Console.WriteLine("Please choose which activity you would like to do: ");
            System.Console.WriteLine("1) Breathing Activity");
            System.Console.WriteLine("2) Listing Activity");
            System.Console.WriteLine("3) Reflection Activity");
            System.Console.WriteLine("4) Body Scan Activity");
            System.Console.WriteLine("5) Quit");
            input = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (input)
            {
                case 1:
                    BreathingActivity breathAct = new BreathingActivity();
                    breathAct.RunActivity();
                    break;
                case 2:
                    ListingActivity listAct = new ListingActivity();
                    listAct.RunActivity();
                    break;
                case 3:
                    ReflectionActivity refAct = new ReflectionActivity();
                    refAct.RunActivity();
                    break;
                case 4:
                    BodyScanActivity bodAct = new BodyScanActivity();
                    bodAct.RunActivity();
                    break;
                case 5:
                    System.Console.WriteLine("Have a good day!");
                    break;
            }
        }
        
    }
}