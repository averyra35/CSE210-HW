using System;
using System.Collections.Generic;

namespace Test1
{
    class ListingCommand : Command
    {
        public override void Execute()
        {
            Console.WriteLine("This is the Listing Command.");
        }
    }
}