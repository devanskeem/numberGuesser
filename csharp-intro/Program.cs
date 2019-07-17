using System;

namespace csharpintro
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Devan Skeem";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} version {1} created by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();

            Console.Write("What is your name? ");
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game", inputName);


            while (true) {
                Random random = new Random();
                int correctNum = random.Next(1, 10);

                int guess = 0;
                int score = 100;
                Console.Write("Guess a number between 1 and 10: ");

                while(guess != correctNum)
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Sorry {0} is not a number, try again: ", input);
                        Console.ResetColor();
                        continue;
                    }
                    guess = Int32.Parse(input);

                    if (guess != correctNum)
                    {
                        score--;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Incorrect number, please guess again: ");
                        Console.ResetColor();
                    }

                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You are correct!! Score: {0}", score);
                Console.ResetColor();

                Console.WriteLine("Play again? [Type Y for yes anything for no]");
                string answer = Console.ReadLine().ToUpper();
                if (answer != "Y") return;
            }
        }
    }
}
