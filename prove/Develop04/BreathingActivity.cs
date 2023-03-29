using System;

namespace Activities
{
    class BreathingActivity : Activity
    {
        public BreathingActivity () { }
        private int timerLength = 0;

        public override void Execute()
        {
            Console.WriteLine("Welcome to the Breathing Activity.\n\nThis activity will help you relax by walking you through breathing in and out slowly. clear your mind and focus on your breathing.");
            Animation();
            Duration();
            DisplayBreathing();
            Animation();
        }

        public override void Duration()
        {
            Console.WriteLine("How much time do you want to have for the activity? ");
            timerLength = int.Parse(Console.ReadLine());
        }

        public void DisplayBreathing()
        {
            DateTime time  = DateTime.Now;
            DateTime endTime = time.AddSeconds(timerLength);
            while (time <= endTime)
            {
                Console.WriteLine("Breathe in...");
                for (int i = 4; i > 0; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                Console.WriteLine("Breathe out...\n");
                Thread.Sleep(3000);
                time  = DateTime.Now;
                if (time >= endTime)
                {
                    Console.WriteLine("\nWell done!!");
                    Thread.Sleep(2000);
                    Console.WriteLine($"You have completed another {timerLength} seconds of the Breathing Activity.\n");
                }
            }
        }
    }
}