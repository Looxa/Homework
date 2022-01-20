using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryForHomework5;

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
                Console.WriteLine("Выберите действие : \nЦифра 1 - Список продуктов" +
                "\nЦифра 2 - Добавить продукт" +
                " \nЦифра 3 - Удалить продукт" + 
                "\nЦифра 4 - Выйти");
                int SwitchAction = Convert.ToInt32(Console.ReadLine());
                if (SwitchAction == 4) break;

                switch (SwitchAction)
                {
                    case 1:

                        list.List();
                        break;

                    case 2:

                        Console.WriteLine("Введите наименование продукта");
                        item.name = Console.ReadLine();
                        Console.WriteLine("Введите цену продукта");
                        string inputPrice = Console.ReadLine();
                        bool resultTryParse = double.TryParse(inputPrice, out var ReadPrice);
                        if (resultTryParse == true)
                        {
                            item.price = ReadPrice;
                        }
                        else
                        {
                            Console.WriteLine("Неверно введена цена");
                        }

                        Console.WriteLine("Введите id продукта");
                        string inputId = Console.ReadLine();
                        resultTryParse = double.TryParse(inputId, out var ReadId);
                        if (resultTryParse == true)
                        {
                            item.price = ReadId;
                        }
                        else
                        {
                            Console.WriteLine("Неверно введена цена");
                        }
                        list.Add(item.id, item.name, item.price);
                        break;

                    case 3:
                        Console.WriteLine("Введите id продукта для удаления");
                        int n = int.Parse(Console.ReadLine());
                        list.Delete(n);
                        break;
                    default:
                        Console.WriteLine("Неверно выбрано действие");
                        break;
                }
            }
        }
    }
}
