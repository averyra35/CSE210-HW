public class Resume
{
    public List<string> jobs = new List<string>();
    public string _name = "";
    public void displayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
    }
}