using System;

namespace ReduceButGrow
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Result: " + Grow(new int[] { 1, 2, 3, 4 }));
            Console.ReadKey();
        }

        public static int Grow(int[] x)
        {
            int result = 1;

            foreach (var item in x)
            {
                result = result * item;
            }

            return result;
        }
    }
}
