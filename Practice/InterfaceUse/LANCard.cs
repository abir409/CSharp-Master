using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUse
{
    public class LANCard : IUSBDevice
    {

        bool _connected;
        public bool Connect()
        {
            _connected = true;
            return _connected;
        }

        public string GetData()
        {
            return "Lan Data";
        }
    }
}
