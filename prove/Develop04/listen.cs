using System;

public class Listen : Activity
{
Activity activity = new Activity();
 public Listen()
    {
            _message = "Give yourself time to Listen";
            _description = "Make a reflectiom of the good things in your life.";
    }

    public void Listening()
    {
        Console.Clear();
        Console.WriteLine("Be ready to start");
        activity.Animation();
        Console.WriteLine("");
        Console.WriteLine("Reflect on many ideas that comes to your mind: ");
        Console.WriteLine("");
        Console.WriteLine("Have felt the promptings of the spirit?");
        Console.WriteLine("");
        
        Console.Write("Start: ");
        int count = 0;
            for (int i = 5; i > 0 ; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
             DateTime futureTime = DateTime.Now.AddSeconds(num);
             Console.WriteLine("");
            while (DateTime.Now < futureTime)
            {
                
                Console.Write("> ");
                Console.ReadLine();
                count += 1;
            }
            Console.WriteLine($"You listed {count} items");
    }
}