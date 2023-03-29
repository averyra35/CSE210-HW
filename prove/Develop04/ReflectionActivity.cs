using System;

namespace Activities
{
    class ReflectionActivity : Activity
    {
        public ReflectionActivity () { }
        List<string> prompt = new List<string>();
        List<string> questions = new List<string>();
        int timerLength;
        string chosenPrompt;
        string chosenQuestion;

        public override void Execute()
        {
            Console.WriteLine("Welcome to the Reflection Activity.\n\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n");
            Animation();
            SetList();
            Duration();
            Timer();
            GetPrompt();
            SetList2();
            GetPrompt2();
            DisplayReflection();
            Animation();
        }

        public override string GetPrompt()
        {
            Random rdmPrompt = new Random();
            int randomNum = rdmPrompt.Next(0,prompt.Count());
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
            prompt = new List<string>(System.IO.File.ReadAllLines("reflectionPrompts.txt"));
            return prompt;
        }

        public List<string> SetList2()
        {
            questions = new List<string>(System.IO.File.ReadAllLines("reflectOnQuestions.txt"));
            return questions;
        }
        
        public string GetPrompt2()
        {
            Random rdmPrompt = new Random();
            int randomNum = rdmPrompt.Next(0,questions.Count());
            chosenQuestion = questions[randomNum];
            return chosenQuestion;
        }
        
        public void DisplayReflection()
        {
            Console.WriteLine("Get ready. . .");
            Animation();
            Console.WriteLine($"Consider the following prompt:\n --- {chosenPrompt} --- \nWhen you have something in mind, press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.\nYou may begin in: ");
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
                Console.WriteLine(chosenQuestion);
                GetPrompt2();
                Animation();
                if (time >= endTime)
                {
                    Console.WriteLine("\nWell done!!");
                    Thread.Sleep(2000);
                    Console.WriteLine($"You have completed another {timerLength} seconds of the Reflecting Activity.\n");
                }
            }
        }
    }
}