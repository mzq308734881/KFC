using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC.AbstractFactory
{
    public class SubMealDrinkA : Drink
    {
        public void GetDrink()
        {
            Console.WriteLine("一杯可乐！");
        }
    }
}
