using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC.Builder
{
    public class Client
    {
        static void Main(string[] args)
        {
            //动态确定套餐种类
            MealBuilder mb = (MealBuilder)XMLUtil.GetClassName();
            string className = mb.ToString();
            //服务员是指挥者
            KFCWaiter waiter = new KFCWaiter();  //得到指挥者对象
            //服务员准备套餐
            waiter.setMealBuilder(mb);  //准备套餐(将套餐类型反馈给服务员)
            //客户获得套餐
            Meal meal = waiter.construct();        //获得该套餐
            Console.WriteLine(className+"套餐组合:");
            Console.WriteLine(meal.getFood());   //得到返回值
            Console.WriteLine(meal.getDrink());
            Console.ReadKey();
        }
    }
}
