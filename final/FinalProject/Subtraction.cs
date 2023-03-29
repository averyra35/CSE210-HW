using System;

namespace EquationSolver
{
    class Subtraction : Simple
    {
        int x = 0;
        int y = 0;
        int answer = 0;
        
        public Subtraction (){}

        public override void Variables ()
        {
            Console.WriteLine("What is your first number? ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your second number? ");
            y = int.Parse(Console.ReadLine());
        }
        
        public int Minus ()
        {
            answer = x - y;
            return answer;
        }

        public override void Execute()
        {
            Console.WriteLine("  --  You have selected Subtraction:  --  \n");
            Variables();
            Minus();
            Console.WriteLine($" \nThe answer is: {Minus()} \n");
        }
    }
}