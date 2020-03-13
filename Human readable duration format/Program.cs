using System;
using System.Collections.Generic;

namespace Human_readable_duration_format
{
    public class Program
    {
        private static void Main(string[] args)
        {
        }

        public static string formatDuration(int seconds)
        {
            List<string> solution = new List<string>();
            int[] times = new int[5];
            string[] timeNames = new[] { "year", "day", "hour", "minute", "second" };
            if (seconds == 0) return "now";

            times[0] = (seconds / (60 * 60 * 24 * 365));
            seconds -= times[0] * 60 * 60 * 24 * 365;
            times[1] = seconds / (60 * 60 * 24);
            seconds -= times[1] * 60 * 60 * 24;
            times[2] = seconds / (60 * 60);
            seconds -= times[2] * 60 * 60;
            times[3] = seconds / 60;
            times[4] = seconds - (times[3] * 60);

            for (int i = 0; i < times.Length; i++)
            {
                if (times[i] > 0)
                {
                    if (times[i] == 1) solution.Add($"{times[i]} {timeNames[i]}");
                    else solution.Add($"{times[i]} {timeNames[i]}s");
                }
            }

            if (solution.Count > 1)
            {
                solution[solution.Count - 1] = "and " + solution[solution.Count - 1];
                solution[solution.Count - 1].Remove(0);
                return string.Join(", ", solution.ToArray()).Remove(string.Join(", ", solution.ToArray()).LastIndexOf(','), 1);
            }

            return solution[0];
        }
    }
}