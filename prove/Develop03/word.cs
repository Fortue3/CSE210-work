using System;

public class ReplaceWord
{
    private string Scripture_quote;

    public void Quote1(string words)
    {
        Scripture_quote = words;
        int count = 1;
        while (count != 0)
        {
            Random randomGenerator = new Random();
            string[] my_word = {"John 10:30:", "I", "and", "my", "father", "are", "one"};
            int index = randomGenerator.Next(my_word.Length);
            var Userinput = Console.ReadKey();

            if (Userinput.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Scripture_quote = Scripture_quote.Replace(my_word[index], "_");
                Console.WriteLine(Scripture_quote);
                 if (Scripture_quote =="_ _ _ _ _ _ _")
                    {
                        count = 0;
                        Console.WriteLine("Done");
                    }
            
            }
            else
            {
                count = 0;

            }
        }
    }

    public void Quote2(string words)
        {
            Scripture_quote = words;
            int count = 1;
            while (count != 0)
            {
                Random randomGenerator = new Random();
                string[] my_word = {"1Nephi 2:15 :", "and", "my", "father", "dwelt", "in a", "tent"};
                int index = randomGenerator.Next(my_word.Length);

                var Userinput = Console.ReadKey();
                if (Userinput.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Scripture_quote= Scripture_quote.Replace(my_word[index], "_");
                    Console.WriteLine(Scripture_quote);
                    if (Scripture_quote =="_ _ _ _ _ _ _")
                    {
                        count = 0;
                        Console.WriteLine("Done");
                    }
                
                }
                else
                {
                   count = 0;
                }
            }
        }

    public void Quote3(string words)
        {
            Scripture_quote = words;
            
            int count = 1;
            while (count != 0)
            {
                Random randomGenerator = new Random();
                string[] my_word = {"John 11:35:", "and", "Jesus", "wept"};
                int index = randomGenerator.Next(my_word.Length);

                var Userinput = Console.ReadKey();
                if (Userinput.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Scripture_quote = Scripture_quote.Replace(my_word[index], "_");
                    Console.WriteLine(Scripture_quote);
                     if (Scripture_quote =="_ _ _ _")
                    {
                        count = 0;
                        Console.WriteLine("Done");
                    }
                
                }
                else
                {
                    count = 0;
                }

            }
        }
}