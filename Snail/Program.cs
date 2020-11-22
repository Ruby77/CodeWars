using System.Collections.Generic;

namespace Snail
{
    public class SnailSolution
    {
        public static void Main(string[] args) { }
        public static int[] Snail(int[][] array)
        {
            if (array[0].Length == 0)
                return new int[0];
            var solution = new List<int>();
            solveChallenge(0);
            return solution.ToArray();
            void solveChallenge(int n)
            {
                if (n <= array.Length / 2)
                {
                    for (int r = n; r < array.Length - n; r++) solution.Add(array[n][r]);
                    for (int d = n + 1; d < array.Length - n; d++) solution.Add(array[d][array.Length - 1 - n]);
                    for (int l = array.Length - 2 - n; l >= n; l--) solution.Add(array[array.Length - 1 - n][l]);
                    for (int u = array.Length - 2 - n; u >= n + 1; u--) solution.Add(array[u][n]);
                    solveChallenge(n + 1);
                }
            }
        }
    }
}
