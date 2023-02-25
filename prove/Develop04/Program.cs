using System;

class Program
{
    static void Main(string[] args)
    
    {
        int count =0;
        while (count != 1)
        {
        Console.Clear();

        Console.WriteLine("MENU");
        Console.WriteLine(" 1. Breathe activity");
        Console.WriteLine(" 2. Reflect activity");
        Console.WriteLine(" 3. Listen activity");
        Console.WriteLine(" 4.  Number Guess activity");
        Console.WriteLine(" 5. Quit");
        Console.Write("Make a selection from the menu: ");

        int userInput = Convert.ToInt32(Console.ReadLine());
        
        if (userInput == 1)
        {
            Console.Clear();
            Breathe breathing = new Breathe();
            Breathe.DisplayMessage();
            Breathe.Duration();
            Breathe.Breathe();
            Breathe.EndMessage();
        }

        else if (userInput == 2)
        {
            Console.Clear();
            Reflect reflection = new Reflect();
            Reflect.DisplayMessage();
            Reflect.Duration();
            Reflect.Reflect();
            Reflect.EndMessage();

        } 

        else if (userInput == 3)
        {
            Console.Clear();
            Listenlistening = new Listen();
            Listen.DisplayMessage();
            Listen.Duration();
            Listen.Listen();
            Listen.EndMessage();
        } 
        else if(userInput == 4)
        {
            Console.Clear();
             randomGame randomGame= new randomGame();
            randomGame.DisplayMessage();
            randomGame.Duration();
            randomGame.Guess();
            randomGame.EndMessage();

        }
        
        
        
        
        
        
        else if (userInput == 5)
        {

            Console.WriteLine("The End..");
            count =1;
        } 

    }
}
}
