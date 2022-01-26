using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForHomework5.Class
{

    public class Inventory // Класс инвентаря 
    {

         List<Items> listOfItems = new List<Items>();
        public void Add() // Метод добавления продукта
        {
            Items item1 = new Items();

            Console.WriteLine("Введите наименование продукта\n");
            string ExName = Console.ReadLine();
            if (ExName == null)
            {
                item1.name = "Неверно введено наименование\n";
            }
            else
            {
                item1.name = ExName;
            }
            Console.WriteLine("Введите цену продукта\n");
            string inputPrice = Console.ReadLine();
            bool resultTryParse = double.TryParse(inputPrice, out var ReadPrice);
            if (resultTryParse == true)
            {
                item1.price = ReadPrice;
            }
            else
            {
                Console.WriteLine("Неверно введена цена\n");
            }

            listOfItems.Add(item1);
        }
        public void Delete()  // Метод удаления продукта
        {
            Console.WriteLine("Введите id продукта для удаления\n");
            string DelNum = Console.ReadLine();
            bool resultTryParse = int.TryParse(DelNum, out var ReadPrice);
            if (resultTryParse == true)
            {
                
                for (int i = 0; i < listOfItems.Count; i++)
                {
                    if (ReadPrice == i)
                    {
                        listOfItems.RemoveAt(i);
                    };
                }
            }
            else
            {
                Console.WriteLine("Неверно введён Id\n");
            }




        }
        public void List()  //Метод вывода списка продуктов
        {
            double PriceCount = 0;
            for (int i = 0; i < listOfItems.Count; i++)
            {
                listOfItems[i].id = i;
                Console.WriteLine("Id: " + listOfItems[i].id + "\n Имя продукта: " + listOfItems[i].name + "\n Цена: " + listOfItems[i].price);
                if (i < 1)
                {
                    PriceCount = listOfItems[i].price;
                }
                else
                {
                    PriceCount = listOfItems[i].price + PriceCount;
                }
            }
            Console.WriteLine("Цена всего инвентаря: " + PriceCount);
        }
    }

}

