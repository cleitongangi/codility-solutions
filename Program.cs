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
            //Console.WriteLine(PassingCars.Solution2(new int[] { 0, 1, 0, 1, 1 }));

            // https://app.codility.com/programmers/lessons/5-prefix_sums/count_div/            
            //Console.WriteLine(CountDiv.Solution2(10, 99, 2));

            // https://app.codility.com/programmers/lessons/5-prefix_sums/genomic_range_query/
            //Console.WriteLine(string.Join(",", GenomicRangeQuery.Solution("AC", new int[] { 0,0,1}, new int[] { 0,1,1 })));

            // https://app.codility.com/programmers/lessons/5-prefix_sums/min_avg_two_slice/
            // Console.WriteLine(MinAvgTwoSlice.Solution(new int[] { 4, 2, 2, 5, 1, 5, 8 }));

            // CoutingSort Sample. Ref: https://code-maze.com/counting-sort-in-c/
            //Console.WriteLine(string.Join(",", CoutingSort.CountingSort(new int[] { 7, 1, 2, 8, 9, 9, 4, 1, 5, 5 })));

            // Selection Sort. Ref: https://code-maze.com/csharp-selection-sort/
            //Console.WriteLine(string.Join(",", SelectionSort.SortArray(new int[] { 7, 1, 2, 8, 9, 9, 4, 1, 5, 5 })));

            // Merge Sort. Ref: https://code-maze.com/csharp-merge-sort/
            //Console.WriteLine(string.Join(",", SortMerge.Sort(new int[] { 7, 1, 2, 8, 9, 9, 4, 1, 5, 5 })));

            // Bubble Sort. Ref: https://code-maze.com/csharp-bubble-sort/
            //Console.WriteLine(string.Join(",", BubbleSort.SortArray(new int[] { 7, 1, 2, 8, 9, 9, 4, 1, 5, 5 })));

            // Quicksort. Ref: https://code-maze.com/csharp-quicksort-algorithm/
            //Console.WriteLine(string.Join(",", Quicksort.Sort(new int[] { 7, 1, 2, 8, 9, 9, 4, 1, 5, 5 })));

            // https://app.codility.com/programmers/lessons/6-sorting/distinct/
            //Console.WriteLine(string.Join(",", Distinct.BestSolution(new int[] { 7, 1, 2, 8, 9, 9, 4, 1, 5, 5 })));

            // https://app.codility.com/programmers/lessons/6-sorting/max_product_of_three/
            Console.WriteLine(string.Join(",", MaxProductOfThree.Solution(new int[] { -3, 1, 2, -2, 5, 6 })));

            Console.ReadKey();
        }
    }
}