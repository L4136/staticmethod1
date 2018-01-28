using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace staticmethod1
{
    class ItMath
    {
        public static bool OnkoLuku(string input)
        {
            float number;
            bool result = float.TryParse(input, out number);
            Console.Write("Input " + input + " is a number: ");
            return result;
        }

        public static bool OnkoPvm(string input )
        {
            var dateFormats = new[] { "dd.MM.yyyy", "dd.MM.yy" };
            DateTime date;
            bool result = DateTime.TryParse(input, out date);
            Console.Write("Input " + input + " is a date: ");
            return result;
        }
    }
}
