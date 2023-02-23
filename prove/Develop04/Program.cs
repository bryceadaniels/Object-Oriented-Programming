using System;

class Program
{
    static void Main(string[] args)
    {
        ReflectionActivity refAct = new ReflectionActivity();
        BreathingActivity breAct = new BreathingActivity();
        breAct.RunActivity();
        refAct.RunActivity();

        
    }
}