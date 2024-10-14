using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnonymousObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic point2 = new { x = 5, y = 7, z = 9, Name = "Abir" };
            Console.WriteLine(point2.x);
        }
    }
}
