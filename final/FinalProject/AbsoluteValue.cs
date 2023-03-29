using System;

namespace EquationSolver
{
    class AbsoluteValue : Simple
    {
        int x = 0;
        int answer = 0;

        public AbsoluteValue (){}
        public override void Variables ()
        {
            Console.WriteLine("What is your number? ");
            x = int.Parse(Console.ReadLine());
        }
        

        public  int Absolute()
        {
            answer = Math.Abs(x);
            return answer;
        }

        public override void Execute()
        {
            Console.WriteLine("  --  You have selected Absolute Value:  --  \n");
            Variables();
            Absolute();
            Console.WriteLine($" \nThe answer is: {Absolute()} \n");
        }
    }
}