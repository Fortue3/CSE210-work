using System;

public class Breathe : Activity
{
    DateTime currentTime = new DateTime();
    Activity activity = new Activity();


    public Breathe()
    {
            _message = "Take a deep breathe";
            _description = "Focus on brething in and out and relax your mind.";
    }

    public void Breathing()
    {
        Console.Clear();
       
        Console.WriteLine("Be ready to start...");


        activity.Animation();
        Console.WriteLine("");
        
        DateTime futureTime = DateTime.Now.AddSeconds(num);
        while (DateTime.Now < futureTime)

            {   Console.Write("Breathe in...");
                for (int i = 3; i > 0; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                    
                    
                }
                Console.WriteLine(" ");
                Console.Write("Breathe Out...");
                for (int i = 5; i > 0; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                    
                    
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");
               
               
                
            }
            


    }
}