using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000.Business
{
    public class Order:Menu
    {
        public List<MenuItem> item = new List<MenuItem>();

        public double Total
        {
            get
            {
                double calculatedTotal = 0;
                foreach (MenuItem item in items)
                {
                    calculatedTotal = calculatedTotal + item.Price;
                }
                return calculatedTotal;
            }
        }
    }
}
