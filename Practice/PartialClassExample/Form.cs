using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassExample
{
    public partial class Form
    {
        private string _name;
        private string _email;
        private string _password;
        private string _address;
        private string _photo;

        public Form()
        {
            _name = string.Empty;
            _email = string.Empty;  
            _password = string.Empty;
            _address = string.Empty;
            _photo = string.Empty;
        }

        public void Reset()
        {
            _name = string.Empty;
            _email = string.Empty;
            _password = string.Empty;
            _address = string.Empty;
            _photo = string.Empty;
        }
    }
}
