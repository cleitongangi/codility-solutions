namespace ConsoleApp.Lessons
{
    internal static class StoneWall
    {
        public static int Solution(int[] h)
        {
            var stack = new Stack<int>();

            var result = 0;
            for (int i = 0; i < h.Length; i++)
            {
                next:
                if (stack.Any())
                {
                    if (stack.Peek() > h[i])
                    {
                        stack.Pop();
                        goto next;
                    }
                    else if (stack.Peek() < h[i])
                    {
                        stack.Push(h[i]);
                        result++;
                    }
                }
                else
                {
                    stack.Push(h[i]);
                    result++;
                }
            }

            return result;
        }
    }
}