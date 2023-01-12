using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcomeMsg();

        string name = PromptName();
        int num = PromptNum();
        int squaredNum = squareNum(num);
        DisplayResult(name,num);
    }
    static void DisplayWelcomeMsg()
    {
        Console.WriteLine("Welcome to my program");
    }
    static string PromptName()
    {
        Console.Write("Please enter your name: ");

        string name = Console.ReadLine();
        return name;
        }
    
        static int PromptNum()
        {
            Console.WriteLine("Enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    } 
    static int squareNum(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, The square of your number is:{square}");
    }
    
    
}