namespace ConsoleApp.Lessons
{
    internal static class Dominator
    {
        public static int Solution(int[] a)
        {
            var size = 0;
            var candidate = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (size == 0)
                {
                    candidate = a[i];
                    size++;
                }
                else if (a[i] != candidate)
                {
                    size--;
                }
            }
            
            var count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == candidate)
                {
                    count++;
                    if (count > (a.Length / 2))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}