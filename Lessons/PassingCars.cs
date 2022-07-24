namespace ConsoleApp.Lessons
{
    internal static class PassingCars
    {
        public static int Solution(int[] A)
        {
            var sumPassingCars = new Dictionary<int, int>();
            var countPassingCars = 0;
            for (int i = A.Length - 1; i >= 0; i--)
            {
                if (A[i] == 1)
                {
                    countPassingCars++;
                }

                sumPassingCars.Add(i, countPassingCars);
            }

            var result = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    result += sumPassingCars[i];
                }

                if (result > 1000000000)
                    return -1;
            }
            return result;
        }


        public static int Solution2(int[] A)
        {
            int result = 0;
            int count = 0;
            foreach (int car in A)
            {
                if (car == 0)
                {
                    count++;
                }
                if (count > 0)
                {
                    if (car == 1)
                    {
                        result = result + count;
                        if (result > 1000000000)
                        {
                            return -1;
                        }
                    }
                }
            }
            return result;
        }
    }
}