namespace ConsoleApp.Lessons
{
    internal static class Fish
    {
        public static int Solution(int[] a, int[] b)
        {
            var fishInRiver = new Stack<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (b[i] == 0)
                { // Fish in upstream
                    if (!fishInRiver.Any())
                    { // First fish
                        fishInRiver.Push(i);
                        continue;
                    }

                    // resolve conflicts                    
                    var goNext = false;
                    while (fishInRiver.Any() && b[fishInRiver.Peek()] == 1)
                    { // The last fish is in opposite direction
                        if (a[fishInRiver.Peek()] < a[i])
                        { // The last fish is smaller. 
                            fishInRiver.Pop(); // Eaten
                        }
                        else
                        { // The last fish is bigger. 
                            goNext = true; // Eat current fish. Go to next fish
                            break;
                        }
                    }

                    if (goNext)
                    {
                        continue;
                    }

                    // The fish in upstream survive
                    fishInRiver.Push(i);
                }
                else
                { // Fish in downstream (b[i] == 1)
                    fishInRiver.Push(i);
                }
            }

            return fishInRiver.Count();
        }
    }
}