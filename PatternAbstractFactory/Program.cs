using PatternAbstractFactory.AbstractFactory;
using PatternAbstractFactory.AbstractProduct;
using PatternAbstractFactory.ConcreteFactory;
using System;

namespace PatternAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IElectricalFactory electricalFactory = new IndianElectricalFactory();
            IFan fan = electricalFactory.GetFan();
            fan.SwithOn();

            Console.ReadKey();
        }
    }
}
