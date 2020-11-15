using System;

namespace Simple_Equation
{
    public class Kata
    {
        public static void Main(string[] args) { }

        public static string SolveTheEquation(string equation)
        {
            var equationParts = equation.Split(' ');
            long a = Convert.ToInt64(equationParts[2]);
            long b = Convert.ToInt64(equationParts[4]);

            switch (equation[2])
            {
                case '/':
                    return $"x = {a * b}";
                case '*':
                    return $"x = {(double)b / a:0.00}";
                case '+':
                    return $"x = {b - a}";
            }

            return $"x = {b + a}";
        }
    }
}
