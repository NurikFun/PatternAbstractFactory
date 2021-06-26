using PatternAbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAbstractFactory.ConcreteProduct
{
    public class IndianTubelight : ITubelight
    {
        public void SwithOn()
        {
            Console.WriteLine("Indian tube light turned on... Wow so shiny");
        }
    }
}
