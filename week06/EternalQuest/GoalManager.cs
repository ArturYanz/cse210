using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;


    public GoalManager()
    {

        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        int choice = 0;

        while (choice != 6)
        {
            Console.Clear();

            DisplayPlayerInfo();

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("     1. Create New Goal");
            Console.WriteLine("     2. List Goals");
            Console.WriteLine("     3. Save Goals");
            Console.WriteLine("     4. Load Goals");
            Console.WriteLine("     5. Record Event");
            Console.WriteLine("     6. Quit");

            Console.WriteLine("");

            Console.Write("Select a choice from the menu: ");


            string input = Console.ReadLine();

            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                Pause();
                continue;
            }


            if (choice == 1)
            {
                Console.Clear();
                CreateGoal();
                Pause();

            }
            else if (choice == 2)
            {
                Console.Clear();
                ListGoalDetails();
                Pause();
            }
            else if (choice == 3)
            {
                Console.Clear();
                SaveGoals();
                Pause();
            }
            else if (choice == 4)
            {
                Console.Clear();
                LoadGoals();
                Pause();
            }
            else if (choice == 5)
            {
                Console.Clear();
                RecordEvent();
                Pause();
            }
            else if (choice == 6)
            {
                Console.WriteLine("");
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Press Enter to try again.");
                Pause();
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.");
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("");
        Console.WriteLine("The Types of Goals are the following:");
        Console.WriteLine("     1. Simple Goal");
        Console.WriteLine("     2. Eternal Goal");
        Console.WriteLine("     3. Checklist Goal");

        Console.WriteLine("");

        Console.Write("Which goal do you want to create? ");


        string input = Console.ReadLine();

        if (!int.TryParse(input, out int type) || type < 1 || type > 3)
        {
            Console.WriteLine("Invalid goal type.");
            Pause();
            return;
        }

        Console.WriteLine("");
        Console.Write("Enter the name of your goal: ");
        string name = Console.ReadLine();

        Console.Write("Enter a brief description of it: ");
        string description = Console.ReadLine();

        Console.Write("How many points is this goal worth?: ");

        
        if (!int.TryParse(Console.ReadLine(), out int points))
        {
            Console.WriteLine("Invalid points value");
            return;
        }

        if (type == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == 3)
        {
            Console.Write("How many times does this challenge needs to be completed to get a bonus?: ");

            if (!int.TryParse(Console.ReadLine(), out int target))
            {
                Console.WriteLine("Invalid number.");
                return;
            }

            Console.Write("What would be the bonus for completing it that many times?: ");
            if (!int.TryParse(Console.ReadLine(), out int bonus))
            {
                Console.WriteLine("Invalid bonus.");
                return;
            }

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }

        Console.WriteLine("");

        Console.WriteLine("Goal created succesfully!");
    }

    public void RecordEvent()
    {

        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }


        ListGoalDetails();

        Console.Write("Which goal did you complete? ");

        if (!int.TryParse(Console.ReadLine(), out int index) || index < 1 || index > _goals.Count)
        {
            Console.WriteLine("Invalid goal number");
            return;
        }

        index -= 1;

        int earnedPoints = _goals[index].RecordEvent();
        _score += earnedPoints;


        Console.WriteLine("");

        Console.WriteLine($"Well done! You earned {earnedPoints} points!");
    }

    public void SaveGoals()
    {

        Console.WriteLine("");

        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goal/s saved succesfully.");
    }

    public void LoadGoals()
    {

        Console.WriteLine("");
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            if (parts[0] == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]),
                    bool.Parse(parts[4])
                ));
            }
            else if (parts[0] == "EternalGoal")
            {
                _goals.Add(new EternalGoal(

                    parts[1],
                    parts[2],
                    int.Parse(parts[3])
                ));
            }
            else if (parts[0] == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(

                    parts[1],
                    parts[2],
                    int.Parse(parts[3]),
                    int.Parse(parts[4]),
                    int.Parse(parts[5]),
                    int.Parse(parts[6])
                ));
            }
        }

        Console.WriteLine("Goals loaded succesfully.");
    }

    private void Pause()
    {
        Console.WriteLine("");
        Console.WriteLine("Press Enter to return to menu...");
        Console.ReadLine();
    }
}