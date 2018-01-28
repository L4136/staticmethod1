using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace staticmethod1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestiPeti testbed = new TestiPeti();

            while (true)
            { 
                //testbed.TestiPetiFloat();
                testbed.TestiPetiDate();
            }
               
        }
    }
}
