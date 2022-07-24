namespace ConsoleApp.Lessons
{
    internal static class CountDiv
    {
        public static int Solution(int A, int B, int K)
        {
            var result = 0;
            for (int i = A; i <= B; i++)
            {
                if ((i % K) == 0)
                    result++;
            }
            return result;
        }

        public static int Solution2(int A, int B, int K)
        {
            int result = 0;

            if (A % K == 0)
            {
                result = ((B - A) / K) + 1;
            }
            else
            {
                result = (B / K - ((A / K) + 1)) + 1;
            }

            return result;
        }
    }
}