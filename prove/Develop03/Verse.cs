using System;
using System.Collections.Generic;

namespace Memorizing
{
    public class Verse
    {
        private string _verse;
        private List<Words> words = new List<Words>();
        private List<int> indexes = new List<int>();

        public Verse(string verse)
        {
            _verse = verse;
            GetWords();
        }

        private void GetWords()
        {
            string[] splitWords = _verse.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in splitWords)
            {
                Words newWord = new Words(word);
                words.Add(newWord);
            }
        }

        public void DisplayVerse()
        {
            foreach (Words word in words)
            {
                word.DisplayWord();
                Console.Write(" ");
            }
        }

        private int GetRandomIndex(int maximum)
        {
            Random random = new Random();
            int index = random.Next(0, maximum);
            while (indexes.Contains(index))
            {
                index = random.Next(0, maximum);
            }
            indexes.Add(index);
            return index;
        }
        
        public void HideWords()
        {
            int amountToHide = 4;

            if (words.Count == indexes.Count)
            {
                return;
            }
            else if (words.Count - 4 <= indexes.Count)
            {
                amountToHide = words.Count - indexes.Count;
            }

            for (int i = 0; i < amountToHide; i++)
            {
                words[GetRandomIndex(words.Count)].HideWord();
            }
        }
    }
}