public interface ICalculate
{
    /// <summary>
    /// Performs an addition operation
    /// </summary>
    /// <param name="lhs"></param>
    /// <param name="rhs"></param>
    /// <returns>The result of adding the left hand side to the right hand side</returns>
    public double Add(double lhs, double rhs);
    /// <summary>
    /// Performs a subtraction operation
    /// </summary>
    /// <param name="lhs"></param>
    /// <param name="rhs"></param>
    /// <returns>The result of subtracting the right hand side from the left hand side</returns>
    public double Subtract(double lhs, double rhs);
    /// <summary>
    /// Performs a multiplying operation
    /// </summary>
    /// <param name="lhs"></param>
    /// <param name="rhs"></param>
    /// <returns>The result of multiplying the left hand side by the right hand side</returns>
    public double Multiply(double lhs, double rhs);
    /// <summary>
    /// Performs a dividing operation
    /// </summary>
    /// <param name="lhs"></param>
    /// <param name="rhs">Denominator, also known as the divisor. Cannot be equal to 0</param>
    /// <returns>The result of dividing the left hand side by the right hand side</returns>
    public double Divide(double lhs, double rhs);
}