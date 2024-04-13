using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП__19_2
{
    //задача 1

    interface IInterface
    {
        void Method();
    }

    //задача 2

    interface IInterfacee
    {
        double Method1();
        int Method2();
        double Method3(double x);
        double Method4(double x);
    }

    //задача 3

    interface IInterface1
    {
        void Method1();
    }
    interface IInterface2 : IInterface1
    {
        void Method2();
    }
    interface IInterface3 : IInterface2
    {
        void Method3();
    }

    //задача 4

    interface IReflection
    {
        void Loud();
        void Fine();
    }
    interface ITalk
    {
        void Thinks();
    }

    //задача 5

    interface ISwitchable
    {
        void Inclusion();
        void Shutdown();
    }

    //задача 6

    interface IArithmetic
    {
        double Add();
        double Subtract();
        double Multiply();
        double Divide();
    }

    interface ISquare
    {
        double Square(double x);
        double SquareRoot(double x);
    }
    
    //задача 7

    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();

    }
    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1");
            DerivedClass dClass = new DerivedClass();
            dClass.Method();

            Console.WriteLine("\nЗадача 2");
            MyClass myClass = new MyClass();
            Console.WriteLine($"Число PI: {myClass.Method1()}");
            Console.WriteLine($"Возвращающее число: {myClass.Method2()}");
            Console.WriteLine($"5 в квадрате: {myClass.Method3(5)}");
            Console.WriteLine($"Корень квадратный из 6: {myClass.Method4(6)}");

            Console.WriteLine("\nЗадача 3");
            DerivedClass1 class1 = new DerivedClass1();
            class1.Method1();
            class1.Method2();
            class1.Method3();

            Console.WriteLine("\nЗадача 4");
            Human human = new Human();
            human.Loud();
            human.Thinks();
            human.Fine();

            Console.WriteLine("\nЗадача 5");
            TVSet tV = new TVSet();
            PersonalComputer personal = new PersonalComputer();
            List<ISwitchable> switchables = new List<ISwitchable>();
            switchables.Add(tV);
            switchables.Add(personal);
            foreach (var elem in switchables)
            {
                elem.Inclusion();
                elem.Shutdown();
            }

            Console.WriteLine("\nЗадача 6");
            A a = new A();
            Console.WriteLine($"Сумма: {a.Add()}");
            Console.WriteLine($"Умножение: {a.Multiply()}");
            Aa aa = new Aa();
            Console.WriteLine($"Сумма: {aa.Add()}");

            Console.WriteLine("\nЗадача 7");
            Player player = new Player();
            player.Play();
            player.Pause();
            player.Stop();
            player.Record();
            player.Pause();
            player.Stop();

            Console.ReadKey();

        }
    }
}
