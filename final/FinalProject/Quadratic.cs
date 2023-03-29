using System;

namespace EquationSolver
{
    class Quadratic : Complex
    {
        double a = 0;
        double b = 0;
        double c = 0;
        double posAnswer = 0;
        double negAnswer = 0;
        public Quadratic (){}

        public override void Variables ()
        {
            Console.WriteLine("What is the a value? ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("What is your b value? ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("What is your c value? ");
            c = double.Parse(Console.ReadLine());
        }
        
        public double[] QuadraticSolver ()
        {
            posAnswer = ((-b + (double) (Math.Sqrt((b * b) - (4 * a * c)))) / (2 * a));
            negAnswer = ((-Math.Abs(b) - (double) (Math.Sqrt((b * b) - (4 * a * c)))) / (2 * a));
            double[] answers = {posAnswer, negAnswer};
            return (answers);
        }

        public override void Execute()
        {
            Console.WriteLine("  --  You have selected Quadratic:  --  \n");
            Variables();
            double[] answers = QuadraticSolver();
            Console.WriteLine($" \nThe positive answer is: {answers[0]} \nThe negative answer is: {answers[1]} \n");
        }
    }
}