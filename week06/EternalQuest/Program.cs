using System;

class Program
{
    static void Main(string[] args)
    {

        //for the creativity i added a leveling system to the program
        //the level of the user increases after every 1000 points and i added it to help it feel more like a game.
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}