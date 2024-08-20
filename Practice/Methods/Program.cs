using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            //if(number < 2)
            //{
            //    Console.WriteLine("Not Prime");
            //}
            //else
            //{
            //    bool divided = false;
            //    for(int i= 2; i<=Math.Sqrt(number); i++)
            //    {
            //        if(number % i ==0)
            //        {
            //            Console.WriteLine("Not Prime");
            //            divided = true;
            //            break;
            //        }
            //    }
            //    if(!divided)
            //    {
            //        Console.WriteLine("Prime");
            //    }
            //}

            bool result = IsPrime(num);

            if(result)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }

            bool IsPrime(int n)
            {
                if(n<2)
                {
                    return false;
                }

                for(int i = 2; i < n; i++)
                {
                    if(n % i ==0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
