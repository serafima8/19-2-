using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП__19_2
{
    class A : IArithmetic
    {
        public double Add()
        {
            Console.Write("Переменная х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Переменная y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            return x + y;
        }
        public double Subtract()
        {
            Console.Write("Переменная х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Переменная y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            return x - y;
        }
        public double Multiply()
        {
            Console.Write("Переменная х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Переменная y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            return x * y;
        }
        public double Divide()
        {
            Console.Write("Переменная х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Переменная y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            return x / y;
        }
    }
}
