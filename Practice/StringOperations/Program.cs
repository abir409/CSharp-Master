using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c = 'A';
            int x = (int)c;
            Console.WriteLine(x);

            String name = "Abir";
            name = name.Replace('i', 'm');
            Console.WriteLine(name);

            int pos = name.IndexOf('b');
            Console.WriteLine(pos);
            
            bool isPunctuation = char.IsPunctuation(';');
            Console.WriteLine(isPunctuation);

        }
    }
}
