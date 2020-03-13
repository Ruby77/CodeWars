using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Readable_Time
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static string GetReadableTime(int seconds)
        {
            return $"{(seconds / 3600):00}:{(seconds / 60 % 60):00}:{(seconds % 60):00}";
        }
    }
}
