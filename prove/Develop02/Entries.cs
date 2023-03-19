public class Entries
{
    public string _prompt;
    public string _answer;
    public string _date;
    
    public string Date()
    {
        return DateTime.Now.ToShortDateString();
    }
    
    public void AddJournalEntry()
    {
         _date = Date();
         PromptGenerator Prompt = new PromptGenerator();
         _prompt = Prompt.Generator();
         _answer = Console.ReadLine();
         
    }   
}