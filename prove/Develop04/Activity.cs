using System;
using System.Diagnostics;

namespace Activities
{
    class Activity
    {
        List<string> _prompt = new List<string>();
        private int _timerLength = 0;
        string chosenPrompt = "";

        public Activity (){}
        
        public virtual void Execute()
        {
            throw new Exception("method not implemented in the base class");
        }

        public virtual List<string> SetList()
        {
            return _prompt;
        }

        public virtual string GetPrompt()
        {
            return chosenPrompt;
        }

        public virtual void Duration()
        { }

        public void Timer()
        {
            for (int i = _timerLength; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
                Console.Write("\b\b  \b");
            }
        }

        public void Animation()
        {     
            List<string> animation = new List<string>();
            animation.Add("|");
            animation.Add("/");
            animation.Add("-");
            animation.Add("\\");
            animation.Add("|");
            animation.Add("/");
            animation.Add("-");
            animation.Add("\\");
            
                DateTime startTime = DateTime.Now;
                DateTime endingTime = startTime.AddSeconds(5);

                int i = 0;
                while (DateTime.Now < endingTime)
                {
                    string s = animation[i];
                    Console.Write(s);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");

                    i++;

                    if (i >= animation.Count)
                    {
                        i = 0;
                    }
                }
        }
    }
}