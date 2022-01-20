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
        public int id { get; set; }
    }


    public class Inventory // Класс инвентаря 
    {

        List<Items> listOfItems = new List<Items>();
        Items item1 = new Items();
        public void Add(int id1, string name1, double price1) // Метод добавления продукта
        {
            Items itemX = new Items() { id = id1, name = name1, price = price1 };
            listOfItems.Add(itemX);
        }
        public void Delete(int n)  // Метод удаления продукта
        {
            item1.id = n;
            listOfItems.RemoveAt(listOfItems.IndexOf(item1));
        }
        public void List()  //Метод вывода списка продуктов
        {
            double PriceCount = 0;
            for (int i = 0; i < listOfItems.Count; i++)
            {
                Console.WriteLine("Id: " + listOfItems[i].id + "\n Имя продукта: " + listOfItems[i].name + "\n Цена: " + listOfItems[i].price);
                if (listOfItems[i].price == 0)
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
