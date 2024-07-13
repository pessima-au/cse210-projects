using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    // Class to manage goals
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
            while (true)
            {
                Console.WriteLine("1. List Goals");
                Console.WriteLine("2. Create Goal");
                Console.WriteLine("3. Record Event");
                Console.WriteLine("4. Save Goals");
                Console.WriteLine("5. Load Goals");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        ListGoalDetails();
                        break;
                    case "2":
                        CreateGoal();
                        break;
                    case "3":
                        RecordEvent();
                        break;
                    case "4":
                        SaveGoals();
                        break;
                    case "5":
                        LoadGoals();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid option, try again.");
                        break;
                }
            }
        }

        public void ListGoalDetails()
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }
            Console.WriteLine($"\nTotal Points: {_score}\n");
        }

        public void CreateGoal()
        {
            Console.WriteLine("Select goal type: ");
            Console.WriteLine("1. Simple");
            Console.WriteLine("2. Eternal");
            Console.WriteLine("3. Checklist");
            var type = Console.ReadLine();
            Console.WriteLine("Enter goal name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Enter goal description: ");
            var description = Console.ReadLine();
            Console.WriteLine("Enter goal points: ");
            var points = int.Parse(Console.ReadLine());

            switch (type)
            {
                case "1":
                    _goals.Add(new SimpleGoal(name, description, points));
                    break;
                case "2":
                    _goals.Add(new EternalGoal(name, description, points));
                    break;
                case "3":
                    Console.WriteLine("Enter goal target: ");
                    var target = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter goal bonus: ");
                    var bonus = int.Parse(Console.ReadLine());
                    _goals.Add(new CheckListGoal(name, description, points, target, bonus));
                    break;
                default:
                    Console.WriteLine("Invalid goal type.");
                    break;
            }
        }

        public void RecordEvent()
        {
            Console.WriteLine("Which goal have you accomplished: ");
            var goalNumber = int.Parse(Console.ReadLine());
            if (goalNumber <= 0 || goalNumber > _goals.Count)
            {
                Console.WriteLine("Invalid goal number.");
                return;
            }

            var goal = _goals[goalNumber - 1];
            goal.RecordEvent();

            _score += goal._points;

            if (goal is CheckListGoal checklistGoal && checklistGoal.IsComplete() && !checklistGoal._isComplete)
            {
                _score += checklistGoal._bonus;
                checklistGoal._isComplete = true; // this line of code marks as complete
            }
        }

        public void SaveGoals()
        {
            Console.WriteLine("Enter file name to save: ");
            var fileName = Console.ReadLine();

            using (var writer = new StreamWriter(fileName))
            {
                writer.WriteLine(_score);
                foreach (var goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }

            Console.WriteLine("Goals saved successfully.");
        }

        public void LoadGoals()
        {
            Console.WriteLine("Enter the name of the file to load: ");
            var fileName = Console.ReadLine();

            if (!File.Exists(fileName))
            {
                Console.WriteLine("File not found.");
                return;
            }

            using (var reader = new StreamReader(fileName))
            {
                _score = int.Parse(reader.ReadLine());
                _goals.Clear();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(';');
                    switch (parts[0])
                    {
                        case "SimpleGoal":
                            var simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                            if (bool.Parse(parts[4]))
                            {
                                simpleGoal.RecordEvent(); // Marks goal as complete if it was saved as complete
                            }
                            _goals.Add(simpleGoal);
                            break;
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                            break;
                        case "CheckListGoal":
                            var checklistGoal = new CheckListGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]));
                            checklistGoal._amountCompleted = int.Parse(parts[4]);
                            _goals.Add(checklistGoal);
                            break;
                    }
                }
            }

            Console.WriteLine("Goals loaded successfully.");
        }
    }
}
