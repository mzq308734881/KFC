using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC.AbstractFactory
{
    public interface EFactory
    {
        Food productFood();
        Drink productDrink();
    }
}
