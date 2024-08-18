using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint m = 5;

            m = ~m;
            Console.WriteLine(Convert.ToString(m, toBase:2));

            uint n = 0b_0101_0011;
            uint x = 0b_0011_1100;

            uint z = n ^ x;
            Console.WriteLine(Convert.ToString(z, toBase:2));
        }
    }
}
