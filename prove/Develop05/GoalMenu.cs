using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;


/*
GoalMenu: manages the main program flow
- Allows creating, listing, saving, loading, recording events, and deleting goals
- "Delete Goal" option was included to help the user correct mistakes (wrong points, typos, or changing goals)
- When deleting, a reason is saved to maintain traceability
*/
public class GoalMenu
{

    //Atributes
    private List<Goal> _goals = new List<Goal>();//list to store all goals
    private int _totalScore;//stores the user's total accumulated points

    //Method that displays and handles the main menu options
    public void Menu()
    {
        int _option = 0;
        while (_option != 7)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {_totalScore} points.");
            Console.WriteLine("Menu Options");
            Console.WriteLine("1-Create New Goal");
            Console.WriteLine("2-List Goals");
            Console.WriteLine("3-Save Goals");
            Console.WriteLine("4-Load Goals");
            Console.WriteLine("5-Record Event");
            Console.WriteLine("6-Delete Goal");
            Console.WriteLine("7-Quit");
            Console.WriteLine("Select a choice from the menu:");
            _option = int.Parse(Console.ReadLine());

            if (_option == 1)
            {
                CreateGoal();

            }
            else if (_option == 2)
            {
                ListGoals();
            }
            else if (_option == 3)
            {
                SaveGoals();
            }
            else if (_option == 4)
            {
                LoadGoals();
            }
            else if (_option == 5)
            {
                RecordEvent();
            }
            else if (_option == 6)
            {
                DeleteGoal();
            }
            else if (_option == 7)
            {
                Console.WriteLine("Goodbye");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option, please try again, select a number from 1 to 6");
            }
        }
    }
    //Method that allows the user to create different types of goals
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal.");
        Console.WriteLine("2. Eternal Goal.");
        Console.WriteLine("3. Checklist Goal.");
        Console.WriteLine("Which type of goal would you like to create?:");
        int type = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal?");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it?");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal?");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points, false));
        }
        if (type == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        if (type == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus?");
            int requiredCount = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times?");
            int bonusPoints = int.Parse(Console.ReadLine());


            _goals.Add(new ChecklistGoal(name, description, points, requiredCount, bonusPoints));
        }
    }

    //Displays all goals and their current status
    public void ListGoals()
    {
        Console.WriteLine("The goals are:");
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($" {i}.{goal.GetStatus()}");
            i++;
        }
    }

    //Saves goals and score to a file
    public void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goal file?:");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine(_totalScore);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetFile());
            }
        }
    }

    //Loads goals and score from a file
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file?");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _totalScore = int.Parse(lines[0]);
            _goals.Clear();

            foreach (string line in lines.Skip(1))
            {
                string[] parts = line.Split(":");
                string type = parts[0];
                string[] details = parts[1].Split(",");

                string name = details[0].Trim();
                string description = details[1].Trim();
                int points = int.Parse(details[2].Trim());
                bool isDeleted = bool.Parse(details[3].Trim());
                string deleteReason = details[4].Trim();

                if (type == "Simple Goal")
                {
                    bool isCompleted = bool.Parse(details[5].Trim());
                    SimpleGoal goal = new SimpleGoal(name, description, points, isCompleted);
                    if (isDeleted)
                    {
                        goal.SetIsDeleted(deleteReason);

                    }
                    _goals.Add(goal);
                }


                else if (type == "Eternal Goal")
                {
                    EternalGoal goal = new EternalGoal(name, description, points);
                    if (isDeleted)
                    {
                        goal.SetIsDeleted(deleteReason);

                    }
                    _goals.Add(goal);
                }
                else if (type == "Checklist Goal")
                {
                    int bonusPoints = int.Parse(details[5].Trim());
                    int requiredCount = int.Parse(details[6].Trim());
                    int currentCount = int.Parse(details[7].Trim());

                    ChecklistGoal goal = new ChecklistGoal(name, description, points, requiredCount, bonusPoints);
                    goal.SetCurrentCount(currentCount);
                    if (isDeleted)
                    {
                        goal.SetIsDeleted(deleteReason);

                    }
                    _goals.Add(goal);

                }
            }
        }
        else
        {
            Console.Write("File not found");
        }

    }

    //Records progress on an active goal and updates score
    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        List<Goal> activeGoals = new List<Goal>();

        for (int i = 0; i < _goals.Count; i++)
        {
            if (!_goals[i].GetIsDeleted() && !_goals[i].IsComplete())
            {

                activeGoals.Add(_goals[i]);
                Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
            }

        }

        if (activeGoals.Count == 0)
        {
            Console.WriteLine("There are no active goals to record");
            return;
        }
        Console.Write("Which goal did you accomplish?");

        if (int.TryParse(Console.ReadLine(), out int results))
        {
            results -= 1;

            if (results >= 0 && results < _goals.Count)
            {
                int pointsEarned = _goals[results].RecordEvent();
                _totalScore += pointsEarned;
                Console.WriteLine($"Congratulations! You have earned {pointsEarned} points");
                Console.WriteLine($"You now have {_totalScore} points");
            }
            else
            {
                Console.WriteLine("Invalid goal selections");
            }
        }
    }

    //Marks a goal as deleted and saves a reason for traceability
    public void DeleteGoal()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
        Console.Write("Which goal do yo want to delete?");
        if (int.TryParse(Console.ReadLine(), out int results))
        {
            results -= 1;
            if (results >= 0 && results < _goals.Count)
            {

                Console.WriteLine("Why do you want to delete this goal?");
                string deleteReason = Console.ReadLine();

                _goals[results].SetIsDeleted(deleteReason);
                Console.WriteLine("Goal marked as deleted successfully");

            }
            else
            {
                Console.WriteLine("Invalid goal selections");
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");

        }
    }
    //Returns the current total score
    public int GetTotalScore()
    {
        return _totalScore;
    }
}