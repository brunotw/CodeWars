using System.Collections.Generic;
using System.Linq;

namespace EqualSidesOfAnArray
{
    public class EqualSidesOfAnArrayMain
    {
        public static int FindEvenIndex(int[] arr)
        {
            List<int> list = arr.ToList();
            List<int> validIndexes = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                List<int> numbersOnTheLeft = i == 0 ? new List<int>() : list.Take(i).ToList();
                List<int> numbersOnTheRiht = i == arr.Length - 1 ? new List<int>() : list.Skip(i + 1).ToList();

                if (numbersOnTheLeft.Sum() == numbersOnTheRiht.Sum())
                    validIndexes.Add(i);
            }

            validIndexes.Sort();

            int lowestIndex = validIndexes.Count() > 0 ? validIndexes.First() : -1;
            return lowestIndex;
        }

    }
}
