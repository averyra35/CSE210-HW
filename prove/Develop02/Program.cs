using System;
namespace JournalWriting
{

    public class Menu
    {
        static void Main(string[] args)
        {
            Journal j = new Journal();
            LoadNSave ls = new LoadNSave();

            bool keepGoing = true;
            while (keepGoing == true)
            {
                Console.WriteLine("Please select one of the following choices:");
                Console.WriteLine("  1. Write \n  2. Display\n  3. Load\n  4. Save\n  5. Quit");
                Console.Write("What would you like to do? ");
                
                string answer = Console.ReadLine();
                int choice = int.Parse(answer);

                if (choice == 1)
                {
                    PromptList prompt1 = new PromptList();
                    prompt1.promptFileNumbers();
                    prompt1.prompt();
                }

                else if (choice == 2)
                {
                    j.displayEntries();
                }

                else if (choice == 3)
                {
                    ls.load();
                }

                else if (choice == 4)
                {
                    ls.save();
                }

                else if (choice == 5)
                {
                    keepGoing = false;
                }
            }
        }
    }
}