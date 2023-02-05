using System;
using System.IO;

namespace JournalWriting
{
    public class PromptList
    {
        List<string> promptLines;
        int promptLineCount = 0;
        
        public void promptFileNumbers()
        {
            promptLines = new List<string>(System.IO.File.ReadAllLines("Prompts.txt"));
            foreach (string line in promptLines){promptLineCount += 1;}
        }

        public void prompt()
        {
            Journal j = new Journal();

            Random rdmPrompt = new Random();
            int randomNum = rdmPrompt.Next(0,promptLineCount);
            string chosenPrompt = promptLines[randomNum];

            Console.WriteLine(chosenPrompt);
            j.prompt = chosenPrompt;
            j.journalEntry = Console.ReadLine();
            j.date = Convert.ToString(DateTime.Now);
            j.saveEntry();
        }

    }
}