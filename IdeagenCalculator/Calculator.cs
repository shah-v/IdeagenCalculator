using System;
namespace IdeagenCalculator
{
    public class Calculator
    {
        public double Calculate(string sum)
        {
            _ = Decimal.TryParse(sum, out decimal result);

            string[] splitSum = sum.Split(' ');

            // Do things in parentheses first
            int indexOpenBracket = Array.LastIndexOf(splitSum, "(");
            if (indexOpenBracket > -1)
            {
                int indexCloseBracket = Array.IndexOf(splitSum, ")", indexOpenBracket);
                string insideBracket = "";

                for (int i = indexOpenBracket + 1; i < indexCloseBracket; i++)
                {
                    string space = i + 1 < indexCloseBracket ? " " : "";
                    insideBracket += splitSum[i] + space;
                }

                decimal bracketResult = (decimal) Calculate(insideBracket);
                string currOperation = "( " + insideBracket + " )";
                string newSum = sum.Replace(currOperation, bracketResult.ToString());

                return Calculate(newSum);
            }

            int indexMultiply = Array.IndexOf(splitSum, "*");
            int indexDivide = Array.IndexOf(splitSum, "/");

            // Multiplication and Division going from left to right
            if (indexMultiply > -1 && indexMultiply < indexDivide || indexMultiply > -1 && indexDivide < 0)
            {
                string newSum = CalculateTemplate(sum, splitSum, indexMultiply, "*");

                return Calculate(newSum);
            }

            if (indexDivide > -1)
            {
                string newSum = CalculateTemplate(sum, splitSum, indexDivide, "/");

                return Calculate(newSum);
            }

            int indexPlus = Array.IndexOf(splitSum, "+");
            int indexMinus = Array.IndexOf(splitSum, "-");

            // Addition and Subtraction going from left to right
            if (indexPlus > -1 && indexPlus < indexMinus || indexPlus > -1 && indexMinus < 0)
            {
                string newSum = CalculateTemplate(sum, splitSum, indexPlus, "+");

                return Calculate(newSum);
            }

            if (indexMinus > -1)
            {
                string newSum = CalculateTemplate(sum, splitSum, indexMinus, "-");

                return Calculate(newSum);
            }

            return (double) Math.Round(result, 11);
        }

        private static string CalculateTemplate(string sum, string[] splitSum, int currIndex, string currOperator)
        {
            decimal firstValue = Convert.ToDecimal(splitSum[currIndex - 1]);
            decimal secondValue = Convert.ToDecimal(splitSum[currIndex + 1]);
            decimal result = CalculateOperation(currOperator, firstValue, secondValue);

            string currOperation = firstValue.ToString() + $" {currOperator} " + secondValue.ToString();
            return sum.Replace(currOperation, result.ToString());
        }

        private static decimal CalculateOperation(string currOperator, decimal firstArg, decimal secondArg)
        {
            switch (currOperator)
            {
                case "+":
                    return firstArg + secondArg;
                case "-":
                    return firstArg - secondArg;
                case "*":
                    return firstArg * secondArg;
                case "/":
                    return firstArg / secondArg;
                default:
                    return 0;
            }
        }
    }
}
