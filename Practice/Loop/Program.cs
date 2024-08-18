using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //foreach
            int[] ages = new int[] { 1, 2, 3, 4, 5 };
            foreach (int age in ages)
            {
                Console.WriteLine(age);
            }
            //while loop
            bool flage = false;
            while (flage == false)
            {
                Console.WriteLine("world");
                flage = true;
            }
            //do while loop
            bool flaged = false;
            do
            {
                Console.WriteLine("C#");
            }while (flaged == true);
        }
    }
}
