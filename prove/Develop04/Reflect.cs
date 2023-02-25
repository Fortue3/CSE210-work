using System;

public class Reflect : Activity
{
    Activity activity = new Activity();
    Random random = new Random();
    public Reflect()
    {
            _message = "Make a reflection";
            _description = "Think and reflect on the times you had strength and remember what helped you then.";
    }
    public void Reflect()
    {
        Console.Clear();
        Console.WriteLine("Prepare to start");
        activity.Animation();
        Console.WriteLine("");
        Console.WriteLine("Consider this:");
        Console.WriteLine("");
        Console.WriteLine("Think of a time you had a challenge and how you managed it");
        Console.WriteLine("");
        Console.WriteLine("When you have thought of something press enter for contiuation.");
        
        var userInput = Console.ReadKey();
        if (userInput.Key == ConsoleKey.Enter)
        {
            Console.WriteLine("Now ponder on each of the following questions");
            Console.Write("Start: ");

            for (int i = 5; i > 0 ; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }


             DateTime futureTime = DateTime.Now.AddSeconds(num);
            while (DateTime.Now < futureTime)
            {
            string[] words = {"Did you feel any change?", "Share your experiencs so that someone may also do as you did "};
            int index = random.Next(words.Length);
            Console.WriteLine(" ");

            Console.Write(words[index]);
            activity.Animation();
            Console.WriteLine(" ");

        }
        }

    }
}
