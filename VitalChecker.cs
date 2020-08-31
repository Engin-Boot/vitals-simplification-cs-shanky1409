internal class VitalChecker
{
    static internal bool CheckVitalStatus(float bpm, float spo2, float respRate)
    {
        RangeChecker bpmChecker = new RangeChecker(70, 150);
        RangeChecker spo2Checker = new RangeChecker(90, float.MaxValue);
        RangeChecker respRateChecker = new RangeChecker(30, 95);

        return (bpmChecker.CheckVitalRange(bpm) && spo2Checker.CheckVitalRange(spo2) && respRateChecker.CheckVitalRange(respRate));
    }
}
