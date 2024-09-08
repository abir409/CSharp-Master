using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2002 , 4 , 23);
            Console.WriteLine(date.ToString("dd-MM-yy"));

            date = date.AddMonths(2);
            Console.WriteLine(date.ToString("dd-MM-yy"));

            DateTime date2 = DateTime.UtcNow;
            Console.WriteLine(date2);

            Console.WriteLine(date2.DayOfYear);
            
            TimeSpan diff = date2.Subtract(date);
            Console.WriteLine(diff.TotalDays);
        }
    }
}
