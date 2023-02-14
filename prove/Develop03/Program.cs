using System;

class Program
{
    static void Main(string[] args)
    {
        //
        Scriptures my_scriptures = new Scriptures();
        Memorize my_memory = new Memorize();


        Console.WriteLine(my_scriptures.SetScripture());
        string answer = my_scriptures.GetScripture();

        Console.WriteLine("Press Enter to continue or write quit to exit!");
        
            my_memory.SetWord(answer);
            my_memory.GetWord();


    }
}