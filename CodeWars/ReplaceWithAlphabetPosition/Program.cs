using System;
using System.Linq;

namespace ReplaceWithAlphabetPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "the sunset sets at twelve o' clock.";
            var r = String.Join(" ", text.ToCharArray().Where(Char.IsLetter).Select(c => (int)c % 32));
            r.Trim();
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}
