namespace ConsoleApp.Lessons
{
    internal static class Brackets
    {
        public static int Solution(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 1;
            }

            var bracketStack = new Stack<char>();
            foreach (var item in s)
            {
                switch (item)
                {
                    case '(':
                    case '[':
                    case '{':
                        bracketStack.Push(item);
                        break;
                    case ')':
                    case ']':
                    case '}':
                        if (!bracketStack.Any())
                        {
                            return 0;
                        }

                        var lastBracket = bracketStack.Pop();
                        if (item != GetEquivalent(lastBracket))
                        {
                            return 0;
                        }
                        break;
                    default:
                        // Doesn't add letters in stack
                        break;
                }
            }

            if (bracketStack.Any())
            {
                return 0;
            }
            return 1;
        }

        private static char GetEquivalent(char bracket)
        {
            switch (bracket)
            {
                case '(':
                    return ')';
                case '[':
                    return ']';
                case '{':
                    return '}';
                default:
                    throw new ArgumentException();
            }
        }
    }
}