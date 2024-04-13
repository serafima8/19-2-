using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП__19_2
{
    class TVSet : ISwitchable
    {
        public void Inclusion()
        {
            Console.WriteLine("Телевизор включен");
        }
        public void Shutdown()
        { 
            Console.WriteLine("Телевизор выключен"); 
        }
    }
}
