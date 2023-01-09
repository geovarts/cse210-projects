using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int num_percentage = int.Parse(percentage);
        string letter_grade = "";
        if (num_percentage >= 90){
            letter_grade = "A";
        }
        else if (num_percentage >= 80){
            letter_grade = "B";
        }
        else if(num_percentage >= 70){
            letter_grade = "C";
        }
        else if(num_percentage >= 60){
            letter_grade = "D";            
        }

        else {
            letter_grade = "F";
        }

        Console.WriteLine($"Your grade is: {letter_grade}");

        if (num_percentage >= 70){
            Console.Write("You pass the course");
        }
        else{
            Console.Write("Try next time");
        }

    }
}