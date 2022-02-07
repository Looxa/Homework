using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForHomework5.Class
{

    public class Inventory // Класс инвентаря 
    {

         List<Item> listOfItems = new List<Item>();
        public void AddItem() // Метод добавления продукта
        {
            Item itemToList = new Item();

            Console.WriteLine("Введите наименование продукта\n");
            string nameOfNewItem = Console.ReadLine();
            if (nameOfNewItem == null)
            {
                itemToList.nameOfItem = "Неверно введено наименование\n";
            }
            else
            {
                itemToList.nameOfItem = nameOfNewItem;
            }
            Console.WriteLine("Введите цену продукта\n");
            string inputPrice = Console.ReadLine();
            bool resultTryParse = double.TryParse(inputPrice, out var readPrice);
            if (resultTryParse == true)
            {
                itemToList.priceOfItem = readPrice;
            }
            else
            {
                Console.WriteLine("Неверно введена цена\n");
            }

            listOfItems.Add(itemToList);
        }
        public void DeleteItem()  // Метод удаления продукта
        {
            Console.WriteLine("Введите id продукта для удаления\n");
            string idForDelete = Console.ReadLine();
            bool resultTryParse = int.TryParse(idForDelete, out var readPrice);
            if (resultTryParse == true)
            {
                
                for (int i = 0; i < listOfItems.Count; i++)
                {
                    if (readPrice == i)
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
        public void ListOfItems()  //Метод вывода списка продуктов + цена корзины 
        {
            double priceCount = 0;
            for (int i = 0; i < listOfItems.Count; i++)
            {
                listOfItems[i].idOfItem = i;
                Console.WriteLine("Id: " + listOfItems[i].idOfItem + "\n Имя продукта: " + listOfItems[i].nameOfItem + "\n Цена: " + listOfItems[i].priceOfItem);
                if (i < 1)
                {
                    priceCount = listOfItems[i].priceOfItem;
                }
                else
                {
                    priceCount = listOfItems[i].priceOfItem + priceCount;
                }
            }
            Console.WriteLine("Цена всего инвентаря: " + priceCount);
        }
    }

}

