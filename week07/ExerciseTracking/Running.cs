public class Running : Activity
{
    private double distance; 

    public Running(DateTime date, int duration, double distance)
        : base(date, duration)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed() 
    {
        return (distance / (double)duration) * 60;
    }

    public override double GetPace()
    {
        return (duration / distance) * 60;
    }
    public override string GetSummary()
    {
        return $"{base.GetSummary().Replace("unit", "miles")}";
    }
}
