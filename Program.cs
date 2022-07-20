using ConsoleApp.Lessons;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // https://app.codility.com/programmers/lessons/3-time_complexity/perm_missing_elem/
            //Console.WriteLine(Lessons.PermMissingElem.Solution(new int[] { 2, 3, 1, 5 }));

            // https://app.codility.com/programmers/lessons/4-counting_elements/frog_river_one/
            //Console.WriteLine(FrogRiverOne.Solution2(5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 }));

            // https://app.codility.com/programmers/lessons/4-counting_elements/perm_check/
            //Console.WriteLine(PermCheck.Solution(new int[]{ 1,2,3,4,5 }));

            // https://app.codility.com/programmers/lessons/4-counting_elements/max_counters/
            Console.WriteLine(string.Join(",", MaxCounters.Solution2(5,new int[]{ 3,4,4,6,1,4,4 })));
            

            Console.ReadKey();
        }
    }
}