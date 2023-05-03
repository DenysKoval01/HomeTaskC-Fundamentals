using System;
using System.Linq;

List<string> words = new() { "cat", "dog", "human", "car", "house" };
string wordToGuess = words[new Random().Next(0, words.Count)];
char[] guessedLetters = new char[wordToGuess.Length];
int lives = 6;
Console.WriteLine("Guess the word!");
Console.WriteLine(string.Join(" ", Enumerable.Repeat("_", wordToGuess.Length)));
while (lives > 0)
{
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
    if (!correctGuess)
    {
        lives--;
        Console.WriteLine("No such letter. Lives left: " + lives);
    }
    Console.WriteLine(string.Join(" ", guessedLetters.Select(c => c == '\0' ? "_" : c.ToString())));
    if (!guessedLetters.Contains('\0'))
    {
        Console.WriteLine("Congratulations! You guessed the word.");
        return;
    }
}
Console.WriteLine("Game over. The word was " + wordToGuess);
