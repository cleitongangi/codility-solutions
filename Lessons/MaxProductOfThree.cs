namespace ConsoleApp.Lessons
{
    internal static class MaxProductOfThree
    {
        public static int Solution(int[] A)
        {
            Array.Sort(A);

            // Multiplica os 3 maiores valores
            var option1 = A[A.Length - 3] * A[A.Length - 2] * A[A.Length - 1];
            // Multiplica os 2 menores valores (pois se forem negativos, vai ficar positivo) e multiplica o maior valor.
            var option2 = A[0] * A[1] * A[A.Length - 1];

            if (option1 > option2)
            {
                return option1;
            }
            else
            {
                return option2;
            }
        }
    }
}