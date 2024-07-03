using System;
using System.Collections.Generic;
using System.Linq;


// I have upgraded the program by adding a new 'ScriptureLibrary' that holds a list of scriptures
// that  is randomly selected from and displayed. Each time the user runs the program a new randomly
// selected scripture will be displayed.
class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary scriptureLibrary = new ScriptureLibrary();

         
         scriptureLibrary.AddScripture(new Scripture(new Reference("John", 3, 35), "The Father loveth the Son, and hath given all things into his hand.")); 
         scriptureLibrary.AddScripture(new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."));
         scriptureLibrary.AddScripture(new Scripture(new Reference("2 Nephi", 31, 10), "And he said unto the children of men: Follow thou me. Wherefore, my beloved brethren, can we follow Jesus save we shall be willing to keep the commandments of the Father?"));
         scriptureLibrary.AddScripture(new Scripture(new Reference("Doctrine and Covenants", 82, 10), "10 I, the Lord, am bound when ye do what I say; but when ye do not what I say, ye have no promise."));

        Scripture randomScripture = scriptureLibrary.GetRandomScripture();
        


        Console.WriteLine(randomScripture.GetDisplayText());

        while (true)
        {
            //code  to clear the console
            Console.Clear();

            //code to prompt user to press 'Enter' or type 'quit'.
            Console.WriteLine("Welcome to the Scripture Memorizer.");
            Console.WriteLine("Press 'Enter' to continue; type 'Quit' to exit.");
            Console.WriteLine();


            //code to display the scripture text
            Console.WriteLine(randomScripture.GetDisplayText());
            string input = Console.ReadLine();


            if (input.ToLower() == "quit")
            {
                break;
            }

            //hide random words
            randomScripture.HideRandomWords(3);

            if (randomScripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine("All words have been hidden. Program will end now.");
                //Console.WriteLine(randomScripture.GetDisplayText());
                break;
            }

        }

    }


}