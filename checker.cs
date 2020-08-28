using System;
using System.Diagnostics;

class Checker
{
    static bool vitalsAreOk(float bpm, float spo2, float respRate)
    {
        return (RangeChecker.CheckBpm(bpm) && RangeChecker.CheckSpo2(spo2) && RangeChecker.CheckRespRate(respRate));
    }
    static void ExpectTrue(bool expression)
    {
        if (!expression)
        {
            Console.WriteLine("Expected true, but got false");
            Environment.Exit(1);
        }
    }
    static void ExpectFalse(bool expression)
    {
        if (expression)
        {
            Console.WriteLine("Expected false, but got true");
            Environment.Exit(1);
        }
    }
    static int Main()
    {
        ExpectTrue(vitalsAreOk(100, 95, 60));
        ExpectFalse(vitalsAreOk(40, 91, 92));
        Console.WriteLine("All ok");
        return 0;
    }
}