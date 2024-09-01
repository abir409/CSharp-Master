using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class VIPMember : Member
    {
        public VIPMember(int id) : base(id) 
        {
            Balance = 100;
            HashValue = "ABCDE";
        }

        public override int GetAge()
        {
            return DateTime.Now.Subtract(DateOfBirth).Days;
        }
    }
}
