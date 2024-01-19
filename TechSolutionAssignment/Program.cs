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
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var processor = new NumberProcessor();
        var result = processor.ProcessNumbers(numbers);
        Console.WriteLine(string.Join(", ", result));
    }
}
