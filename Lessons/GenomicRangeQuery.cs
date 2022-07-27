namespace ConsoleApp.Lessons
{
    internal static class GenomicRangeQuery
    {
        public static int[] Solution(string S, int[] P, int[] Q)
        {
            var counting = new int[S.Length + 1][];

            for (int i = 0; i < S.Length + 1; i++)
            {
                counting[i] = new int[4] { 0, 0, 0, 0, };
            }

            for (int i = 0; i < S.Length; i++)
            {
                for (int r = 0; r < 4; r++)
                {
                    counting[i + 1][r] = counting[i][r];
                }
                switch (S[i])
                {
                    case 'A':
                        counting[i + 1][0]++;
                        break;
                    case 'C':
                        counting[i + 1][1]++;
                        break;
                    case 'G':
                        counting[i + 1][2]++;
                        break;
                    case 'T':
                        counting[i + 1][3]++;
                        break;
                }
            }

            var result = new int[P.Length];
            for (int i = 0; i < P.Length; i++)
            {
                if (P[i] == Q[i])
                {
                    switch (S[P[i]])
                    {
                        case 'A':
                        result[i] = 1;
                        break;
                    case 'C':
                        result[i] = 2;
                        break;
                    case 'G':
                        result[i] = 3;
                        break;
                    case 'T':
                        result[i] = 4;
                        break;
                    }
                }
                else
                {
                    var initial = counting[P[i]];
                    var end = counting[Q[i] + 1];
                    if ((end[0] - initial[0]) > 0)
                    {
                        result[i] = 1;
                    }
                    else if ((end[1] - initial[1]) > 0)
                    {
                        result[i] = 2;
                    }
                    else if ((end[2] - initial[2]) > 0)
                    {
                        result[i] = 3;
                    }
                    else if ((end[3] - initial[3]) > 0)
                    {
                        result[i] = 4;
                    }
                }
            }
            return result;
        }
    }
}