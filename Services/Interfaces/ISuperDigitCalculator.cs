namespace SuperDigitoApp.Services.Interfaces;

public interface ISuperDigitCalculator
{
    /// <summary>
    /// Calculates the super digit of a given integer.
    /// </summary>
    /// <param name="x">The input integer.</param>
    /// <returns>The super digit of the input integer.</returns>
    int Calculate(int x);
}