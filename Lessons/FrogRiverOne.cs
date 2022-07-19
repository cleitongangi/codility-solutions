namespace ConsoleApp.Lessons
{
    internal static class FrogRiverOne
    {
        public static int Solution(int X, int[] A)
        {
            var hash = new HashSet<int>();
            for (int i = 1; i <= X; i++)
            {
                hash.Add(i);
            }

            for (int i = 0; i < A.Length; i++)
            {
                hash.Remove(A[i]);
                if (hash.Count() == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int Solution2(int X, int[] A)
        {
            var hash = new HashSet<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= X)
                {
                    hash.Add(A[i]);
                }
                if (hash.Count == X)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}