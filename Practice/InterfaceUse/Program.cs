using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

            HoverCraft hovercraft = new HoverCraft();
            hovercraft.StartEngine();

            ClassA c = new ClassB(); //boxing

            ClassB c3 = (ClassB)c; //unboxing

            c3.Method3();
        }
    }
}
