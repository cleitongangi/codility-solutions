namespace ConsoleApp.Lessons
{
    internal static class NumberOfDiscIntersections
    {
        // Score 75%. 50% de performance
        public static int Solution(int[] A)
        {
            Int64 intersectionCount = 0;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (((Int64)i + A[i]) >= ((Int64)j - A[j]))
                    {
                        intersectionCount++;
                        if (intersectionCount > 10000000)
                        {
                            return -1;
                        }
                    }
                }
            }
            return (int)intersectionCount;
        }
    }
}