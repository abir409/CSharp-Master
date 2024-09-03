using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUse
{
    public class Keyboard : IUSBDevice
    {
        public bool Connect()
        {
            return true;
        }

        public string GetData()
        {
            return "Data from KeyBoard";
        }
    }
}
