using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);

        List<string> verses = new List<string>
        {
            "verse",
            "verse",
            "verse"
        };
    }
}