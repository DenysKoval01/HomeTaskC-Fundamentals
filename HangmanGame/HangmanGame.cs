using System;
using System.Linq;

//The program should pick a random word from a list (example: cat)
//list of random words
List<string> words = new() { "cat", "dog", "human", "car", "house" };
string wordToGuess = words[new Random().Next(0, words.Count)];
char[] guessedLetters = new char[wordToGuess.Length];
int lives = 6;
Console.WriteLine("Guess the word!");
//It should display the random word masked with "_"  (example: _ _ _)
Console.WriteLine(string.Join(" ", Enumerable.Repeat("_", wordToGuess.Length)));
//The program should keep asking for letters until the player still has at least one life remaining or correctly guesses the word
while (lives > 0)
{
    //The program should ask the player to provide a letter
    Console.Write("Enter a letter: ");
    string input = Console.ReadLine().ToLower();
    if (input.Length != 1 || !char.IsLetter(input[0]))
    {
        Console.WriteLine("Please enter a single letter.");
        continue;
    }
    char guess = input[0];
    bool correctGuess = false;
    for (int i = 0; i < wordToGuess.Length; i++)
    {
        if (wordToGuess[i] == guess)
        {
            guessedLetters[i] = guess;
            correctGuess = true;
            break;
        }
    }
    //If the letter is not in the random word, then the player should lose a life. By default, the player has 6 lives.
    if (!correctGuess)
    {
        lives--;
        //It should display how many lives the player has
        Console.WriteLine("No such letter. Lives left: " + lives);
    }
    //It should display the already correctly guessed letter(s) from the random word including the newly matched characters (example: _a_) OR if the letter is wrong a notification that there is no such letter in the word (___, and in a new line: “no such letter").
    Console.WriteLine(string.Join(" ", guessedLetters.Select(c => c == '\0' ? "_" : c.ToString())));
    if (!guessedLetters.Contains('\0'))
    {
        Console.WriteLine("Congratulations! You guessed the word.");
        return;
    }
}
//If the player "died", the program should display a game over notification
Console.WriteLine("Game over. The word was " + wordToGuess);
