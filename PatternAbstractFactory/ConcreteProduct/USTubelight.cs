using PatternAbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAbstractFactory.ConcreteProduct
{
    public class USTubelight : ITubelight
    {
        public void SwithOn()
        {
            Console.WriteLine("The best US tubelight in the world turned on!");
        }
    }
}
