using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


public class GoalMenu
{

    private List<Goal> _goals = new List<Goal>();
    private int _totalScore;

    public void GoalMenu()
    {
        int _option = 0;
        while (_option != 6)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {_totalScore} points.");
            Console.WriteLine("Menu Options");
            Console.WriteLine("1-Create New Goal");
            Console.WriteLine("2-List Goals");
            Console.WriteLine("3-Save Goals");
            Console.WriteLine("4-Load Goals");
            Console.WriteLine("5-Record Event");
            Console.WriteLine("6-Quit");
            Console.WriteLine("Select a choice from the menu:");
            _option = int.Parse(Console.ReadLine());

            if (_option == 1)
            {

            }
            else if (_option == 2)
            {

            }
            else if (_option == 3)
            {

            }
            else if (_option == 4)
            {

            }
            else if (_option == 5)
            {

            }
            else if (_option == 6)
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




}