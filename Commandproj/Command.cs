using System;

namespace Test1
{
    class Command
    {
        public virtual void Execute()
        {
            Console.WriteLine("This is the Breathing Command.");
        }
    }
}