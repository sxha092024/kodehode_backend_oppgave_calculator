using System.Diagnostics;

public class Calculator : ICalculate
{
    public double Add(double lhs, double rhs)
    {
        return lhs + rhs;
    }
    public double Subtract(double lhs, double rhs)
    {
        return lhs - rhs;
    }
    public double Multiply(double lhs, double rhs)
    {
        return lhs * rhs;
    }
    public double Divide(double lhs, double rhs)
    {
        return lhs / rhs;
    }

    /// <summary>
    /// Performs a single calculation on the provided user input.
    /// The user input must be supplied in postfix notation with the desired operator at the end.
    /// </summary>
    /// <param name="input">Postfix notation: lhs rhs operator</param>
    /// <returns>The result of the performed operation</returns>
    /// <exception cref="ArgumentException">Inconvertible numbers or illegal operator placement</exception>
    /// <exception cref="NotImplementedException">Unimplemented postfix operators</exception>
    public double PostFixCalculate(string input)
    {
        double? lhs = null;
        double? rhs = null;
        string[] ops = input.Split(' ');
        foreach (string op in ops)
        {
            switch (op)
            {
                case "+":
                    if (lhs != null && rhs != null) { 
                        Console.WriteLine($"operator: {op}, lhs({lhs}), rhs({rhs})");
                        return Add((double)lhs, (double)rhs);
                    }
                    break;
                case "-":
                    if (lhs != null && rhs != null) { 
                        Console.WriteLine($"operator: {op}, lhs({lhs}), rhs({rhs})");
                        return Subtract((double)lhs, (double)rhs);
                    }
                    break;
                case "*":
                    if (lhs != null && rhs != null) { 
                        Console.WriteLine($"operator: {op}, lhs({lhs}), rhs({rhs})");
                        return Multiply((double)lhs, (double)rhs);
                    }
                    break;
                case "/":
                    if (lhs != null && rhs != null) { 
                        Console.WriteLine($"operator: {op}, lhs({lhs}), rhs({rhs})");
                        if (rhs == 0) {
                            throw new DivideByZeroException();
                        }
                        return Divide((double)lhs, (double)rhs);
                    }
                    break;
                default:
                    if (lhs == null) { 
                        double res;
                        if (double.TryParse(op, out res)) {
                            lhs = res;
                        } else {
                            throw new ArgumentException($"`{op}` cannot be converted to double (lhs)");
                        }
                    }
                    else if (rhs == null) {
                        double res;
                        if (double.TryParse(op, out res)) {
                            rhs = res;
                        } else {
                            throw new ArgumentException($"`{op}` cannot be converted to double (rhs)");
                        }
                     }
                    else {
                    }
                    break;
            }
        }
        throw new NotImplementedException();
    }
}