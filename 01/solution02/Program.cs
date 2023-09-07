using System;
using System.Collections.Generic;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 5, 6, 7, 8, 9 };
            List<int> moda = ModaCalculator(numbers);

            Console.WriteLine("Moda(s):" + string.Join(", ", moda));

        }

        static List<int> ModaCalculator(int[] numbers)
        {
            Dictionary<int, int> count = new Dictionary<int, int>();
            int maxCount = 0;
            List<int> moda = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];
                if (count.ContainsKey(number))
                {
                    count[number]++;
                }
                else
                {
                    count[number] = 1;
                }
            }

            foreach (var keyValuePair in count)
            {
                if (keyValuePair.Value > maxCount)
                {
                    moda.Clear();
                    moda.Add(keyValuePair.Key);
                    maxCount = keyValuePair.Value;
                }
                else if (keyValuePair.Value == maxCount)
                {
                    moda.Add(keyValuePair.Key);
                }
            }

            return moda;
        }
    }
}