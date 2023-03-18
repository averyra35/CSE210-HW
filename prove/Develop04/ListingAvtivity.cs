using System;

namespace Activities
{
    class ListingActivity : Activity
    {
        public ListingActivity () { }
        List<string> prompt = new List<string>();
        int timerLength;

        public override List<string> SetList()
        {
                List<string> prompt = new List<string>(System.IO.File.ReadAllLines("listingPrompts.txt"));
                return prompt;
                
        }

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

        public override void Execute()
        {
            Console.WriteLine("Welcome to the Listing Activity.\n\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            SetList();
            Duration();
            Timer();
            GetPrompt();
            Animation();
        }
    }
}