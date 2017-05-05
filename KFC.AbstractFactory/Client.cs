using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC.AbstractFactory
{
    class Client
    {
        static void Main(string[] args)
        {
            try
            {
                EFactory factory;
                Food food;
                Drink drink;
                factory = (EFactory)XMLUtil.GetClassName();
                string className = factory.ToString();
                Console.WriteLine(className+"套餐组合：");
                food = factory.productFood();
                food.GetFood();
                drink = factory.productDrink();
                drink.GetDrink();
            }
            catch (Exception ex)
            {
                Console.WriteLine("异常：" + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
