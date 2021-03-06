using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinerMax3000.Business;

namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Menu> menusFromDatabase = Menu.GetAllMenus();
            Menu firstMenu = menusFromDatabase[0];
            firstMenu.SaveNewMenuItem("Smorgas", "A classic nordic dish.", 10);
            menusFromDatabase = Menu.GetAllMenus();
            Order hungryGuestOrder = new Order();
            foreach(Menu CurrentMenu in menusFromDatabase)
            {
                foreach (MenuItem currentItem in CurrentMenu.items)
                {
                    hungryGuestOrder.items.Add(currentItem);
                }
            }
            Console.WriteLine("The total is:" + hungryGuestOrder.Total);
            Console.ReadKey();
        }
    }
}
