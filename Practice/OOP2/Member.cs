using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Member
    {
        private int Id {  get; set; }
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }

        protected double Balance { get; set; }

        protected internal string HashValue { get; set; }

        private protected string x {  get; set; }
        public Member(int id)
        {
            Id = id;
            Balance = 50;
        }


        public virtual int GetAge()
        {
            return DateTime.Now.Year - DateOfBirth.Year;
        }
    }
}
