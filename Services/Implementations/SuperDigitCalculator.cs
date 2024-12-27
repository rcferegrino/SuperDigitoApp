using SuperDigitoApp.Services.Interfaces;

namespace SuperDigitoApp.Services.Implementations;

public class SuperDigitCalculator : ISuperDigitCalculator
{
    /// <summary>
    /// Calculates the super digit of a given integer.
    /// </summary>
    /// <param name="x">The input integer.</param>
    /// <returns>The super digit of the input integer.</returns>
    public int Calculate(int x)
    {
        while (true)
        {
            if (x is >= 0 and <= 9) return x;

            var digitSum = 0;
            while (x > 0)
            {
                digitSum += x % 10;
                x /= 10;
            }

            x = digitSum;
        }
    }
}