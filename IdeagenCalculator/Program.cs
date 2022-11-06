
namespace IdeagenCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            string input;
            Console.WriteLine("Calculator");
            do
            {
                Console.WriteLine();
                Console.Write("Enter value: ");
                input = Console.ReadLine();

                double result = calculator.Calculate(input);

                Console.WriteLine("Sum : {0}", result);
            } while (true);
        }
    }
}


