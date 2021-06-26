using PatternAbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAbstractFactory.AbstractFactory
{
    public interface IElectricalFactory
    {
        IFan GetFan();
        ITubelight GetTubelight();

    }
}
