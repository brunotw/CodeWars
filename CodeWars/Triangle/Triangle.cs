using System.Collections.Generic;
using System.Linq;

namespace Triangle
{
    public class Triangle
    {
        public static bool IsTriangle(int a, int b, int c)
        {
            List<int> list = new List<int> { a, b, c };
            list.Sort();

            if (list.Where(t => t < 0).Count() > 0) return false;

            int triangleSides = list.Take(2).Sum();
            int triangleBase = list.Last();

            return triangleSides > triangleBase;
        }
    }
}
