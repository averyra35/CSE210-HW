using System;

namespace EquationSolver
{
    class Simple : Equations
    {
        public Simple (){}

        public override void Menu ()
        {
            Equations e = new Equations();
            Simple s = new Simple();
            Simple a = new Addition();
            Simple sub = new Subtraction();
            Simple av = new AbsoluteValue();
            Dictionary<string, Simple> SimpleChoices = new Dictionary<string, Simple>();
            SimpleChoices["1"] = a;
            SimpleChoices["2"] = sub;
            SimpleChoices["3"] = av;
            string choice = "";
            while (choice != "5")
            {
                Console.WriteLine("Menu Options:\n  1. Addition Problem\n  2. Subtraction Problem\n  3. Absolute Value\n  4. Back\n");
                choice = Console.ReadLine();
                if (choice == "4")
                {
                    e.Menu();
                }
                SimpleChoices[choice].Execute();
            }
        }
    }
}