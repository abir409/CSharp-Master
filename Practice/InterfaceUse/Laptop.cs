using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUse
{
    internal class Laptop
    {
        IUSBDevice port1;
        IUSBDevice port2;

        public Laptop()
        {
            
        }
        public void AddUsbDeviceinPort1(IUSBDevice device)
        {
            port1 = device;
        }

        public void AddUsbDeviceinPort2(IUSBDevice device)
        {
            port2 = device;
        }

        public string TransferDataFromPort1()
        {
            var status =  port1.Connect();
            if(status)
            {
                string bytes = port1.GetData();
                return bytes;
            }
            else
                return null;
            
        }
        public string TransferDataFromPort2()
        {
            port2.Connect();
            string bytes = port2.GetData();
            return bytes;
        }
    }
}
