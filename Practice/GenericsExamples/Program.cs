using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coordinate<Product> coordinate = new Coordinate<Product>();
            coordinate.x = new Product();

            Product p = coordinate.x;
        }
    }
}
