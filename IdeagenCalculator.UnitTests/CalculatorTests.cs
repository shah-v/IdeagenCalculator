using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IdeagenCalculator.UnitTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Calculate_Add()
        {
            // Arrange
            Calculator calculator = new Calculator();
            string input = "1 + 1";
            string input2 = "1 + 2 + 3";
            string input3 = "11 + 23";
            double expectedResult = 2;
            double expectedResult2 = 6;
            double expectedResult3 = 34;

            // Act
            double result = calculator.Calculate(input);
            double result2 = calculator.Calculate(input2);
            double result3 = calculator.Calculate(input3);

            // Assert
            Assert.AreEqual(expectedResult, result);
            Assert.AreEqual(expectedResult2, result2);
            Assert.AreEqual(expectedResult3, result3);
        }

        [TestMethod]
        public void Calculate_AddDecimals()
        {
            // Arrange
            Calculator calculator = new Calculator();
            string input = "11.1 + 23";
            double expectedResult = 34.1;

            // Act
            double result = calculator.Calculate(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Calculate_AddNegativeNumber()
        {
            // Arrange
            Calculator calculator = new Calculator();
            string input = "-10 + 20";
            double expectedResult = 10;

            // Act
            double result = calculator.Calculate(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Calculate_AddWithBracket()
        {
            // Arrange
            Calculator calculator = new Calculator();
            string input = "( 11.5 + 15.4 ) + 10.1";
            double expectedResult = 37;

            // Act
            double result = calculator.Calculate(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Calculate_Substract()
        {
            // Arrange
            Calculator calculator = new Calculator();
            string input = "1 - 1";
            double expectedResult = 0;

            // Act
            double result = calculator.Calculate(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Calculate_SubstractDecimals()
        {
            // Arrange
            Calculator calculator = new Calculator();
            string input = "33.5432 - 12.3";
            double expectedResult = 21.2432;

            // Act
            double result = calculator.Calculate(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Calculate_SubstractDecimals_ReturnNegativeNumber()
        {
            // Arrange
            Calculator calculator = new Calculator();
            string input = "11.1 - 23";
            double expectedResult = -11.9;

            // Act
            double result = calculator.Calculate(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        
        [TestMethod]
        public void Calculate_SubstractWithBracket()
        {
            // Arrange
            Calculator calculator = new Calculator();
            string input = "23 - ( 29.3 - 12.5 )";
            double expectedResult = 6.2;

            // Act
            double result = calculator.Calculate(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Calculate_Multiply()
        {
            // Arrange
            Calculator calculator = new Calculator();
            string input = "2 * 2";
            double expectedResult = 4;

            // Act
            double result = calculator.Calculate(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Calculate_MultiplyAdd()
        {
            // Arrange
            Calculator calculator = new Calculator();
            string input = "1 + 1 * 3";
            double expectedResult = 4;

            // Act
            double result = calculator.Calculate(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Calculate_MultiplyWithSubstract()
        {
            // Arrange
            Calculator calculator = new Calculator();
            string input = "11 - 3 * 3";
            double expectedResult = 2;

            // Act
            double result = calculator.Calculate(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Calculate_MultiplyDecimals()
        {
            // Arrange
            Calculator calculator = new Calculator();
            string input = "40.34 * 3.444";
            double expectedResult = 138.93096;

            // Act
            double result = calculator.Calculate(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Calculate_MultiplyWithBracket()
        {
            // Arrange
            Calculator calculator = new Calculator();
            string input = "3 * ( 3.2 - 1 )";
            double expectedResult = 6.6;

            // Act
            double result = calculator.Calculate(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Calculate_Divide()
        {
            // Arrange
            Calculator calculator = new Calculator();
            string input = "6 / 2";
            double expectedResult = 3;

            // Act
            double result = calculator.Calculate(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Calculate_DivideAdd()
        {
            // Arrange
            Calculator calculator = new Calculator();
            string input = "10 + 3 / 3";
            double expectedResult = 11;

            // Act
            double result = calculator.Calculate(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Calculate_DivideWithSubstract()
        {
            // Arrange
            Calculator calculator = new Calculator();
            string input = "15 - 9 / 3";
            double expectedResult = 12;

            // Act
            double result = calculator.Calculate(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Calculate_DivideDecimals()
        {
            // Arrange
            Calculator calculator = new Calculator();
            string input = "7.3 / 5";
            double expectedResult = 1.46;

            // Act
            double result = calculator.Calculate(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Calculate_DivideWithBracket()
        {
            // Arrange
            Calculator calculator = new Calculator();
            string input = "( 1 / 2 ) - 1 + 1";
            double expectedResult = 0.5;

            // Act
            double result = calculator.Calculate(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Calculate_SubstractAdd()
        {
            // Arrange
            Calculator calculator = new Calculator();
            string input = "10 - 5 + 20";
            double expectedResult = 25;

            // Act
            double result = calculator.Calculate(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Calculate_DivideMultiply()
        {
            // Arrange
            Calculator calculator = new Calculator();
            string input = "1 / 10 * 20";
            double expectedResult = 2;

            // Act
            double result = calculator.Calculate(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Calculate_AddSubstractMultiplyDivide()
        {
            // Arrange
            Calculator calculator = new Calculator();
            string input = "5 + 3 - 2 * 10 / 4";
            double expectedResult = 3;

            // Act
            double result = calculator.Calculate(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Calculate_MultiplySubstractDivideAdd()
        {
            // Arrange
            Calculator calculator = new Calculator();
            string input = "3 * 3 - 10 / 2 + 9";
            double expectedResult = 13;

            // Act
            double result = calculator.Calculate(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Calculate_NestedBracket()
        {
            // Arrange
            Calculator calculator = new Calculator();
            string input = "10 - ( 2 + 3 * ( 7 - 5 ) )";
            double expectedResult = 2;

            // Act
            double result = calculator.Calculate(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
