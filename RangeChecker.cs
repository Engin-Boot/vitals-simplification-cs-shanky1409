internal class RangeChecker
{
    static internal bool CheckBpm(float bpm)
    {
        return (bpm < 70 ? false : bpm > 150 ? false : true);
    }
    static internal bool CheckSpo2(float spo2)
    {
        return (spo2 < 90 ? false : true);
    }
    static internal bool CheckRespRate(float respRate)
    {
        return (respRate < 30 ? false : respRate > 95 ? false : true);
    }
}