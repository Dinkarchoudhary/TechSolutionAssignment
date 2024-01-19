namespace TestTechSolution
{
    /// <summary>
    /// Test class for the <see cref="NumberProcessor"/> class.
    /// </summary>
    [TestClass]
    public class NumberProcessorTests
    {
        /// <summary>
        /// Tests the <see cref="NumberProcessor.ProcessNumbers"/> method to ensure it multiplies each number by two.
        /// </summary>
        [TestMethod]
        public void ProcessNumbers_ShouldMultiplyEachNumberByTwo()
        {
            // Arrange
            var numberProcessor = new NumberProcessor();
            var inputNumbers = new List<int> { 1, 2, 3 };

            // Act
            var resultNumbers = numberProcessor.ProcessNumbers(inputNumbers);

            // Assert
            CollectionAssert.AreEqual(new List<int> { 2, 4, 6 }, resultNumbers);
        }

        /// <summary>
        /// Tests the private method <see cref="NumberProcessor.MultiplyByTwo"/> indirectly by invoking it through reflection.
        /// Ensures that it correctly multiplies the input number by two.
        /// </summary>
        [TestMethod]
        public void MultiplyByTwo_ShouldMultiplyInputByTwo()
        {
            // Arrange
            var numberProcessor = new NumberProcessor();

            // Act
            var result = PrivateMethodInvoker.InvokePrivateMethod<int>(numberProcessor, "MultiplyByTwo", 3);

            // Assert
            Assert.AreEqual(6, result);
        }

    }
}