using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC.AbstractFactory
{
    public class SubMealFactoryA : EFactory
    {
        public Drink productDrink()
        {
            return new SubMealDrinkA();
        }

        public Food productFood()
        {
            return new SubMealFoodA();
        }
    }
}
