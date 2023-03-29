using System;

namespace EquationSolver
{
    class Addition : Simple
    {
        int x = 0;
        int y = 0;
        int answer = 0;
        
        public Addition (){}

        public override void Variables ()
        {
            Console.WriteLine("What is your first number? ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your second number? ");
            y = int.Parse(Console.ReadLine());
        }
        
        public int Add ()
        {
            answer = x + y;
            return answer;
        }

        public override void Execute()
        {
            Console.WriteLine("  --  You have selected Addition:  --  \n");
            Variables();
            Add();
            Console.WriteLine($" \nThe answer is: {Add()} \n");
        }
    }
}