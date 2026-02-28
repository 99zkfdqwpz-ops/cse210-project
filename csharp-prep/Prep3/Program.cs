using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        int NumberOfGuesses = 0;
       
        while (guess != magicNumber)
        {   NumberOfGuesses += 1;
            Console.Write("guess a number: ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Guess higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Guess lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"it took you {NumberOfGuesses} guess(es)");
            }
            
        }                    
    }
}