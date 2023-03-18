using System;

namespace Memorizing
{
    public class Words
    {
        private string _word;
        private string hiddenWord = "";
        private bool isHidden = false;

        public Words(string word)
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

        public void DisplayWord()
        {
            if (isHidden)
            {
                Console.Write(hiddenWord);
            }
            else
            {
                Console.Write(_word);
            }
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