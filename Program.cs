using System;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNum = random.Next(1, 21);

            int guessLimit = 5;
            int guesses;

            string welcome = WelcomeText(); //method part!
            Console.WriteLine(welcome);

                 //code just like: (int i = 0; i < 5; i++) but i think this is more Readable.
            for (guesses = 0; guesses < guessLimit; guesses++)
            {
                Console.Write("Gissa ett tal: ");
                int userInput = int.Parse(Console.ReadLine());
                //userinput without "debbuging" just a simple code this time.

                if (userInput == randomNum)
                {
                    Console.WriteLine("______________________");
                    Console.WriteLine("\nWohoo! Du klarade det!");
                    Console.WriteLine("______________________");
                    break; // End the game when the user guesses correctly.
                }
                else if (userInput < randomNum)
                {
                    Console.WriteLine("Tyvärr, du gissade för lågt!");
                    // User input is too low
                }
                else if (userInput > randomNum)
                {
                    Console.WriteLine("Tyvärr, du gissade för högt!");
                    // User input is too high
                }
            }

            if (guesses == guessLimit)
            {
                Console.WriteLine("__________________________________________________");
                Console.WriteLine("\nTyvärr, Du lyckades inte gissa talet på fem försök");
                Console.WriteLine("__________________________________________________");
                //Game over!
            }
        }

        public static string WelcomeText() 
        {
            return "Välkommen!\nJag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.";
        }   /* i could write out this code without a retunvalue
              but i choosed to do it this way */
    }
}
/* it was not necessary but i tried to do the number game with both try/catch && TryParse code.
    I did not get the converting part "unvalid char" to not count as guesses,
                            so i skiped it for the asignment */
