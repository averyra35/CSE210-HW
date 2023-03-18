using System;

namespace Activities
{
    class ReflectionActivity : Activity
    {
        public ReflectionActivity () { }
        List<string> prompt = new List<string>();
        int timerLength;

        public override string GetPrompt()
        {
            Random rdmPrompt = new Random();
            int randomNum = rdmPrompt.Next(0,prompt.Count);
            string chosenPrompt = prompt[randomNum];
            return chosenPrompt;
        }

        public override int Duration()
        {
            Console.WriteLine("How much time do you want to have for the activity? ");
            timerLength = Console.Read();
            return timerLength;
        }

        public override List<string> SetList()
        {
                List<string> prompt = new List<string>(System.IO.File.ReadAllLines("reflectionPrompts.txt"));
                return prompt;
                
        }
        
        public override void Execute()
        {
            Console.WriteLine("Welcome to the Reflection Activity.\n\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            SetList();
            Duration();
            Timer();
            GetPrompt();
            Animation();
        }
    }
}