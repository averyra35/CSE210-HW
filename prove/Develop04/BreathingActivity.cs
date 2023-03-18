using System;

namespace Activities
{
    class BreathingActivity : Activity
    {
        public BreathingActivity () { }
        List<string> prompt = new List<string>();
        int timerLength;

        public override void Execute()
        {
            Console.WriteLine("Welcome to the Breathing Activity.\n\nThis activity will help you relax by walking you through breathing in and out slowly. clear your mind and focus on your breathing.");
            SetList();
            Duration();
            Timer();
            GetPrompt();
            Animation();
        }

        public override int Duration()
        {
            Console.WriteLine("How much time do you want to have for the activity? ");
            timerLength = Console.Read();
            return timerLength;
        }

        public void DisplayBreathing()
        {
            Console.WriteLine("Breathe in...");
            for (int i = 4; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");

            }
            Console.WriteLine("Breathe out...");
        }
    }
}