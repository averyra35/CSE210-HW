using System;
using System.Collections.Generic;

namespace Memorizing
{
    public class Verse
    {
        private string _verse;
        private List<Word> words = new List<Word>();
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
                Word newWord = new Word(word);
                words.Add(newWord);
            }
        }

        public string DisplayVerse()
        {
            string text = "";
            foreach (Word word in words)
            {
                text += word.DisplayWord() + " ";
            }
            return text;
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
            int amountToHide = 2;

            if (words.Count() == indexes.Count())
            {
                return;
            }
            else if (words.Count() - 2 <= indexes.Count())
            {
                amountToHide = words.Count() - indexes.Count();
            }

            for (int i = 0; i < amountToHide; i++)
            {
                words[GetRandomIndex(words.Count())].HideWord();
            }
        }
    }
}