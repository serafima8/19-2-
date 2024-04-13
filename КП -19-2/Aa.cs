using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП__19_2
{
    class Aa : A
    {
        public new double Add()
        {
            Console.Write("Переменная х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Переменная y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Переменная z: ");
            double z = Convert.ToDouble(Console.ReadLine());
            return x + y + z;
        }
       
    }
}
