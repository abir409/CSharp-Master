using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r1 = CalculateAverage(3, 5, 9, 42, 11);

            double CalculateAverage(params double[] numbers)
            {
                double sum = 0;
                foreach (double number in numbers)
                {
                    sum += number;
                }
                return sum / numbers.Length;
            }

            void UpdateValue1(in double value)
            {

            }
            void UpdateValue2(out double value)
            {
                value = 5;
            }
            double t = 9;
            UpdateValue3(ref t);
            void UpdateValue3(ref double value)
            {
                value = 5;
            }
            Console.WriteLine(t);
        }
    }
}
