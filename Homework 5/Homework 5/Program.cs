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
            Item item = new Item();
            Inventory listOfItems = new Inventory();

            while (true)
            {
                Console.WriteLine("|||Выберите действие : \n\nЦифра 1 - Список продуктов" +
                "\nЦифра 2 - Добавить продукт" +
                " \nЦифра 3 - Удалить продукт" +
                "\nЦифра 7 - Выйти\n");
                int SwitchAction = Convert.ToInt32(Console.ReadLine());
                if (SwitchAction == 7) break;

                switch (SwitchAction)
                {
                    case 1:
                        listOfItems.ListOfItems();
                        break;

                    case 2:

                        listOfItems.AddItem();
                        break;

                    case 3:

                        listOfItems.DeleteItem();
                        break;

                    default:
                        Console.WriteLine("Неверно выбрано действие\n");
                        break;
                }
            }
        }
    }
}
