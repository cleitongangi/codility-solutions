namespace ConsoleApp.Lessons
{
    internal static class PermCheck
    {
        public static int Solution(int[] A) {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var list = new HashSet<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if(A[i] > A.Length)
                {
                    return 0;
                }

                list.Add(A[i]);                
            }
            if(list.Count == A.Length)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}