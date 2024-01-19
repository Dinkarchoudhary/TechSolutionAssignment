using System;
using System.Collections.Generic;

/// <summary>
/// Represents the entry point of the program.
/// </summary>
public class Program
{
    /// <summary>
    /// The main method of the program.
    /// </summary>
    /// <param name="args">Command-line arguments.</param>
    public static void Main(string[] args)
    {
        var inputNumbers = new List<int> { 1, 2, 3, 4, 5 };
        var numberProcessor = new NumberProcessor();
        var processedNumbers = numberProcessor.ProcessNumbers(inputNumbers);
        Console.WriteLine($"Processed Numbers: {string.Join(", ", processedNumbers)}");
    }
}
