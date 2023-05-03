using System;

bool playAgain = true;

while (playAgain)
{
    int randomNumber = new Random().Next(51);

    int guess = -1;

    while (guess != randomNumber)
    {
        Console.Write("I'm thinking of a number between 0 and 50. Can you guess it? ");
        guess = Convert.ToInt32(Console.ReadLine());

       if (guess < randomNumber)
           Console.WriteLine("My number is bigger..");
       else if (guess > randomNumber)
           Console.WriteLine("My number is smaller..");
       else
           Console.WriteLine("Bullseye!");
    }

    Console.Write("Do you want to play again? (y/n): ");
    playAgain = Console.ReadLine().ToLower() == "y";
}
