using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
    public class SimpleCalculator
    {
        public static void startCalculator()
        {
            decimal operand1;
            decimal operand2;
            char operation;

            decimal result;

            Console.WriteLine("Bitte geben Sie Ihre erste Zahl ein:\n");
            decimal.TryParse(Console.ReadLine(), out operand1);

            Console.WriteLine("\nBitte wählen Sie die Operation (+,-,*,/):\n");
            operation = Console.ReadKey().KeyChar;

            Console.WriteLine("\nBitte geben Sie Ihre zweite Zahl ein:\n");
            decimal.TryParse(Console.ReadLine(), out operand2);

            result = calculate(operand1, operation, operand2);

            Console.WriteLine("\nErgibt: " + result + "\n\n");

        }

        static decimal calculate(decimal operand1, char operation, decimal operand2)
        {
            switch (operation)
            {
                case '+':
                    return addition(operand1, operand2);
                case '-':
                    return subtraction(operand1, operand2);
                case '*':
                    return multiplication(operand1, operand2);
                case '/':
                    return division(operand1, operand2);
                default:
                    return 0;
            }
        }

        static decimal addition(decimal operand1, decimal operand2)
        {
            return operand1 + operand2;
        }

        static decimal subtraction(decimal operand1, decimal operand2)
        {
            return operand1 - operand2;
        }

        static decimal multiplication(decimal operand1, decimal operand2)
        {
            return operand1 * operand2;
        }

        static decimal division(decimal operand1, decimal operand2)
        {
            return operand1 / operand2;
        }
    }
}
