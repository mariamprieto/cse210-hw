using System;

/*
Main program:
- Starts the goal menu
- Includes option to delete goals to help users correct or adjust their goals and maintain a full history
*/
class Program
{
    static void Main(string[] args)
    {
        GoalMenu menu = new GoalMenu();
        menu.Menu();
    }
}