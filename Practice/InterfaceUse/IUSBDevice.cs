using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUse
{
    internal interface IUSBDevice
    {
        bool Connect();

        string GetData();
    }
}
