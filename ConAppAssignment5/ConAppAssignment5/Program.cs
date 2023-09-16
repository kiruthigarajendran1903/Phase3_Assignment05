using ConAppAssignment5;

public class Program
{
    public static void Main(String[] args)
    {
        Calc cal = new Calc();
        Console.WriteLine("Arithmetic Operations");
        Console.WriteLine("Add two numbers");

        Console.WriteLine("Result: " + cal.Add(12, 12));

        Console.WriteLine("Arithmetic Operations");
        Console.WriteLine("Subtract two numbers");

        Console.WriteLine("Result: " + cal.Sub(12, 12));

        Console.WriteLine("Arithmetic Operations");
        Console.WriteLine("Multiply two numbers");

        Console.WriteLine("Result: " + cal.Mul(12, 12));

        Console.WriteLine("Arithmetic Operations");
        Console.WriteLine("Divide two numbers");

        Console.WriteLine("Result: " + cal.Div(12, 12));
    }
}