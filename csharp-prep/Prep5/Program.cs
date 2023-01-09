using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program!");
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Please enter your favorite number: ");
        string number = Console.ReadLine();
        int num = int.Parse(number);
        int square = num * num;
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}