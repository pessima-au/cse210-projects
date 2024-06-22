using System.Collections.Generic;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");


    List<int> numbers =  new List<int>();
    int sum = 0;
    int average = 1;
    
    Console.WriteLine("Enter a list of numbers , type 0 when finished.");
    while (true) {
        Console.Write("Enter number: ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        if (number == 0) {
            break;
        }
        else {
            numbers.Add(number);
            sum += number;
        }
    }
      average = sum / numbers.Count;
      Console.WriteLine($"The sum is {sum}");
      Console.WriteLine($"The average is {average}"); 
        

    }
}