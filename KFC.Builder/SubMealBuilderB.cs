using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC.Builder
{
    public class SubMealBuilderB : MealBuilder
    {
        public override void buildDrink()  //重载抽象方法
        {
            meal.setFood("一个鸡肉卷");
        }

        public override void buildFood()
        {
            meal.setDrink("一杯果汁");
        }
    }
}
