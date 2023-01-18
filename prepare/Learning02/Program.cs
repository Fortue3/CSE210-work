using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1.jTitle = "Supervisor";
        job1.co = "Zesa";
        job1.yStarted ="2001";
        job1.yEnded = "2010";

        Job job2 = new Job();
        job2.jTitle = "Branch Manager";
        job2.co = "Macro";
        job2.yStarted ="2013";
        job2.yEnded = "2020";

        Cv mycv = new Cv();
        myCv.name = "Fortunate Kwenda";
        myCv.jobs.Add(job1);
        myCv.jobs.Add(job2);
        myCv.Display();
    }
}