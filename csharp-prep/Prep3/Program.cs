using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        bool isPlaying = true;
        while (isPlaying)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            int userGuess = int.Parse(guess);
            if (userGuess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (userGuess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (userGuess == number)
            {
                Console.WriteLine("You guessed it!");
                isPlaying = false;
            }
        }
    }
}