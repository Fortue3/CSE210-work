using System;
public class Cv
{
    public string name;
   
    public void Display(){
Console.WriteLine($"Name:{name}");
   Console.WriteLine("Jobs");
   foreach(Job job in jobs)
   {
   job.Display();
   }
}
}