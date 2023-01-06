using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);
        string letter = "";
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80 && percent < 90)
        {
            letter = "B";
        }
        else if (percent >= 70 && percent < 80)
        {
            letter = "C";
        }
        else if (percent >= 60 && percent < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your Grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else if (percent < 70)
        {
            Console.WriteLine("You failed the class, better luck next time.");
        }


    }
}