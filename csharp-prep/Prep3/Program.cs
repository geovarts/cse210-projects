using System;

class Program
{
    static void Main(string[] args)
    {
        Random number_random = new Random();
        int magic_number = number_random.Next(1, 100);

        int guess = -1;

        while (guess != magic_number){
            Console.Write("What is your guess? ");
            string s_guess = Console.ReadLine();
            guess = int.Parse(s_guess);

            if (magic_number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magic_number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Excellent, you guessed it");
            }

        }
    }
}