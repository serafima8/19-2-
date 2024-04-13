using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП__19_2
{
    class Ab : A, ISquare
    {
        public double Square(double x)
        {
            return Math.Pow(x, 2);
        }
        public double SquareRoot(double x)
        {
            return Math.Sqrt(x);
        }
    }
}
