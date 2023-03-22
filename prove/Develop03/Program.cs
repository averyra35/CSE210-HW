using System;

namespace Memorizing
{
    public class Program
    {
        static void Main(string[] args)
        {
            Scripture s = new Scripture();
            Output o = new Output();
            o.clearScreen();        
            o.showScripture(s.giveScripture());
            
            Console.Write("\nPress Enter key to continue or type 'quit' to finish:");
            string input = Console.ReadLine();
            while (input != "quit" && !s.CheckCompletion()
            {
                o.clearScreen();
                s.HideWords();
                o.showScripture(s.GetVerses());
                Console.Write("\nPress Enter key to continue or type 'quit' to finish:");
                input = Console.ReadLine();
            }
        }
    }
}