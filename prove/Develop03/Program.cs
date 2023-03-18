using System;

namespace Memorizing
{
    public class Program
    {
        static void Main(string[] args)
        {
            Words w = new Words("");
            Scripture s = new Scripture("");
            Output o = new Output();
            Verse v = new Verse("");
            o.clearScreen();        
            s.giveScripture();
            o.showScripture(s);
            
            Console.Write("\nPress Enter key to continue or type 'quit' to finish:");
            string input = Console.ReadLine();
            while (input != "quit")
            {
                o.clearScreen();
                v.HideWords();
                o.showScripture(s);

                Console.Write("\nPress Enter key to continue or type 'quit' to finish:");
                input = Console.ReadLine();
            }
        }
    }
}