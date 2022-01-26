using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryForHomework5.Struct;
using ClassLibraryForHomework5.Class;

namespace Homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Items item = new Items();
            Inventory list = new Inventory();

            while (true)
            {
                Console.WriteLine("|||Выберите действие : \n\nЦифра 1 - Список продуктов через класс" +
                "\nЦифра 2 - Добавить продукт через класс" +
                " \nЦифра 3 - Удалить продукт через класс" +
                "\nЦифра 4 - Список продуктов через структуру (не готово)" +
                "\nЦифра 5 - Добавить продукт через структуру (не готово)" +
                " \nЦифра 6 - Удалить продукт через структуру (не готово)" +
                "\nЦифра 7 - Выйти\n");
                int SwitchAction = Convert.ToInt32(Console.ReadLine());
                if (SwitchAction == 7) break;

                switch (SwitchAction)
                {
                    case 1:
                        list.List();
                        break;

                    case 2:

                        list.Add();
                        break;

                    case 3:

                        list.Delete();
                        break;

                    case 4:

                        break;

                    case 5:

                        break;

                    case 6:

                        break;

                    default:
                        Console.WriteLine("Неверно выбрано действие\n");
                        break;
                }
            }
        }
    }
}
