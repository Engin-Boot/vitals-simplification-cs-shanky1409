using System;
using System.Diagnostics;

class Checker
{
    static bool CheckVitalStatus(float bpm, float spo2, float respRate)
    {
        return (RangeChecker.CheckBpm(bpm) && RangeChecker.CheckSpo2(spo2) && RangeChecker.CheckRespRate(respRate));
    }
    
    static int Main()
    {
        ExpectationChecker.ExpectTrue(CheckVitalStatus(100, 95, 60));
        ExpectationChecker.ExpectFalse(CheckVitalStatus(40, 91, 92));
        Console.WriteLine("All ok");
        return 0;
    }
}