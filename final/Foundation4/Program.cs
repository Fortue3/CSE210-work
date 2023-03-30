using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // create some activities
        RunningActivity running = new RunningActivity(new DateTime(2023, 03, 13), 30, 3.0);
        CyclingActivity cycling = new CyclingActivity(new DateTime(2023, 03, 13), 45, 15.0);
        SwimmingActivity swimming = new SwimmingActivity(new DateTime(2023, 03, 14), 60, 30);

        // put them in a list
        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        // iterate through the list and display the summary for each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

class Activity
{
    private DateTime date;
    protected int length;

    public Activity(DateTime date, int length)
    {
        this.date = date;
        this.length = length;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual TimeSpan GetPace()
    {
        return new TimeSpan(0, 0, 0);
    }

    public virtual string GetSummary()
    {
        string summary = $"{date.ToString("dd MMM yyyy")} {GetType().Name} ({length} min): ";
        summary += $"Distance {GetDistance()} km, Speed {GetSpeed()} kph, ";
        summary += $"Pace: {GetPace().Minutes} min {GetPace().Seconds} sec per km";
        return summary;
    }
}

class RunningActivity : Activity
{
    private double distance;

    public RunningActivity(DateTime date, int length, double distance) : base(date, length)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        double hours = (double)length / 60;
        return distance / hours;
    }

    public override TimeSpan GetPace()
    {
        double paceInSeconds = length * 60 / distance;
        return TimeSpan.FromSeconds(paceInSeconds);
    }
}

class CyclingActivity : Activity
{
    private double speed;

    public CyclingActivity(DateTime date, int length, double speed) : base(date, length)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetDistance()
    {
        double hours = (double)length / 60;
        return speed * hours;
    }

    public override TimeSpan GetPace()
    {
        double paceInSeconds = 60 / speed;
        return TimeSpan.FromSeconds(paceInSeconds);
    }
}

class SwimmingActivity : Activity
{
    private int laps;

    public SwimmingActivity(DateTime date, int length, int laps) : base(date, length)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000.0; // convert meters to kilometers
    }

    public override double GetSpeed()
    {
        double hours = (double)length / 60;
        return GetDistance() / hours;
    }

    public override TimeSpan GetPace()
    {
        double paceInSeconds = length * 60 / (laps * 50 / 1000.0);
        return TimeSpan.FromSeconds(paceInSeconds);
    }
}
