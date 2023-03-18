using System;
using System.IO;
using System.Collections.Generic;

namespace Memorizing
{
    public class Scripture
    {
        private List<string> scripture = new List<string>();
        private string reference = "";
        private string text = "";
        private List<Verse> verses = new List<Verse>();

        public Scripture (string scripture)
        {
            string[] scriptureVerses = scripture.Split("|", StringSplitOptions.RemoveEmptyEntries);
            reference = scriptureVerses[0];
            text = scriptureVerses[1];
            SeparateVerses();
        }

        public void setScripture()
        {
            scripture = new List<string>(System.IO.File.ReadAllLines("Scripture.txt"));
        }
        
        public List<string> giveScripture()
        {
            return scripture;
        }

        public void DisplayVerses()
        {
            Console.WriteLine($"\n{reference}");
            foreach (Verse verse in verses)
            {
                verse.DisplayVerse();
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private void SeparateVerses()
        {
            string[] split = text.Split("\n", StringSplitOptions.RemoveEmptyEntries);

            foreach (string verse in split)
            {
                Verse nextVerse = new Verse(verse);
                verses.Add(nextVerse);
            }
        }
        public void HideWords()
        {
            foreach (Verse verse in verses)
            {
                verse.HideWords();
            }
        }
    }
}