using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var result = Calculator.CalculateAverage(new double[] {5.0, 2.5});
            Console.WriteLine(Calculator.PI);

            

            Calculator calculator = new Calculator();
            Calculator.PI = 4.6;
            Console.WriteLine(calculator.GetPI());
        }
    }
}
