using System;
using System.Linq;

namespace Simple_Pig_Latin
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static string PigIt(string str)
        {
            return string.Join(' ', str.Split(' ').Select(w => string.Concat(w.Remove(0, 1), w[0] + "ay")));
        }
    }
}
