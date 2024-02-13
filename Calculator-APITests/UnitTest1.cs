using CalculatorAPI.Controllers;

namespace Calculator_APITests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestAddition_PositiveNumbers()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();
            decimal num1 = 5;
            decimal num2 = 10;
            string expectedResult = "Result: = 15 \nOperation performed: Addition";

            // Act
            string result = controller.Add(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, result, "Addition of positive numbers is not correct");
        }

        [TestMethod]
        public void TestAddition_NegativeNumbers()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();
            decimal num1 = -5;
            decimal num2 = -10;
            string expectedResult = "Result: = -15 \nOperation performed: Addition";

            // Act
            string result = controller.Add(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, result, "Addition of negative numbers is not correct");
        }

        [TestMethod]
        public void TestAddition_PositiveAndNegativeNumbers()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();
            decimal num1 = 10;
            decimal num2 = -5;
            string expectedResult = "Result: = 5 \nOperation performed: Addition";

            // Act
            string result = controller.Add(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, result, "Addition of positive and negative numbers is not correct");
        }

        [TestMethod]
        public void TestAddition_ZeroAndPositiveNumber()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();
            decimal num1 = 0;
            decimal num2 = 10;
            string expectedResult = "Result: = 10 \nOperation performed: Addition";

            // Act
            string result = controller.Add(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, result, "Addition of zero and positive number is not correct");
        }

        [TestMethod]
        public void TestAddition_ZeroAndNegativeNumber()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();
            decimal num1 = 0;
            decimal num2 = -10;
            string expectedResult = "Result: = -10 \nOperation performed: Addition";

            // Act
            string result = controller.Add(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, result, "Addition of zero and negative number is not correct");
        }
}