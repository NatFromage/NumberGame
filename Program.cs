using System.Security.Principal;

namespace NumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int winningNumber = rnd.Next(1, 99);

            GuessNumber(winningNumber);

        }

        public static void GuessNumber(int winningNumber)
        {
            int guessCount = 0;
            Console.WriteLine("Guess a number between 1 and 99.");

            while (guessCount < 5)
            {
                int guess = Convert.ToInt32(Console.ReadLine());

                if (!(0 < guess && guess < 99))
                {
                    Console.WriteLine("Invalid guess. Please enter a number between 1 and 99.");
                }
                else if (guess < winningNumber && guessCount != 4)
                {
                    Console.WriteLine("The winning number is HIGHER. Try again.");
                }
                else if (guess > winningNumber && guessCount!=4)
                {
                    Console.WriteLine("The winning number is LOWER. Try again.");
                }
                else if (guess == winningNumber)
                {
                    Console.WriteLine($"You WIN! {guess} was the WINNING NUMBER!!");
                    return;
                }

                guessCount++;
            }

            Console.WriteLine($"Sorry, you LOSE! The winning number was {winningNumber}.");
        }
    }
}
