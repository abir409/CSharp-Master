using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Dhaka");
            list.Add("Sylhet");
            list.Add("Feni");

            list.Remove("Sylhet");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Dictionary<string, int> ages = new Dictionary<string, int>();
            ages.Add("Abir", 24);
            ages.Add("Rahim", 25);

            foreach (var age in ages)
            {
                Console.WriteLine($"{age.Key} {age.Value}");
            }

            Console.WriteLine(ages["Abir"]);

            HashSet <string> set = new HashSet<string>();
            set.Add("Abir");
            set.Add("Rahim");
            set.Add("Abir");

            foreach (var sets in set)
            {
                Console.WriteLine(sets);
            }

            Stack<string> stack = new Stack<string>();
            stack.Push("Dhaka");
            var last = stack.Pop();
            var last2 = stack.Peek();
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Khulna");
            queue.Enqueue("dhaka");
            var first = queue.Dequeue();
            var first2 = queue.Peek();


        }
    }
}
