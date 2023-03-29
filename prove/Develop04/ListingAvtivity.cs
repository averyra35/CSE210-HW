using System;

namespace Activities
{
    class ListingActivity : Activity
    {
        public ListingActivity () { }
        List<string> prompt = new List<string>();
        int timerLength;
        string chosenPrompt;

        public override void Execute()
        {
            Console.WriteLine("Welcome to the Listing Activity.\n\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n");
            Animation();
            SetList();
            Duration();
            Timer();
            GetPrompt();
            DisplayListing();
            Animation();
        }

        public override string GetPrompt()
        {
            Random rdmPrompt = new Random();
            int randomNum = rdmPrompt.Next(1,prompt.Count());
            chosenPrompt = prompt[randomNum];
            return chosenPrompt;
        }

        public override void Duration()
        {
            Console.WriteLine("How much time do you want to have for the activity? ");
            timerLength = int.Parse(Console.ReadLine());
        }

        public override List<string> SetList()
        {
            prompt = new List<string>(System.IO.File.ReadAllLines("listingPrompts.txt"));
            return prompt;
                
        }

        public void DisplayListing()
        {
            Console.WriteLine("Get ready. . .");
            Thread.Sleep(5000);
            Console.WriteLine($"List as many responses you can to the following prompt:\n --- {chosenPrompt} --- \nYou may begin in: ");
            for (int i = 3; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            DateTime time  = DateTime.Now;
            DateTime endTime = time.AddSeconds(timerLength);
            while (time <= endTime)
            {
                time  = DateTime.Now;
                Console.ReadLine();
                if (time >= endTime)
                {
                    Console.WriteLine("\nWell done!!");
                    Thread.Sleep(2000);
                    Console.WriteLine($"You have completed another {timerLength} seconds of the Listing Activity.\n");
                }
            }
        }
    }
}