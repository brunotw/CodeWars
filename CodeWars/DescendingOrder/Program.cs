using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DescendingOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console started!");

            Assert.AreEqual(Kata.DescendingOrder(21445), 54421);
            Assert.AreEqual(Kata.DescendingOrder(145263), 654321);
            Assert.AreEqual(Kata.DescendingOrder(1254859723), 9875543221);

            Console.WriteLine($"Completed.");
            Console.ReadKey();
        }
    }

    public static class Kata
    {
        public static long DescendingOrder(int num)
        {
            // Bust a move right here
            string numbersString = Convert.ToString(num);
            List<int> numbers = num.ToString().Select(number => Convert.ToInt32(number - 48)).ToList();

            numbers.Sort();
            numbers.Reverse();
            numbersString = string.Empty;

            foreach (var item in numbers)
            {
                numbersString += item;
            }

            return Convert.ToInt64(numbersString);
        }
    }
}
