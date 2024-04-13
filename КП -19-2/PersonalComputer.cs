using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП__19_2
{
    class PersonalComputer : ISwitchable
    {
        public void Inclusion()
        {
            Console.WriteLine("Компьютер включен");
        }
        public void Shutdown()
        {
            Console.WriteLine("Компьютер выключен");
        }
    }
}
