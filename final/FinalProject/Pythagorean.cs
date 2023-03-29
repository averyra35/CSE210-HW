using System;

namespace EquationSolver
{
    class Pythagorean : Complex
    {
        double a = 0;
        double b = 0;
        double answer = 0;
        public Pythagorean (){}
        
        public override void Variables ()
        {
            Console.WriteLine("What is the a value? ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("What is your b value? ");
            b = double.Parse(Console.ReadLine());
        }
        
        public double PythagoreanSolver ()
        {
            answer = Math.Sqrt(a * a + b * b);
            return answer;
        }

        public override void Execute()
        {
            Console.WriteLine("  --  You have selected Quadratic:  --  \n");
            Variables();
            PythagoreanSolver();
            Console.WriteLine($" \nYour c value is: {PythagoreanSolver()} \n");
        }
    }
}