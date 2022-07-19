namespace ConsoleApp.Lessons
{
    internal static class PermMissingElem
    {
        public static int Solution(int[] A)
        {
            var list = new HashSet<int>();
            for (int i = 1; i <= A.Length + 1; i++)
            {
                list.Add(i);
            }

            foreach (var item in A)
            {
                list.Remove(item);
            }
            return list.FirstOrDefault();
        }
    }
}