using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC.Builder
{
    public abstract class MealBuilder
    {
        //抽象类，建造者
        protected Meal meal = new Meal();
        public abstract void buildFood();
        public abstract void buildDrink();
        public Meal getMeal()
        {
            return meal;
        }
    }
}
