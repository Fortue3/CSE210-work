using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int answer = 0;
        Journal journal = new Journal();

        while (answer !=5)
        {
            Console.WriteLine("Please select one of the Following options: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
   
            answer = int.Parse(Console.ReadLine());
            
            switch(answer){
                
                case 1:
                journal.AddJournalEntry2() ;
                break;
                
                case 2:
                journal.DisplayJournalEntries();
                break;
                            
                case 3:
                journal.LoadJournal();
                break;
                           
                case 4:
                journal.SaveJournal();
                break;
                            
                case 5:
                Console.WriteLine("Bye!");
                break;
                           
                default:
                Console.Write("You have entered an incorrect number!");
                break;
                
                }
        }  
    }
}