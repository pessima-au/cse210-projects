using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

            string grade = " ";
            string letter = " ";
        Console.Write("Please enter your grade percentage: ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);


       
       if (gradePercentage >= 90) 
        {
           grade =  "A";
           Console.WriteLine($"Your grade is {grade}.");
        }

        else if (gradePercentage >= 80) 
        {
            grade = "B";
             Console.WriteLine($"Your grade is {grade}.");
        }

        else if (gradePercentage >= 70) 
        {
            grade = "C";
            Console.WriteLine($"Your grade is {grade}.");
        }

        else if (gradePercentage >= 60) 
        {
            grade = "D";
            Console.WriteLine($"Your grade is {grade}.");
        }

        else {
            grade = "F";
             Console.WriteLine($"Your grade is {grade}.");
        }



        if (gradePercentage >= 90) 
        {
           letter =  "A";
        }

        else if (gradePercentage >= 80) 
        {
            letter = "B";
        }

        else if (gradePercentage >= 70) 
        {
            letter = "C";
        }

        else if (gradePercentage >= 60) 
        {
            letter = "D";
        }

        else {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}.");
    }
}