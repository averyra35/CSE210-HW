using System;

namespace Memorizing
{
    public class Output
    {
        private List<string> scripture1;

        public void clearScreen()
        {
            Console.Clear();
        }
        public void showScripture(Scripture s)
        {
                scripture1 = new List<string>(System.IO.File.ReadAllLines("Scripture.txt"));
                foreach (string line in scripture1){Console.WriteLine(line);}
        }
    }
}