using System;

class Program
{
    static void Main(string[] args)
    {
        AllGoals goals = new AllGoals();
        int choice = 0;
        while (choice != 7)
        {
            Program.DisplayMenu(goals);
            choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                Program.DisplayCreateNewGoalMenu();
                int goalChoice = int.Parse(Console.ReadLine());
                Goal goal = null;
                switch(goalChoice)
                {
                    case 1:
                    goal = new ordinaryGoal();
                    goal.GetCommonInfo();
                    goal = new ordinaryGoal("ordinary Goal", goal.GetGoalName(), goal.GetDescription(), goal.GetPoints(), false);
                    goals.Add(goal);
                    Console.Clear();
                    break;
                    case 2:
                    goal = new EternalGoal();
                    goal.GetCommonInfo();
                    goal = new EternalGoal("Eternal Goal", goal.GetGoalName(), goal.GetDescription(), goal.GetPoints());
                    goals.Add(goal);
                    Console.Clear();
                    break;
                    case 3:
                    goal = new ChecklistGoal();
                    goal.GetCommonInfo();
                    goal.SetTimesToAccomplishGoal();
                    int numOfTime = goal.GetTimesToAccomplishGoal();
                    goal.SetBonusPoints();
                    int bonusPoints = goal.GetBonusPoints();
                    goals.Add(new ChecklistGoal("Checklist Goal", goal.GetGoalName(), goal.GetDescription(), goal.GetPoints(), bonusPoints, 0, numOfTime));
                    Console.Clear();
                    break;
                }
                break;
                case 2:
                Console.Clear();
                goals.displayList();
                break;
                case 3:
                Console.Clear();
                System.IO.File.WriteAllLines($@"{goals.GetFileName()}", goals.SaveGoals());
                break;
                case 4:
                Console.Clear();
                goals.DeleteGoal();
                break;
                case 5:
                Console.Clear();
                goals.LoadGoals();
                break;
                case 6:
                Console.Clear();
                goals.RecordGoalAccomplished();
                Console.Clear();
                break;
                case 7: break;
            }
        }
    }
    static void DisplayMenu(AllGoals goals)
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine($"You have {goals.GetTotalPoints()} points.");
        Console.WriteLine();
        Console.WriteLine("Menu Options: " +
        "\n     1. Create New Goal" +
        "\n     2. List Goals" +
        "\n     3. Save Goals" +
        "\n     4. Remove Goals" +
        "\n     5. Load Goals" +
        "\n     6. Record Event" +
        "\n     7. Quit");
        Console.WriteLine("------------------------------");
        Console.Write("Select a choice from the menu: ");
    }
    static void DisplayCreateNewGoalMenu()
    {
        Console.WriteLine("The types of Goals are:" +
        "\n     1. ordinary Goal" +
        "\n     2. Eternal Goal" +
        "\n     3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
    }   
}