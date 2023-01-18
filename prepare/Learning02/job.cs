using System;
public class Job
{
  public string jTitle;
    public string co;
    public int yStarted;
    public int yEnded;
    public void Display(){
Console.WriteLine($"{jTitle} ({co}) {yStarted} {yEnded}");
}
}