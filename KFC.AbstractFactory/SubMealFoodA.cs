using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC.AbstractFactory
{
    public class SubMealFoodA : Food
    {
        public void GetFood()
        {
            Console.WriteLine("汉堡！");
        }
    }
}
