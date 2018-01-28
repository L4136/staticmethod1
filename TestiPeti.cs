using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace staticmethod1
{
    class TestiPeti
    {
        public void TestiPetiFloat()
        {
            Console.Write("Your input: ");
            string input = Console.ReadLine();
            Console.WriteLine(ItMath.OnkoLuku(input));
        }
        public void TestiPetiDate()
        {
            Console.Write("Your input: ");
            string input = Console.ReadLine();
            Console.WriteLine(ItMath.OnkoPvm(input));
        }
    }
}

