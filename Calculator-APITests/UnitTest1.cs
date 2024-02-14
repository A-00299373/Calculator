using CalculatorAPI.Controllers;

namespace Calculator_APITests;

[TestClass]

public class AdditionTests
{

        [TestMethod]
        public void TestAddition_NegativeNumbers()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();
            // decimal num1 = -65165;
            // decimal num2 = -11515;
            // string expectedResult = $"Result: = -76680 \nOperation performed: Addition";

            Random random = new Random();
            decimal num1 = (decimal)random.NextDouble() * -10000; // Generate random decimal between 0 and 10000
            decimal num2 = (decimal)random.NextDouble() * -10000; // Generate random decimal between 0 and 10000

            string expectedResult = $"Result: = {num1 + num2} \nOperation performed: Addition";

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
            // decimal num1 = 157;
            // decimal num2 = -565;
            // string expectedResult = $"Result: = -408 \nOperation performed: Addition";

            Random random = new Random();
            decimal num1 = (decimal)random.NextDouble() * 10000; // Generate random decimal between 0 and 10000
            decimal num2 = (decimal)random.NextDouble() * -10000; // Generate random decimal between 0 and -10000

            string expectedResult = $"Result: = {num1 + num2} \nOperation performed: Addition";

            // Act
            string result = controller.Add(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, result, "Addition of positive and negative numbers is not correct");
        }

        [TestMethod]
        public void TestAddition_ZeroAndNegativeNumber()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();
            // decimal num1 = 0;
            // decimal num2 = -15;
            // string expectedResult = $"Result: = -15 \nOperation performed: Addition";

            Random random = new Random();
            decimal num1 = 0;
            decimal num2 = (decimal)random.NextDouble() * -10000; // Generate random decimal between 0 and -10000

            string expectedResult = $"Result: = {num1 + num2} \nOperation performed: Addition";

            // Act
            string result = controller.Add(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, result, "Addition of Zero and negative number is not correct");

        }

        [TestMethod]
        public void TestAddition_RandomNumbers()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();
            // decimal num1 = 3.5m;
            // decimal num2 = 2.5m;
            // string expectedResult = $"Result: = 6.0 \nOperation performed: Addition";

            Random random = new Random();
            decimal num1 = (decimal)random.NextDouble() * 10000; // Generate random decimal between 0 and 10000
            decimal num2 = (decimal)random.NextDouble() * 10000; // Generate random decimal between 0 and 10000

            string expectedResult = $"Result: = {num1 + num2} \nOperation performed: Addition";

            // Act
            string result = controller.Add(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, result, "Addition of decimal numbers is not correct");
        }

        [TestMethod]
        public void TestAddition_MaximumValues()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();
            decimal num1 = decimal.MaxValue;
            decimal num2 = decimal.MaxValue;
            string expectedResult = "Result: = Overflow \nOperation performed: Addition"; // Expected result when overflow occurs

            // Act
                string result = null;
            try
            {
                result = controller.Add(num1, num2);
            }
            catch (OverflowException)
            {
                result = "Result: = Overflow \nOperation performed: Addition";
            }

            // Assert
            Assert.AreEqual(expectedResult, result, "Addition of maximum values is not correct");
        }
}

[TestClass]
public class SubtractionTests
{
        [TestMethod]
        public void TestSubtraction_PositiveNumbers()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();
            // decimal num1 = 10;
            // decimal num2 = 5;
            // string expectedResult = $"Result: = 5 \nOperation performed: Subtraction";


            Random random = new Random();
            decimal num1 = (decimal)random.NextDouble() * 10000; // Generate random decimal between 0 and 10000
            decimal num2 = (decimal)random.NextDouble() * 10000; // Generate random decimal between 0 and 10000

            string expectedResult = $"Result: = {num1 - num2} \nOperation performed: Subtraction";

            // Act
            string result = controller.Subtract(num1, num2); // Assign the result

