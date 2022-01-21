using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForHomework5
{
    public class Items // Класс продуктов
    {
        public string name { get; set; }
        public double price { get; set; }
        public int id;
    }


    public class Inventory // Класс инвентаря 
    {

        List<Items> listOfItems = new List<Items>();
        Items item1 = new Items();
        public void Add(string name1, double price1) // Метод добавления продукта
        {
            Items itemX = new Items() { name = name1, price = price1 };
            listOfItems.Add(itemX);
        }
        public void Delete(int DelNum1)  // Метод удаления продукта
        {
           // listOfItems.RemoveAt(listOfItems.IndexOf());
            for (int i = 0; i < listOfItems.Count; i++)
            {
                if (DelNum1 == i)
                {
                    listOfItems.RemoveAt(i);
                };
            }    



        }
        public void List()  //Метод вывода списка продуктов
        {
            double PriceCount = 0;
            for (int i = 0; i < listOfItems.Count; i++)
            {
                listOfItems[i].id = listOfItems[i].id + i;
                Console.WriteLine("Id: " + listOfItems[i].id + "\n Имя продукта: " + listOfItems[i].name + "\n Цена: " + listOfItems[i].price);
                if (i < 1)
                {
                    PriceCount = listOfItems[i].price;
                }
                else
                {
                    PriceCount = listOfItems[i].price + listOfItems[i - 1].price;
                }
            }
            Console.WriteLine("Цена всего инвентаря: " + PriceCount);
        }
    }

}
