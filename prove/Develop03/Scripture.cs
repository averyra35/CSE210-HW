using System;
using System.IO;
using System.Collections.Generic;

namespace Memorizing
{
    public class Scripture
    {
        private List<string> _scripture = new List<string>();
        private string reference = "";
        private string text = "";
        private List<Verse> verses = new List<Verse>();

        public Scripture ()
        {
            setScripture();
            string[] scriptureVerses = string.Join(" ", _scripture).Split("|", StringSplitOptions.RemoveEmptyEntries);
            reference = scriptureVerses[0];
            text = scriptureVerses[1].Replace(" $ ", "\n");
            SeparateVerses();
        }

        public void setScripture()
        {
            _scripture = new List<string>(System.IO.File.ReadAllLines("Scripture.txt"));
        }
        
        public string giveScripture()
        {
            return reference + text;
        }

        public string GetVerses()
        {
            string scriptureText = "";
            foreach (Verse verse in verses)
            {
                scriptureText += verse.DisplayVerse() + "\n";
            }
            return reference + "\n" + scriptureText;
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

        public bool CheckCompletion()
        {
            string s = GetVerses().Replace(reference, "").Replace("_", "").Replace(" ", "").Replace("\n", "");
            Console.WriteLine(s);
            if (s == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}