            // Assert
            Assert.AreEqual(expectedResult, result, "Subtraction of positive numbers is not correct");
        }

        [TestMethod]
        public void TestSubtraction_ZeroAndNegativeNumbers()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();
            // decimal num1 = 0;
            // decimal num2 = -66612;
            // string expectedResult = $"Result: = 66612 \nOperation performed: Subtraction";


            Random random = new Random();
            decimal num1 = 0;
            decimal num2 = (decimal)random.NextDouble() * 10000; // Generate random decimal between 0 and -10000

            string expectedResult = $"Result: = {num1 - num2} \nOperation performed: Subtraction";

            // Act
            string result = controller.Subtract(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, result, "Subtraction of random numbers between 0 and 10 is not correct");
        }

        [TestMethod]
        public void TestSubtraction_MaximumValues()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();
            decimal num1 = decimal.MaxValue;
            decimal num2 = decimal.MaxValue;
            string expectedResult = $"Result: = { num1 - num2 } \nOperation performed: Subtraction"; 

            // Act

            string result = controller.Subtract(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, result, "Subtraction of maximum values is not correct");
        }

        [TestMethod]
        public void TestSubtraction_NegativeNumbers()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();
            // decimal num1 = -16556;
            // decimal num2 = -5616;
            // string expectedResult = $"Result: = -10940 \nOperation performed: Subtraction";


            Random random = new Random();
            decimal num1 = (decimal)random.NextDouble() * -1000; // Generate random decimal between 0 and 1000
            decimal num2 = (decimal)random.NextDouble() * -1000; // Generate random decimal between 0 and 1000

            string expectedResult = $"Result: = {num1 - num2} \nOperation performed: Subtraction";

            // Act
            string result = controller.Subtract(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, result, "Subtraction of negative numbers is not correct");
        }

        [TestMethod]
        public void TestSubtraction_RandomNumbers()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();
            // decimal num1 = 78.5545m;
            // decimal num2 = 15.545m;
            // string expectedResult = "Result: = 63.0095 \nOperation performed: Subtraction";


            Random random = new Random();
            decimal num1 = (decimal)random.NextDouble() * 10000; // Generate random decimal between 0 and 10000
            decimal num2 = (decimal)random.NextDouble() * 10000; // Generate random decimal between 0 and 10000

            string expectedResult = $"Result: = {num1 - num2} \nOperation performed: Subtraction";


            // Act
            string result = controller.Subtract(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, result, "Subtraction of decimal numbers is not correct");
        }
}

[TestClass]
public class MultiplicationTests
{
        [TestMethod]
        public void TestMultiplication_ZeroAndNegativeNumber()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();
            // decimal num1 = 0;
            // decimal num2 = -10;
            // string expectedResult = "Result: = 0 \nOperation performed: Multiplication";


            Random random = new Random();
            decimal num1 = 0;
            decimal num2 = (decimal)random.NextDouble() * -10000; // Generate random decimal between 0 and -10000

            string expectedResult = $"Result: = { num1 * num2 } \nOperation performed: Multiplication";

            // Act
            string result = controller.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, result, "Multiplication of zero and a negative number is not correct");
        }

        [TestMethod]
        public void TestMultiplication_PositiveAndNegativeNumbers()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();
            // decimal num1 = 5;
            // decimal num2 = -10;
            // string expectedResult = "Result: = -50 \nOperation performed: Multiplication";

            Random random = new Random();
            decimal num1 = (decimal)random.NextDouble() * 10000; // Generate random decimal between 0 and 10000
            decimal num2 = (decimal)random.NextDouble() * -10000; // Generate random decimal between 0 and -10000

            string expectedResult = $"Result: = {num1 * num2} \nOperation performed: Multiplication";

            // Act
            string result = controller.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, result, "Multiplication of positive and negative numbers is not correct");
        }

        [TestMethod]
        public void TestMultiplication_PositiveNumbers()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();
            // decimal num1 = 10;
            // decimal num2 = 5;
            // string expectedResult = "Result: = 50 \nOperation performed: Multiplication";


            Random random = new Random();
            decimal num1 = (decimal)random.NextDouble() * 65465; // Generate random decimal between 0 and 65465
            decimal num2 = (decimal)random.NextDouble() * 16516; // Generate random decimal between 0 and 16516

            string expectedResult = $"Result: = {num1 * num2} \nOperation performed: Multiplication";

            // Act
            string result = controller.Multiply(num1, num2); // Assign the result

            // Assert
            Assert.AreEqual(expectedResult, result, "Multiplication of positive numbers is not correct");
        }

        [TestMethod]
        public void TestMultiplication_RandomNumbers()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();
            // decimal num1 = 45.6545m;
            // decimal num2 = 245.7878m;
            // string expectedResult = "Result: = 11221.31911510 \nOperation performed: Multiplication";


            Random random = new Random();
            decimal num1 = (decimal)random.NextDouble() * 10000; // Generate random decimal between 0 and 10000
            decimal num2 = (decimal)random.NextDouble() * 10000; // Generate random decimal between 0 and 10000

            string expectedResult = $"Result: = {num1 * num2} \nOperation performed: Multiplication";

            // Act
            string result = controller.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, result, "Multiplication of decimal numbers is not correct");
        }

        [TestMethod]
        public void TestMultiplication_MaximumValues()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();
            decimal num1 = decimal.MaxValue;
            decimal num2 = decimal.MaxValue;
            string expectedResult = "Result: = Overflow \nOperation performed: Multiplication"; // Expected result when overflow occurs

            // Act
            string result = null;
            try
            {
                result = controller.Multiply(num1, num2);
            }
            catch (OverflowException)
            {
                result = "Result: = Overflow \nOperation performed: Multiplication";
            }

            // Assert
            Assert.AreEqual(expectedResult, result, "Multiplication of maximum values is not correct");
        }
}

