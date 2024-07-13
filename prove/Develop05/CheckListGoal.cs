
namespace EternalQuest
{
    // Class for checklist goals
    public class CheckListGoal : Goal
    {
        public int _amountCompleted;
        public int _target { get; private set; }
        public int _bonus { get; private set; }
        public bool _isComplete = false;

        public CheckListGoal(string name, string description, int points, int target, int bonus)
            : base(name, description, points)
        {
            _amountCompleted = 0;
            _target = target;
            _bonus = bonus;
            _isComplete = false;
        }

        public override void RecordEvent()
        {
            _amountCompleted++;
            DisplayAnimation();
        }

        public override bool IsComplete()
        {
            return _amountCompleted >= _target;
        }

        public override string GetDetailsString()
        {
            return $"{(_isComplete ? "[X]" : "[ ]")} - {_shortName}: {_description} - Points: {_points} - Completed: {_amountCompleted}/{_target} - Bonus: {_bonus}";
        }

        public override string GetStringRepresentation()
        {
            return $"CheckListGoal;{_shortName};{_description};{_points};{_amountCompleted};{_target};{_bonus}";
        }

        private void DisplayAnimation()
        {
            Console.WriteLine("Goal Achieved!");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }
            Console.WriteLine();
        }
    }
}
