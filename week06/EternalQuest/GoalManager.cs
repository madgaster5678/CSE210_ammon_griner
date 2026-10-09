using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.IO;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your current score is: {_score}");
        Console.WriteLine($"Your current level is {GetLevel()}");
    }

    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetName());
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("What kind of goal do you want to make?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string goalmaker = Console.ReadLine();
        Console.WriteLine("What is the name of the goal?");
        string goalmakername = Console.ReadLine();
        Console.WriteLine("What is the goal's description?");
        string goalmakerdescription = Console.ReadLine();
        Console.WriteLine("How many points Should it be worth?");
        int goalmakerpoints = int.Parse(Console.ReadLine());
        if (goalmaker == "1")
        {
            SimpleGoal goal = new SimpleGoal(false, goalmakername, goalmakerdescription, goalmakerpoints);
            _goals.Add(goal);
        }
        else if (goalmaker == "2")
        {
            EternalGoal goal = new EternalGoal(goalmakername, goalmakerdescription, goalmakerpoints);
            _goals.Add(goal);
        }
        else if (goalmaker == "3")
        {
            Console.WriteLine("How many times should this goal be completed?");
            int goalmakertarget = int.Parse(Console.ReadLine());
            Console.WriteLine("What should the bonus be for completing this goal?");
            int goalmakerbonus = int.Parse(Console.ReadLine());
            ChecklistGoal goal = new ChecklistGoal(goalmakername, goalmakerdescription, goalmakerpoints, goalmakertarget, goalmakerbonus);
            _goals.Add(goal);
        }
    }

    public void RecordEvent()
    {
        int goalcheck = _goals.Count;
        if (goalcheck == 0)
        {
            Console.WriteLine("You do not have any goals.");
            return;
        }
        Console.WriteLine("Which goal have you accomplished?");
        int goalCount = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goalCount}. {goal.GetDetailsString()}");
            goalCount += 1;
        }
        Console.WriteLine("Please input the number of the goal");
        bool validInput = int.TryParse(Console.ReadLine(), out int completedGoal);
        if (!validInput)
        {
            Console.WriteLine("Please enter a valid number");
            return;
        }
        if (completedGoal < 1 || completedGoal > (_goals.Count))
        {
            Console.WriteLine("Invalid goal number");
            return;
        }
        Goal selectedGoal = _goals[completedGoal - 1];
        bool wasComplete = selectedGoal.IsComplete();
        if (selectedGoal is SimpleGoal && !wasComplete)
        {
            _score += selectedGoal.GetPoints();
        }
        else if (selectedGoal is ChecklistGoal)
        {
            _score += selectedGoal.GetPoints();
        }
        else if (selectedGoal is EternalGoal)
        {
            _score += selectedGoal.GetPoints();
        }
        selectedGoal.RecordEvent();
        if (selectedGoal is ChecklistGoal && !wasComplete && selectedGoal.IsComplete())
        {
            _score += ((ChecklistGoal)selectedGoal).GetBonus(); 
        }

    }

    public void Start()
    {
        int userChoice = 0;
        Console.WriteLine("Welcome to the DMC goal tracker");
        while (userChoice != 7)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Create a Goal");
            Console.WriteLine("2. List your Goals");
            Console.WriteLine("3. Save your Goals");
            Console.WriteLine("4. Load your saved Goals");
            Console.WriteLine("5. Record a Goal Completed");
            Console.WriteLine("6. Display Your score");
            Console.WriteLine("7. Quit");
            userChoice = int.Parse(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                CreateGoal();
                break;
                case 2:
                ListGoalDetails();
                break;
                case 3:
                SaveGoal();
                break;
                case 4:
                LoadGoal();
                break;
                case 5:
                RecordEvent();
                break;
                case 6:
                DisplayPlayerInfo();
                break;
                
            }
        }
        Console.WriteLine("Thank you for using the DMC Goal tracker. We hope you have a great day.");
    }

    public int GetLevel()
    {
        int level = 1 + (_score / 1000);
        return level;
    }

    public void SaveGoal()
    {
        Console.WriteLine("What filename do you want for your goals?");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoal()
    {
        Console.WriteLine("What is the name of the file you want to open?");
        string filename = Console.ReadLine();
        if (!File.Exists(filename))
        {
            Console.WriteLine("That file does not exist");
            return;
        }
        _goals.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line = reader.ReadLine();
            _score = int.Parse(line);
            line = reader.ReadLine();
            while (line != null)
            {
                string[] parts = line.Split(',');
                if (parts[0] == "SimpleGoal")
                {
                    string goalrename = parts[1];
                    string goalredescription = parts[2];
                    int goalrepoints = int.Parse(parts[3]);
                    bool goalrecomplete = bool.Parse(parts[4]);
                    SimpleGoal goal = new SimpleGoal(goalrecomplete, goalrename, goalredescription, goalrepoints);
                    _goals.Add(goal);
                }
                else if (parts[0] == "EternalGoal")
                {
                    string goalrename = parts[1];
                    string goalredescription = parts[2];
                    int goalrepoints = int.Parse(parts[3]);
                    EternalGoal goal = new EternalGoal(goalrename, goalredescription, goalrepoints);
                    _goals.Add(goal);
                }
                else if (parts[0] == "ChecklistGoal")
                {
                    string goalrename = parts[1];
                    string goalredescription = parts[2];
                    int goalrepoints = int.Parse(parts[3]);
                    int goalretarget = int.Parse(parts[4]);
                    int goalrebonus = int.Parse(parts[5]);
                    int goalreamount = int.Parse(parts[6]);
                    ChecklistGoal goal = new ChecklistGoal(goalrename, goalredescription, goalrepoints, goalretarget, goalrebonus, goalreamount);
                    _goals.Add(goal);
                }
                line = reader.ReadLine();
                
            }
            
        }
    }
}