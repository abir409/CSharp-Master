using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop();
            laptop.AddUsbDeviceinPort1(new Keyboard());
            string data = laptop.TransferDataFromPort1();

            Console.WriteLine(data);
        }
    }
}
