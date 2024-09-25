using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? x = null;

            x = 5;

            if (!x.HasValue)
            {
                Console.WriteLine("Not Assigned");
            }
            else
                Console.WriteLine(x.Value);

            Person p = GetPerson("Abir");
            p?.Talk("Hello");

            Person GetPerson(string name)
            {
                if (name == "Abir")
                    return new Person() {Name = "Abir"};
                else 
                    return null;
            }

            string personname = p?.Name ?? "N/A";
            Console.WriteLine(personname);

            

        }
    }
}
