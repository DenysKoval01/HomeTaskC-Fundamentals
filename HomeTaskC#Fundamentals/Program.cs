using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskC_Fundamentals
{
    public class Program
    {
        static public void Main(String[] args)
        {
            bool playAgain = true;

            while (playAgain)
            {
                //The program should think a number between 0 and 50, and ask the player to enter a number
                int randomNumber = new Random().Next(51);

                int guess = -1;

                //The program should keep asking the user until he/she found the correct number
                while (guess != randomNumber)
                {
                    Console.Write("I'm thinking of a number between 0 and 50. Can you guess it? ");
                    guess = Convert.ToInt32(Console.ReadLine());

                    printMessageOnNumberDepends(guess, randomNumber);
                }

                playAgain = isUserWantsToContinuePlay();
            }
        }

        private static void printMessageOnNumberDepends(int guess, int randomNumber)
        {
            if (guess < randomNumber)
                //If the entered number is less then random number, then the program should display a message: ""My number is bigger..""
                Console.WriteLine("My number is bigger..");
            else if (guess > randomNumber)
                //If the entered number is greater than the random number, then the program should display a message: ""My number is smaller..""
                Console.WriteLine("My number is smaller..");
            else
                // If the entered number matches the random number, then display: ""Bullseye!""
                Console.WriteLine("Bullseye!");
        }

        private static bool isUserWantsToContinuePlay()
        {
            //Bonus: The program should ask if the player wants to play again. If not, then exit, otherwise the game should start over"
            Console.Write("Do you want to play again? (y/n): ");
            return Console.ReadLine().ToLower() == "y";
        }
    } 
}
