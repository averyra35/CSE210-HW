using System;

namespace Test1
{
    class ReflectingCommand : Command
    {
        public override void Execute()
        {
            Console.WriteLine("This is the Reflecting Command.");
        }
    }
}