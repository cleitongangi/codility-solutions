using ConsoleApp.Lessons;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Codility Solutions:");

            // https://app.codility.com/programmers/lessons/3-time_complexity/perm_missing_elem/
            //Console.WriteLine(Lessons.PermMissingElem.Solution(new int[] { 2, 3, 1, 5 }));

            // https://app.codility.com/programmers/lessons/4-counting_elements/frog_river_one/
            //Console.WriteLine(FrogRiverOne.Solution2(5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 }));

            // https://app.codility.com/programmers/lessons/4-counting_elements/perm_check/
            //Console.WriteLine(PermCheck.Solution(new int[]{ 1,2,3,4,5 }));

            // https://app.codility.com/programmers/lessons/4-counting_elements/max_counters/
            //Console.WriteLine(string.Join(",", MaxCounters.Solution2(5,new int[]{ 3,4,4,6,1,4,4 })));

            // https://app.codility.com/programmers/lessons/4-counting_elements/missing_integer/
            //Console.WriteLine(MissingInteger.Solution2(new int[]{ 1, 3, 6, 4, 1, 2 }));

            // https://app.codility.com/programmers/lessons/5-prefix_sums/passing_cars/
            Console.WriteLine(PassingCars.Solution2(new int[] { 0, 1, 0, 1, 1 }));

            Console.ReadKey();
        }
    }
}