using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_v._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня недели (от 1 до 7)");
            int DayOfWeek = Convert.ToInt32(Console.ReadLine());
            switch (DayOfWeek)
            {
                case 1:
                Console.WriteLine("Сегодня понедельник");
                    break;
                case 2:
                Console.WriteLine("Сегодня вторник");
                    break;
                case 3:
                Console.WriteLine("Сегодня среда");
                    break;
                case 4:
                Console.WriteLine("Сегодня четверг");
                    break;
                case 5:
                Console.WriteLine("Сегодня пятница");
                    break;
                case 6:
                Console.WriteLine("Сегодня суббота");
                    break;
                default:
                Console.WriteLine("Сегодня воскресенье");
                    break;
            }
            Console.ReadKey(); // Сообщение для проверки работы git
        }
    }
}
