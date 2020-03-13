using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Regex_validate_PIN_code
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidatePin("12345"));
            Console.ReadKey();
        }
        public static bool ValidatePin(string pin)
        {
            //Regex methode
            //Hierbij gecontroleerd om te kijken of er geen enter bij zat (één van de tests van code wars.... :-(....)
            return Regex.IsMatch(pin, "^[0-9]{4}$|^[0-9]{6}$") && !pin.Contains("\n");

            //Linq methode
            //return pin.All(n => char.IsDigit(n) && (pin.Length == 4 || pin.Length == 6));
        }
    }
}