[TestClass]
public class DividisionTests
{
    [TestMethod]
    public void TestDivision_PositiveNumbers()
    {
        // Arrange
        CalculatorController controller = new CalculatorController();
        // decimal num1 = 10;
        // decimal num2 = 2;
        // string expectedResult = "Result: = 5 \nOperation performed: Division";


        Random random = new Random();
        decimal num1 = (decimal)random.NextDouble() * 10000; // Generate random decimal between 0 and 10000
        decimal num2 = (decimal)random.NextDouble() * 10000; // Generate random decimal between 0 and 10000
        string expectedResult = $"Result: = { num1 / num2 } \nOperation performed: Division";

        // Act
        string result = controller.Divide(num1, num2);

        // Assert
        Assert.AreEqual(expectedResult, result, "Division of two positive numbers is not correct");
    }

    [TestMethod]
    public void TestDivision_NegativeNumbers()
    {
        // Arrange
        CalculatorController controller = new CalculatorController();
        // decimal num1 = -168460;
        // decimal num2 = -5455152;
        // string expectedResult = "Result: = 0.0308808993773225750629863293 \nOperation performed: Division";


        Random random = new Random();
        decimal num1 = (decimal)random.NextDouble() * -10000; // Generate random decimal between 0 and -10000
        decimal num2 = (decimal)random.NextDouble() * -10000; // Generate random decimal between 0 and -10000
        string expectedResult = $"Result: = { num1 / num2 } \nOperation performed: Division";

        // Act
        string result = controller.Divide(num1, num2);

        // Assert
        Assert.AreEqual(expectedResult, result, "Division of two negative numbers is not correct");
    }

    [TestMethod]
        public void TestDivision_ByZero()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();
            // decimal num1 = 10;
            // decimal num2 = 0;
            // string expectedResult = "Cannot divide by zero.";


            Random random = new Random();
            decimal num1 = (decimal)random.NextDouble() * 10000; // Generate random decimal between 0 and 10000
            decimal num2 = 0;
            string expectedResult = "Cannot divide by zero.";

            // Act
            string result = controller.Divide(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, result, "Division is not performed because any number 'Cannot divide by zero.'");
        }

    [TestMethod]
        public void TestDivision_MaximumValues()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();
            decimal num1 = decimal.MaxValue;
            decimal num2 = decimal.MaxValue;
            string expectedResult = $"Result: = { num1 / num2 } \nOperation performed: Division"; // Expected result when dividing maximum value by a finite number

            // Act
            string result = controller.Divide(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, result, "Division of maximum values is not correct");
        }

        [TestMethod]
        public void TestDivision_ZeroAndNegativeNumber()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();
            // decimal num1 = 0;
            // decimal num2 = -10;
            // string expectedResult = $"Result: = 0 \nOperation performed: Division";


            Random random = new Random();
            decimal num1 = 0;
            decimal num2 = (decimal)random.NextDouble() * -10000; // Generate random decimal between 0 and -10000
            string expectedResult = $"Result: = { num1 / num2 } \nOperation performed: Division";

            // Act
            string result = controller.Divide(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, result, "Division of zero and a negative number is not correct");
        }
}