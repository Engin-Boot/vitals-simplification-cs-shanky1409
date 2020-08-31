using System;
using System.Diagnostics;

class Checker
{
    static int Main()
    {
        ExpectationChecker.ExpectTrue(CheckVitalStatus(100, 95, 60));
        ExpectationChecker.ExpectFalse(CheckVitalStatus(40, 91, 92));
        ExpectationChecker.ExpectFalse(CheckVitalStatus(151, 92, 94));
        ExpectationChecker.ExpectFalse(CheckVitalStatus(72, 80, 92)); 
        ExpectationChecker.ExpectFalse(CheckVitalStatus(80, 92, 20)); 
        ExpectationChecker.ExpectFalse(CheckVitalStatus(80, 92, 100)); 
	    ExpectationChecker.ExpectTrue(CheckVitalStatus(70, 92, 95));  
	    ExpectationChecker.ExpectTrue(CheckVitalStatus(150, 90, 30));  
        Console.WriteLine("All ok");
        return 0;
    }
}