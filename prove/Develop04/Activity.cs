using System;

public class Activity
{
    protected string _message= "";
    protected string _description = " ";
    public int num ;

    string[] spinner = {"|","/","-",@"\"};

    public Activity()
    {

    }

    public void DisplayMessage()
    {
        Console.WriteLine($"Welcome to the {_message} activity.");
        Console.WriteLine(" ");
        Console.WriteLine($"This activity will help you {_description}");

       
    }

    public void Duration()
    {
        Console.WriteLine(" ");
        Console.Write("How long in seconds would you like your session? ");
        int userNum = Convert.ToInt32(Console.ReadLine());
        num = userNum;
    
    }

    public void Animation()
    {      
        int count = 3;

        while (count !=0) 
        { 
            count-=1;
            foreach (var item in spinner)
            {
                Console.Write(item);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
            


           
        } 
    }

    public void EndMessage()
    {
        Console.WriteLine("Well Done");
        Animation();
        Console.WriteLine($"You completed this activity in {num} seconds");
        Animation();
    }
        

    }
