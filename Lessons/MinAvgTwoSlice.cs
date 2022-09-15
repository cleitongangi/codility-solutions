namespace ConsoleApp.Lessons
{
    internal static class MinAvgTwoSlice
    {
        public static int Solution(int[] A)
        {
            var minAvg = double.MaxValue;
            var minIndex = 0;

            for (int i = 0; i < A.Length - 1; i++)
            {
                // Check groups of two
                var avg = (A[i] + A[i + 1]) / 2.0;
                if (avg < minAvg)
                {
                    minAvg = avg;
                    minIndex = i;
                }

                // Check groups of tree                
                if (i < A.Length - 2)
                {
                    avg = (A[i] + A[i + 1] + A[i + 2]) / 3.0;
                    if (avg < minAvg)
                    {
                        minAvg = avg;
                        minIndex = i;
                    }
                }
            }

            return minIndex;
        }
    }
}