using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        int num = -1;

        do{
            Console.WriteLine("Enter a number");
            string usernumber = Console.ReadLine();
            num = int.Parse(usernumber);
            if(num!=0)
            {
                numbers.Add(num);
            }
        }
        while(num!=0);
        int sum = 0;
        foreach (int number in numbers)
        {
            sum+= number;
        }
        Console.WriteLine($"The sum is: {sum}");
        float avg = ((float)sum)/numbers.Count;
        Console.WriteLine($"The average of these numbers is: {avg}");
        int maximum = numbers[0];
        foreach(int number in numbers)
        {
            if(number>maximum)
            {
                maximum = number;
            }
        }
         Console.WriteLine($"The maximum number is: {maximum}");
         
    }
}