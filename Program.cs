using System.Diagnostics;

namespace backend_oppg_class_inter_met;

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        Console.WriteLine("Enter a calculation");
        Console.WriteLine("Note, this calculator uses postfix notation, ie 1 2 + = 3");
        Console.Write("Input: ");
        string? input = Console.ReadLine();
        Debug.Assert(input != null, "Input must cannot be missing");
        try
        {
            double result = calculator.PostFixCalculate(input);
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException exception)
        {
            Console.WriteLine($"Cannot divide by zero\n{exception}");
            Environment.Exit(-1);
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            Environment.Exit(1);
        }
    }
}
