using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExamples
{
    public class Coordinate<T, Q> where T : struct
    {
        public T x {  get; set; }
        public Q y { get; set; }

        public T Something(Q Anything)
        {
            throw new NotImplementedException();
        }
    }
}
