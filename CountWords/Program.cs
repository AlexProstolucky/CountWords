using System.Reflection.Emit;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hi write the text:");
        string buf = Console.ReadLine();
        buf = buf.Replace("-", "");
        while (buf.StartsWith(" "))
        {
            buf = buf.Remove(0, 1);
        }
        while (buf.EndsWith(" "))
        {
            buf = buf.Remove(buf.Length - 1);
        }
        buf = buf.Replace("   ", " ");
        buf = buf.Replace("  ", " ");
        Console.WriteLine(System.Convert.ToString(buf.Count(s => s == ' ') + 1));
    }
}