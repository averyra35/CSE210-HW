using System;
using System.Diagnostics;

namespace EquationSolver
{
    class Equations : Program
    {
        public Equations (){}
        
        public virtual void Variables ()
        {        }

        public virtual void Execute ()
        {
            throw new Exception("method not implemented in the base class");
        }
        public override void Menu ()
        {
            Equations e = new Equations();
            Equations s = new Simple();
            Equations c = new Complex();
            Dictionary<string, Equations> EquationChoices = new Dictionary<string, Equations>();
            EquationChoices["1"] = s;
            EquationChoices["2"] = c;
            string choice = "";

            while (choice != "3")
            {
                Console.WriteLine("Menu Options:\n  1. Simple Problem\n  2. Complex Problem\n  3. Quit\n");
                choice = Console.ReadLine();
                EquationChoices[choice].Menu();
            }
        }
    }
}