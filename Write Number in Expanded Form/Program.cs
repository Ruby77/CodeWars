using System;
using System.Collections.Generic;
using System.Linq;

namespace Write_Number_in_Expanded_Form
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static string ExpandedForm(long num)
        {
            List<long> nums = new List<long>();
            Enumerable.Range(1, num.ToString().Length)
                .ToList()
                .ForEach(i =>
                {
                    long newNum = num % Convert.ToInt64(Math.Pow(Convert.ToDouble(10), Convert.ToDouble(i)));
                    if(newNum > 0) nums.Add(newNum);
                    num -= newNum;
                });
            nums.Reverse();

            return string.Join(" + ", nums);
        }
    }
}
