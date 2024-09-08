using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Name = "Abir";
            user.Status = UserStatus.Active;

            Console.WriteLine((int)user.Status);
            Console.WriteLine(user.Status);
        }
    }
}
