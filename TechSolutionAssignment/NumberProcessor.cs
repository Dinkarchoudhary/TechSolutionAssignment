/// <summary>
/// Represents a class for processing numbers.
/// </summary>
public class NumberProcessor
{
    /// <summary>
    /// Processes a list of numbers by multiplying each number by two.
    /// </summary>
    /// <param name="inputNumbers">The input list of numbers.</param>
    /// <returns>A new list containing the processed numbers.</returns>
    public List<int> ProcessNumbers(List<int> inputNumbers)
    {
        List<int> resultNumbers = new List<int>();

        foreach (var number in inputNumbers)
        {
            resultNumbers.Add(MultiplyByTwo(number));
        }

        return resultNumbers;
    }

    /// <summary>
    /// Multiplies a number by two.
    /// </summary>
    /// <param name="number">The input number.</param>
    /// <returns>The result of multiplying the input number by two.</returns>
    private int MultiplyByTwo(int number)
    {
        return number * 2;
    }
}