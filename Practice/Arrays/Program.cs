using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //normal or dimensional array
            int[] x = new int[5];
            x[0] = 1;

            Console.WriteLine(x[0]);

            int[,] y = new int[5, 5];
            y[0, 0] = 7;

            Console.WriteLine(y[0,0]);


            //jagged arrays

            int [][] z = new int[5][];

            z[0] = new int[] {1,2};
            z[1] = new int[] { 3, 4, 5 };
            z[2] = new int[] { 6 };
            z[3] = new int[] { 7 };
            z[4] = new int[] { 8, 9, 10 };

            for(int row= 0; row < z.Length; row++)
            {
                for(int col = 0; col < z[row].Length; col++)
                {
                    Console.Write(z[row][col]);
                }
                Console.WriteLine();
            }

            
        }
    }
}
