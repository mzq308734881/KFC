using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC.Builder
{
    class SubMealBuilderA:MealBuilder
    {
        public override void buildFood()  //重载抽象方法
        {
            meal.setFood("一个鸡腿堡");
        }
        public override void buildDrink() //重载抽象方法
        {
            meal.setDrink("一杯可乐");
        }
    }
}
