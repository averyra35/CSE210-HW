using System;
using System.IO;
namespace JournalWriting
{
    public class Journal
    {
        public string date = "";
        public string journalEntry = "";
        public string prompt;
        
        public void displayEntry()
        {
            Console.WriteLine($"{prompt}\n {journalEntry}\n {date}");
        }

        public static string fileName = "Journal.txt";

        public void saveEntry()
        {
            using (StreamWriter outputFile = new StreamWriter(fileName, true))
            {
                outputFile.WriteLine($"{date}\n{prompt}\n{journalEntry}\n");
            }
        }

        public static List<string> entries;
        public void displayEntries()
        {
                entries = new List<string>(System.IO.File.ReadAllLines("Journal.txt"));
                foreach (string line in entries){Console.WriteLine(line);}
        }
    }
}