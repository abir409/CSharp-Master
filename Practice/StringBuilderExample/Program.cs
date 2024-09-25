using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string location = "Dhaka";

            StringBuilder stringBuilder = new StringBuilder(location);
            stringBuilder.Append(", Bangladesh");
            stringBuilder.Replace('l' , 'g');
            stringBuilder.Insert(17, '.');

            stringBuilder[0] = 'd';

            Console.WriteLine(stringBuilder);
        }
    }
}
