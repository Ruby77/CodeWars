using System.Linq;

namespace Sum_of_Minimums_
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static int SumOfMinimums(int[,] numbers)
        {
            return Enumerable
                .Range(0, numbers.GetLength(0))
                .Select(x => Enumerable.Range(0, numbers.GetLength(1)).Select(y => numbers[x, y]))
                .Sum(x => x.Min());
        }
    }
}
