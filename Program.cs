using System;
//namespace 

namespace NumberGuesses
{
    //main class
    class Program
    {
        // enter point method
        static void Main(string[] args)
        {
            // Set app vars
            string appName = "Number Gusser";
            string appVetsion = "1.0.0";
            string appAurthor = "Yegnesh Konathala";

            //change text colour
            Console.ForegroundColor = ConsoleColor.Red;

            //writeout app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVetsion, appAurthor);

            //reset text colour
            Console.ResetColor();

            //ask user name
            Console.WriteLine(" what is your name? ");

            //get user input
            String inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game..", inputName);

            //init correct number
            int correctNumber = 7;

            //init guess var
            int guess = 0;

            //ask user for number
            Console.WriteLine("guess a number between 1 to 10");

            //while guess is not correct
            while (guess != correctNumber)
            {
                //get user input
                string input = Console.ReadLine();

                // makesure its a number
                if (!int.TryParse(input, out guess))

                { 
                //change text colour
                Console.ForegroundColor = ConsoleColor.Red;

                //writeout app info
                Console.WriteLine("Please enter number");

                //reset text colour
                Console.ResetColor();

                continue;
            }
                guess = Int32.Parse(input);

                if( guess != correctNumber)
                {
                    //change text colour
                    Console.ForegroundColor = ConsoleColor.Red;

                    //writeout app info
                    Console.WriteLine("Wrong number please try again");

                    //reset text colour
                    Console.ResetColor();
                }
                
            }
            //change text colour
            Console.ForegroundColor = ConsoleColor.Green;

            //writeout app info
            Console.WriteLine("You are correct");

            //reset text colour
            Console.ResetColor();

        }
    }
}
