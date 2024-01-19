namespace TestTechSolution
{

    [TestClass]
    public class NumberProcessorTests
    {
        [TestMethod]
        public void ProcessNumbers_ShouldMultiplyByTwo()
        {
            // Arrange
            var processor = new NumberProcessor();
            var inputNumbers = new List<int> { 1, 2, 3 };

            // Act
            var result = processor.ProcessNumbers(inputNumbers);

            // Assert
            CollectionAssert.AreEqual(new List<int> { 2, 4, 6 }, result);
        }



        [TestMethod]
        public void MultiplyByTwo_ShouldMultiplyInputByTwo()
        {
            // Arrange
            var processor = new NumberProcessor();

            // Act
            var result = InvokePrivateMethod(processor, "MultiplyByTwo", 3);

            // Assert
            Assert.AreEqual(6, result);
        }

        // Helper method to invoke private methods using reflection
        private int InvokePrivateMethod(object instance, string methodName, params object[] parameters)
        {
            var methodInfo = instance.GetType().GetMethod(methodName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            return (int)methodInfo.Invoke(instance, parameters);
        }

    }
}