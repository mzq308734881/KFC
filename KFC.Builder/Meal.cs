using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC.Builder
{
    public class Meal
    {
        //实体类
        //food和drink是部件
        private String food;
        private String drink;

        public void setFood(String food)
        {
            this.food = food;
        }

        public void setDrink(String drink)
        {
            this.drink = drink;
        }

        public String getFood()
        {
            return (this.food);
        }

        public String getDrink()
        {
            return (this.drink);
        }
    }
}
