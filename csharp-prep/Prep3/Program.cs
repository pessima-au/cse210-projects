using System;
using System.Net;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

     /* int  magicNumber = 6;
      Console.Write("What is your guess? ");
      string userGuess = Console.ReadLine();

      int guessed = int.Parse(userGuess);
      
      if (guessed == magicNumber) 
      {
        Console.Write("You guessed it");
      }else if (guessed < magicNumber)
      {
        Console.WriteLine("Higher");
      } else
      {
        Console.WriteLine("Lower");
      }*/
       

        // Add a loop that keeps looping as long as the
        //  guess does not match the magic number.

        // At this point, the user should be able to 
        // keep playing until they get the correct answer.

      Boolean playAgain = true;
      while (playAgain)
      {
        Random randomGenerator = new Random();
        int magicNumber1 = randomGenerator.Next(1, 100);
        int guess = 0;
        int numberOfGuesses = 0;

        Console.WriteLine($"What is the magic number? {magicNumber1}");
        while (guess != magicNumber1) {
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);

          if (guess == magicNumber1) {
              Console.WriteLine("You guessed it.");
            }
            else if (guess < magicNumber1) {
                Console.WriteLine("Higher");
            }
            else{
                Console.WriteLine("Lower");
            }
            numberOfGuesses++;
        }
       
        Console.WriteLine($"You guessed {numberOfGuesses} times.");

        Console.WriteLine("Do you want to play again? (yes/no): ");
        playAgain = Console.ReadLine().Trim().ToLower() == "yes";
        if  (playAgain != true) 
        {
          playAgain = false;
          Console.WriteLine("Thank you for playing.");
       }

    }
}

}