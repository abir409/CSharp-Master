using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Name = "Abir";

            Person person2 = person1;

            person2.Name = "Alam";

            Console.WriteLine(person1.Name);
            Console.WriteLine(person2.Name);
        }
    }
}
