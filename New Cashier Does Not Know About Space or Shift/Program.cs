using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace New_Cashier_Does_Not_Know_About_Space_or_Shift
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
        }
        public static string GetOrder(string input)
        {
            List<string> orderList = new List<string>();
            string[] orders = new string[8] {"burger", "fries", "chicken", "pizza", "sandwich", "onionrings", "milkshake", "coke"};
            orders.ToList().ForEach(order =>
            {
                Enumerable.Range(0, Regex.Matches(input, order).Count)
                    .ToList().
                    ForEach(i => orderList.Add(char.ToUpper(order[0]) + order.Substring(1)));
            });

            return string.Join(" ", orderList);
        }
    }
}
