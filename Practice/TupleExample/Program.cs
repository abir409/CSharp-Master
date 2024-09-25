using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[2];
            Person p = new Person();
            p.Name = "Abir";
            p.Age = 24;
            p.Id = 1;
            persons[0] = p;

            persons[1] = new Person()
            {
                Name = "Tareq",
                Age = 24,
                Id = 2
            };

            Order[] orders = new Order[2];
            Order order = new Order();
            orders[0] = order;
            order.PersonName = "Abir";
            order.Id = 1;
            order.Price = 100;

            orders[1] = new Order()
            {
                Id = 2,
                PersonName = "Tareq",
                Price = 900
            };

            (int id, double price)[] r = new (int id, double price)[2];
            int count = 0;

            for (int i = 0; i < persons.Length; i++)
            {
                for (int j = 0; j < orders.Length; j++)
                {
                    if (persons[i].Name == orders[j].PersonName)
                    {
                        r[count++] = (persons[i].Id, orders[j].Price);
                    }
                }
            }
            foreach(var t in r)
            {
                Console.WriteLine($"{t.id},{t.price }");
            }
        }
    }
}
