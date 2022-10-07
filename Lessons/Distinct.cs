using System;


namespace ConsoleApp.Lessons
{
    internal static class Distinct
    {
        public static int Solution(int[] array)
        {
            var distinctCount = 0;
            int? lastValue = null;
            foreach (var item in array.OrderBy(x => x))
            {
                if (!lastValue.HasValue)
                {
                    lastValue = item;
                    distinctCount++;
                }
                else
                {
                    if (lastValue.Value != item)
                    {
                        lastValue = item;
                        distinctCount++;
                    }
                }
            }
            return distinctCount;
        }

        public static int BestSolution(int[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }

            var distinctCount = 1;
            Array.Sort(array);

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != array[i - 1])
                {
                    distinctCount++;
                }
            }
            return distinctCount;
        }
    }
}