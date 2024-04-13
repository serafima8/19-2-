using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП__19_2
{
    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Проигрывание");
        }

        public void Pause()
        {
            Console.WriteLine("Пауза");
        }

        public void Stop()
        {
            Console.WriteLine("Остановка");
        }

        public void Record()
        {
            Console.WriteLine("Запись");
        }
    }
}
