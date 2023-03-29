using System;

namespace Activities
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Activity> activities = new Dictionary<string, Activity>();
            Activity a = new Activity();
            Activity l = new ListingActivity();
            Activity r = new ReflectionActivity();
            Activity b = new BreathingActivity();
            activities["1"] = b;
            activities["2"] = r;
            activities["3"] = l;
            string choice = "";

            while (choice != "4")
            {
                Console.WriteLine("Menu Options:\n  1. Breathing Activity\n  2. Reflection Activity\n  3. Listing Activity\n");
                choice = Console.ReadLine();
                activities[choice].Execute();
            }
        }
    }
}