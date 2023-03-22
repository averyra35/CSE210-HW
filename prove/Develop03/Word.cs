using System;

namespace Memorizing
{
    public class Word
    {
        private string _word;
        private string hiddenWord = "";
        private bool isHidden = false;

        public Word(string word)
        {
            _word = word;
            GetHiddenWord();
        }

        private void GetHiddenWord()
        {
            foreach (char letter in _word)
            {
                if (letter !='.' || letter !='!' || letter !='?' || letter !=',' || letter !=':' || letter !=';')
                {
                    hiddenWord += "_";
                }
                else
                {
                    hiddenWord += letter;
                     
                }
            }
        }

        public string DisplayWord()
        {
            return (isHidden) ? hiddenWord : _word;
        }

        public void HideWord()
        {
            isHidden = true;
        }

        public void ShowWord()
        {
            isHidden = false;
        }
    }
}