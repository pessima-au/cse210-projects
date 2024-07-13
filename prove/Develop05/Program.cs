using System;
using EternalQuest;
// I added an extra method to display and animation followed by a message that a goal has been achieved.
public class Program
{
    public static void Main()
    {
        var manager = new GoalManager();
        manager.Start();
    }
}
