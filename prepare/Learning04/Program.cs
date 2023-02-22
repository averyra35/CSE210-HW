using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a = new Assignment("Avery Anderson", "Long Division");
        Console.WriteLine(a.GetSummary());

        MathAssignment m = new MathAssignment("Hailey Anderson", "Multiplication", "8.4", "11-20");
        Console.WriteLine(m.GetSummary());
        Console.WriteLine(m.GetHomeworkList());

        WritingAssignment w = new WritingAssignment("Colt Anderson", "Cultures Around the World", "The Middle East");
        Console.WriteLine(w.GetSummary());
        Console.WriteLine(w.GetWritingInformation());
    }
}