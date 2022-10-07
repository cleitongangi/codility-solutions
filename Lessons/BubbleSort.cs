namespace ConsoleApp.Lessons
{
    internal static class BubbleSort
    {
        public static int[] SortArray(int[] numArray)
        {
            var n = numArray.Length;
            bool swapRequired;
            for (int i = 0; i < n - 1; i++)
            {
                swapRequired = false;
                for (int j = 0; j < n - i - 1; j++)
                    if (numArray[j] > numArray[j + 1])
                    {
                        var tempVar = numArray[j];
                        numArray[j] = numArray[j + 1];
                        numArray[j + 1] = tempVar;
                        swapRequired = true;
                    }
                if (swapRequired == false)
                    break;
            }
            return numArray;
        }
    }
}