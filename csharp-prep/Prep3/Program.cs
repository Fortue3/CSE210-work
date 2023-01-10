using System;

class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        // We could also use a do-while loop here...
        while (guess != magicNumber){
        Console.WriteLine("Enter your geuss number");
        guess = int.Parse(Console.ReadLine());

        if(guess<magicNumber)
        {
            Console.WriteLine("Higher");

        }
        else if(guess>magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed right");
        }

    }
    }
}