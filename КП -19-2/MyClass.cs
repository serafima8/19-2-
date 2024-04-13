using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП__19_2
{
    class MyClass : IInterfacee
    {
        public double Method1()
        {
            return Math.PI;
        }
        
        public int Method2()
        {
            return 8;
        }

        public double Method3(double x)
        {
            return Math.Pow(x,2);
        }
        public double Method4(double x)
        {
            return Math.Sqrt(x);
        }
    }
}
