using System;

namespace EquationSolver
{
    class Complex : Equations
    {
        public Complex (){}

        public override void Menu ()
        {
            Equations e = new Equations();
            Complex s = new Complex();
            Complex p = new Pythagorean();
            Complex q = new Quadratic();
            Dictionary<string, Complex> ComplexChoices = new Dictionary<string, Complex>();
            ComplexChoices["1"] = p;
            ComplexChoices["2"] = q;
            string choice = "";

            while (choice != "4")
            {
                Console.WriteLine("Menu Options:\n  1. Pythagorean Problem\n  2. Quadratic Problem\n  3. Back\n");
                choice = Console.ReadLine();
                if (choice == "3")
                {
                    e.Menu();
                }
                ComplexChoices[choice].Execute();
            }
        }
    }
}