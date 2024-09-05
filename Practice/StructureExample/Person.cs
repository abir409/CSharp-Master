using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureExample
{
    public struct Person
    {
        public int _id;

        public string Name { get; set; }

        public int Age { get; set; }

        public Person(string name)
        {
            Name = name;
            Age = 0;
            _id = 0;
        }

        public void Run(int speed)
        {
            Console.WriteLine("Running");
        }
    }
}
