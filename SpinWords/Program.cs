using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Stop_gninnipS_My_sdroW
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static string SpinWords(string sentence)
        {
            return string
                .Join(" ", sentence
                    .Split(' ')
                    .Select(x => x.Length >= 5 ? new string(x.Reverse().ToArray()): x));
        }
    }
}
