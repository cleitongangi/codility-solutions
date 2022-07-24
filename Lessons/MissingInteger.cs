namespace ConsoleApp.Lessons
{
    internal static class MissingInteger
    {
        public static int Solution(int[] A)
        {
            var hash = new HashSet<int>();
            for (int i = 1; i <= 1000000; i++)
            {
                hash.Add(i);
            }

            for (int i = 0; i < A.Length; i++)
            {
                hash.Remove(A[i]);
            }

            return hash.First();
        }

        // Best solution
        public static int Solution2(int[] A)
        {
            HashSet<int> found = new HashSet<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    found.Add(A[i]);
                }
            }

            int result = 1;
            while (found.Contains(result))
            {
                result++;
            }

            return result;
        }
    }
}