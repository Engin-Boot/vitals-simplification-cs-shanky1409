using System;
using System.Diagnostics;

class Checker
{
    static int Main()
    {
        ExpectationChecker.ExpectTrue(VitalChecker.CheckVitalStatus(100, 95, 60));
        ExpectationChecker.ExpectFalse(VitalChecker.CheckVitalStatus(40, 91, 92));
        ExpectationChecker.ExpectFalse(VitalChecker.CheckVitalStatus(151, 92, 94));
        ExpectationChecker.ExpectFalse(VitalChecker.CheckVitalStatus(72, 80, 92)); 
        ExpectationChecker.ExpectFalse(VitalChecker.CheckVitalStatus(80, 92, 20)); 
        ExpectationChecker.ExpectFalse(VitalChecker.CheckVitalStatus(80, 92, 100)); 
	    ExpectationChecker.ExpectTrue(VitalChecker.CheckVitalStatus(70, 92, 95));  
	    ExpectationChecker.ExpectTrue(VitalChecker.CheckVitalStatus(150, 90, 30));  
        Console.WriteLine("All ok");
        return 0;
    }
}