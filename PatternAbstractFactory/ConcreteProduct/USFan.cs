using PatternAbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAbstractFactory.ConcreteProduct
{
    public class USFan : IFan
    {
        public void SwithOn()
        {
            Console.WriteLine("Wow after 1 second summer turned to winter! US Fan is a great!");
        }
    }
}
