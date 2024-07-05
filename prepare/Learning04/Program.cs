using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment assignment = new Assignment("Mohamed Doe", "Algebra" );
        // Console.WriteLine(assignment.GetSummary());

        MathAssignment assignment1 = new MathAssignment("Mohamed Sherrif", "Algebra", "9.2", "12-21");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(assignment1.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment assignment = new WritingAssignment("Amidu Makavory", "Realism", "World Politics: Trend and Transformation");
        Console.WriteLine(assignment.GetWritingInformation());
    }
}