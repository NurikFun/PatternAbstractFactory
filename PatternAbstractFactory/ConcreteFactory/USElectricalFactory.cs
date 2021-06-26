using PatternAbstractFactory.AbstractFactory;
using PatternAbstractFactory.AbstractProduct;
using PatternAbstractFactory.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAbstractFactory.ConcreteFactory
{
    public class USElectricalFactory : IElectricalFactory
    {
        public IFan GetFan()
        {
            return new USFan();
        }

        public ITubelight GetTubelight()
        {
            return new USTubelight();
        }
    }
}
