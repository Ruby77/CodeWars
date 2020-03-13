using System;
using System.Linq;

namespace Data_Reverse
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static int[] DataReverse(int[] data)
        {
            int[][] chunk = new int[data.Length / 8][];
            Enumerable
                .Range(0, data.Length / 8)
                .ToList()
                .ForEach(i =>
                {
                    chunk[i] = data
                        .Skip(8 * i)
                        .Take(8)
                        .ToArray();
                });

            return chunk.Reverse().SelectMany(array => array).ToArray();
        }
    }
}
