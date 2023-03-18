using System;

namespace Test1
{
    class BreathingCommand : Command
    {
        public override void Execute()
        {
            Console.WriteLine("This is the Breathing Command.");
        }
    }
}