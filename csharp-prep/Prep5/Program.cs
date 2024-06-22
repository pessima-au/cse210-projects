using System;

class Program
{
    static void Main(string[] args)
    {
     DisplayWelcome();
    string userName = PromptUserName();
    int favoriteNumber = PromptUserNumber();
    int squaredNumber = squareNumber(favoriteNumber);
    DisplayResult(userName, squaredNumber);
    }
  
    static string DisplayWelcome() 
  {
     string message = "Welcome tho the program!";
     Console.WriteLine(message);
    return message;
  }

    static string PromptUserName()
  {
     Console.Write("Please enter your name: ");
    return Console.ReadLine();
  }

    static int PromptUserNumber()
  {
      Console.Write("Please your favorite number: ");
      return int.Parse(Console.ReadLine());
  }

    static int squareNumber(int number)
  {
    return number * number;
  }

    static void DisplayResult(string userName, int squaredNumber)
  {
      Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
      
  }
}