using System;

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Command> commands = new Dictionary<string, Command>();
            commands["1"] = new BreathingCommand();
            commands["2"] = new ReflectingCommand();
            commands["3"] = new ListingCommand();

            Console.WriteLine("Which command would you like to run? ");
            string choice = Console.ReadLine();

            commands[choice].Execute();
        }
    }
}