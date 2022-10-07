namespace ConsoleApp.Lessons
{
    internal static class Triangle
    {
        public static int Solution(int[] A)
        {
            Array.Sort(A);

            for (int i = 2; i < A.Length; i++)
            {
                if ((Int64)A[i - 2] + A[i - 1] > A[i])
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}