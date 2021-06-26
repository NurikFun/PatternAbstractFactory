using PatternAbstractFactory.AbstractProduct;
using System;

namespace PatternAbstractFactory.ConcreteProduct
{
    public class IndianFan : IFan
    {
        public void SwithOn()
        {
            Console.WriteLine("Indian fan turned on... Feel cool");
        }
    }
}
