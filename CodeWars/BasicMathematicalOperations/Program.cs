using System;

namespace BasicMathematicalOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            bool result = basicOp('+', 4, 7) == 11;
            result = basicOp('-', 15, 18) == -3;
            result = basicOp('*', 5, 5) == 25;
            result = basicOp('/', 49, 7) == 7;
        }

        public static double basicOp(char operation, double value1, double value2)
        {
            switch (operation)
            {
                case '+':
                    return value1 + value2;
                case '-':
                    return value1 - value2;
                case '*':
                    return value1 * value2;
                case '/':
                    return value1 / value2;
                default:
                    throw new ArgumentOutOfRangeException();
            }

        }
    }
}
