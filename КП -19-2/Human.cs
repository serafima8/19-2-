using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП__19_2
{
    class Human : IReflection, ITalk 
    {
        public void Loud()
        {
            Console.WriteLine("Говорит громко - Я люблю программирование!");
        }
        public void Thinks()
        {
            Console.WriteLine("Думает - A С# больше всего");
        }
        public void Fine()
        {
            Console.WriteLine("Говорит нормально - Меньше люблю компьютерные игры");
        }
    }
}
