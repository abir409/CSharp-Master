using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    internal class Calculator
    {

        public static double PI = 3.14;
        public static double CalculateAverage(double[] numbers)
        {

            var sum = 0.0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Length;    
        }

        public double GetPI()
        {
            return PI;
        }

    }
}
