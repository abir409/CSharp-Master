using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Name = "Test";
            product.Price = 100;

            if (product is ICloneable)
            {
                Product product2 = (Product)product.Clone();
            }
            using (FileStream fileStream = File.Open("", FileMode.Open));
            
               // fileStream.Write();
            

        }
    }
}
