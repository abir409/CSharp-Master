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

            //int [][] z = new int[5][];

            //z[0] = new int[] {1,2};
            //z[1] = new int[] { 3, 4, 5 };
            //z[2] = new int[] { 6 };
            //z[3] = new int[] { 7 };
            //z[4] = new int[] { 8, 9, 10 };

            //for(int row= 0; row < z.Length; row++)
            //{
            //    for(int col = 0; col < z[row].Length; col++)
            //    {
            //        Console.Write(z[row][col]);
            //    }
            //    Console.WriteLine();
            //}
            string[] friends = new string[3];

            friends[0] = "Abir";
            friends[1] = "Shafin";
            friends[2] = "Rakib";

            string[][] Breakfast = new string[3][];

            Breakfast[0] = new string[2];
            Breakfast[1] = new string[2];
            Breakfast[2] = new string[1];

            Breakfast[0][0] = "Bread";
            Breakfast[0][1] = "Orange Juice";

            Breakfast[1][0] = "Panta vaat";
            Breakfast[1][1] = "Alu vorta";

            Breakfast[2][0] = "Pasta";

            for (int i = 0; i < Breakfast.Length; i++)
            {
                string[] ArrayElements = Breakfast[i];  
                Console.WriteLine(friends[i]);
                Console.WriteLine("---------------------");
                for (int j = 0; j < ArrayElements.Length; j++)
                {
                    Console.WriteLine(ArrayElements[j]);
                }
                Console.WriteLine();

            }
            
        }
    }
}
