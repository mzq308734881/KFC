using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC.AbstractFactory
{
    public class SubMealFoodB : Food
    {
        public void GetFood()
        {
            Console.WriteLine("全家桶！");
        }
    }
}
