using System;
using System.IO;
namespace JournalWriting
{
    public class LoadNSave
    {
        Journal j = new Journal();
        public void load()
        {
            Console.Write("What is the filename? ");
            string rewriteFile = Console.ReadLine();
            File.Replace(rewriteFile, Journal.fileName, null);
        }

        public void save()
        {
            Console.Write("What is the filename? ");
            string newFile = Console.ReadLine();
            
            using (StreamWriter outputFile = new StreamWriter(newFile, true))
            {   
                foreach (string line in Journal.entries){outputFile.WriteLine(line);}
            }
        }
    }
}