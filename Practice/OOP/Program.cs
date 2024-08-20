 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WaterBottle bottle = new WaterBottle();
            bottle.Wateramount = 400;
            bottle.IsOpen = true;
            bottle.AddWater(100);

            WaterBottle bottle2 = new WaterBottle("blue",500);
            bottle2.Wateramount = 300;
            bottle2.IsOpen = false;
            bottle2.AddWater(100);

            Console.WriteLine(bottle.Wateramount+" "+ bottle.Color+ " "+ bottle.IsOpen) ;
            Console.WriteLine(bottle2.Wateramount+ " "+ bottle.Color+ " "+ bottle2.IsOpen);
        }
    }
}
