using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC.Builder
{
    public class KFCWaiter
    {
        //指挥者
        private MealBuilder mb;
        public void setMealBuilder(MealBuilder mb)
        {
            this.mb = mb;
        }

        public Meal construct()
        {
            mb.buildFood();             //选择食物
            mb.buildDrink();            //选择饮料
            return mb.getMeal();   //返回套餐结果
        }
    }
}
