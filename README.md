# TechSolutionAssignment
# TestTechSolution

TestTechSolution is a simple C# project that demonstrates a NumberProcessor class for processing numbers. It includes a utility class for invoking private methods using reflection and a set of unit tests.

## Overview

- [NumberProcessor](#numberprocessor)
- [Program](#program)
- [NumberProcessorTests](#numberprocessortests)
- [PrivateMethodInvoker](#privatemethodinvoker)

## NumberProcessor

### Represents a class for processing numbers.

- **Methods:**
  - `ProcessNumbers(List<int> inputNumbers): List<int>`
    - Processes a list of numbers by multiplying each number by two.

  - `private int MultiplyByTwo(int number)`
    - Multiplies a number by two.

## Program

### Represents the entry point of the program.

- **Methods:**
  - `Main(string[] args)`
    - The main method of the program.

## NumberProcessorTests

### Test class for the NumberProcessor class.

- **Test Methods:**
  - `ProcessNumbers_ShouldMultiplyEachNumberByTwo()`
    - Tests the ProcessNumbers method to ensure it multiplies each number by two.

  - `MultiplyByTwo_ShouldMultiplyInputByTwo()`
    - Tests the private method MultiplyByTwo indirectly by invoking it through reflection.

## PrivateMethodInvoker

### Utility class for invoking private methods using reflection.

- **Methods:**
  - `InvokePrivateMethod<T>(object instance, string methodName, params object[] parameters): T`
    - Invokes a private method on the specified instance using reflection.

## Getting Started

1. Clone the repository.
2. Open the project in your preferred C# development environment.
3. Build and run the project.

## Usage

- Modify the `inputNumbers` list in the `Main` method of `Program` to process different numbers.
- Explore the functionality of the `NumberProcessor` class.

## Unit Testing

- Run the unit tests in the `NumberProcessorTests` class to verify the correctness of the code.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
