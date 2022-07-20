namespace ConsoleApp.Lessons
{
    internal static class MaxCounters
    {
        public static int[] Solution(int N, int[] A)
        {
            var maxAnyCounter = 0;
            int[] result = new int[N];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = 0;
            }

            for (int k = 0; k < A.Length; k++)
            {
                var x = A[k];
                if(x >= 1 && x <= N)
                {
                    result[x-1] += 1;
                    if(result[x-1] > maxAnyCounter)
                    {
                        maxAnyCounter = result[x-1];
                    }
                }
                if(x == N+1)
                {
                    for (int i = 0; i < result.Length; i++)
                    {
                        result[i] = maxAnyCounter;
                    }
                }
            }

            return result;
        }

        // This is the best solution
        public static int[] Solution2(int N, int[] A)
        {
            var maxAnyCounter = 0;
            var result = new int[N];
            var minimumValue = 0;
            
            for (int k = 0; k < A.Length; k++)
            {
                var x = A[k];
                if(x >= 1 && x <= N)
                {
                    if(result[x-1] <= minimumValue)
                    {
                        result[x-1] = minimumValue + 1;
                    }
                    else
                    {
                        result[x-1] += 1;
                    }                 
                    if(result[x-1] > maxAnyCounter)
                    {
                        maxAnyCounter = result[x-1];
                    }
                }
                if(x == N + 1)
                {
                    minimumValue = maxAnyCounter;                    
                }
            }

            for (int i = 0; i < result.Length; i++)
            {
                if(result[i] < minimumValue)
                {
                    result[i] = minimumValue;
                }
            }

            return result;
        }
    }
}