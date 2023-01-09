using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string name = PromptUserName();
        int number = PromptUserNumber();

        int squared_number = SquareNumber(number);

        DisplayResult(name, squared_number);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name2 = Console.ReadLine();

        return name2;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number2 = int.Parse(Console.ReadLine());

        return number2;
    }

    static int SquareNumber(int number2)
    {
        int square = number2 * number2;
        return square;
    }

    static void DisplayResult(string name2, int square)
    {
        Console.WriteLine($"{name2}, the square of your number is {square}");
    }
}