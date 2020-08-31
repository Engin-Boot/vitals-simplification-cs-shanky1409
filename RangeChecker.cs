internal class RangeChecker
{
    private float lowerLimit;
    private float upperLimit;
    internal RangeChecker(float lowerLimit , float upperLimit)
    {
        this.lowerLimit = lowerLimit;
        this.upperLimit = upperLimit;
    }
    internal bool CheckVitalRange(float value)
    {
        if(value < this.lowerLimit || value > this.upperLimit)
            return false;
        return true;
    }
}